using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateSonyPlayList
{
    public partial class FrmMain : Form
    {

        const string M3UHEAD = "#EXTM3U\r\n";
        const string M3UITEM = "#EXTINF:,\r\n{0}\r\n";
        private List<FileModel> fileList;
        public FrmMain()
        {
            InitializeComponent();
            this.AllowDrop = true;
            base.DragEnter += new DragEventHandler(this.ctl_DragEnter);
            base.DragDrop += new DragEventHandler(this.ctl_DragDrop);
            this.WireDragDrop(base.Controls);
        }

        private void picPlayListFilePathDialogOpen_Click(object sender, EventArgs e)
        {
            FileDialog dia = new OpenFileDialog();
            dia.Filter = "Playlist File|*.m3u;*.m3u8";
            if (dia.ShowDialog() == DialogResult.OK)
            {
                txtPlayListFilePath.Text = dia.FileName;
            }
        }

        private void picMusicFolderDialogOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择音乐文件夹";
            if (!string.IsNullOrEmpty(Properties.Settings.Default.PassFolderDialogSelectPath))
            {
                dialog.SelectedPath = Properties.Settings.Default.PassFolderDialogSelectPath;
            }
            
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.SelectedPath))
            {
                txtMusicFolderPath.Text = dialog.SelectedPath;
                Properties.Settings.Default.PassFolderDialogSelectPath = dialog.SelectedPath;
            }
        }

        private void picReplaceFolderPathDialogOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog(); 
            if (!string.IsNullOrEmpty(Properties.Settings.Default.PassFolderDialogSelectPath))
            {
                dialog.SelectedPath = Properties.Settings.Default.PassFolderDialogSelectPath;
            }
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.SelectedPath))
            {
                txtReplaceFolderPath.Text = dialog.SelectedPath;
            }
        }
        private void btnLoadPlayListFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private bool LoadFile(bool isSave = false, bool isShowLog = true)
        {
            if (string.IsNullOrEmpty(txtPlayListFilePath.Text))
            {
                MessageBox.Show("请选择歌曲列表文件");
                return false;
            }

            if (!File.Exists(txtPlayListFilePath.Text))
            {
                File.WriteAllText(txtPlayListFilePath.Text, M3UHEAD, System.Text.Encoding.UTF8);
                if(isShowLog)
                    ShowLog(M3UHEAD, "green");
            }
            else
            {
                if (!isSave)
                {
                    string[] lines = System.IO.File.ReadAllLines(txtPlayListFilePath.Text);
                    if (lines.Length > 0)
                    {
                        ShowLog(string.Join("\r\n", lines));
                    }
                }
                else
                {
                    if (rbtAlter.Checked)
                    {
                        File.WriteAllText(txtPlayListFilePath.Text, M3UHEAD, System.Text.Encoding.UTF8);
                    }
                }
            }
            return true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Preview();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!LoadFile(true,false))
                return;


            Preview(false);
            foreach (var item in this.fileList)
            {
                FileMode fileMode = FileMode.Append;                   
                using (FileStream fs = new FileStream(txtPlayListFilePath.Text, FileMode.Append, FileAccess.Write, FileShare.Write, 1024, FileOptions.Asynchronous))
                {
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(string.Format(M3UITEM, item.PlayListFilePathName));
                    IAsyncResult writeResult = fs.BeginWrite(buffer, 0, buffer.Length, (asyncResult) =>
                    {
                        FileStream fStrem = (FileStream)asyncResult.AsyncState;
                        fStrem.EndWrite(asyncResult);
                    }, fs);
                    fs.Close();
                }
            }
            ShowLog(string.Format("已保存列表,共{0}個\r\n", this.fileList.Count));

        }
        #region

        private void ctl_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.txtMusicFolderPath.Text = data[0];
            }
        }

        private void ctl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void WireDragDrop(Control.ControlCollection ctls)
        {
            foreach (Control control in ctls)
            {
                control.AllowDrop = true;
                control.DragEnter += new DragEventHandler(this.ctl_DragEnter);
                control.DragDrop += new DragEventHandler(this.ctl_DragDrop);
                this.WireDragDrop(control.Controls);
            }
        }
        #endregion

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        private void Preview(bool isShowLog = true)
        {
            string musicFolderPath = txtMusicFolderPath.Text;
            string replaceFolderPath = txtReplaceFolderPath.Text;
            string fileType = txtFileType.Text;
            if (string.IsNullOrEmpty(musicFolderPath))
            {
                MessageBox.Show("请选择音乐文件夹");
                return;
            }
            if (string.IsNullOrEmpty(replaceFolderPath))
            {
                replaceFolderPath = musicFolderPath.Substring(0, musicFolderPath.LastIndexOf('\\') + 1);
            }
            replaceFolderPath = replaceFolderPath.Trim('\\') + "\\";
            if (string.IsNullOrEmpty(fileType))
            {
                fileType = "*";
            }

            this.fileList = new List<FileModel>();
            richTextBoxLog.Clear();
            List<string> fileList = GetFiles(musicFolderPath, fileType.Split(';'), cbxIncludeSubFolder.Checked);

            int idx = 0;
            foreach (string file in fileList)
            {
                FileInfo fi = new FileInfo(file);
                FileModel fileModel = new FileModel();
                fileModel.SeqNo = idx++;
                fileModel.FullName = fi.FullName;
                fileModel.FileType = fi.Extension;
                fileModel.PlayListFilePathName = fi.FullName.Replace(replaceFolderPath, "").Replace("\\", "/");
                this.fileList.Add(fileModel);
                if(isShowLog)
                    ShowLog(string.Format(M3UITEM, fileModel.PlayListFilePathName), "green");                
            }
            if (isShowLog)
                ShowLog(string.Format("已加載所有文件,共{0}個\r\n", this.fileList.Count));
        }

        //獲取文件夾指定類型文件
        private List<string> GetFiles(string folderPath, string[] fileExtensions, bool isSearchChild = true)
        {
            List<string> files = new List<string>();
            foreach (string fileExtension in fileExtensions)
            {
                if (isSearchChild)
                {
                    files.AddRange(Directory.GetFiles(folderPath, fileExtension, SearchOption.AllDirectories));
                }
                else
                {
                    files.AddRange(Directory.GetFiles(folderPath, fileExtension, SearchOption.TopDirectoryOnly));
                }
            }
            return files;
        }

        #region Show Event Log
        private delegate void logDelegate(object log, string color);
        public void ShowLog(object log, string color = "black")
        {
            if (richTextBoxLog.InvokeRequired)
                Invoke(new logDelegate(ShowLog), new object[] { log, color });
            else
            {
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.SelectionLength = 0;
                richTextBoxLog.SelectionColor = Color.FromName(color);
                richTextBoxLog.AppendText(string.Format("{0}", log));
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.SelectionLength = 0;
                richTextBoxLog.SelectionColor = Color.Black;
                richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
                richTextBoxLog.ScrollToCaret();
                Application.DoEvents();
            }
        }
        #endregion

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.PassFolderDialogSelectPath))
            {
                Properties.Settings.Default.Save();
            }
        }
    }

    public class FileModel
    {
        public int SeqNo { get; set; }
        public string FullName { get; set; }
        public string FileType { get; set; }
        public string PlayListFilePathName { get; set; }
    }
}
