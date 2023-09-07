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
    public partial class EmergencyHistory : Form
    {
        public string name;
        public string userid;
        public string acoountposition;

        public EmergencyHistory()
        {
            InitializeComponent();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date2, time2;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void viewall()
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_emergency";
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
                item.SubItems.Add(myreader["birthdate"].ToString());
                item.SubItems.Add(myreader["contact"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["causeofincident"].ToString());
                item.SubItems.Add(myreader["roomnumber"].ToString());
                lver.Items.Add(item);
            }

            con.Close();
        }

        private void EmergencyHistory_Load(object sender, EventArgs e)
        {

            viewall();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_emergency where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                item.SubItems.Add(myreader["birthdate"].ToString());
                item.SubItems.Add(myreader["contact"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["causeofincident"].ToString());
                item.SubItems.Add(myreader["roomnumber"].ToString());
                lver.Items.Add(item);
            }

            con.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_emergency";
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
                item.SubItems.Add(myreader["birthdate"].ToString());
                item.SubItems.Add(myreader["contact"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["causeofincident"].ToString());
                item.SubItems.Add(myreader["roomnumber"].ToString());
                lver.Items.Add(item);
            }

            con.Close();
        }

        private void lver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lver.SelectedItems.Count == 0) return;
            ListViewItem item = lver.SelectedItems[0];
            txthospitalnumber.Text = item.SubItems[0].Text;
            txtsurname.Text = item.SubItems[1].Text;
            txtfirstname.Text = item.SubItems[2].Text;
            txtmiddlename.Text = item.SubItems[3].Text;
            txtage.Text = item.SubItems[4].Text;
            cmbsex.Text = item.SubItems[5].Text;
            dateTimePicker2.Text = item.SubItems[6].Text;
            txtcontact.Text = item.SubItems[7].Text;
            txtaddress.Text = item.SubItems[8].Text;
            dateTimePicker2.Text = item.SubItems[9].Text;
            lbltime.Text = item.SubItems[10].Text;
            txtcause.Text = item.SubItems[11].Text;
            cmberbed.Text = item.SubItems[12].Text;

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
            mn.name = name;
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

    }
}
