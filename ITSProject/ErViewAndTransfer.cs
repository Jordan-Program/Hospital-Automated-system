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
    public partial class ErViewAndTransfer : Form
    {
        public string name;
        public string userid;
        public string acoountposition;

        public ErViewAndTransfer()
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

        public string health, date2, time2;

        public string hospitalnumber, surname, firstname, middlename, date, time, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, ecg, xray, ctscan, sex, age;

        public int count = 0, x = 1;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void doctors()
        {
            connection();
            query = "select * from db_its.tbl_doctor";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                cmbdoctor.Items.Add(myreader["doctorname"].ToString());
            }

            con.Close();
        }

        public void malerlabreqeust()
        {
            if (ckbmalehematolgy.Checked == true)
            {
                hematology = "Yes";

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + x + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";


                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (ckbmalehematolgy.Checked == false)
            {
                hematology = "No";
            }

            if (ckbmaleurinalysis.Checked == true)
            {
                urinalysis = "Yes";

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + x + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";


                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

            }

            if (ckbmaleurinalysis.Checked == false)
            {
                urinalysis = "No";
            }

            if (ckbmalefecalysis.Checked == true)
            {
                fecalysis = "Yes";

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + x + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";


                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (ckbmalefecalysis.Checked == false)
            {
                fecalysis = "No";
            }

            if (ckbmalebloodbanking.Checked == true)
            {
                bloodbanking = "Yes";

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + x + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";


                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (ckbmalebloodbanking.Checked == false)
            {
                bloodbanking = "No";
            }

            if (ckbmaleclinicalchem.Checked == true)
            {
                clinicalchem = "Yes";

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + x + "','" + "0" + "','" + "0" + "','" + "0" + "')";


                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (ckbmaleclinicalchem.Checked == false)
            {
                clinicalchem = "No";
            }
        }

        public void viewall()
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_erward";
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
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["cause"].ToString());
                item.SubItems.Add(myreader["bednumber"].ToString());
                item.SubItems.Add(myreader["philhealth"].ToString());
                lver.Items.Add(item);
            }

            con.Close();
        }

        private void ErViewAndTransfer_Load(object sender, EventArgs e)
        {
            doctors();

            viewall();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_erward";
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
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["cause"].ToString());
                item.SubItems.Add(myreader["bednumber"].ToString());
                item.SubItems.Add(myreader["philhealth"].ToString());
                lver.Items.Add(item);
            }

            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connection();
            lver.Items.Clear();
            query = "select * from db_its.tbl_erward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["cause"].ToString());
                item.SubItems.Add(myreader["bednumber"].ToString());
                item.SubItems.Add(myreader["philhealth"].ToString());
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
            txtoccupation.Text = item.SubItems[9].Text;
            dateTimePicker2.Text = item.SubItems[10].Text;
            lbltime.Text = item.SubItems[11].Text;
            txtcause.Text = item.SubItems[12].Text;
            cmberbed.Text = item.SubItems[13].Text;
            health = item.SubItems[14].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;

        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            if (txthospitalnumber.Text == "")
            {
                MessageBox.Show("Choose a patient you want to transfer");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_ertransfer (hospitalnumber, surname, firstname, middlename, birthdate, age, sex, address, contact, occupation, philhealth) values ('" + txthospitalnumber.Text + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + dateTimePicker2.Text + "','" + txtage.Text + "','" + cmbsex.Text + "','" + txtaddress.Text.Replace("'", "''") + "','" + txtcontact.Text + "','" + txtoccupation.Text.Replace("'", "''") + "','" + health + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Patient has been Trasfered. Proceed to admitting");

                connection();
                query = "update db_its.tbl_erroom set roomstatus = '" + "Available" + "' where erroomcount = '" + cmberbed.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "delete from db_its.tbl_erward where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Transfer a patient to Admitting. " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                txthospitalnumber.Text = "";
                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                txtage.Text = "";
                cmbsex.SelectedIndex = -1;
                txtcontact.Text = "";
                txtaddress.Text = "";
                txtoccupation.Text = "";
                dateTimePicker2.Text = "";
                lbltime.Text = "";
                txtcause.Text = "";
                cmberbed.Text = "";
                lver.Items.Clear();

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
            mn.name = name;
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnrequest_Click(object sender, EventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlreq.Size.Height >= 244) this.timer1.Enabled = false;
            else pnlreq.Height += 12;
            if (pnlreq.Size.Height != 10)
            {
                pnlreq.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlreq.Size.Height <= 10) this.timer2.Enabled = false;
            else pnlreq.Height -= 12;
            if (pnlreq.Size.Height == 10)
            {
                pnlreq.Visible = false;
            }
        }

        private void btnmalesavereq_Click(object sender, EventArgs e)
        {
            if (hospitalnumber == "")
            {
                MessageBox.Show("No Patient Selected");
            }

            else if (ckbmalehematolgy.Checked == false && ckbmaleurinalysis.Checked == false && ckbmalefecalysis.Checked == false && ckbmalebloodbanking.Checked == false
                 && ckbmaleclinicalchem.Checked == false && ckbmalectscan.Checked == false && ckbmaleecg.Checked == false && ckbmalexray.Checked == false)
            {
                MessageBox.Show("Please select what a request check - up.");
            }

            else if (cmbdoctor.Text == "")
            {
                MessageBox.Show("Please select the doctor who request for Additional check - up");
            }

            else
            {
                if (ckbmalehematolgy.Checked == true || ckbmaleurinalysis.Checked == true || ckbmalefecalysis.Checked == true || ckbmalebloodbanking.Checked == true || ckbmaleclinicalchem.Checked == true)
                {
                    malerlabreqeust();

                    connection();
                    query = "insert into db_its.tbl_laboratorypendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, physician) values ('"
                        + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + age + "','" + sex + "','" + hematology + "','" + urinalysis
                        + "','" + fecalysis + "','" + bloodbanking + "','" + clinicalchem + "' ,'" + cmbdoctor.Text + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();




                }

                if (ckbmalectscan.Checked == true)
                {
                    connection();
                    query = "insert into db_its.tbl_ctscanpendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                        + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + age + "','" + sex + "','" + cmbdoctor.Text + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                    connection();
                    query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + x + "','" + "0" + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                }

                if (ckbmaleecg.Checked == true)
                {
                    connection();
                    query = "insert into db_its.tbl_ecgpendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                        + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + age + "','" + sex + "','" + cmbdoctor.Text + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                    connection();
                    query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + x + "','" + "0" + "','" + "0" + "')";


                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                }

                if (ckbmalexray.Checked == true)
                {
                    connection();
                    query = "insert into db_its.tbl_xraypendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                        + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + age + "','" + sex + "','" + cmbdoctor.Text + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                    connection();
                    query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + x + "')";


                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                }

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Send an additional check for patient. " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Your Request has Been saved. Please Proceed to designated Ancillary Check - up");
                
                this.timer2.Enabled = true;
                this.timer1.Enabled = false;
                count = 0;

                txthospitalnumber.Text = "";
                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                txtage.Text = "";
                cmbsex.SelectedIndex = -1;
                txtcontact.Text = "";
                txtaddress.Text = "";
                txtoccupation.Text = "";
                dateTimePicker2.Text = "";
                lbltime.Text = "";
                txtcause.Text = "";
                cmberbed.Text = "";
                lver.Items.Clear();

                btnrequest.Visible = false;
            }
        }

        private void btndischarge_Click(object sender, EventArgs e)
        {
            txthospitalnumber2.Text = txthospitalnumber.Text;
            txtsurname2.Text = txtsurname.Text;
            txtfirstname2.Text = txtfirstname.Text;
            txtmiddlename2.Text = txtmiddlename.Text;
            txtage2.Text = txtage.Text;
            cmbsex2.Text = cmbsex.Text;
            txtoccupation2.Text = txtoccupation.Text;
            txtcontact2.Text = txtcontact.Text;
            txtaddress2.Text = txtaddress.Text;
            lbltime2.Text = lbltime.Text;
            cmberbed2.Text = cmberbed.Text;
            dateTimePicker4.Text = dateTimePicker1.Text;
            lbltime3.Text = time2;

            pnlemergencydischarge.Visible = true;
            btnrequest.Visible = false;
        }

        private void btndischarge2_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_er_discharge (hospitalnumber, surname, firstname, middlename, birthdate, age, sex, occupation, contact, address, timebrought, datebrought, timedischarge, datedischarge, bednumber, bedfee) values ('" + txthospitalnumber2.Text 
                + "','" + txtsurname2.Text + "','" + txtfirstname2.Text + "','" + txtmiddlename2.Text + "','" + dateTimePicker3.Text + "','" + txtage2.Text + "','" + cmbsex2.Text + "','" + txtoccupation2.Text + "','" + txtcontact2.Text + "','" + txtaddress2.Text + "','" + lbltime2.Text + "','" 
                + dateTimePicker4.Text + "','" + lbltime3.Text + "','" + dateTimePicker5.Text + "','" + cmberbed2.Text + "','" + lblbedfee.Text +"')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            connection();
            query = "update db_its.tbl_erroom set roomstatus = '" + "Available" + "' where erroomcount = '" + cmberbed2.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            connection();
            query = "delete from db_its.tbl_erward where hospitalnumber = '" + txthospitalnumber2.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            MessageBox.Show("Patient has been Discharged.");

            txthospitalnumber2.Text = "";
            txtsurname2.Text = "";
            txtfirstname2.Text = "";
            txtmiddlename2.Text = "";
            txtage2.Text = "";
            cmbsex2.Text = "";
            txtoccupation2.Text = "";
            txtcontact2.Text = "";
            txtaddress2.Text = "";
            lbltime2.Text = "";
            cmberbed2.Text = "";
            dateTimePicker4.Text = "";
            lbltime3.Text = "";

            txthospitalnumber.Text = "";
            txtsurname.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            txtage.Text = "";
            cmbsex.SelectedIndex = -1;
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtoccupation.Text = "";
            dateTimePicker2.Text = "";
            lbltime.Text = "";
            txtcause.Text = "";
            cmberbed.Text = "";
            lver.Items.Clear();

            viewall();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Discharge a patient to Emergency. " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            pnlemergencydischarge.Visible = false;
        }

     
    }
}
