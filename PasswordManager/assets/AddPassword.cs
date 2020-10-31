using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class AddPassword : Form
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void btn_AddPassword_Click(object sender, EventArgs e)
        {
            Main.Passwords.Add(new password(txt_Name.Text, txt_Password.Text));
            txt_Name.Clear();
            txt_Password.Clear();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
