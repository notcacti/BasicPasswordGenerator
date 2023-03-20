using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();
        string pwds = Path.Combine(@"C:\", "pwds.txt");

        private void passwordGenerator(int passwordLength)
        {
            string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@$%^&#!@$%^&#!@$%^&#";
            string randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            passwordLabel.Text = randomPassword;
        }
        public Form1()
        {
            InitializeComponent();
            passwordLengthSlider.Minimum = 5;
            passwordLengthSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void CopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }

        private void passwordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PassLengthLabel.Text = "Password Length: " + passwordLengthSlider.Value.ToString();
            currentPasswordLength = passwordLengthSlider.Value;
            passwordGenerator(currentPasswordLength);
        }

        private void button1_Click(object sender, EventArgs e)
        {   /* Detect file and delete it
            if (File.Exists(storein))
            {
                File.Delete(storein);
            }
            ^^ unnecessary */

            if (File.Exists(pwds))
            {
                using (StreamWriter sw = File.AppendText(pwds))
                {
                    //Add the text
                    sw.WriteLine(passwordLabel.Text + "\n");
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(pwds)) ;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("No Access to Folder, Try running in admin mode", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openPass_Click(object sender, EventArgs e)
        {
            if (File.Exists(pwds))
            {
                Process.Start(pwds);
            }
            else
            {
                MessageBox.Show("Save a password first to open the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clPwd_Click(object sender, EventArgs e)
        {
            File.Delete(pwds);
        }
    }
}
