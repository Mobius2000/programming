using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Validation;
using PhotoManagerClient;

namespace Client_PM
{
    public partial class DLG_Login : Form
    {
        public User Logged_User { get; set; }
        ValidationProvider ValidationProvider;
        const string Path = @"C:\Users\201735116\Source\Repos\programming\Client_PM_03\RememberMeForm.txt";
        public DLG_Login()
        {
            InitializeComponent();
            Logged_User = null;
        }

        private void DLG_Login_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this, Submit_Task);
            ValidationProvider.AddControlToValidate(TBX_UserName, Validate_UserName, Validate_UserName_OnSubmit);
            ValidationProvider.AddControlToValidate(TBX_Password, Validate_Password, Validate_Password_OnSubmit);

            if (File.Exists(Path))
            {
                StreamReader Sr = new StreamReader(Path);
                if (Sr.ReadLine() == "YES")
                {
                    TBX_UserName.Text = Sr.ReadLine();
                    TBX_Password.Text = Sr.ReadLine();
                    CHBX_Remember.Checked = true;
                }
                Sr.Close();
            }
            
        }

        private bool Validate_UserName(ref string message)
        {
            message = "User name is missing";
            return TBX_UserName.Text != "";
        }

        private bool Validate_UserName_OnSubmit(ref string message)
        {
            message = "User name does not exist";
            return DBPhotosWebServices.UserNameExist(TBX_UserName.Text);
        }

        private bool Validate_Password(ref string message)
        {
            message = "Password is missing";
            return TBX_Password.Text != "";
        }

        private bool Validate_Password_OnSubmit(ref string message)
        {
            message = "Wrong password";
            return DBPhotosWebServices.PasswordMatch(TBX_UserName.Text, TBX_Password.Text);
        }

        private void Submit_Task()
        {
            WaitSplash.Show(this, "Login...");
            Logged_User = DBPhotosWebServices.Login(TBX_UserName.Text, TBX_Password.Text);
            WaitSplash.Hide();
        }

        private void LBLINK_Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (CHBX_Remember.Checked)
            {
                RegisterLogin();
            }
            else
            {
                RegisterNoLogin();
            }
        }

        private void RegisterLogin()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            using (FileStream fs = File.Create(Path))
            {
                AddText(fs, "YES");
                AddText(fs, "\r\n" + TBX_UserName.Text);
                AddText(fs, "\r\n" + TBX_Password.Text);
            }
        }

        private void RegisterNoLogin()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            FileStream fs = File.Create(Path);
            AddText(fs, "NO");
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        
    }
}

// allo sa va 