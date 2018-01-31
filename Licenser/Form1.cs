using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Licenser
{
    public partial class Form1 : Form
    {
        string privKey;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_loadPrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //set private key in text field
                textBox_fileName.Text = dlg.FileName;
            }
            try
            {
                
                privKey = System.IO.File.ReadAllText(@textBox_fileName.Text);
                RSACryptoServiceProvider csp;

                csp = new RSACryptoServiceProvider();
                //generate public key from private key
                csp.FromXmlString(privKey);
                textBox_publicKey.Text = csp.ToXmlString(false);
            }
            catch(Exception er)
            {
                label_message.Text = "Invalid File.";
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if (textBox_fileName.Text == null)
            {
                return;
            }
            string privKey = System.IO.File.ReadAllText(@textBox_fileName.Text);

            //generate license unique to this computer 
            textBox_license.Text = LicenseChecker.GenerateLicense(privKey);

            label_message.Text = "License Generated.";

        }
         
        private void button_verify_Click(object sender, EventArgs e)
        {

            if (textBox_fileName.Text == null)
            {
                return;
            }

            string pubKey = textBox_publicKey.Text;
            
            if (LicenseChecker.VerifyLicense(pubKey,textBox_license.Text))
            {
                label_message.Text = "License Verified.";
            }
            else
            {
                label_message.Text = "Invalid License.";
            }

        }
    }


}
