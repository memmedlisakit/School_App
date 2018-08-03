using System; 
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Net;
using School.Settings;

namespace School.Pages
{
    public partial class Register : Form
    { 
        OpenFileDialog file = new OpenFileDialog();

        public Register()
        {
            InitializeComponent();
            this.pctImage.Image = School.Properties.Resources._default;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.isNotEmpty())
            { 
                string name = this.txtName.Text;
                string surname = this.txtSurname.Text;
                string username = this.txtUsername.Text;
                string email = this.txtEmail.Text;
                string password = this.txtPassword.Text;
                int gender = this.ckbMale.Checked ? 1 : 0;
                string imageName = null;

                if (file.SafeFileName != "")
                {
                    imageName = DateTime.Now.ToString("yyyyMMddHHssmm") + file.SafeFileName;
                    Extentions.ImageUpload(file, imageName, "Uploads");
                }

                string sql = "INSERT INTO Students(name, surname, username, email, password, gender, image) VALUES('" + name + "', '" + surname + "', '" + username + "', '" + email + "', '" + password + "', " + gender + ", '" + imageName + "')";
                using(SQLiteConnection con = new SQLiteConnection(Login.connection))
                {
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(sql,con))
                    { 
                        com.ExecuteNonQuery();
                    }
                }
                btnRegister.Enabled = false;
                cleaner();
                this.lblSuccess.Text = "registration was successfully";
            } 
        }

        bool isNotEmpty()
        {
            if (this.txtName.Text == "")
            {
                this.lblName.Text = "name is required !!!";
                this.ActiveControl = this.txtName;
                return false;
            }
            if (this.txtSurname.Text == "")
            {
                this.lblSurname.Text = "surname is required !!!";
                this.ActiveControl = this.txtSurname;
                return false;
            }
            if(this.txtUsername.Text == "")
            {
                this.lblUsername.Text = "username is required !!!";
                this.ActiveControl = this.txtUsername;
                return false;
            }
            if (this.txtEmail.Text == "")
            {
                this.lblEmail.Text = "email is required !!!";
                this.ActiveControl = this.txtEmail;
                return false;
            }
            if (this.txtPassword.Text == "")
            {
                this.lblPassword.Text = "password is required !!!";
                this.ActiveControl = this.txtPassword;
                return false;
            }
            if (!(this.ckbMale.Checked || this.ckbFemale.Checked))
            {
                this.lblGender.Text = "gender is required !!!";
                return false;
            }
            return true;
        }

        void cleaner()
        {
            this.txtName.Text = "";
            this.txtSurname.Text = "";
            this.txtUsername.Text = "";
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
            this.ckbMale.Checked  = false;
            this.ckbFemale.Checked = false;
            this.lblName.Text = "";
            this.lblSurname.Text = "";
            this.lblUsername.Text = "";
            this.lblEmail.Text = "";
            this.lblPassword.Text = "";
            this.lblGender.Text = "";
        }

        private void linkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            file.ShowDialog();
            if (file.FileName != "")
            {
                this.pctImage.Image = Image.FromFile(file.FileName); 
            }
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Login.hideSignUp();
            Login.ThisForm.Show();
        }
    }
}
