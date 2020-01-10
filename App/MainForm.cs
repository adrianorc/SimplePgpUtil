using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private static string REGISTRY_PATH = @"SOFTWARE\SimplePGPUtil";
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

            btnEncrypt.Enabled = false;
            Cursor = Cursors.WaitCursor;
            toolStripStatusText.Text = "Encrypting...";

            try
            {
                using (FileStream streamPublicKey = File.Open(txtPublicKeyToEncrypt.Text, FileMode.Open))
                using (Stream outputFile = File.Create(txtSaveEncryptedFile.Text))
                {
                    PGPHelper.EncryptStream(txtFileToEncrypt.Text, streamPublicKey, outputFile);
                }

                toolStripStatusText.Text = $"Done! Encrypted file saved to '{txtSaveEncryptedFile.Text}'";

                // clear status text after 20s
                Task.Delay(20000)
                    .ContinueWith(task =>
                    {
                        toolStripStatusText.Text = "";
                    });

            } catch (Exception ex)
            {
                MessageBox.Show("Could not encrypt the file. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusText.Text = "";
            }
            finally
            {
                btnEncrypt.Enabled = true;
                Cursor = Cursors.Default;
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

        private void TrySaveValues()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(REGISTRY_PATH);
            }

            // settings tab
            key.SetValue("InitWithWindows", checkBoxStartWindows.Checked ? 1 : 0);
            key.SetValue("SaveRestorePaths", checkBoxSaveRetoreFileLocations.Checked ? 1 : 0);

            if (checkBoxSaveRetoreFileLocations.Checked)
            {
                // encrypt tab
                key.SetValue("FileToEncrypt", txtFileToEncrypt.Text);
                key.SetValue("PublicKeyToEncrypt", txtPublicKeyToEncrypt.Text);
                key.SetValue("PathToSaveEncryptedFile", txtSaveEncryptedFile.Text);

                // decrypt tab
                key.SetValue("FileToDecrypt", txtFileToDecrypt.Text);
                key.SetValue("PrivateKeyToDecrypt", txtPrivateKeyToDecrypt.Text);
                key.SetValue("PathToSaveDecryptedFile", txtSaveDecryptedFile.Text);
            }
        }

        private void TryRestoreValues()
        {
            Func<object, string> GetString = input => input != null ? input.ToString() : "";
            Func<object, int, int> GetIntOrDef = (input, def) =>
            {
                if (input == null)
                {
                    return def;
                }

                if (Int32.TryParse(input.ToString(), out int result))
                {
                    return result;
                }

                return def;
            };

            RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
            if (key == null)
            {
                return;
            }

            // settings tab
            checkBoxStartWindows.Checked = GetIntOrDef(key.GetValue("InitWithWindows"), 0) != 0;
            checkBoxSaveRetoreFileLocations.Checked = GetIntOrDef(key.GetValue("SaveRestorePaths"), 0) != 0;

            if (checkBoxSaveRetoreFileLocations.Checked)
            {
                // encrypt tab
                txtFileToEncrypt.Text = GetString(key.GetValue("FileToEncrypt"));
                txtPublicKeyToEncrypt.Text = GetString(key.GetValue("PublicKeyToEncrypt"));
                txtSaveEncryptedFile.Text = GetString(key.GetValue("PathToSaveEncryptedFile"));

                // decrypt tab
                txtFileToDecrypt.Text = GetString(key.GetValue("FileToDecrypt"));
                txtPrivateKeyToDecrypt.Text = GetString(key.GetValue("PrivateKeyToDecrypt"));
                txtSaveDecryptedFile.Text = GetString(key.GetValue("PathToSaveDecryptedFile"));
            }
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

        private void btnSelectFileToDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PGP files (*.pgp)|*.pgp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileToDecrypt.Text = openFileDialog.FileName;
                }
            }

        }

        private void btnSelectPrivateKeyToDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPrivateKeyToDecrypt.Text = openFileDialog.FileName;
                }
            }

        }

        private void btnSaveDecryptedFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveDecryptedFile.Text = saveFileDialog.FileName;
                }
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            btnDecrypt.Enabled = false;
            Cursor = Cursors.WaitCursor;
            toolStripStatusText.Text = $"Decrypting...";

            try
            {
                using (Stream inputFile = File.OpenRead(txtFileToDecrypt.Text))
                using (Stream privateKey = File.OpenRead(txtPrivateKeyToDecrypt.Text))
                {
                    PGPHelper.DecryptStream(
                        inputFile,
                        privateKey,
                        string.IsNullOrWhiteSpace(txtPassphraseToDecrypt.Text) ? null : txtPassphraseToDecrypt.Text.ToCharArray(),
                        txtSaveDecryptedFile.Text
                    );

                }

                toolStripStatusText.Text = $"Done! Clear file saved to '{txtSaveDecryptedFile.Text}'";

                // clear status text after 20s
                Task.Delay(20000)
                    .ContinueWith(task =>
                    {
                        toolStripStatusText.Text = "";
                    });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not decrypt the file. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusText.Text = "";
            }
            finally
            {
                btnDecrypt.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
