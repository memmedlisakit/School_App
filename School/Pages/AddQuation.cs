using System; 
using System.Data;
using System.Data.SQLite; 
using System.Windows.Forms; 
using System.Drawing; 
using System.IO;
using School.Settings;
using System.Collections.Generic;
using System.Net;

namespace School.Pages
{
    public partial class AddQuation : Form
    {
       static SQLiteConnection con = new SQLiteConnection(Login.connection);
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        List<string> images = new List<string>();
        List<string> answers = new List<string>();
        string imageFolderPath = "";

        public AddQuation()
        {
            InitializeComponent();
            this.fillComboBox(this.cmbAllCategory);
            this.fillComboBox(this.cmbCategory);
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
        }
          
        public void fillComboBox(ComboBox combo)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Categories";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            da.SelectCommand = com;
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            { 
                combo.Items.Add(row["name"]);
            }
        }

        private bool checkingFiled()
        {
            if (this.cmbCategory.Text == "") {
                this.lblCategory.Text = "Select a category !!!";
                return false;
            }
            if (this.txtAnswer.Text == "")
            {
                this.lblAnswer.Text = "Write an answer !!!";
                return false;
            } 
            if (ofd.SafeFileName == "")
            {
                this.lblImage.Text = "Choose an image !!!";
                return false;
            }
            return true;
        }

        private void cleaner()
        {
            this.lblAllAnswers.Text = "";
            this.lblAllCategory.Text = "";
            this.lblAllImages.Text = "";
            this.lblAnswer.Text = "";
            this.lblCategory.Text = "";
            this.lblImage.Text = "";
            this.txtAnswer.Text = "";
            this.cmbAllCategory.SelectedIndex=  - 1;
            this.cmbCategory.SelectedIndex = -1;
            this.pckSingle.Image = null;
        }

        public static int getCatId(string name)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Categories WHERE name = '"+name+"'";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            da.SelectCommand = com;
            da.Fill(dt);
            int id = Convert.ToInt32(dt.Rows[0]["id"]);
            return id;            
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.checkingFiled())
            {
                string imageName = DateTime.Now.ToString("yyyyMMddHHssmm") + ofd.SafeFileName;
                Extentions.ImageUpload(ofd, imageName, "Quations_Images");
                string answer = this.txtAnswer.Text;
                string sql = "INSERT INTO Quations(answer, category_id, image) VALUES('" + this.txtAnswer.Text + "', '" + getCatId(this.cmbCategory.Text) + "', '" + imageName + "')";
                SQLiteCommand com = new SQLiteCommand(sql, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                this.cleaner();
            } 
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                this.pckSingle.Image = Image.FromFile(ofd.FileName);
            }
        }



        // Multipli insertion
        private void btnAllSave_Click(object sender, EventArgs e)
        {
               if (!this.checkingAllFiled())
               {
                    return;
               }
               int id = getCatId(this.cmbAllCategory.Text);
               for (int i = 0; i < images.Count; i++) 
               {
                    try
                    {
                        SQLiteCommand com = new SQLiteCommand();
                        string imageName = DateTime.Now.ToString("yyyyMMddHHssmm") + images[i];
                        string path = Extentions.GetPath() + "Quations_Images\\" + imageName;
                        WebClient webclient = new WebClient();
                        webclient.DownloadFile(imageFolderPath + "\\" + images[i], path);
                        string sql = "INSERT INTO Quations(answer, category_id, image) VALUES('" + this.answers[i] + "', " + id + ", '" + imageName + "')";
                        com.CommandText = sql;
                        com.Connection = con;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        this.cmbAllCategory.SelectedIndex = -1;
                    }
                    catch (Exception)
                    {
                        this.lblMulti.ForeColor = Color.Red;
                        this.lblMulti.Text = "An error occurred connecting with database";
                        return;
                    }
               }
            this.lblMulti.ForeColor = Color.Lime;
            this.lblMulti.Text = "Added successfuly";
            this.cleaner();
        }

        private void btnAllImages_Click(object sender, EventArgs e)
        {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    foreach (string file in files)
                    {
                        if(Path.GetExtension(file) == ".jpg" || Path.GetExtension(file) == ".jpeg")
                        {
                            this.images.Add(Path.GetFileName(file));
                        }
                    }
                    imageFolderPath = fbd.SelectedPath; 
            }
        }

        private void btnAllAnswers_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(ofd.SafeFileName) == ".txt")
                {
                    this.ReadTxt(ofd.FileName);
                }
                else
                {
                    this.lblAllAnswers.Text = "File extention must be .txt!!!";
                }
            }

        }

        void ReadTxt(string fileName)
        {
            string line;
            StreamReader file = new StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                this.answers.Add(line);
            }
        }

        bool checkingAllFiled()
        {
            if(this.cmbAllCategory.Text == "")
            {
                this.lblAllCategory.Text = "Select a category !!!";
                return false;
            }
            if (this.images.Count <= 0)
            {
                this.lblAllImages.Text = "Select am Image folder !!!";
                return false;
            }
            if (this.answers.Count <= 0)
            {
                this.lblAllAnswers.Text = "Select a answers !!!";
                return false;
            }
            if (this.answers.Count < this.images.Count)
            {
                this.lblAllAnswers.Text = "Answers count must be same as images count !!!";
                return false;
            }
            if (this.images.Count < this.answers.Count)
            {
                this.lblAllImages.Text = "Images count must be same as answers count !!!";
                return false;
            }
            return true;
        }
    }
}
