namespace App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSelectFileToSaveEncrypted = new System.Windows.Forms.Button();
            this.txtSaveEncryptedFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectPublicKey = new System.Windows.Forms.Button();
            this.txtPublicKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFileToEncrypt = new System.Windows.Forms.Button();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassphraseToDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSaveDecryptedFile = new System.Windows.Forms.Button();
            this.txtSaveDecryptedFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectPrivateKeyToDecrypt = new System.Windows.Forms.Button();
            this.txtPrivateKeyToDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectFileToDecrypt = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxStartWindows = new System.Windows.Forms.CheckBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotificationIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSaveRetoreFileLocations = new System.Windows.Forms.CheckBox();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.contextMenuStripNotificationIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(835, 251);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.btnSelectFileToSaveEncrypted);
            this.tabPage1.Controls.Add(this.txtSaveEncryptedFile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSelectPublicKey);
            this.tabPage1.Controls.Add(this.txtPublicKeyToEncrypt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSelectFileToEncrypt);
            this.tabPage1.Controls.Add(this.txtFileToEncrypt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(25, 180);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(116, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSelectFileToSaveEncrypted
            // 
            this.btnSelectFileToSaveEncrypted.Location = new System.Drawing.Point(717, 99);
            this.btnSelectFileToSaveEncrypted.Name = "btnSelectFileToSaveEncrypted";
            this.btnSelectFileToSaveEncrypted.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFileToSaveEncrypted.TabIndex = 8;
            this.btnSelectFileToSaveEncrypted.Text = "Select...";
            this.btnSelectFileToSaveEncrypted.UseVisualStyleBackColor = true;
            this.btnSelectFileToSaveEncrypted.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSaveEncryptedFile
            // 
            this.txtSaveEncryptedFile.Location = new System.Drawing.Point(111, 99);
            this.txtSaveEncryptedFile.Name = "txtSaveEncryptedFile";
            this.txtSaveEncryptedFile.Size = new System.Drawing.Size(584, 20);
            this.txtSaveEncryptedFile.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save To";
            // 
            // btnSelectPublicKey
            // 
            this.btnSelectPublicKey.Location = new System.Drawing.Point(717, 60);
            this.btnSelectPublicKey.Name = "btnSelectPublicKey";
            this.btnSelectPublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPublicKey.TabIndex = 5;
            this.btnSelectPublicKey.Text = "Select...";
            this.btnSelectPublicKey.UseVisualStyleBackColor = true;
            this.btnSelectPublicKey.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPublicKeyToEncrypt
            // 
            this.txtPublicKeyToEncrypt.Location = new System.Drawing.Point(111, 61);
            this.txtPublicKeyToEncrypt.Name = "txtPublicKeyToEncrypt";
            this.txtPublicKeyToEncrypt.Size = new System.Drawing.Size(584, 20);
            this.txtPublicKeyToEncrypt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public Key";
            // 
            // btnSelectFileToEncrypt
            // 
            this.btnSelectFileToEncrypt.Location = new System.Drawing.Point(717, 23);
            this.btnSelectFileToEncrypt.Name = "btnSelectFileToEncrypt";
            this.btnSelectFileToEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFileToEncrypt.TabIndex = 2;
            this.btnSelectFileToEncrypt.Text = "Select...";
            this.btnSelectFileToEncrypt.UseVisualStyleBackColor = true;
            this.btnSelectFileToEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(111, 23);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.Size = new System.Drawing.Size(584, 20);
            this.txtFileToEncrypt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File to Encrypt";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPassphraseToDecrypt);
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.btnSaveDecryptedFile);
            this.tabPage2.Controls.Add(this.txtSaveDecryptedFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSelectPrivateKeyToDecrypt);
            this.tabPage2.Controls.Add(this.txtPrivateKeyToDecrypt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSelectFileToDecrypt);
            this.tabPage2.Controls.Add(this.txtFileToDecrypt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Passphrase";
            // 
            // txtPassphraseToDecrypt
            // 
            this.txtPassphraseToDecrypt.Location = new System.Drawing.Point(111, 99);
            this.txtPassphraseToDecrypt.Name = "txtPassphraseToDecrypt";
            this.txtPassphraseToDecrypt.PasswordChar = '*';
            this.txtPassphraseToDecrypt.Size = new System.Drawing.Size(310, 20);
            this.txtPassphraseToDecrypt.TabIndex = 20;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(25, 180);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(116, 23);
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSaveDecryptedFile
            // 
            this.btnSaveDecryptedFile.Location = new System.Drawing.Point(717, 137);
            this.btnSaveDecryptedFile.Name = "btnSaveDecryptedFile";
            this.btnSaveDecryptedFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDecryptedFile.TabIndex = 18;
            this.btnSaveDecryptedFile.Text = "Select...";
            this.btnSaveDecryptedFile.UseVisualStyleBackColor = true;
            this.btnSaveDecryptedFile.Click += new System.EventHandler(this.btnSaveDecryptedFile_Click);
            // 
            // txtSaveDecryptedFile
            // 
            this.txtSaveDecryptedFile.Location = new System.Drawing.Point(111, 137);
            this.txtSaveDecryptedFile.Name = "txtSaveDecryptedFile";
            this.txtSaveDecryptedFile.Size = new System.Drawing.Size(584, 20);
            this.txtSaveDecryptedFile.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Save To";
            // 
            // btnSelectPrivateKeyToDecrypt
            // 
            this.btnSelectPrivateKeyToDecrypt.Location = new System.Drawing.Point(717, 60);
            this.btnSelectPrivateKeyToDecrypt.Name = "btnSelectPrivateKeyToDecrypt";
            this.btnSelectPrivateKeyToDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPrivateKeyToDecrypt.TabIndex = 15;
            this.btnSelectPrivateKeyToDecrypt.Text = "Select...";
            this.btnSelectPrivateKeyToDecrypt.UseVisualStyleBackColor = true;
            this.btnSelectPrivateKeyToDecrypt.Click += new System.EventHandler(this.btnSelectPrivateKeyToDecrypt_Click);
            // 
            // txtPrivateKeyToDecrypt
            // 
            this.txtPrivateKeyToDecrypt.Location = new System.Drawing.Point(111, 61);
            this.txtPrivateKeyToDecrypt.Name = "txtPrivateKeyToDecrypt";
            this.txtPrivateKeyToDecrypt.Size = new System.Drawing.Size(584, 20);
            this.txtPrivateKeyToDecrypt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Private Key";
            // 
            // btnSelectFileToDecrypt
            // 
            this.btnSelectFileToDecrypt.Location = new System.Drawing.Point(717, 23);
            this.btnSelectFileToDecrypt.Name = "btnSelectFileToDecrypt";
            this.btnSelectFileToDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFileToDecrypt.TabIndex = 12;
            this.btnSelectFileToDecrypt.Text = "Select...";
            this.btnSelectFileToDecrypt.UseVisualStyleBackColor = true;
            this.btnSelectFileToDecrypt.Click += new System.EventHandler(this.btnSelectFileToDecrypt_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Location = new System.Drawing.Point(111, 23);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.Size = new System.Drawing.Size(584, 20);
            this.txtFileToDecrypt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "File to Decrypt";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxSaveRetoreFileLocations);
            this.tabPage3.Controls.Add(this.checkBoxStartWindows);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartWindows
            // 
            this.checkBoxStartWindows.AutoSize = true;
            this.checkBoxStartWindows.Location = new System.Drawing.Point(16, 17);
            this.checkBoxStartWindows.Name = "checkBoxStartWindows";
            this.checkBoxStartWindows.Size = new System.Drawing.Size(166, 17);
            this.checkBoxStartWindows.TabIndex = 0;
            this.checkBoxStartWindows.Text = "Start Minimized with Windows";
            this.checkBoxStartWindows.UseVisualStyleBackColor = true;
            this.checkBoxStartWindows.CheckedChanged += new System.EventHandler(this.checkBoxStartWindows_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusText});
            this.statusBar.Location = new System.Drawing.Point(0, 287);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(864, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusText
            // 
            this.toolStripStatusText.Name = "toolStripStatusText";
            this.toolStripStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotificationIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Simple PGP Encrypt/Decrypt Util";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStripNotificationIcon
            // 
            this.contextMenuStripNotificationIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripNotificationIcon.Name = "contextMenuStripNotificationIcon";
            this.contextMenuStripNotificationIcon.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // checkBoxSaveRetoreFileLocations
            // 
            this.checkBoxSaveRetoreFileLocations.AutoSize = true;
            this.checkBoxSaveRetoreFileLocations.Location = new System.Drawing.Point(16, 40);
            this.checkBoxSaveRetoreFileLocations.Name = "checkBoxSaveRetoreFileLocations";
            this.checkBoxSaveRetoreFileLocations.Size = new System.Drawing.Size(161, 17);
            this.checkBoxSaveRetoreFileLocations.TabIndex = 1;
            this.checkBoxSaveRetoreFileLocations.Text = "Save/Restore File Locations";
            this.checkBoxSaveRetoreFileLocations.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 309);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple PGP Encrypt/Decrypt Util";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenuStripNotificationIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSelectFileToSaveEncrypted;
        private System.Windows.Forms.TextBox txtSaveEncryptedFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectPublicKey;
        private System.Windows.Forms.TextBox txtPublicKeyToEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFileToEncrypt;
        private System.Windows.Forms.TextBox txtFileToEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBoxStartWindows;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusText;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotificationIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassphraseToDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSaveDecryptedFile;
        private System.Windows.Forms.TextBox txtSaveDecryptedFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectPrivateKeyToDecrypt;
        private System.Windows.Forms.TextBox txtPrivateKeyToDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFileToDecrypt;
        private System.Windows.Forms.TextBox txtFileToDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSaveRetoreFileLocations;
    }
}

