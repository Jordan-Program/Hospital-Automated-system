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
    public partial class AdmissionBilling : Form
    {
        public string name;
        public string userid;
        public string acoountposition;

        private int time1 = 5;

        public AdmissionBilling()
        {
            InitializeComponent();
            roomprice();
            ancillaryprice();
            doctor();

            

            dtpdatedischarge.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbltimeofdischarge.Text = DateTime.Now.ToString("hh:mm:ss tt");

            
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string surname, firstname, middlename, admissionno, hospitalnumber, date, time, date2, time2, kindofindigent;

        public int hematologyprice, urinalysisprice, fecalysisprice, bloodbankingprice, clinicalchemprice, xrayprice, ctscanprice, ecgprice, doctorprice;



        public void viewall()
        {
            if (cmbwardtype.Text == "Medical Male Ward")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_maleward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }
        }

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void AdmissionBilling_Load(object sender, EventArgs e)
        {
            timer1.Start();
            viewall();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void doctor()
        {
            connection();
            query = "select * from db_its.tbl_doctorprice";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                doctorprice = int.Parse(myreader["doctorprice"].ToString());
                txtdoctorfee.Text = doctorprice.ToString();
            }
            con.Close();
        }

        public void ancillaryprice()
        {
            connection();
            query = "select * from db_its.tbl_ancillaryprice";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                hematologyprice = int.Parse(myreader["labprice"].ToString());
                urinalysisprice = int.Parse(myreader["labprice"].ToString());
                fecalysisprice = int.Parse(myreader["labprice"].ToString());
                bloodbankingprice = int.Parse(myreader["labprice"].ToString());
                clinicalchemprice = int.Parse(myreader["labprice"].ToString());
                xrayprice = int.Parse(myreader["xrayprice"].ToString());
                ctscanprice = int.Parse(myreader["ctscanprice"].ToString());
                ecgprice = int.Parse(myreader["ecgprice"].ToString());

                lblhematologyprice.Text = hematologyprice.ToString();
                lblurinalysisprice.Text = urinalysisprice.ToString();
                lblfecalysisprice.Text = fecalysisprice.ToString();
                lblbloodbankingprice.Text = bloodbankingprice.ToString();
                lblclinicalchemprice.Text = clinicalchemprice.ToString();
                lblxrayprice.Text = xrayprice.ToString();
                lblctscanprice.Text = ctscanprice.ToString();
                lblecgprice.Text = ecgprice.ToString();



            }
            con.Close();
        }

        public void roomprice()
        {
            connection();
            query = "select * from db_its.tbl_roomprice";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                txtroomrate.Text = myreader["roomprice"].ToString();
            }
            con.Close();
        }

        public void computingofbills()
        {
            
           
            DateTime start = dtpdateadmitted.Value.Date;
            DateTime end = dtpdatedischarge.Value.Date;

          

            txtdays.Text = Convert.ToInt32(end.Subtract(start).Days).ToString();

            int days;
            days = int.Parse(txtdays.Text);

            int price;
            price = int.Parse(txtroomrate.Text);


            int total = price * days;
            txttotal.Text = total.ToString();
        }
    

        public void computingofotherfee()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, total = 0;




            a = Convert.ToInt32(lblhematogy.Text);
            a = int.Parse(lblhematogy.Text) * hematologyprice;

            lblhematotal.Text = a.ToString();

            b = Convert.ToInt32(lblurinalysis.Text);
            b = int.Parse(lblurinalysis.Text) * urinalysisprice;

            lbluritotal.Text = b.ToString();

            c = Convert.ToInt32(lblfecalysis.Text);
            c = int.Parse(lblfecalysis.Text) * fecalysisprice;

            lblfecatotal.Text = c.ToString();

            d = Convert.ToInt32(lblbloodbanking.Text);
            d = int.Parse(lblbloodbanking.Text) * bloodbankingprice;

            lblbloodtotal.Text = d.ToString();

            e = Convert.ToInt32(lblclinicalchem.Text);
            e = int.Parse(lblclinicalchem.Text) * clinicalchemprice;

            lblchemtotal.Text = e.ToString();

            f = Convert.ToInt32(lblxray.Text);
            f = int.Parse(lblxray.Text) * xrayprice;

            lblxraytotal.Text = f.ToString();

            g = Convert.ToInt32(lblctscan.Text);
            g = int.Parse(lblctscan.Text) * ctscanprice;

            lblctscantotal.Text = g.ToString();

            h = Convert.ToInt32(lblecg.Text);
            h = int.Parse(lblecg.Text) * ecgprice;

            lblecgtotal.Text = h.ToString();

            total = a + b + c + d + e + f + g + h;

            txtotherfeetotal.Text = total.ToString();
        }

        public void clear()
        {
            lblhospitalnumber.Text = "";
            lblpatientname.Text = "";
            lblcontact.Text = "";
            lbladdress.Text = "";
            lblwardtype.Text = "";
            lblbednumber.Text = "";
            lblsssno.Text = "";
            lblgsisno.Text = "";
            lblphilno.Text = "";
            lbltimeaddmitted.Text = "";
            lbltimeofdischarge.Text = "";
            lblhematogy.Text = "0";
            lblhematotal.Text = "0";
            lblurinalysis.Text = "0";
            lbluritotal.Text = "0";
            lblfecalysis.Text = "0";
            lblfecatotal.Text = "0";
            lblbloodbanking.Text = "0";
            lblbloodtotal.Text = "0";
            lblclinicalchem.Text = "0";
            lblchemtotal.Text = "0";
            lblxray.Text = "0";
            lblxraytotal.Text = "0";
            lblecg.Text = "0";
            lblecgtotal.Text = "0";
            lblctscan.Text = "0";
            lblctscantotal.Text = "0";
            txtotherfeetotal.Text = "0";
            txtroomrate.Text = "0";
            txtdays.Text = "0";
            txttotal.Text = "";
            txtoverall.Text = "0";
            txtdiscount.Text = "0";
            txtamountpaid.Text = "";
            txtchange.Text = "0";

            
        }

        public void deletionofrequestcheckup()
        {
            connection();
            query = "delete from db_its.tbl_wardrequestcheckup where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatepatientstatus()
        {
            connection();
            query = "update db_its.tbl_basicinfo set patientstatus = '" + "Out - Patient" + "' where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatebedstatusanddeletion()
        {
            if (cmbwardtype.Text == "Medical Male Ward")
            {
                connection();
                query = "update db_its.tbl_medicalmalewardroom set roomstatus = '" + "Available" + "' where medicalmaleroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_maleward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbwardtype.Text == "Medical Female Ward")
            {
                connection();
                query = "update db_its.tbl_medicalfemalewardroom set roomstatus = '" + "Available" + "' where medicalfemaleroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_femaleward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbwardtype.Text == "OB - Gyne")
            {
                connection();
                query = "update db_its.tbl_obgyneroom set roomstatus = '" + "Available" + "' where obgyneroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_obgyneward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbwardtype.Text == "Surgical")
            {
                connection();
                query = "update db_its.tbl_surgicalroom set roomstatus = '" + "Available" + "' where surgicalroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_surgicalward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbwardtype.Text == "Pediatric")
            {
                connection();
                query = "update db_its.tbl_pediatricroom set roomstatus = '" + "Available" + "' where pediatricroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_pediatricward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbwardtype.Text == "Isolation")
            {
                connection();
                query = "update db_its.tbl_isolationroom set roomstatus  = '" + "Available" + "' where isolationroomcount = '" + lblbednumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_isolationward where hospitalnumber = '" + hospitalnumber + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.name = name;
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void cmbwardtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbwardtype.Text == "Medical Male Ward" || cmbwardtype.Text == "Medical Female Ward"
                || cmbwardtype.Text == "OB - Gyne" || cmbwardtype.Text == "Surgical" || cmbwardtype.Text == "Pediatric"
                || cmbwardtype.Text == "Isolation")
            {
                pnladmission.Visible = true;
                
                clear();
                roomprice();
                ancillaryprice();

            }

            if (cmbwardtype.Text == "Medical Male Ward")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_maleward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }

            if (cmbwardtype.Text == "Medical Female Ward")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_femaleward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }

            if (cmbwardtype.Text == "OB - Gyne")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_obgyneward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }

            if (cmbwardtype.Text == "Surgical")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_surgicalward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }


            if (cmbwardtype.Text == "Pediatric")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_pediatricward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }

            if (cmbwardtype.Text == "Isolation")
            {
                connection();
                lvadmission.Items.Clear();
                query = "select * from db_its.tbl_isolationward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item = new ListViewItem();
                    item.Text = myreader["admissionno"].ToString();
                    item.SubItems.Add(myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item.SubItems.Add(myreader["admittingofficer"].ToString());
                    item.SubItems.Add(myreader["bednumber"].ToString());
                    lvadmission.Items.Add(item);
                }
                con.Close();
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            if (cmbwardtype.Text == "")
            {
                MessageBox.Show("Choose a Ward");
            }
            else
            {
                if (cmbwardtype.Text == "Medical Male Ward")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_maleward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbwardtype.Text == "Medical Female Ward")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_femaleward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbwardtype.Text == "OB - Gyne")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_obgyneward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbwardtype.Text == "Surgical")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_surgicalward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }


                if (cmbwardtype.Text == "Pediatric")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_pediatricward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbwardtype.Text == "Isolation")
                {
                    connection();
                    lvadmission.Items.Clear();
                    query = "select * from db_its.tbl_isolationward";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {



                        var item = new ListViewItem();
                        item.Text = myreader["admissionno"].ToString();
                        item.SubItems.Add(myreader["hospitalnumber"].ToString());
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvadmission.Items.Add(item);
                    }
                    con.Close();
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cmbwardtype.Text == "")
            {
                MessageBox.Show("Choose a Ward");
            }

            else
            {
                if (cmbwardtype.Text == "Medical Male Ward")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_femaleward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }
                }

                if (cmbwardtype.Text == "Medical Female Ward")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_femaleward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }

                }

                if (cmbwardtype.Text == "OB - Gyne")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_obgyneward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }
                }

                if (cmbwardtype.Text == "Surgical")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {

                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_surgicalward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }

                }

                if (cmbwardtype.Text == "Pediatric")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_pediatricward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }
                }

                if (cmbwardtype.Text == "Isolation")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvadmission.Items.Clear();
                        query = "select * from db_its.tbl_isolationward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {



                            var item = new ListViewItem();
                            item.Text = myreader["admissionno"].ToString();
                            item.SubItems.Add(myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString());
                            item.SubItems.Add(myreader["firstname"].ToString());
                            item.SubItems.Add(myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvadmission.Items.Add(item);
                        }
                        con.Close();
                    }

                }

            }

        }

        private void lvadmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpdatedischarge.Text = DateTime.Now.ToString("yyyy-MM-dd");

           

            if (lvadmission.SelectedItems.Count == 0) return;
            ListViewItem item = lvadmission.SelectedItems[0];
            admissionno = item.SubItems[0].Text;
            lblhospitalnumber.Text = item.SubItems[1].Text;
            lblpatientname.Text = item.SubItems[2].Text + ", " + item.SubItems[3].Text + " " + item.SubItems[4].Text;
            lblcontact.Text = item.SubItems[5].Text;
            lbladdress.Text = item.SubItems[6].Text;
            dtpdateadmitted.Text = item.SubItems[7].Text;
            lbltimeaddmitted.Text = item.SubItems[8].Text;
            lblbednumber.Text = item.SubItems[10].Text;

            hospitalnumber = item.SubItems[1].Text;
            surname = item.SubItems[2].Text;
            firstname = item.SubItems[3].Text;
            middlename = item.SubItems[4].Text;
            lblwardtype.Text = cmbwardtype.Text;


            

            connection();
            query = "select * from db_its.tbl_admission where hospitalnumber =  '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                lblsssno.Text = myreader["sssno"].ToString();
                lblgsisno.Text = myreader["gsisnumber"].ToString();
                lblphilno.Text = myreader["philhealth"].ToString();

                if (lblphilno.Text == "")
                {
                    txtdiscount.Enabled = false;
                }

                if (lblphilno.Text != "")
                {
                    txtdiscount.Enabled = true;
                }

            }

            con.Close();

            connection();
            query = "select sum(hematology) as hema, sum(urinalysis) as uri, sum(fecalysis) as feca, sum(bloodbanking) as blood, sum(clinicalchem) as chem,"
                + " sum(ecg) as e, sum(xray) as x, sum(ctscan) as ct from db_its.tbl_wardrequestcheckup where hospitalnumber  =  '" + hospitalnumber + "'";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                lblhematogy.Text = myreader["hema"].ToString();
                lblurinalysis.Text = myreader["uri"].ToString();
                lblfecalysis.Text = myreader["feca"].ToString();
                lblbloodbanking.Text = myreader["blood"].ToString();
                lblclinicalchem.Text = myreader["chem"].ToString();
                lblecg.Text = myreader["e"].ToString();
                lblxray.Text = myreader["x"].ToString();
                lblctscan.Text = myreader["ct"].ToString();


            }

            con.Close();

            if (dtpdateadmitted.Text == dtpdatedischarge.Text)
            {


                txtdays.Text = "1";

                int days;
                days = int.Parse(txtdays.Text);

                int price;
                price = int.Parse(txtroomrate.Text);


                int total = price * days;
                txttotal.Text = total.ToString();

                computingofotherfee();




                int a, b, total1;

                a = int.Parse(txtotherfeetotal.Text);
                b = int.Parse(txttotal.Text);

                total1 = a + b + doctorprice;

                txtoverall.Text = total1.ToString();
            }

            else
            {
                computingofbills();
                computingofotherfee();




                int a, b, total;

                a = int.Parse(txtotherfeetotal.Text);
                b = int.Parse(txttotal.Text);

                total = a + b + doctorprice;

                txtoverall.Text = total.ToString();
            }
            
        }

        private void txtamountpaid_TextChanged(object sender, EventArgs e)
        {

            if (txtamountpaid.Text == "")
            {
                txtchange.Text = "";
              
            }

            else
            {
                if (lblphilno.Text == "")
                {
                    if (txtamountpaid.Text != "")
                    {
                        

                        double a, b, c;

                        a = int.Parse(txtoverall.Text);
                        b = int.Parse(txtamountpaid.Text);

                        c = b - a;


                        txtchange.Text = c.ToString();
                    }
                }

                if (lblphilno.Text != "")
                {
                    if (txtamountpaid.Text != "")
                    {

                        double a, b, c;
                        
                        a = int.Parse(txtoverall.Text);
                        b = int.Parse(txtamountpaid.Text);

                        c = b - a;


                        txtchange.Text = c.ToString();
                    }
                }

            }


        }

        private void txtamountpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void btnsavetransaction_Click(object sender, EventArgs e)
        {



            date = DateTime.Now.ToString("MMddyyyy");
            time = DateTime.Now.ToString("hhmmss");

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");

            if (ckbindijent.Checked == false)
            {
                string billingstat = "";

                if (lblhospitalnumber.Text == "")
                {
                    MessageBox.Show("Please choose a patient");
                }

                else if (txtamountpaid.Text == "")
                {
                    MessageBox.Show("Amount field is Blank. Please input the right amount");
                }

                else if (int.Parse(txtamountpaid.Text) < int.Parse(txtoverall.Text))
                {
                    MessageBox.Show("Payment is insufficient");
                    txtamountpaid.Text = "";
                    txtchange.Text = "";

                }

                else
                {
                    if (MessageBox.Show("Are you sure you want to Log - out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection();
                        query = "insert into db_its.tbl_discharge_transaction (transactionid, hospitalnumber, surname, firstname, middlename, wardtype, dateadmitted, timeadmitted,"
                               + " datedischarge, timedischarge, otherfeetotal, totalstayamount, overallamountdue, discount, amountpaid, changed, user, time, date) values ('" + date + time
                                + "','" + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblwardtype.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeaddmitted.Text
                                + "','" + dtpdatedischarge.Text + "','" + time2 + "','" + txtotherfeetotal.Text + "','" + txttotal.Text + "','" + txtoverall.Text + "','" + txtdiscount.Text
                                + "','" + txtamountpaid.Text + "','" + txtchange.Text + "','" + name + "','" + time2 + "','" + date2 + "')";

                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();

                        connection();
                        query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();

                        MessageBox.Show("Transaction has been saved.");



                        updatepatientstatus();
                        updatebedstatusanddeletion();
                        deletionofrequestcheckup();

                        AdmissionReceipt ar = new AdmissionReceipt();
                        ar.transactionid = date + time;
                        ar.patientid = hospitalnumber;
                        ar.patientname = lblpatientname.Text;
                        ar.username = name;
                        ar.ward = lblwardtype.Text;
                        ar.bed = lblbednumber.Text;
                        ar.hema = lblhematotal.Text;
                        ar.uri = lbluritotal.Text;
                        ar.feca = lblfecatotal.Text;
                        ar.blood = lblbloodtotal.Text;
                        ar.chem = lblchemtotal.Text;
                        ar.xray = lblxraytotal.Text;
                        ar.ecg = lblecgtotal.Text;
                        ar.ctscan = lblctscantotal.Text;
                        ar.otherfee = txtotherfeetotal.Text;
                        ar.totalchargebed = txtroomrate.Text;
                        ar.overall = txtoverall.Text;
                        ar.discount = txtdiscount.Text;
                        ar.amountpaid = txtamountpaid.Text;
                        ar.change = txtchange.Text;
                        ar.sss = lblsssno.Text;
                        ar.gsis = lblgsisno.Text;
                        ar.phil = lblphilno.Text;
                        ar.billingstat = billingstat;
                        ar.ShowDialog();

                        clear();
                        viewall();

                    }
                }
            }

            if (ckbindijent.Checked == true)
            {
                string billingstat = kindofindigent + " Cause for being Indigent." + txtindigent.Text;

                txtamountpaid.Enabled = false;
                txtamountpaid.Text = txtoverall.Text;
                txtchange.Text = "0";
                txtdiscount.Text = "0";

                if (lblhospitalnumber.Text == "")
                {
                    MessageBox.Show("Please choose a patient");
                }

                else
                {
                    if (MessageBox.Show("Are you sure you want to Log - out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection();
                        query = "insert into db_its.tbl_discharge_transaction (transactionid, hospitalnumber, surname, firstname, middlename, wardtype, dateadmitted, timeadmitted,"
                               + " datedischarge, timedischarge, otherfeetotal, totalstayamount, overallamountdue, discount, amountpaid, changed, user, billingstatus, time, date) values ('" + date + time
                                + "','" + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblwardtype.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeaddmitted.Text
                                + "','" + dtpdatedischarge.Text + "','" + time2 + "','" + txtotherfeetotal.Text + "','" + txttotal.Text + "','" + txtoverall.Text + "','" + txtdiscount.Text
                                + "','" + txtamountpaid.Text + "','" + txtchange.Text + "','" + name + "','" + billingstat + "','" + time2 + "','" + date2 + "')";

                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();

                        connection();
                        query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();

                        MessageBox.Show("Transaction has been saved.");



                        updatepatientstatus();
                        updatebedstatusanddeletion();
                        deletionofrequestcheckup();

                        AdmissionReceipt ar = new AdmissionReceipt();
                        ar.transactionid = date + time;
                        ar.patientid = hospitalnumber;
                        ar.patientname = lblpatientname.Text;
                        ar.username = name;
                        ar.ward = lblwardtype.Text;
                        ar.bed = lblbednumber.Text;
                        ar.hema = lblhematotal.Text;
                        ar.uri = lbluritotal.Text;
                        ar.feca = lblfecatotal.Text;
                        ar.blood = lblbloodtotal.Text;
                        ar.chem = lblchemtotal.Text;
                        ar.xray = lblxraytotal.Text;
                        ar.ecg = lblecgtotal.Text;
                        ar.ctscan = lblctscantotal.Text;
                        ar.otherfee = txtotherfeetotal.Text;
                        ar.totalchargebed = txtroomrate.Text;
                        ar.overall = txtoverall.Text;
                        ar.discount = txtdiscount.Text;
                        ar.amountpaid = txtamountpaid.Text;
                        ar.change = txtchange.Text;
                        ar.sss = lblsssno.Text;
                        ar.gsis = lblgsisno.Text;
                        ar.phil = lblphilno.Text;
                        ar.billingstat = billingstat;
                        ar.ShowDialog();

                        clear();

                        txtindigent.Text = "";
                        ckbindijent.Checked = false;
                        rdbgsis.Checked = false;
                        rdbpcso.Checked = false;

                        viewall();
                    }

                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;
                roomprice();
                ancillaryprice();
            }

            else
            {
                time1 = 5;
            }
        }

        private void ckbindijent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbindijent.Checked == true)
            {
                txtamountpaid.Enabled = false;
                groupBox4.Enabled = true;

            }

            if (ckbindijent.Checked == false)
            {
                txtamountpaid.Enabled = true;
                groupBox4.Enabled = false;
            }
        }

        private void rdbgsis_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbgsis.Checked == true)
            {
                kindofindigent = "Indigent patient and paid by DSWD";
            }
            
        }

        private void rdbpcso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpcso.Checked == true)
            {
                kindofindigent = "Indigent patient and paid by PSCO";
            }
        }

        private void txtdiscount_Click(object sender, EventArgs e)
        {
            txtdiscount.Items.Clear();
            connection();
            query = "select * from db_its.tbl_phildiscount where status = '"+ "Enable" +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtdiscount.Items.Add(myreader["icd"].ToString());
                
                
            }
            con.Close();
        }

       
    }
}