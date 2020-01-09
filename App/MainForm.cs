using System;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
