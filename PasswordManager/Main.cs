using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PasswordManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //--------------------------Functions-----------------------------
        private string PasswordDecryptCheck(string check)
        {
            string DecrpytTest = Cypher.Decrypt(check);
            if (DecrpytTest == null)
            {
                //Console.WriteLine("String not encrypted");
                return check;
            }
            else
            {
                return Cypher.Decrypt(check);
            }
        }
        //--------------------------Lists------------------------------
        public static List<password> Passwords = new List<password>();
        //-------------------------Objects-----------------------------
        private string[] PasswordFile;
        readonly OpenFileDialog SelectFile = new OpenFileDialog();
        readonly CommonOpenFileDialog SelectFolder = new CommonOpenFileDialog();
        public static string FileName;
        private string PathToUse;
        //--------------------------Buttons-----------------------------


        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            Passwords.Clear();
            ListBox_Passwords.Items.Clear();
            SelectFile.ShowDialog();            
            try
            {                
                PasswordFile = File.ReadAllLines(SelectFile.FileName);

                for (int i = 0; i < PasswordFile.Length; i++)
                {                    
                    string[] listItems = PasswordFile[i].Split(',');
                    string test = PasswordDecryptCheck(listItems[0]);
                    if (test == null)
                    {
                        ListBox_Passwords.Items.Add(new ListViewItem(new String[] { listItems[0], listItems[1] }));
                        Passwords.Add(new password(listItems[0], listItems[1]));
                    }
                    else
                    {
                        try
                        {
                            ListBox_Passwords.Items.Add(new ListViewItem(new String[] { Cypher.Decrypt(listItems[0]), Cypher.Decrypt(listItems[1]) }));
                            Passwords.Add(new password(Cypher.Decrypt(listItems[0]), Cypher.Decrypt(listItems[1])));
                        }
                        catch (Exception ExceptionString)
                        {
                            MessageBox.Show(ExceptionString.ToString());
                            break;
                        }
                        
                    }                    
                }
            }
            catch (System.ArgumentException)
            {

            }
            PathToUse = SelectFile.FileName;
        }

        private void btn_addPassword_Click(object sender, EventArgs e)
        {
            if (PathToUse==null)
            {
                MessageBox.Show("Please Select a File");
            }
            else
            {
            AddPassword Add = new AddPassword();
            Add.ShowDialog();
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            ListBox_Passwords.Items.Clear();
            foreach (var item in Passwords)
            {
                ListBox_Passwords.Items.Add(new ListViewItem(new string[] { item.name, item.pword }));
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (PathToUse==null)
            {
                MessageBox.Show("Error no file open");
            }
            else
            {
                try
                {
                    File.WriteAllText(PathToUse, "");
                    foreach (var item in Passwords)
                    {
                        File.AppendAllText(PathToUse, Cypher.Encrypt(item.name) + "," + Cypher.Encrypt(item.pword) + Environment.NewLine);
                    }
                    ListBox_Passwords.Items.Clear();
                    Passwords.Clear();

                }
                catch (Exception)
                {

                    throw;
                }
                var myfile = File.OpenRead(PathToUse);
                myfile.Close();
                PathToUse = null;
            }
        }

        private void btn_removePass_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem eachItem in ListBox_Passwords.SelectedItems)
                {
                    Passwords.RemoveAt(eachItem.Index);
                    ListBox_Passwords.Items.Remove(eachItem);
                    
                }                
            }
            catch (Exception)
            {

                MessageBox.Show("Please select a valid password");
            }
        }

        
        private void btn_CreatFile_Click(object sender, EventArgs e)
        {
            CreateFile nf = new CreateFile();
            nf.ShowDialog();
            if (FileName!=null)
            {
                SelectFolder.IsFolderPicker = true;
                SelectFolder.ShowDialog();
                var myfile = File.Create(SelectFolder.FileName+"//"+FileName);
                myfile.Close();
                PathToUse = (SelectFolder.FileName + "//" + FileName);
            }
        }
    }
}
