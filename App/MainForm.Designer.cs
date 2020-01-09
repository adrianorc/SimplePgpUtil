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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxStartWindows = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.btnSelectFileToEncrypt = new System.Windows.Forms.Button();
            this.btnSelectPublicKey = new System.Windows.Forms.Button();
            this.txtPublicKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFileToSaveEncrypted = new System.Windows.Forms.Button();
            this.txtSaveEncryptedFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusBar.SuspendLayout();
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
            this.mainTabControl.Size = new System.Drawing.Size(835, 244);
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
            this.tabPage1.Size = new System.Drawing.Size(827, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxStartWindows);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartWindows
            // 
            this.checkBoxStartWindows.AutoSize = true;
            this.checkBoxStartWindows.Location = new System.Drawing.Point(6, 6);
            this.checkBoxStartWindows.Name = "checkBoxStartWindows";
            this.checkBoxStartWindows.Size = new System.Drawing.Size(166, 17);
            this.checkBoxStartWindows.TabIndex = 0;
            this.checkBoxStartWindows.Text = "Start Minimized with Windows";
            this.checkBoxStartWindows.UseVisualStyleBackColor = true;
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
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(111, 23);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.Size = new System.Drawing.Size(584, 20);
            this.txtFileToEncrypt.TabIndex = 1;
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
            this.txtPublicKeyToEncrypt.Location = new System.Drawing.Point(111, 60);
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
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(25, 177);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(116, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusText});
            this.statusBar.Location = new System.Drawing.Point(0, 275);
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
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Simple PGP Encrypt/Decrypt Util";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 297);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple PGP Encrypt/Decrypt Util";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
    }
}

