using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Encryption_Decryption
{
    public partial class Secured : Form
    {
        public Secured()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System_security.EncryptionKey = textBox1.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = System_security.Encrypt(richTextBox1.Text);
            }
            catch (Exception)
            {

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = System_security.Decrypt(richTextBox2.Text);
            }
            catch (Exception)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/HashJProgramming");
            }
            catch (Exception)
            {

               
            }
        }
    }
}
