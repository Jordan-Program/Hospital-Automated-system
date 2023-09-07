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
    public partial class Transaction : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Transaction()
        {
            InitializeComponent();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss");
            
            
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string surname, firstname, middlename, transactionid = "", hospitalnumber = "", patientname = "", total = "", discount = "", amount = "", change = "", time = "", date = "", date2, time2;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            dptstartdate.MaxDate = DateTime.Today;
            dptenddate.MinDate = DateTime.Today;

            dtpstartdate2.MaxDate = DateTime.Today;
            dtpenddate2.MinDate = DateTime.Today;

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_ancillary_transaction";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                

                var item = new ListViewItem();
                item.Text = myreader["transactionid"].ToString();
                item.SubItems.Add(myreader["hospitalnumber"].ToString());
                item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["total"].ToString());
                item.SubItems.Add(myreader["discount"].ToString());
                item.SubItems.Add(myreader["amount"].ToString());
                item.SubItems.Add(myreader["changed"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView1.Items.Add(item);

               

              
            }

            con.Close();

            csrancillary ob = new csrancillary();
            ob.SetParameterValue("start", "2000-1-1");
            ob.SetParameterValue("end", "4000-1-1");
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " View All transactoin " + "','" + date2 + " " + time2 + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_ancillary_transaction where date   >= '"+ dptstartdate.Text +"' and date  <= '"+ dptenddate.Text +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                

                var item = new ListViewItem();
                item.Text = myreader["transactionid"].ToString();
                item.SubItems.Add(myreader["hospitalnumber"].ToString());
                item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["total"].ToString());
                item.SubItems.Add(myreader["discount"].ToString());
                item.SubItems.Add(myreader["amount"].ToString());
                item.SubItems.Add(myreader["changed"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView1.Items.Add(item);

            }

            con.Close();

            csrancillary ob = new csrancillary();
            ob.SetParameterValue("start", dptstartdate.Text);
            ob.SetParameterValue("end", dptenddate.Text);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " View a specific transaction " + "','" + date2 + " " + time2 + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            transactionid = item.SubItems[0].Text;
            hospitalnumber = item.SubItems[1].Text;
            patientname = item.SubItems[2].Text;
            total = item.SubItems[3].Text;
            discount = item.SubItems[4].Text;
            amount = item.SubItems[5].Text;
            change = item.SubItems[6].Text;
            time = item.SubItems[7].Text;
            date = item.SubItems[8].Text;

           

            
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "Ancillary Transaction")
            {
                pnlancillarytransaction.Visible = true;
                pnldischargetransaction.Visible = false;
            }

            if (cmbsearch.Text == "Admission Transaction")
            {
                pnlancillarytransaction.Visible = false;
                pnldischargetransaction.Visible = true;
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

        private void btnview2_Click(object sender, EventArgs e)
        {
            connection();
            listView2.Items.Clear();
            query = "select * from db_its.tbl_discharge_transaction where date   >= '" + dtpstartdate2.Text + "' and date  <= '" + dtpenddate2.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["transactionid"].ToString();
                item.SubItems.Add(myreader["hospitalnumber"].ToString());
                item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["otherfeetotal"].ToString());
                item.SubItems.Add(myreader["totalstayamount"].ToString());
                item.SubItems.Add(myreader["overallamountdue"].ToString());
                item.SubItems.Add(myreader["discount"].ToString());
                item.SubItems.Add(myreader["amountpaid"].ToString());
                item.SubItems.Add(myreader["changed"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView2.Items.Add(item);

            }

            con.Close();

            crsadmissiontransaction ob = new crsadmissiontransaction();
            ob.SetParameterValue("start", dtpstartdate2.Text);
            ob.SetParameterValue("end", dtpenddate2.Text);
            crystalReportViewer2.ReportSource = ob;
            crystalReportViewer2.Refresh();
        }

        private void btnviewall2_Click(object sender, EventArgs e)
        {
            connection();
            listView2.Items.Clear();
            query = "select * from db_its.tbl_discharge_transaction";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["transactionid"].ToString();
                item.SubItems.Add(myreader["hospitalnumber"].ToString());
                item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["otherfeetotal"].ToString());
                item.SubItems.Add(myreader["totalstayamount"].ToString());
                item.SubItems.Add(myreader["overallamountdue"].ToString());
                item.SubItems.Add(myreader["discount"].ToString());
                item.SubItems.Add(myreader["amountpaid"].ToString());
                item.SubItems.Add(myreader["changed"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView2.Items.Add(item);

            }

            con.Close();

            crsadmissiontransaction ob = new crsadmissiontransaction();
            ob.SetParameterValue("start", "2000-1-1");
            ob.SetParameterValue("end", "4000-1-1");
            crystalReportViewer2.ReportSource = ob;
            crystalReportViewer2.Refresh();

            con.Close();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " View All transactoin " + "','" + date2 + " " + time2 + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }


        
    }
}
