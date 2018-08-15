﻿using School.Models;
using School.Settings;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace School.Pages
{
    partial class StuTicket : Form
    { 
        public List<Quation> Quations { get; set; } = new List<Quation>();

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public List<P_TicketAndQuation> Pivot { get; set; } = new List<P_TicketAndQuation>();

        public List<Quation> selectedQuatins { get; set; } = new List<Quation>();

        public List<Quation> IncorrectQuations { get; set; } = new List<Quation>();

        public int CorrectCount { get; set; }

        System.Timers.Timer Timer = new System.Timers.Timer();

        System.Timers.Timer MessageTimer = new System.Timers.Timer();

        public int Index { get; set; } = 0;

        public int Minut { get; set; } = 15;

        public int Second { get; set; } = 1;

        public int MessageSecond { get; set; } = 0;


        Loading loading = new Loading();


        public StuTicket()
        {
            InitializeComponent();
            this.lblName.Text = Login.LoginedUser.Name;
            this.lblSurname.Text = Login.LoginedUser.Surname;
            this.Quations = getData<Quation>("Quations") as List<Quation>;
            this.Tickets = getData<Ticket>("Tickets") as List<Ticket>;
            this.Pivot = getData < P_TicketAndQuation>("P_TicketAndQuation") as List<P_TicketAndQuation>;
            fillCmbTickets();
            setTimer(1000); 
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            this.Timer.Stop();
            this.Timer.Dispose();
            Dashboard.ThisForm.Show();
        }

        private List<T> getData<T>(string table)
        {
            List<T> list = new List<T>(); 
            List<Quation> quations = new List<Quation>(); 
            List<Ticket> tickets   = new List<Ticket>(); 
            List<P_TicketAndQuation> pivot = new List<P_TicketAndQuation>();


            using(SQLiteConnection con =new SQLiteConnection(Login.connection))
            {
                string sql = "SELECT * FROM " + table;
                SQLiteCommand com = new SQLiteCommand(sql, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (table == "Quations")
                {
                    foreach (DataRow row in dt.Rows)
                    { 
                        quations.Add(new Quation
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Image = row["image"].ToString(),
                            Answer = row["answer"].ToString(),
                            Category_id = Convert.ToInt32(row["category_id"])
                        });

                    }
                    list = quations as List<T>;
                }
                if (table == "Tickets")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        tickets.Add(new Ticket
                        {
                            Id = Convert.ToInt32(row["id"]), 
                            Name = row["name"].ToString()
                        });

                    }
                    list = tickets as List<T>;
                }
                if (table == "P_TicketAndQuation")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        pivot.Add(new P_TicketAndQuation
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Quation_id = Convert.ToInt32(row["quation_id"]),
                            Ticket_id = Convert.ToInt32(row["ticket_id"])
                        });

                    }
                    list = pivot as List<T>;
                }

            }

            return list;
        }

        private void fillCmbTickets()
        {
            this.cmbTicket.Items.Clear();
            foreach (Ticket item in this.Tickets)
            {
                ComboboxItem itm = new ComboboxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };
                cmbTicket.Items.Add(itm);
            }
            cmbTicket.SelectedIndex = 0;
        }

        private void setQuation()
        { 
            using (FileStream s = new FileStream(Extentions.GetPath() + "\\Quations_Images\\" + this.selectedQuatins[Index].Image, FileMode.Open))
            {
                this.pctTicket.Image = Image.FromStream(s);
            }
            this.cleaner();
        }

        private void cmbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedQuatins.Clear();
            this.IncorrectQuations.Clear();
            this.Index = 0;
            this.CorrectCount = 0;
            int tickt_id = Convert.ToInt32((cmbTicket.SelectedItem as ComboboxItem).Value);
            foreach (P_TicketAndQuation item in this.Pivot.Where(p=>p.Ticket_id == tickt_id).ToList())
            {
                this.selectedQuatins.Add(this.Quations.First(q => q.Id == item.Quation_id));
            }
            this.setQuation();
            foreach (Button btn in this.grpQuations.Controls)
            {
                btn.BackColor = Color.Black;
            }

            this.Minut = 15;
            this.Second = 0;
            this.lblDuration.Text = "15:00";
        }
  
        private void btnAnswer(object sender, EventArgs e)
        {
            bool result;
            Button btn = sender as Button;
            string answer = this.selectedQuatins[Index].Answer;
            if (btn.Text == answer)
            {
                this.lblResponse.Text = "Cavab Doğrudur";
                this.lblResponse.ForeColor = Color.Green;
                btn.BackColor = Color.LawnGreen;
                result = true;
                CorrectCount++;
                if (CorrectCount == 9)
                { 
                  ShowResponse($"\"{Login.LoginedUser.Name}\" İmtahandan keçdiniz", Color.Green);
                }
            }
            else
            {
                foreach (Button _btn in this.grpAnswers.Controls)
                {
                    if(_btn.Text == answer)
                    {
                        _btn.BackColor = Color.LawnGreen;
                    }
                }
                this.lblResponse.Text = "Cavab Səhvdir";
                this.lblResponse.ForeColor = Color.Red;
                btn.BackColor = Color.Red;
                this.IncorrectQuations.Add(this.selectedQuatins[Index]);
                result = false;
                checkExem();
            }
            foreach (Button btnQua in this.grpQuations.Controls)
            {
                if((Convert.ToInt32(btnQua.Text) - 1)== this.Index)
                {
                    btnQua.BackColor = result ? Color.LawnGreen : Color.Red;
                }
            } 
        } 

        private void ShowResponse(string message, Color back_color)
        {
            loading.lblMessage.Text = message;
            loading.lblMessage.Left = ((loading.Width - loading.lblMessage.Width) / 2);
            loading.lblMessage.ForeColor = Color.White;
            loading.BackColor = back_color;
            loading.Show(this);
            MessageTimer.Elapsed += new ElapsedEventHandler(CloseMessage);
            MessageTimer.Interval = 1000;
            MessageTimer.Enabled = true;
        }

        private void checkExem()
        {
            if (this.IncorrectQuations.Count >= 2)
            {
                this.Timer.Stop();
                this.Timer.Dispose();
                ShowResponse("İmtahan dayandırıldı", Color.Red);
            }
        }

        private void cleaner()
        {
            foreach (Button btn in this.grpAnswers.Controls)
            {
                btn.BackColor = Color.Black;
                btn.Enabled = true;
            }
            this.lblResponse.Text = "";
        }

        private void setTimer(int interval)
        { 
            Timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            Timer.Interval = interval;
            Timer.Enabled = true;
        }
         
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (this.Minut == 0 && this.Second == 0)
            {
                this.Timer.Stop();
                this.Timer.Dispose();
                MessageBox.Show(this, "İmtahan vaxtı bitti");
                this.Close();
            }
            if(this.Second > 0)
            {
                this.lblDuration.Text = this.Minut + ":" + --this.Second;
            }
            else
            {
                this.Second = 60;
                this.Minut--;
            }
        }
         
        private void CloseMessage(object source, ElapsedEventArgs e)
        {
            MessageSecond++;
            if (MessageSecond > 2)
            {
                this.MessageTimer.Stop();
                this.MessageTimer.Dispose();
                loading.Close();
                this.Close();
            }
        }

        private void StuTicket_Load(object sender, EventArgs e)
        {
            this.pctTicket.Width = (this.Width / 2);
            this.pctTicket.Height = (this.Width / 4);
            this.pctTicket.Left = ((this.Width - this.pctTicket.Width) / 2);

            this.pnlAnswer.Left = ((this.Width - this.pnlAnswer.Width) / 2);
            this.pnlAnswer.Top = (this.pctTicket.Top + this.pctTicket.Height + 5);

            this.pnlInfo.Left = ((this.Width - this.pnlInfo.Width) / 2);
            this.pnlInfo.Top = (pnlAnswer.Top + pnlAnswer.Height);
        }

        private void FormResize(object sender, EventArgs e)
        {
            this.pctTicket.Width = (this.Width / 2);
            this.pctTicket.Height = (this.Width / 4);
            this.pctTicket.Left = ((this.Width - this.pctTicket.Width) / 2);

            this.pnlAnswer.Left = ((this.Width - this.pnlAnswer.Width) / 2);
            this.pnlAnswer.Top = (this.pctTicket.Top + this.pctTicket.Height + 5);

            this.pnlInfo.Left = ((this.Width - this.pnlInfo.Width) / 2);
            this.pnlInfo.Top = (pnlAnswer.Top + pnlAnswer.Height);
        }

        private void SelectButton(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Text);
            this.Index = --num;
            this.setQuation();
        }
    }
}
