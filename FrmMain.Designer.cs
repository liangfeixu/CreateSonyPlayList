namespace CreateSonyPlayList
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picMusicFolderDialogOpen = new System.Windows.Forms.PictureBox();
            this.txtMusicFolderPath = new System.Windows.Forms.TextBox();
            this.picReplaceFolderPathDialogOpen = new System.Windows.Forms.PictureBox();
            this.txtReplaceFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxIncludeSubFolder = new System.Windows.Forms.CheckBox();
            this.picPlayListFilePathDialogOpen = new System.Windows.Forms.PictureBox();
            this.txtPlayListFilePath = new System.Windows.Forms.TextBox();
            this.rbtAlter = new System.Windows.Forms.RadioButton();
            this.rbtBefore = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnLoadPlayListFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicFolderDialogOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplaceFolderPathDialogOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayListFilePathDialogOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "播放列表:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "音樂路徑:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "替換路徑:";
            // 
            // picMusicFolderDialogOpen
            // 
            this.picMusicFolderDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicFolderDialogOpen.Image = global::CreateSonyPlayList.Properties.Resources.find;
            this.picMusicFolderDialogOpen.InitialImage = null;
            this.picMusicFolderDialogOpen.Location = new System.Drawing.Point(652, 97);
            this.picMusicFolderDialogOpen.Name = "picMusicFolderDialogOpen";
            this.picMusicFolderDialogOpen.Size = new System.Drawing.Size(18, 17);
            this.picMusicFolderDialogOpen.TabIndex = 4;
            this.picMusicFolderDialogOpen.TabStop = false;
            this.picMusicFolderDialogOpen.Click += new System.EventHandler(this.picMusicFolderDialogOpen_Click);
            // 
            // txtMusicFolderPath
            // 
            this.txtMusicFolderPath.AllowDrop = true;
            this.txtMusicFolderPath.Location = new System.Drawing.Point(101, 96);
            this.txtMusicFolderPath.Name = "txtMusicFolderPath";
            this.txtMusicFolderPath.Size = new System.Drawing.Size(571, 20);
            this.txtMusicFolderPath.TabIndex = 3;
            // 
            // picReplaceFolderPathDialogOpen
            // 
            this.picReplaceFolderPathDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReplaceFolderPathDialogOpen.Image = global::CreateSonyPlayList.Properties.Resources.find;
            this.picReplaceFolderPathDialogOpen.InitialImage = null;
            this.picReplaceFolderPathDialogOpen.Location = new System.Drawing.Point(652, 153);
            this.picReplaceFolderPathDialogOpen.Name = "picReplaceFolderPathDialogOpen";
            this.picReplaceFolderPathDialogOpen.Size = new System.Drawing.Size(18, 17);
            this.picReplaceFolderPathDialogOpen.TabIndex = 6;
            this.picReplaceFolderPathDialogOpen.TabStop = false;
            this.picReplaceFolderPathDialogOpen.Click += new System.EventHandler(this.picReplaceFolderPathDialogOpen_Click);
            // 
            // txtReplaceFolderPath
            // 
            this.txtReplaceFolderPath.AllowDrop = true;
            this.txtReplaceFolderPath.Location = new System.Drawing.Point(101, 152);
            this.txtReplaceFolderPath.Name = "txtReplaceFolderPath";
            this.txtReplaceFolderPath.Size = new System.Drawing.Size(571, 20);
            this.txtReplaceFolderPath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "如“*.flac”";
            // 
            // txtFileType
            // 
            this.txtFileType.AllowDrop = true;
            this.txtFileType.Location = new System.Drawing.Point(274, 202);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(98, 20);
            this.txtFileType.TabIndex = 19;
            this.txtFileType.Text = "*.flac;*.wav;*.ape";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "文件過濾關鍵文件:";
            // 
            // cbxIncludeSubFolder
            // 
            this.cbxIncludeSubFolder.AutoSize = true;
            this.cbxIncludeSubFolder.Checked = true;
            this.cbxIncludeSubFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIncludeSubFolder.Location = new System.Drawing.Point(42, 205);
            this.cbxIncludeSubFolder.Name = "cbxIncludeSubFolder";
            this.cbxIncludeSubFolder.Size = new System.Drawing.Size(98, 17);
            this.cbxIncludeSubFolder.TabIndex = 17;
            this.cbxIncludeSubFolder.Text = "包含子文件夾";
            this.cbxIncludeSubFolder.UseVisualStyleBackColor = true;
            // 
            // picPlayListFilePathDialogOpen
            // 
            this.picPlayListFilePathDialogOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlayListFilePathDialogOpen.Image = global::CreateSonyPlayList.Properties.Resources.find;
            this.picPlayListFilePathDialogOpen.InitialImage = null;
            this.picPlayListFilePathDialogOpen.Location = new System.Drawing.Point(652, 39);
            this.picPlayListFilePathDialogOpen.Name = "picPlayListFilePathDialogOpen";
            this.picPlayListFilePathDialogOpen.Size = new System.Drawing.Size(18, 17);
            this.picPlayListFilePathDialogOpen.TabIndex = 22;
            this.picPlayListFilePathDialogOpen.TabStop = false;
            this.picPlayListFilePathDialogOpen.Click += new System.EventHandler(this.picPlayListFilePathDialogOpen_Click);
            // 
            // txtPlayListFilePath
            // 
            this.txtPlayListFilePath.AllowDrop = true;
            this.txtPlayListFilePath.Location = new System.Drawing.Point(101, 38);
            this.txtPlayListFilePath.Name = "txtPlayListFilePath";
            this.txtPlayListFilePath.Size = new System.Drawing.Size(571, 20);
            this.txtPlayListFilePath.TabIndex = 21;
            // 
            // rbtAlter
            // 
            this.rbtAlter.AutoSize = true;
            this.rbtAlter.Location = new System.Drawing.Point(598, 206);
            this.rbtAlter.Name = "rbtAlter";
            this.rbtAlter.Size = new System.Drawing.Size(58, 17);
            this.rbtAlter.TabIndex = 29;
            this.rbtAlter.Text = "   覆蓋";
            this.rbtAlter.UseVisualStyleBackColor = true;
            // 
            // rbtBefore
            // 
            this.rbtBefore.AutoSize = true;
            this.rbtBefore.Checked = true;
            this.rbtBefore.Location = new System.Drawing.Point(543, 206);
            this.rbtBefore.Name = "rbtBefore";
            this.rbtBefore.Size = new System.Drawing.Size(49, 17);
            this.rbtBefore.TabIndex = 28;
            this.rbtBefore.TabStop = true;
            this.rbtBefore.Text = "追加";
            this.rbtBefore.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "寫入方式:";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(40, 238);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(630, 168);
            this.richTextBoxLog.TabIndex = 31;
            this.richTextBoxLog.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(517, 425);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 34;
            this.btnClearLog.Text = "清空日誌";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(378, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(242, 425);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 32;
            this.btnPreview.Text = "預覽";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnLoadPlayListFile
            // 
            this.btnLoadPlayListFile.Location = new System.Drawing.Point(81, 425);
            this.btnLoadPlayListFile.Name = "btnLoadPlayListFile";
            this.btnLoadPlayListFile.Size = new System.Drawing.Size(125, 23);
            this.btnLoadPlayListFile.TabIndex = 35;
            this.btnLoadPlayListFile.Text = "   加載播放列表內容";
            this.btnLoadPlayListFile.UseVisualStyleBackColor = true;
            this.btnLoadPlayListFile.Click += new System.EventHandler(this.btnLoadPlayListFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 472);
            this.Controls.Add(this.btnLoadPlayListFile);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtAlter);
            this.Controls.Add(this.rbtBefore);
            this.Controls.Add(this.picPlayListFilePathDialogOpen);
            this.Controls.Add(this.txtPlayListFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxIncludeSubFolder);
            this.Controls.Add(this.picReplaceFolderPathDialogOpen);
            this.Controls.Add(this.txtReplaceFolderPath);
            this.Controls.Add(this.picMusicFolderDialogOpen);
            this.Controls.Add(this.txtMusicFolderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "索尼音樂列表添加";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picMusicFolderDialogOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplaceFolderPathDialogOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayListFilePathDialogOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picMusicFolderDialogOpen;
        private System.Windows.Forms.TextBox txtMusicFolderPath;
        private System.Windows.Forms.PictureBox picReplaceFolderPathDialogOpen;
        private System.Windows.Forms.TextBox txtReplaceFolderPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxIncludeSubFolder;
        private System.Windows.Forms.PictureBox picPlayListFilePathDialogOpen;
        private System.Windows.Forms.TextBox txtPlayListFilePath;
        private System.Windows.Forms.RadioButton rbtAlter;
        private System.Windows.Forms.RadioButton rbtBefore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnLoadPlayListFile;
    }
}

