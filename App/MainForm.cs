using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private bool isQuiting;

        public MainForm()
        {
            InitializeComponent();
            isQuiting = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtFileToEncrypt.Text = openFileDialog.FileName;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtPublicKeyToEncrypt.Text = openFileDialog.FileName;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "PGP File (*.pgp)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "pgp";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtSaveEncryptedFile.Text = saveFileDialog.FileName;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFileToEncrypt.Text))
            {
                MessageBox.Show("Please select a file to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtPublicKeyToEncrypt.Text))
            {
                MessageBox.Show("Please select the public key to encrypt the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSaveEncryptedFile.Text))
            {
                MessageBox.Show("Please select the path to save the encrypted file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                btnEncrypt.Enabled = false;
                toolStripStatusText.Text = "Encrypting...";

                using (FileStream streamPublicKey = File.Open(txtPublicKeyToEncrypt.Text, FileMode.Open))
                using (Stream outputFile = File.Create(txtSaveEncryptedFile.Text))
                {
                    PGPHelper.EncryptStream(txtFileToEncrypt.Text, streamPublicKey, outputFile);
                }

                toolStripStatusText.Text = $"Done! Encrypted file saved to '{txtSaveEncryptedFile.Text}'";

            } catch (Exception ex)
            {
                MessageBox.Show("Could not encrypt the file. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEncrypt.Enabled = true;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isQuiting = true;
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Visible = !Visible;
        }

        private void checkBoxStartWindows_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInitWithWindows();
        }

        private void UpdateInitWithWindows()
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                
                if (checkBoxStartWindows.Checked)
                {
                    // app will start with windows
                    var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                    key.SetValue("SimplePGPUtil", $"\"{Application.ExecutablePath.ToString()}\" /background");
                }
                else
                {
                    // app will NOT start with windows
                    var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                    key.DeleteValue("SimplePGPUtil", false);
                }
            } finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TryRestoreValues();
        }

        private void TryRestoreValues()
        {
            var path = @"SOFTWARE\SimplePGPUtil";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            if (key != null)
            {
                txtFileToEncrypt.Text = key.GetValue("FileToEncrypt") != null ? key.GetValue("FileToEncrypt").ToString() : "";
                txtPublicKeyToEncrypt.Text = key.GetValue("PublicKeyToEncrypt") != null ? key.GetValue("PublicKeyToEncrypt").ToString() : "";
                txtSaveEncryptedFile.Text = key.GetValue("PathToSaveEncryptedFile") != null ? key.GetValue("PathToSaveEncryptedFile").ToString() : "";

                int initWithWindows = 0;
                if (key.GetValue("InitWithWindows") != null)
                {
                    bool r = int.TryParse(key.GetValue("InitWithWindows").ToString(), out initWithWindows);
                }

                checkBoxStartWindows.Checked = initWithWindows != 0;
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TrySaveValues();

            if (checkBoxStartWindows.Checked && !isQuiting)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void TrySaveValues()
        {
            var path = @"SOFTWARE\SimplePGPUtil";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(path);
            }

            key.SetValue("FileToEncrypt", txtFileToEncrypt.Text);
            key.SetValue("PublicKeyToEncrypt", txtPublicKeyToEncrypt.Text);
            key.SetValue("PathToSaveEncryptedFile", txtSaveEncryptedFile.Text);
            key.SetValue("InitWithWindows", checkBoxStartWindows.Checked ? 1 : 0);
        }
    }
}
