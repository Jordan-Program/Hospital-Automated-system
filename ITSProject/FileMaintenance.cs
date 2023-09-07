using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITSProject
{
    public partial class FileMaintenance : Form
    {
        public string acoountposition;
        public string name;
        public string useridd;

        public FileMaintenance()
        {
            InitializeComponent();

        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        

        public string user, date, time, status = "Active", usernumber, username, usersid, philid;
        public int id, attempt = 2, count = 0;
        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void viewall()
        {
            connection();
            lvaudittrail.Items.Clear();
            query = "select * from db_its.tbl_audittrail";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["logno"].ToString();
                item.SubItems.Add(myreader["user"].ToString());
                item.SubItems.Add(myreader["action"].ToString());
                item.SubItems.Add(myreader["message"].ToString());
                item.SubItems.Add(myreader["datetime"].ToString());
                lvaudittrail.Items.Add(item);

            }
            con.Close();

            crsaudittrail ob = new crsaudittrail();
            ob.SetParameterValue("start", "2000-1-1" + "00:00:00");
            ob.SetParameterValue("end", "4000-1-1" + "23:59:59");
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }

        public void viewallaccounts()
        {
            connection();
            lvaccounts.Items.Clear();
            query = "select * from db_its.tbl_accounts where accountposition != 'admin'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                usernumber = myreader["userid"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["userid"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["username"].ToString());
                item.SubItems.Add(myreader["accountposition"].ToString());
                lvaccounts.Items.Add(item);
            }

            con.Close();
        }


        private void FileMaintenance_Load(object sender, EventArgs e)
        {
            userid();
            discount();
            roomprice();
            doctorprice();
            doctorid();
            doctorlist();
            removedoctor();
            readddoctor();
            queuenumber();
            removeacc();
            viewall();
            viewallaccounts();

            dptstartdate.MaxDate = DateTime.Today;
            dptenddate.MinDate = DateTime.Today;

            ancillaryprice();
            
            medicalmalewardlistview();
            malewardid();
            malewardroomcount();
            
            medicalfemalewardlistview();
            femalewardid();
            femalewardroomcount();
           
            obgynelistview();
            obgyneid();
            obgyneroomcount();
           
            surgicallistview();
            surgicalid();
            surgicalroomcount();

            pediatriclistview();
            pediatricid();
            pediatricroomcount();

            isolationlistview();
            isolationid();
            isolationroomcount();

            erlistview();
            erid();
            erroomcount();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void doctorid()
        {


            connection();
            query = "select * from db_its.tbl_doctor order by doctorcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {


                int count = myreader["doctorid"].ToString().Length;

                if (count == 6)
                {
                   id = int.Parse(myreader["doctorid"].ToString().Substring(5, 1)) + 1;

                    lbldoctorid.Text = "DC" + " - " + id;
                }

                if (count == 7)
                {
                    id = int.Parse(myreader["doctorid"].ToString().Substring(5, 2)) + 1;

                    lbldoctorid.Text = "DC" + " - " + id;
                }

                if (count == 8)
                {
                    id = int.Parse(myreader["doctorid"].ToString().Substring(5, 3)) + 1;

                    lbldoctorid.Text = "DC" + " - " + id;
                }


                if (count == 9)
                {
                    id = int.Parse(myreader["doctorid"].ToString().Substring(5, 4)) + 1;

                    lbldoctorid.Text = "DC" + " - " + id;
                }




            }

            con.Close();
        }



        public void import()
        {
            string mycon = "datasource=localhost;database = db_its;username=root;password=";
            string file1 = @"C:\Users\DatuinMelchisedeck\Desktop\My Files\C# program\ITSProject\db_its.sql";
            using (MySqlConnection con = new MySqlConnection(mycon))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup ex = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        ex.ImportFromFile(file1);
                        con.Close();
                    }
                }
            }
        }

        public void export()
        {
            string mycon = "datasource=localhost;database = db_its;username=root;password=";
            string file1 = @"C:\Users\DatuinMelchisedeck\Desktop\My Files\C# program\ITSProject\db_its.sql";
            using (MySqlConnection con = new MySqlConnection(mycon))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup ex = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        ex.ExportToFile(file1);
                        con.Close();
                    }
                }
            }
        }

        public void createdatabase()
        {
            connection();
            MySqlConnection con = new MySqlConnection(its);
            MySqlCommand command = new MySqlCommand("create database db_its", con);
            MySqlDataReader myreader;
            con.Open();
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
            }
            MessageBox.Show("Database have been created.");
            import();

            con.Close();
        }

        public void userid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_accounts order by usercount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["userid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["userid"].ToString().Substring(6, 1)) + 1;

                        user = " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["userid"].ToString().Substring(6, 2)) + 1;

                        user = " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["userid"].ToString().Substring(6, 3)) + 1;

                        user = " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["userid"].ToString().Substring(6, 4)) + 1;

                        user = " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void doctorprice()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_doctorprice";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    txtcurrenddoctorprice.Text = myreader["doctorprice"].ToString();

                }

            }
            catch
            {
            }
            con.Close();
        }

        public void roomprice()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_roomprice";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    txtcurrentroomprice.Text = myreader["roomprice"].ToString();

                }

            }
            catch
            {
            }
            con.Close();
        }

        public void discount()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_discount";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    txtcurrentdiscount.Text = myreader["discount"].ToString();
                }

            }
            catch
            {
            }
            con.Close();
        }

        public void removedoctor()
        {
            connection();
            lvremovedoctor.Items.Clear();
            query = "select * from db_its.tbl_doctor where doctorstatus = '"+ "Available" +"' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["doctorid"].ToString();
                item.SubItems.Add(myreader["doctorname"].ToString());
                lvremovedoctor.Items.Add(item);
            }

            con.Close();
        }

        public void readddoctor()
        {
            connection();
            lvreadddoctor.Items.Clear();
            query = "select * from db_its.tbl_doctor where doctorstatus = '" + "Not Available" + "' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["doctorid"].ToString();
                item.SubItems.Add(myreader["doctorname"].ToString());
                lvreadddoctor.Items.Add(item);
            }

            con.Close();
        }


        public void doctorlist()
        {
            connection();
            lvaccounts.Items.Clear();
            query = "select * from db_its.tbl_doctor where doctorstatus = '" + "Available" + "' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {



                var item = new ListViewItem();
                item.Text = myreader["doctorid"].ToString();
                item.SubItems.Add(myreader["doctorname"].ToString());
                item.SubItems.Add(myreader["department"].ToString());

                lvdoctor.Items.Add(item);
            }

            con.Close();
        }

        public void queuenumber()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    txtlabqnumber.Text = myreader["qnumberlab"].ToString();
                    txtxrayqnumber.Text = myreader["qnumberxray"].ToString();
                    txtctscanqnumber.Text = myreader["qnumberctscan"].ToString();
                    txtecgqnumber.Text = myreader["qnumberecg"].ToString();

                }

            }
            catch
            {
            }
            con.Close();
        }

        public void ancillaryprice()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_ancillaryprice";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    txtcurrentpricelab.Text = myreader["labprice"].ToString();
                    txtcurrentpricexray.Text = myreader["xrayprice"].ToString();
                    txtcurrentpriceecg.Text = myreader["ecgprice"].ToString();
                    txtcurrentpricectscan.Text = myreader["ctscanprice"].ToString();

                }

            }
            catch
            {
            }
            con.Close();
        }

        private void cbxaccountcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxaccountcontrol.Text == "Doctor")
            {
                txtuserid.Text = "DOC" + user;

            }

            if (cbxaccountcontrol.Text == "Nurse")
            {
                txtuserid.Text = "NUR" + user;

            }

            if (cbxaccountcontrol.Text == "Cashier")
            {
                txtuserid.Text = "CAR" + user;

            }

            if (cbxaccountcontrol.Text == "Medtech")
            {
                txtuserid.Text = "MED" + user;

            }
        }

        public void removeacc()
        {
            connection();
            lvaccounts.Items.Clear();
            query = "select * from db_its.tbl_accounts where accountposition != 'admin'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                usernumber = myreader["userid"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["userid"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["username"].ToString());
                item.SubItems.Add(myreader["accountposition"].ToString());
                lvremoveacc.Items.Add(item);
            }

            con.Close();
        }

        public void medicalmalewardlistview()
        {
            connection();
            lvmalewardaddroom.Items.Clear();
            query = "select * from db_its.tbl_medicalmalewardroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["medicalmaleroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvmalewardaddroom.Items.Add(item);
            }

            con.Close();

            connection();
            lvmalewardupdateroom.Items.Clear();
            query = "select * from db_its.tbl_medicalmalewardroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["medicalmaleroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvmalewardupdateroom.Items.Add(item);
            }

            con.Close();
        
        
        
        }

        public void malewardid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_medicalmalewardroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblmalewardid.Text = "MMW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblmalewardid.Text = "MMW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblmalewardid.Text = "MMW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblmalewardid.Text = "MMW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void malewardroomcount()
        {
            connection();
            query = "select * from db_its.tbl_medicalmalewardroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblmalewardnumber.Text = myreader["medicalmaleroomcount"].ToString();

                int count = int.Parse(lblmalewardnumber.Text);
                count++;
                lblmalewardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void medicalfemalewardlistview()
        {
            connection();
            lvfemalewardaddroom.Items.Clear();
            query = "select * from db_its.tbl_medicalfemalewardroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["medicalfemaleroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvfemalewardaddroom.Items.Add(item);
            }

            con.Close();

            connection();
            lvfemalewardupdateroom.Items.Clear();
            query = "select * from db_its.tbl_medicalfemalewardroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["medicalfemaleroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvfemalewardupdateroom.Items.Add(item);
            }

            con.Close();

        }

        public void femalewardid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_medicalfemalewardroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblfemalewardid.Text = "MFW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblfemalewardid.Text = "MFW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblfemalewardid.Text = "MFW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblfemalewardid.Text = "MFW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void femalewardroomcount()
        {
            connection();
            query = "select * from db_its.tbl_medicalfemalewardroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblfemalewardnumber.Text = myreader["medicalfemaleroomcount"].ToString();

                int count = int.Parse(lblfemalewardnumber.Text);
                count++;
                lblfemalewardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void obgynelistview()
        {
            connection();
            lvobgyneaddroom.Items.Clear();
            query = "select * from db_its.tbl_obgyneroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["obgyneroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvobgyneaddroom.Items.Add(item);
            }

            con.Close();

            connection();
            lvobgyneupdateroom.Items.Clear();
            query = "select * from db_its.tbl_obgyneroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["obgyneroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvobgyneupdateroom.Items.Add(item);
            }

            con.Close();
        }

        public void obgyneid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_obgyneroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblobgynewardid.Text = "OBW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblobgynewardid.Text = "OBW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblobgynewardid.Text = "OBW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblobgynewardid.Text = "OBW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void obgyneroomcount()
        {
            connection();
            query = "select * from db_its.tbl_obgyneroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblobgynewardnumber.Text = myreader["obgyneroomcount"].ToString();

                int count = int.Parse(lblobgynewardnumber.Text);
                count++;
                lblobgynewardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void surgicallistview()
        {
            connection();
            lvsurgicaladdroom.Items.Clear();
            query = "select * from db_its.tbl_surgicalroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["surgicalroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvsurgicaladdroom.Items.Add(item);
            }

            con.Close();

            connection();
            lvsurgicalupdateroom.Items.Clear();
            query = "select * from db_its.tbl_surgicalroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["surgicalroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvsurgicalupdateroom.Items.Add(item);
            }

            con.Close();


        }

        public void surgicalid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_surgicalroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblsurgicalnewid.Text = "SLW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblsurgicalnewid.Text = "SLW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblsurgicalnewid.Text = "SLW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblsurgicalnewid.Text = "SLW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void surgicalroomcount()
        {
            connection();
            query = "select * from db_its.tbl_surgicalroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblsurgicalnewwardnumber.Text = myreader["surgicalroomcount"].ToString();

                int count = int.Parse(lblsurgicalnewwardnumber.Text);
                count++;
                lblsurgicalnewwardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void pediatriclistview()
        {
            connection();
            lvpediatricaddroom.Items.Clear();
            query = "select * from db_its.tbl_pediatricroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["pediatricroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvpediatricaddroom.Items.Add(item);
            }

            con.Close();

            connection();
            lvpediatricupdateroom.Items.Clear();
            query = "select * from db_its.tbl_pediatricroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["pediatricroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvpediatricupdateroom.Items.Add(item);
            }

            con.Close();

        }

        public void pediatricid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_pediatricroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblpediatricnewid.Text = "PTW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblpediatricnewid.Text = "PTW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblpediatricnewid.Text = "PTW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblpediatricnewid.Text = "PTW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void pediatricroomcount()
        {
            connection();
            query = "select * from db_its.tbl_pediatricroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblpediatricnewwardnumber.Text = myreader["pediatricroomcount"].ToString();

                int count = int.Parse(lblpediatricnewwardnumber.Text);
                count++;
                lblpediatricnewwardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void isolationlistview()
        {
            connection();
            lvisolationaddroom.Items.Clear();
            query = "select * from db_its.tbl_isolationroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["isolationroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvisolationaddroom.Items.Add(item);
            }

            con.Close();


            connection();
            lvisolationupdateroom.Items.Clear();
            query = "select * from db_its.tbl_isolationroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["isolationroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lvisolationupdateroom.Items.Add(item);
            }

            con.Close();
        }

        public void isolationid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_isolationroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 1)) + 1;

                        lblisolationnewwardid.Text = "ISW" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 2)) + 1;

                        lblisolationnewwardid.Text = "ISW" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 3)) + 1;

                        lblisolationnewwardid.Text = "ISW" + " - " + id;
                    }

                    if (count == 10)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(6, 4)) + 1;

                        lblisolationnewwardid.Text = "ISW" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void isolationroomcount()
        {
            connection();
            query = "select * from db_its.tbl_isolationroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblisolationnewwardnumber.Text = myreader["isolationroomcount"].ToString();

                int count = int.Parse(lblisolationnewwardnumber.Text);
                count++;
                lblisolationnewwardnumber.Text = count.ToString();

            }

            con.Close();
        }

        public void erlistview()
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_erroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["erroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lver.Items.Add(item);
            }

            con.Close();

            connection();
            lver2.Items.Clear();
            query = "select * from db_its.tbl_erroom where roomstatus != '" + "Taken" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["roomid"].ToString();
                item.SubItems.Add(myreader["erroomcount"].ToString());
                item.SubItems.Add(myreader["roomstatus"].ToString());
                lver2.Items.Add(item);
            }

            con.Close();



        }

        public void erid()
        {
            try
            {
                connection();
                query = "select * from db_its.tbl_erroom order by roomcount desc";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {


                    int count = myreader["roomid"].ToString().Length;

                    if (count == 6)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(5, 1)) + 1;

                        lblerwardid.Text = "ER" + " - " + id;
                    }

                    if (count == 7)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(5, 2)) + 1;

                        lblerwardid.Text = "ER" + " - " + id;
                    }

                    if (count == 8)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(5, 3)) + 1;

                        lblerwardid.Text = "ER" + " - " + id;
                    }

                    if (count == 9)
                    {
                        id = int.Parse(myreader["roomid"].ToString().Substring(5, 4)) + 1;

                        lblerwardid.Text = "ER" + " - " + id;
                    }

                }
            }
            catch
            {
            }
            con.Close();
        }

        public void erroomcount()
        {
            connection();
            query = "select * from db_its.tbl_erroom order by roomcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                lblerroomcount.Text = myreader["erroomcount"].ToString();

                int count = int.Parse(lblerroomcount.Text);
                count++;
                lblerroomcount.Text = count.ToString();

            }

            con.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.acoountposition = acoountposition;
            mn.name = name;
            mn.userid = useridd;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnsaveaccount_Click(object sender, EventArgs e)
        {

            if (txtsurname.Text == "" || txtfirstname.Text == "" ||txtaddress.Text == "" || txtusername.Text == "" || txtpassword.Text == "" || cbxaccountcontrol.Text == "")
            {
                MessageBox.Show("Please Fill up all required field");
            }
            else if (txtcontactnumber.Text.Length < 13 || txtcontactnumber.Text.Length < 9 && txtcontactnumber.Text.Length > 9)
            {
                MessageBox.Show("Please put your phone or telephone number. or Your number is Invalid");
            }

            else if (txtuserid.Text.Length < 4)
            {
                MessageBox.Show("Username should higher than 3 letters");
            }

            else if (txtpassword.Text.Length < 4)
            {
                MessageBox.Show("Password should higher than 3 letters");
            }
            else if (cmbregister.Text == "" && cmbdoctor.Text == "" && cmbviewpatient.Text == "" && cmbancillary.Text == "" 
                    && cmbresult.Text == "" && cmbbilling.Text == "" && cmbreport.Text == "" && cmbemergency.Text == "" 
                    && cmbadmitting.Text == "" && cmbward.Text == "")
            {
                MessageBox.Show("Please Choose Access or Denied in all user control");
            }
            
            else
            {
                connection();
                query = "select * from db_its.tbl_accounts";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    username = myreader["username"].ToString().ToLower();
                    if (txtusername.Text.ToLower() == username)
                    {
                        MessageBox.Show("Username has been existed. Please Change your username");
                    }
                    else
                    {
                        date = DateTime.Now.ToString("MMMM dd, yyyy");
                        time = DateTime.Now.ToString("hh:mm:ss tt");
                        connection();
                        query = "insert into db_its.tbl_accounts (userid, accountposition, username, password, surname, firstname, middlename, contactnumber, address, accountstat, attempts, time, date) values ('" + txtuserid.Text + "','"
                            + cbxaccountcontrol.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtcontactnumber.Text + "','"
                            + txtaddress.Text + "','" + status + "','" + attempt + "','" + time + "','" + date + "')";

                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        MessageBox.Show("New account has been Created");
                        con.Close();

                        connection();
                        query = "insert into db_its.tbl_usercontrol (userid, register, doctor, viewpatient, ancillary, result, billing, reports, emergency, admitting, ward) values ('" + txtuserid.Text + "','" + cmbregister.Text + "','" + cmbdoctor.Text + "','" 
                                + cmbviewpatient.Text + "','" + cmbancillary.Text + "','" + cmbresult.Text + "','" + cmbbilling.Text + "','" + cmbreport.Text + "','" + cmbemergency.Text + "','" + cmbadmitting.Text + "','" + cmbward.Text +"')";

                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();


                        txtsurname.Text = "";
                        txtmiddlename.Text = "";
                        txtfirstname.Text = "";
                        txtaddress.Text = "";
                        txtusername.Text = "";
                        txtpassword.Text = "";
                        cbxaccountcontrol.SelectedIndex = -1;
                        txtcontactnumber.Text = "";
                        txtuserid.Text = "";
                        cmbregister.SelectedIndex = -1;
                        cmbdoctor.SelectedIndex = -1;
                        cmbviewpatient.SelectedIndex = -1;
                        cmbancillary.SelectedIndex = -1;
                        cmbresult.SelectedIndex = -1;
                        cmbbilling.SelectedIndex = -1;
                        cmbreport.SelectedIndex = -1;
                        cmbemergency.SelectedIndex = -1;
                        cmbadmitting.SelectedIndex = -1;
                        cmbward.SelectedIndex = -1;
                        userid();
                    }
                }

                con.Close();



            }

        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            lvaccounts.Items.Clear();
            query = "select * from db_its.tbl_accounts where accountposition != 'admin'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                usernumber = myreader["userid"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["userid"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["username"].ToString());
                item.SubItems.Add(myreader["accountposition"].ToString());
                lvaccounts.Items.Add(item);
            }

            con.Close();
        }

        
        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            if (txtsurname2.Text == "" || txtfirstname2.Text == "" || txtaddress2.Text == "" || txtusername2.Text == "" || txtpassword2.Text == "" || cbxaccountcontrol2.Text == "")
            {
                MessageBox.Show("Please Fill up all required field");
            }

            else if (txtcontactnumber2.Text.Length < 9 || txtcontactnumber2.Text.Length < 13 && txtcontactnumber2.Text.Length > 9)
            {
                MessageBox.Show("Please put your phone or telephone number. or Your number is Invalid");
            }

            else if (txtuserid2.Text.Length < 4)
            {
                MessageBox.Show("Username should higher than 3 letters");
            }

            else if (txtpassword2.Text.Length < 4)
            {
                MessageBox.Show("Password should higher than 3 letters");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_accounts";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    username = myreader["username"].ToString().ToLower();
                    if (txtusername2.Text.ToLower() == username)
                    {
                        MessageBox.Show("Username has been existed. Please Change your username");
                    }
                    else
                    {
                        connection();
                        query = "update db_its.tbl_accounts set surname = '" + txtsurname2.Text + "', firstname = '" + txtfirstname2.Text + "', middlename = '" + txtmiddlename2.Text + "', username = '" + txtusername2.Text + "', password = '" + txtpassword2.Text + "', contactnumber = '" + txtcontactnumber2.Text + "', address = '" + txtaddress2.Text + "', accountposition = '" + cbxaccountcontrol2.Text + "' where userid = '" + txtuserid2.Text + "' ";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        MessageBox.Show("User account has been updated");
                        lvaccounts.Items.Clear();
                        con.Close();

                        connection();
                        query = "update db_its.tbl_usercontrol set register = '" + cmbregister2.Text + "', doctor = '" + cmbdoctor2.Text + "', viewpatient = '" + cmbviewpatient2.Text + "', ancillary = '" + cmbancillary2.Text + "', result = '" + cmbresult2.Text + "', billing = '" + cmbbilling2.Text + "', reports = '" + cmbreport2.Text + "', emergency = '" + cmbemergency2.Text + "', admitting = '" + cmbadmitting2.Text + "', ward = '" + cmbward2.Text + "' where userid = '" + txtuserid2.Text + "' ";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();

                        txtsurname2.Text = "";
                        txtmiddlename2.Text = "";
                        txtfirstname2.Text = "";
                        txtaddress2.Text = "";
                        txtusername2.Text = "";
                        txtpassword2.Text = "";
                        cbxaccountcontrol2.SelectedIndex = -1;
                        txtcontactnumber2.Text = "";
                        txtuserid2.Text = "";
                        cmbregister2.SelectedIndex = -1;
                        cmbdoctor2.SelectedIndex = -1;
                        cmbviewpatient2.SelectedIndex = -1;
                        cmbancillary2.SelectedIndex = -1;
                        cmbresult2.SelectedIndex = -1;
                        cmbbilling2.SelectedIndex = -1;
                        cmbreport2.SelectedIndex = -1;
                        cmbemergency2.SelectedIndex = -1;
                        cmbadmitting2.SelectedIndex = -1;
                        cmbward2.SelectedIndex = -1;
                    }
                }
            }
        }

        private void btnusermaintenance_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = true;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer2.Enabled = false;
                this.timer1.Enabled = true;
                count = 1;

                
            }

            else if (count == 1)
            {
                this.timer2.Enabled = true;
                this.timer1.Enabled = false;
                count = 0;
            }
        }
        private void btndiscount_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = true;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer4.Enabled = false;
                this.timer3.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer4.Enabled = true;
                this.timer3.Enabled = false;
                count = 0;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            connection();
            lvaccounts.Items.Clear();
            query = "select * from db_its.tbl_accounts where accountposition != 'admin' and userid = '" + txtsearchbox.Text.Replace("'", "''") + "' or surname = '" + txtsearchbox.Text.Replace("'", "''") + "' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                usernumber = myreader["userid"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["userid"].ToString();
                item.SubItems.Add(myreader["surname"].ToString());
                item.SubItems.Add(myreader["firstname"].ToString());
                item.SubItems.Add(myreader["middlename"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["username"].ToString());
                item.SubItems.Add(myreader["accountposition"].ToString());
                lvaccounts.Items.Add(item);
            }

            con.Close();
        }

        private void txtsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {
            if ((txtsurname.Text.Length) == 1)
            {
                txtsurname.Text = txtsurname.Text[0].ToString().ToUpper();
                txtsurname.Select(2, 1);

            }
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if ((txtfirstname.Text.Length) == 1)
            {
                txtfirstname.Text = txtfirstname.Text[0].ToString().ToUpper();
                txtfirstname.Select(2, 1);

            }
        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {
            if ((txtmiddlename.Text.Length) == 1)
            {
                txtmiddlename.Text = txtmiddlename.Text[0].ToString().ToUpper();
                txtmiddlename.Select(2, 1);

            }
        }

        private void txtmiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtsurname2_TextChanged(object sender, EventArgs e)
        {
            if ((txtsurname2.Text.Length) == 1)
            {
                txtsurname2.Text = txtsurname2.Text[0].ToString().ToUpper();
                txtsurname2.Select(2, 1);

            }
        }

        private void txtsurname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtfirstname2_TextChanged(object sender, EventArgs e)
        {
            if ((txtfirstname2.Text.Length) == 1)
            {
                txtfirstname2.Text = txtfirstname2.Text[0].ToString().ToUpper();
                txtfirstname2.Select(2, 1);

            }
        }

        private void txtfirstname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtmiddlename2_TextChanged(object sender, EventArgs e)
        {
            if ((txtmiddlename2.Text.Length) == 1)
            {
                txtmiddlename2.Text = txtmiddlename2.Text[0].ToString().ToUpper();
                txtmiddlename2.Select(2, 1);

            }
        }

        private void txtmiddlename2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void lvaccounts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvaccounts.SelectedItems.Count == 0) return;
            ListViewItem item = lvaccounts.SelectedItems[0];
            txtuserid2.Text = item.SubItems[0].Text;
            txtsurname2.Text = item.SubItems[1].Text;
            txtfirstname2.Text = item.SubItems[2].Text;
            txtmiddlename2.Text = item.SubItems[3].Text;
            txtcontactnumber2.Text = item.SubItems[4].Text;
            txtaddress2.Text = item.SubItems[5].Text;
            txtusername2.Text = item.SubItems[6].Text;
            cbxaccountcontrol2.Text = item.SubItems[7].Text;



            connection();
            query = "select * from db_its.tbl_accounts where userid = '" + txtuserid2.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtpassword2.Text = myreader["password"].ToString();
            }

            con.Close();

            connection();
            query = "select * from db_its.tbl_usercontrol where userid = '" + txtuserid2.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                cmbregister2.Text = myreader["register"].ToString();
                cmbdoctor2.Text = myreader["doctor"].ToString();
                cmbviewpatient2.Text = myreader["viewpatient"].ToString();
                cmbancillary2.Text = myreader["ancillary"].ToString();
                cmbresult2.Text = myreader["result"].ToString();
                cmbbilling2.Text = myreader["billing"].ToString();
                cmbreport2.Text = myreader["reports"].ToString();
                cmbemergency2.Text = myreader["emergency"].ToString();
                cmbadmitting2.Text = myreader["admitting"].ToString();
                cmbward2.Text = myreader["ward"].ToString();
            }

            con.Close();
        }

        private void btnupdatediscount_Click(object sender, EventArgs e)
        {
            if (txtupdateddiscount.Text == "")
            {
                MessageBox.Show("Please put your desire discount in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_discount set discount = '" + txtupdateddiscount.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Discount has been Updated");
                discount();
                txtupdateddiscount.Text = "";

                con.Close();
            }

        }

        private void txtupdateddiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            createdatabase();
        }

        private void btnbackupdatabase_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = true;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer6.Enabled = false;
                this.timer5.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer6.Enabled = true;
                this.timer5.Enabled = false;
                count = 0;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtfilepath.Text = dlg.SelectedPath;

            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            if (txtfilepath.Text == "")
            {
                MessageBox.Show("Please select a path where you want to save your Back - up");

            }

            else
            {
                string mycon = "datasource=localhost;database = db_its;username=root;password=";
                string file1 = @txtfilepath.Text + @"\db_its.sql".Replace("\\", "\\\\");
                using (MySqlConnection con = new MySqlConnection(mycon))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup ex = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            ex.ExportToFile(file1);
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Database has been Back - up.");
            }
        }
        private void btnbrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            txtfilepath2.Text = op.FileName;
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            if (txtfilepath2.Text == "")
            {
                MessageBox.Show("Please choose the file to restore your Database");

            }

            else
            {
                string mycon = "datasource=localhost;database = db_its;username=root;password=";
                string file1 = txtfilepath2.Text;
                using (MySqlConnection con = new MySqlConnection(mycon))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup ex = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            ex.ImportFromFile(file1);
                            con.Close();

                        }
                    }
                }
                MessageBox.Show("Database has been Restored");
            }
        }

        private void btnaddnewdoctor_Click(object sender, EventArgs e)
        {
            if (txtdoctorname.Text == "")
            {
                MessageBox.Show("Doctor name is Empty");
            }
            else
            {
                connection();
                query = "insert into db_its.tbl_doctor (doctorid, doctorname, department, doctorstatus)values ('" + lbldoctorid.Text + "','" + "Dr. " + txtdoctorname.Text + "', '" + cmbspecial.Text + "', '" + "Active" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
                MessageBox.Show("New Doctor has Been added.");

                txtdoctorname.Text = "";
                cmbspecial.SelectedIndex = -1;
                doctorid();

                lvdoctor.Items.Clear();
                lvremovedoctor.Items.Clear();

                doctorlist();
                removedoctor();
                readddoctor();
            }
        }

        private void btndoctors_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = true;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

             if (count == 0)
            {
                this.timer8.Enabled = false;
                this.timer7.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer8.Enabled = true;
                this.timer7.Enabled = false;
                count = 0;
            }
        }

        private void txtdoctorname_TextChanged(object sender, EventArgs e)
        {
            if ((txtdoctorname.Text.Length) == 1)
            {
                txtdoctorname.Text = txtdoctorname.Text[0].ToString().ToUpper();
                txtdoctorname.Select(2, 1);

            }
        }

        private void txtdoctorname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void lvdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvdoctor.SelectedItems.Count == 0) return;
            ListViewItem item = lvdoctor.SelectedItems[0];
            lbldoctorid2.Text = item.SubItems[0].Text;
            txtdoctorname2.Text = item.SubItems[1].Text;
            cmbspecial2.Text = item.SubItems[2].Text;

        }

        private void txtdoctorname2_TextChanged(object sender, EventArgs e)
        {
            if ((txtdoctorname2.Text.Length) == 1)
            {
                txtdoctorname2.Text = txtdoctorname2.Text[0].ToString().ToUpper();
                txtdoctorname2.Select(2, 1);

            }
        }

        private void btnupdatedoctor_Click(object sender, EventArgs e)
        {
            if (txtdoctorname2.Text == "")
            {
                MessageBox.Show("Doctor name is Empty");
            }
            else
            {
                connection();
                query = "update db_its.tbl_doctor set doctorname = '" + txtdoctorname2.Text + "', department = '"+ cmbspecial2.Text +"' where doctorid = '" + lbldoctorid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Doctor has been updateded");
                lvdoctor.Items.Clear();
                doctorlist();
                removedoctor();
                readddoctor();
                con.Close();

                txtdoctorname2.Text = "";
                lbldoctorid2.Text = "";
                cmbspecial2.SelectedIndex = -1;
            }
        }

        private void lvremovedoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvremovedoctor.SelectedItems.Count == 0) return;
            ListViewItem item = lvremovedoctor.SelectedItems[0];
            lbldoctorid3.Text = item.SubItems[0].Text;
            txtdoctorname3.Text = item.SubItems[1].Text;
        }

        private void btnremovedoctor_Click(object sender, EventArgs e)
        {
            if (txtdoctorname3.Text == "")
            {
                MessageBox.Show("Please choose a doctor you want to remove");
            }
            else
            {
                connection();
                query = "update db_its.tbl_doctor set doctorstatus = '" + "Not Available" + "' where doctorid = '" + lbldoctorid3.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Doctor has been Resign");
                lvdoctor.Items.Clear();
                lvremovedoctor.Items.Clear();

                doctorlist();
                removedoctor();
                readddoctor();

                lbldoctorid3.Text = "";
                txtdoctorname3.Text = "";
            }

        }

        private void btnqnumber_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = true;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer10.Enabled = false;
                this.timer9.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer10.Enabled = true;
                this.timer9.Enabled = false;
                count = 0;
            }
        }

        private void btnupdatelabqnumber_Click(object sender, EventArgs e)
        {
            if (txtlabqnumber2.Text == "")
            {
                MessageBox.Show("Pease put your desire Queue number of Laboratory in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_qnumbers set qnumberlab = '" + txtlabqnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Queue number of Laboratory has been Updateded");
                queuenumber();
                txtlabqnumber2.Text = "";

                con.Close();
            }
        }

        private void btnupdatexrayqnumber_Click(object sender, EventArgs e)
        {
            if (txtxrayqnumber2.Text == "")
            {
                MessageBox.Show("Pease put your desire Queue number of Xray / Ultrasound in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_qnumbers set qnumberxray = '" + txtxrayqnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Queue number of Xray / Ultrasoung has been Updateded");
                queuenumber();
                txtxrayqnumber2.Text = "";

                con.Close();
            }
        }

        private void btnupdatectscanqnumber_Click(object sender, EventArgs e)
        {
            if (txtctscanqnumber2.Text == "")
            {
                MessageBox.Show("Pease put your desire Queue number of CT scan in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_qnumbers set qnumberctscan = '" + txtctscanqnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Queue number of CT scan has been Updateded");
                queuenumber();
                txtctscanqnumber2.Text = "";

                con.Close();
            }
        }

        private void btnupdateecgqnumber_Click(object sender, EventArgs e)
        {
            if (txtecgqnumber2.Text == "")
            {
                MessageBox.Show("Pease put your desire Queue number of ECG in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_qnumbers set qnumberecg = '" + txtecgqnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Queue number of ECG has been Updateded");
                queuenumber();
                txtecgqnumber2.Text = "";

                con.Close();
            }
        }

        private void txtlabqnumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtxrayqnumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtctscanqnumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtecgqnumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void lvremoveacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvremoveacc.SelectedItems.Count == 0) return;
            ListViewItem item = lvremoveacc.SelectedItems[0];
            usersid = item.SubItems[0].Text;
            
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_accounts set accountstatus = '" + "Deactivate" + "' where userid = '"+ usersid +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Account has been Deactivate");
            lvremoveacc.Items.Clear();
            removeacc();
            con.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.lvremoveacc.SelectedItems.Count <= 0;
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_accounts set accountstatus = '" + status + "' where userid = '" + usersid + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Account has been Activated");
            lvremoveacc.Items.Clear();
            removeacc();
            con.Close();
        }


        private void tabControl1_Click(object sender, EventArgs e)
        {   
            lvremoveacc.Items.Clear();
            removeacc();
            
        }

        private void btnlabprice_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = true;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer14.Enabled = false;
                this.timer13.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer14.Enabled = true;
                this.timer13.Enabled = false;
                count = 0;
            }
        }

        private void btnupdatelabprice_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_ancillaryprice set labprice = '" + txtdesiredpricelab.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Laborataory price has been updated");
            txtdesiredpricelab.Text = "";
            ancillaryprice();
            con.Close();
        }

        private void btnupdatexrayprice_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_ancillaryprice set xrayprice = '" + txtdesiredpricexray.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Xray / Ultrasound price has been updated");
            txtdesiredpricexray.Text = "";
            ancillaryprice();
            con.Close();
        }

        private void btnupdatectscanprice_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_ancillaryprice set ctscanprice = '" + txtdesiredpricectscan.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("CT scan price has been updated");
            txtdesiredpricectscan.Text = "";
            ancillaryprice();
            con.Close();
        }

        private void btnupdateecgprice_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_ancillaryprice set ecgprice = '" + txtdesiredpriceecg.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("ECG price has been updated");
            txtdesiredpriceecg.Text = "";
            ancillaryprice();
            con.Close();
        }

        private void txtdesiredpricexray_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtdesiredpriceecg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtdesiredpricelab_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtdesiredpricectscan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtdoctorname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void btnrooms_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = true;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer12.Enabled = false;
                this.timer11.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer12.Enabled = true;
                this.timer11.Enabled = false;
                count = 0;
            }
        }

        private void btnmalewardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_medicalmalewardroom (roomid, medicalmaleroomcount, roomstatus)values ('" + lblmalewardid.Text + "','" + lblmalewardnumber.Text + "','" + lblmalewardstatus.Text +"')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in Medecil Male Ward.");
           
            medicalmalewardlistview();
            malewardid();
            malewardroomcount();

            con.Close();
        }

        private void lvmalewardupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvmalewardupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvmalewardupdateroom.SelectedItems[0];
            lblmalewardid2.Text = item.SubItems[0].Text;
            lblmalewardnumber2.Text = item.SubItems[1].Text;
            cmbmalewardstatus.Text = item.SubItems[2].Text;
            
        }

        private void btnmalewardupdate_Click(object sender, EventArgs e)
        {
            if (lblmalewardid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

          else if (cmbmalewardstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_medicalmalewardroom set roomstatus = '" + cmbmalewardstatus.Text + "' where roomid = '" + lblmalewardid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Medical Male Ward Room status has been update");

                lblmalewardid2.Text = "";
                lblmalewardnumber2.Text = "";
                cmbmalewardstatus.SelectedIndex = -1;
                medicalmalewardlistview();
                con.Close();
            }
        }
        private void btnfemalewardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_medicalfemalewardroom (roomid, medicalfemaleroomcount, roomstatus)values ('" + lblfemalewardid.Text + "','" + lblfemalewardnumber.Text + "','" + lblfemalewardstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in Medecil Female Ward.");
            
            medicalfemalewardlistview();
            femalewardid();
            femalewardroomcount();

            con.Close();
        }

        private void lvfemalewardupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvfemalewardupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvfemalewardupdateroom.SelectedItems[0];
            lblfemalewardid2.Text = item.SubItems[0].Text;
            lblfemalewardnumber2.Text = item.SubItems[1].Text;
            cmbfemalewardstatus.Text = item.SubItems[2].Text;
        }

        private void btnfemalewardupdate_Click(object sender, EventArgs e)
        {
            if (lblfemalewardid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbfemalewardstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_medicalfemalewardroom set roomstatus = '" + cmbfemalewardstatus.Text + "' where roomid = '" + lblfemalewardid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Medical Female Ward Room status has been update");

                lblfemalewardid2.Text = "";
                lblfemalewardnumber2.Text = "";
                cmbfemalewardstatus.SelectedIndex = -1;
                medicalfemalewardlistview();

                con.Close();
            }
        }
        private void btnobgynewardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_obgyneroom (roomid, obgyneroomcount, roomstatus)values ('" + lblobgynewardid.Text + "','" + lblobgynewardnumber.Text + "','" + lblobgynewardstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in OB - Gyne.");

            obgynelistview();
            obgyneid();
            obgyneroomcount();

            con.Close();
        }

        private void lvobgyneupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvobgyneupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvobgyneupdateroom.SelectedItems[0];
            lblobgynewardid2.Text = item.SubItems[0].Text;
            lblobgynewardnumber2.Text = item.SubItems[1].Text;
            cmbobgynewardstatus.Text = item.SubItems[2].Text;
        }

        private void btnobgynewardupdate_Click(object sender, EventArgs e)
        {
            if (lblobgynewardid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbobgynewardstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_obgyneroom set roomstatus = '" + cmbobgynewardstatus.Text + "' where roomid = '" + lblobgynewardid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("OB - Gyne Room status has been update");

                lblobgynewardid2.Text = "";
                lblobgynewardnumber2.Text = "";
                cmbobgynewardstatus.SelectedIndex = -1;
                obgynelistview();

                con.Close();
            }
        }

        private void btnsurgicalwardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_surgicalroom (roomid, surgicalroomcount, roomstatus)values ('" + lblsurgicalnewid.Text + "','" + lblsurgicalnewwardnumber.Text + "','" + lblsurgicalwardstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in Surgical");

            surgicallistview();
            surgicalid();
            surgicalroomcount();

            con.Close();
        }

        private void lvsurgicalupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsurgicalupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvsurgicalupdateroom.SelectedItems[0];
            lblsurgicalnewid2.Text = item.SubItems[0].Text;
            lblsurgicalnewwardnumber2.Text = item.SubItems[1].Text;
            cmbsurgialnewwardstatus.Text = item.SubItems[2].Text;
        }

        private void btnsurgicalwardupdate_Click(object sender, EventArgs e)
        {

            if (lblsurgicalnewid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbsurgialnewwardstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_surgicalroom set roomstatus = '" + cmbsurgialnewwardstatus.Text + "' where roomid = '" + lblsurgicalnewid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Surgical Room status has been update");

                lblsurgicalnewid2.Text = "";
                lblsurgicalnewwardnumber2.Text = "";
                cmbsurgialnewwardstatus.SelectedIndex = -1;
                surgicallistview();

                con.Close();
            }
        }

        private void btnpediatricwardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_pediatricroom (roomid, pediatricroomcount, roomstatus)values ('" + lblpediatricnewid.Text + "','" + lblpediatricnewwardnumber.Text + "','" + lblpediatricwardstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in Pediatric");

            pediatriclistview();
            pediatricid();
            pediatricroomcount();

            con.Close();
        }

        private void lvpediatricupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvpediatricupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvpediatricupdateroom.SelectedItems[0];
            lblpediatricnewid2.Text = item.SubItems[0].Text;
            lblpediatricnewwardnumber2.Text = item.SubItems[1].Text;
            cmbpediatricwadstatus.Text = item.SubItems[2].Text;
        }

        private void btnpediatricwardupdate_Click(object sender, EventArgs e)
        {

            if (lblpediatricnewid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbpediatricwadstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_pediatricroom set roomstatus = '" + cmbpediatricwadstatus.Text + "' where roomid = '" + lblpediatricnewid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Pediatric Room status has been update");

                lblpediatricnewid2.Text = "";
                lblpediatricnewwardnumber2.Text = "";
                cmbpediatricwadstatus.SelectedIndex = -1;
                pediatriclistview();

                con.Close();
            }

        }

        private void btnisolationwardadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_isolationroom (roomid, isolationroomcount, roomstatus)values ('" + lblisolationnewwardid.Text + "','" + lblisolationnewwardnumber.Text + "','" + lblisolationwardstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Ward Has been added in Isolation");

            isolationlistview();
            isolationid();
            isolationroomcount();

            con.Close();
        }

        private void lvisolationupdateroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvisolationupdateroom.SelectedItems.Count == 0) return;
            ListViewItem item = lvisolationupdateroom.SelectedItems[0];
            lblisolationnewwardid2.Text = item.SubItems[0].Text;
            lblisolationnewwardnumber2.Text = item.SubItems[1].Text;
            cmbisolationwadstatus.Text = item.SubItems[2].Text;
        }

        private void btnisolationwardupdate_Click(object sender, EventArgs e)
        {


            if (lblisolationnewwardid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbisolationwadstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_isolationroom set roomstatus = '" + cmbisolationwadstatus.Text + "' where roomid = '" + lblisolationnewwardid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Isolation Room status has been update");

                lblisolationnewwardid2.Text = "";
                lblisolationnewwardnumber2.Text = "";
                cmbisolationwadstatus.SelectedIndex = -1;
                isolationlistview();

                con.Close();
            }

        }

        private void btnroomprice_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = true;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer16.Enabled = false;
                this.timer15.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer16.Enabled = true;
                this.timer15.Enabled = false;
                count = 0;
            }
        }

        private void btnupdateroomprice_Click(object sender, EventArgs e)
        {
            if (txtupdateroomprice.Text == "")
            {
                MessageBox.Show("Please put your desire Price in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_roomprice set roomprice = '" + txtupdateroomprice.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Room price has been updated");
                roomprice();
                txtupdateroomprice.Text = "";

                con.Close();
            }
        }

        private void txtupdateroomprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void btndoctorprice_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = true;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer18.Enabled = false;
                this.timer17.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer18.Enabled = true;
                this.timer17.Enabled = false;
                count = 0;
            }


        }

        private void btnupdatedoctorprice_Click(object sender, EventArgs e)
        {
            if (txtdesireddoctorprice.Text == "")
            {
                MessageBox.Show("Please put your desire Price in the text box");
            }
            else
            {
                connection();
                query = "update db_its.tbl_doctorprice set doctorprice = '" + txtdesireddoctorprice.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Doctor price has been updated");
                doctorprice();
                txtdesireddoctorprice.Text = "";

                con.Close();
            }
        }

        private void txtdesireddoctorprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlusermaintenance.Size.Width >= 1242) this.timer1.Enabled = false;
            else pnlusermaintenance.Width += 12;
            if (pnlusermaintenance.Size.Width != 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnlusermaintenance.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlusermaintenance.Size.Width <= 10) this.timer2.Enabled = false;
            else pnlusermaintenance.Width -= 12;
            if (pnlusermaintenance.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlusermaintenance.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pnldiscount.Size.Width >= 1248) this.timer3.Enabled = false;
            else pnldiscount.Width += 12;
            if (pnldiscount.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnldiscount.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pnldiscount.Size.Width <= 10) this.timer4.Enabled = false;
            else pnldiscount.Width -= 12;
            if (pnldiscount.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnldiscount.Visible = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pnlbackupdatabase.Size.Width >= 1248) this.timer5.Enabled = false;
            else pnlbackupdatabase.Width += 12;
            if (pnlbackupdatabase.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnlbackupdatabase.Visible = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (pnlbackupdatabase.Size.Width <= 10) this.timer6.Enabled = false;
            else pnlbackupdatabase.Width -= 12;
            if (pnlbackupdatabase.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlbackupdatabase.Visible = false;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (pnldoctors.Size.Width >= 1248) this.timer7.Enabled = false;
            else pnldoctors.Width += 12;
            if (pnldoctors.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnldoctors.Visible = true;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pnldoctors.Size.Width <= 10) this.timer8.Enabled = false;
            else pnldoctors.Width -= 12;
            if (pnldoctors.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnldoctors.Visible = false;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (pnlqnumber.Size.Width >= 1248) this.timer9.Enabled = false;
            else pnlqnumber.Width += 12;
            if (pnlqnumber.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnlqnumber.Visible = true;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (pnlqnumber.Size.Width <= 10) this.timer10.Enabled = false;
            else pnlqnumber.Width -= 12;
            if (pnlqnumber.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlqnumber.Visible = false;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {

            if (pnlroom.Size.Width >= 1248) this.timer11.Enabled = false;
            else pnlroom.Width += 12;
            if (pnlroom.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnlroom.Visible = true;
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (pnlroom.Size.Width <= 10) this.timer12.Enabled = false;
            else pnlroom.Width -= 12;
            if (pnlroom.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlroom.Visible = false;
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (pnllaboratory.Size.Width >= 1248) this.timer13.Enabled = false;
            else pnllaboratory.Width += 12;
            if (pnllaboratory.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnllaboratory.Visible = true;
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (pnllaboratory.Size.Width <= 10) this.timer14.Enabled = false;
            else pnllaboratory.Width -= 12;
            if (pnllaboratory.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnllaboratory.Visible = false;
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if (pnlroomprice.Size.Width >= 1248) this.timer15.Enabled = false;
            else pnlroomprice.Width += 12;
            if (pnlroomprice.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = false;
                btnaudittrail.Enabled = false;
                btnerbed.Enabled = false;
                pnlroomprice.Visible = true;
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            if (pnlroomprice.Size.Width <= 10) this.timer16.Enabled = false;
            else pnlroomprice.Width -= 12;
            if (pnlroomprice.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlroomprice.Visible = false;
            }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            if (pnldoctorprice.Size.Width >= 1248) this.timer17.Enabled = false;
            else pnldoctorprice.Width += 12;
            if (pnldoctorprice.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = true;
                pnldoctorprice.Visible = true;
                btnerbed.Enabled = false;
                btnaudittrail.Enabled = false;
            }
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            if (pnldoctorprice.Size.Width <= 10) this.timer18.Enabled = false;
            else pnldoctorprice.Width -= 12;
            if (pnldoctorprice.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnldoctorprice.Visible = false;
            }
        }

        private void btnviewallaudittrail_Click(object sender, EventArgs e)
        {
            connection();
            lvaudittrail.Items.Clear();
            query = "select * from db_its.tbl_audittrail";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["logno"].ToString();
                item.SubItems.Add(myreader["user"].ToString());
                item.SubItems.Add(myreader["action"].ToString());
                item.SubItems.Add(myreader["message"].ToString());
                item.SubItems.Add(myreader["datetime"].ToString());
                lvaudittrail.Items.Add(item);

            }

            con.Close();

            crsaudittrail ob = new crsaudittrail();
            ob.SetParameterValue("start", "2000-1-1" + "00:00:00" );
            ob.SetParameterValue("end", "4000-1-1" + "23:59:59" );
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            connection();
            lvaudittrail.Items.Clear();
            query = "select * from db_its.tbl_audittrail where datetime   >= '" + dptstartdate.Text + "00:00:00" + "' and datetime  <= '" + dptenddate.Text + "23:59:59" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["logno"].ToString();
                item.SubItems.Add(myreader["user"].ToString());
                item.SubItems.Add(myreader["action"].ToString());
                item.SubItems.Add(myreader["message"].ToString());
                item.SubItems.Add(myreader["datetime"].ToString());
                lvaudittrail.Items.Add(item);

            }

            con.Close();

            crsaudittrail ob = new crsaudittrail();
            ob.SetParameterValue("start", dptstartdate.Text + "00:00:00" );
            ob.SetParameterValue("end", dptenddate.Text + "23:59:59" );
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }

        private void btnaudittrail_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = true;
            pnlerroom.Visible = false;

            if (count == 0)
            {
                this.timer20.Enabled = false;
                this.timer19.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer20.Enabled = true;
                this.timer19.Enabled = false;
                count = 0;
            }
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            if (pnlaudittrail.Size.Width >= 1248) this.timer19.Enabled = false;
            else pnlaudittrail.Width += 12;
            if (pnlaudittrail.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnerbed.Enabled = false;
                pnlaudittrail.Visible = true;
                btnaudittrail.Enabled = true;
            }
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            if (pnlaudittrail.Size.Width <= 10) this.timer20.Enabled = false;
            else pnlaudittrail.Width -= 12;
            if (pnlaudittrail.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlaudittrail.Visible = false;
            }
        }

        private void txtupdateddiscount2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        

        private void btnerbedadd_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_erroom (roomid, erroomcount, roomstatus)values ('" + lblerwardid.Text + "','" + lblerroomcount.Text + "','" + lblerbedstatus.Text + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            MessageBox.Show("Bed Has been added in Emergency.");

            erlistview();
            erid();
            erroomcount();

            con.Close();
        }

        private void lver2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lver2.SelectedItems.Count == 0) return;
            ListViewItem item = lver2.SelectedItems[0];
            lblerwardid2.Text = item.SubItems[0].Text;
            lvlerroomcount2.Text = item.SubItems[1].Text;
            cmberbedstatus.Text = item.SubItems[2].Text;
        }

        private void btnerbedupdate_Click(object sender, EventArgs e)
        {
            if (lblisolationnewwardid2.Text == "")
            {
                MessageBox.Show("Choose a room you want to Update");
            }

            else if (cmbisolationwadstatus.Text == "")
            {
                MessageBox.Show("Please Choose a Room Status");
            }

            else
            {
                connection();
                query = "update db_its.tbl_erroom set roomstatus = '" + cmberbedstatus.Text + "' where roomid = '" + lblerwardid2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Isolation Room status has been update");

                lblerwardid2.Text = "";
                lblerroomcount.Text = "";
                cmberbedstatus.SelectedIndex = -1;
                erlistview();

                con.Close();
            }
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            if (pnlerroom.Size.Width >= 1248) this.timer21.Enabled = false;
            else pnlerroom.Width += 12;
            if (pnlerroom.Size.Width != 10)
            {
                btnusermaintenance.Enabled = false;
                btndiscount.Enabled = false;
                btnbackupdatabase.Enabled = false;
                btndoctors.Enabled = false;
                btnqnumber.Enabled = false;
                btnrooms.Enabled = false;
                btnlabprice.Enabled = false;
                btnroomprice.Enabled = false;
                btndoctorprice.Enabled = false;
                btnerbed.Enabled = true;
                btnaudittrail.Enabled = false;
                pnlerroom.Visible = true;
            }
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            if (pnlerroom.Size.Width <= 10) this.timer22.Enabled = false;
            else pnlerroom.Width -= 12;
            if (pnlerroom.Size.Width == 10)
            {
                btnusermaintenance.Enabled = true;
                btndiscount.Enabled = true;
                btnbackupdatabase.Enabled = true;
                btndoctors.Enabled = true;
                btnqnumber.Enabled = true;
                btnrooms.Enabled = true;
                btnlabprice.Enabled = true;
                btnroomprice.Enabled = true;
                btndoctorprice.Enabled = true;
                btnaudittrail.Enabled = true;
                btnerbed.Enabled = true;
                pnlerroom.Visible = false;
            }
        }

        private void btnerbed_Click(object sender, EventArgs e)
        {
            pnlusermaintenance.Visible = false;
            pnldiscount.Visible = false;
            pnlbackupdatabase.Visible = false;
            pnldoctors.Visible = false;
            pnlqnumber.Visible = false;
            pnllaboratory.Visible = false;
            pnlroom.Visible = false;
            pnlroomprice.Visible = false;
            pnldoctorprice.Visible = false;
            pnlaudittrail.Visible = false;
            pnlerroom.Visible = true;

            if (count == 0)
            {
                this.timer22.Enabled = false;
                this.timer21.Enabled = true;
                count = 1;


            }

            else if (count == 1)
            {
                this.timer22.Enabled = true;
                this.timer21.Enabled = false;
                count = 0;
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));
        }

        private void txtusername2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));
        }

        private void txtpassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));
        }

        private void btnreadddoctor_Click(object sender, EventArgs e)
        {
            if (txtdoctorname4.Text == "")
            {
                MessageBox.Show("Please choose a doctor you want to renew");
            }
            else
            {
                connection();
                query = "update db_its.tbl_doctor set doctorstatus = '" + "Available" + "' where doctorid = '" + lbldoctorid4.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Doctor has been Renew");
                lvdoctor.Items.Clear();
                lvreadddoctor.Items.Clear();

                doctorlist();
                removedoctor();
                readddoctor();

                lbldoctorid4.Text = "";
                txtdoctorname4.Text = "";
            }
        }

        private void lvreadddoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvreadddoctor.SelectedItems.Count == 0) return;
            ListViewItem item = lvreadddoctor.SelectedItems[0];
            lbldoctorid4.Text = item.SubItems[0].Text;
            txtdoctorname4.Text = item.SubItems[1].Text;
        }

        private void btnnewphil_Click(object sender, EventArgs e)
        {
            if (txtdiagnosis.Text == "" || txticd.Text == "" || txtcaserate.Text == "" || txtpf.Text == "" || txthospital.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_phildiscount (diagnosis, icd, caserate, pf, hospital, status)values ('" + txtdiagnosis.Text + "','" + txticd.Text + "','" + txtcaserate.Text + "','" + txtpf.Text + "','" + txthospital.Text + "','" + "Enable" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("New Philhealth Discount has been added.");

                txtdiagnosis.Text = "";
                txticd.Text = "";
                txtcaserate.Text = "";
                txtpf.Text = "";
                txthospital.Text = "";
            }
        }

        private void tabControl9_Click(object sender, EventArgs e)
        {
            connection();
            lvphil.Items.Clear();
            query = "select * from db_its.tbl_phildiscount";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["philcount"].ToString();
                item.SubItems.Add(myreader["diagnosis"].ToString());
                item.SubItems.Add(myreader["icd"].ToString());
                item.SubItems.Add(myreader["caserate"].ToString());
                item.SubItems.Add(myreader["pf"].ToString());
                item.SubItems.Add(myreader["hospital"].ToString());
                lvphil.Items.Add(item);

            }
            con.Close();

            connection();
            lvphil2.Items.Clear();
            query = "select * from db_its.tbl_phildiscount";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["philcount"].ToString();
                item.SubItems.Add(myreader["diagnosis"].ToString());
                item.SubItems.Add(myreader["icd"].ToString());
                item.SubItems.Add(myreader["caserate"].ToString());
                item.SubItems.Add(myreader["pf"].ToString());
                item.SubItems.Add(myreader["hospital"].ToString());
                item.SubItems.Add(myreader["status"].ToString());
                lvphil2.Items.Add(item);

            }
            con.Close();
        }

        private void lvphil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvphil.SelectedItems.Count == 0) return;
            ListViewItem item = lvphil.SelectedItems[0];
            lblphilid.Text = item.SubItems[0].Text;
            txtdiagnosis2.Text = item.SubItems[1].Text;
            txticd2.Text = item.SubItems[2].Text;
            txtcaserate2.Text = item.SubItems[3].Text;
            txtpf2.Text = item.SubItems[4].Text;
            txthospital2.Text = item.SubItems[5].Text;
        }

        private void btnupdatephil_Click(object sender, EventArgs e)
        {
            if (txtdiagnosis2.Text == "" || txticd2.Text == "" || txtcaserate2.Text == "" || txtpf2.Text == "" || txthospital2.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }

            else
            {

                connection();
                query = "update db_its.tbl_phildiscount set diagnosis = '" + txtdiagnosis2.Text + "', icd = '" + txticd2.Text + "', caserate = '" + txtcaserate2.Text + "', pf = '" + txtpf2.Text + "', hospital = '" + txthospital2.Text + "' where philcount = '" + lblphilid.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
                MessageBox.Show("Philhealth has been updated.");

                connection();
                lvphil.Items.Clear();
                query = "select * from db_its.tbl_phildiscount";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = myreader["philcount"].ToString();
                    item.SubItems.Add(myreader["diagnosis"].ToString());
                    item.SubItems.Add(myreader["icd"].ToString());
                    item.SubItems.Add(myreader["caserate"].ToString());
                    item.SubItems.Add(myreader["pf"].ToString());
                    item.SubItems.Add(myreader["hospital"].ToString());
                    lvphil.Items.Add(item);

                }
                con.Close();
            }
        }

        private void lvphil2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvphil2.SelectedItems.Count == 0) return;
            ListViewItem item = lvphil2.SelectedItems[0];
            philid = item.SubItems[0].Text;
            
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_phildiscount set status = '" + "Enable" + "' where philcount = '" + philid + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
            MessageBox.Show("Philhealth has been Enabled.");

            connection();
            lvphil2.Items.Clear();
            query = "select * from db_its.tbl_phildiscount";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["philcount"].ToString();
                item.SubItems.Add(myreader["diagnosis"].ToString());
                item.SubItems.Add(myreader["icd"].ToString());
                item.SubItems.Add(myreader["caserate"].ToString());
                item.SubItems.Add(myreader["pf"].ToString());
                item.SubItems.Add(myreader["hospital"].ToString());
                item.SubItems.Add(myreader["status"].ToString());
                lvphil2.Items.Add(item);

            }
            con.Close();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection();
            query = "update db_its.tbl_phildiscount set status = '" + "Disable" + "' where philcount = '" + philid + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
            MessageBox.Show("Philhealth has been Disabled.");

            connection();
            lvphil2.Items.Clear();
            query = "select * from db_its.tbl_phildiscount";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["philcount"].ToString();
                item.SubItems.Add(myreader["diagnosis"].ToString());
                item.SubItems.Add(myreader["icd"].ToString());
                item.SubItems.Add(myreader["caserate"].ToString());
                item.SubItems.Add(myreader["pf"].ToString());
                item.SubItems.Add(myreader["hospital"].ToString());
                item.SubItems.Add(myreader["status"].ToString());
                lvphil2.Items.Add(item);

            }
            con.Close();

        }

       
    }

        
}
