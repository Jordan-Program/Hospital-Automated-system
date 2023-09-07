using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ITSProject
{
    public partial class Xray : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Xray()
        {
            InitializeComponent();

            Timer DateTimer = new Timer();
            DateTimer.Interval = 1000;
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string surname, firstname, middlename, date, time ,date2, time2;

        public int time1 = 5;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }


        private void DateTimer_Tick(Object sender, EventArgs e)
        {


            date = DateTime.Now.ToString("MMMM dd, yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");

        }

        public void viewall()
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_xraypendingcheckup";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["age"].ToString());
                item.SubItems.Add(myreader["sex"].ToString());
                listView1.Items.Add(item);

            }
            con.Close();
        }

        public void selectphysician()
        {
            connection();
            query = "select * from db_its.tbl_xraypendingcheckup where hospitalnumber = '" + lblhospitalnumber.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
              
                lblphysician.Text = myreader["physician"].ToString();
                con.Close();
            }

        }

        public void deletependingcheckup()
        {
            connection();
            query = "delete from db_its.tbl_xraypendingcheckup where hospitalnumber = '" + lblhospitalnumber.Text + "'";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_xraypendingcheckup";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
               
                

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["age"].ToString());
                item.SubItems.Add(myreader["sex"].ToString());
                listView1.Items.Add(item);
               
            }
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearchbox.Text == "")
            {
                MessageBox.Show("Please insert either Patient - ID or Patient Surname");
            }
            else
            {
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_xraypendingcheckup where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    
                    

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    listView1.Items.Add(item);
                    
                }
                con.Close();
            }
        }

        private void Xray_Load(object sender, EventArgs e)
        {
            timer1.Start();
            viewall();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem item = listView1.SelectedItems[0];
                lblhospitalnumber.Text = item.SubItems[0].Text;
                lblpatientsname.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage.Text = item.SubItems[4].Text;
                lblsex.Text = item.SubItems[5].Text;

                surname = item.SubItems[1].Text;
                firstname = item.SubItems[2].Text;
                middlename = item.SubItems[3].Text;

                selectphysician();

                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + lblhospitalnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox1.Image = null;
                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        con.Close();
                    }

                }
            }

            catch
            { 
            }
        }
        private void btnxrayresult_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber.Text == "")
            {
                MessageBox.Show("Please select a patient");
            }

            else if (txtxrayresult.Text == "")
            {
                MessageBox.Show("Please fill up the required field.");
            }

            else
            {

                connection();
                query = "insert into db_its.tbl_xrayresult (hospitalnumber, surname, firstname, middlename, age, sex, xrayresult, physician, time, date) values ('" + lblhospitalnumber.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + txtxrayresult.Text.Replace("'", "''") + "','" + lblphysician.Text + "','" + time + "','" + date + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
                MessageBox.Show("Patient Xray / Ultrasound Result has been saved. Please return within 2 - 3 days for the result");
                
                txtxrayresult.Text = "";
                lblpatientsname.Text = "";
                lblhospitalnumber.Text = "";
                lblage.Text = "";
                lblsex.Text = "";
                lblphysician.Text = "";
                pictureBox1.Image = null;
                
                deletependingcheckup();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a result to Xray/Ultrasound " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                viewall();
                
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Go Back to Main Menu " + "','" + date2 + " " + time2 + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            MainMenu mn = new MainMenu();
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.name = name;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;
                
            }

            else
            {
                time1 = 5;
            }
        }

    }
}
