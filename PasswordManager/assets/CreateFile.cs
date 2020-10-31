using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class CreateFile : Form
    {
        public CreateFile()
        {
            InitializeComponent();
        }
        public static string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            foreach (char c in invalid)
            {
                txt_FileName.Text = txt_FileName.Text.Replace(c.ToString(), "");
                //checks to make sure there arent any invalid characters
            }
            if (txt_FileName.Text == null)
            {
                MessageBox.Show("Please Enter a valid name");
                //validates file name 
            }
            else
            {
            Main.FileName = txt_FileName.Text;
            }
            ActiveForm.Close();
        }

        private void txt_FileName_KeyPress(object sender, KeyPressEventArgs e)
        {            
            foreach (char c in invalid)
            {
                txt_FileName.Text = txt_FileName.Text.Replace(c.ToString(), "");
            }
        }
    }
}
