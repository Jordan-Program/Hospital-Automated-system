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
    public partial class Admitting : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Admitting()
        {
            InitializeComponent();


            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss");

            lbltimeadmitted.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string manner, condtion, service, surname, firstname, middlename, philhealth, patientid, date, time;

        public int id, time1 = 5;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void Admitting_Load(object sender, EventArgs e)
        {
            hospitalnumber();
            viewall();
            timer1.Start();
            doctors();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void viewall()
        {
            if (ckbfromer.Checked == false)
            {
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_basicinfo where patientstatus = '" + "Out - Patient" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["birthdate"].ToString());
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    listView1.Items.Add(item);
                }

                con.Close();
            }

            if (ckbfromer.Checked == true)
            {
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_ertransfer";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["birthdate"].ToString());
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    listView1.Items.Add(item);
                }

                con.Close();
            }
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

        public void hospitalnumber()
        {
            

            connection();
            query = "select * from db_its.tbl_admission order by admittedcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {


                int count = myreader["admittedid"].ToString().Length;

                if (count == 7)
                {
                    id = int.Parse(myreader["admittedid"].ToString().Substring(6, 1)) + 1;

                    lbladmittingid.Text = "ADM" + " - " + id;
                }

                if (count == 8)
                {
                    id = int.Parse(myreader["admittedid"].ToString().Substring(6, 2)) + 1;

                    lbladmittingid.Text = "ADM" + " - " + id;
                }

                if (count == 9)
                {
                    id = int.Parse(myreader["admittedid"].ToString().Substring(6, 3)) + 1;

                    lbladmittingid.Text = "ADM" + " - " + id;
                }


                if (count == 10)
                {
                    id = int.Parse(myreader["admittedid"].ToString().Substring(6, 4)) + 1;

                    lbladmittingid.Text = "ADM" + " - " + id;
                }




            }

            con.Close();
        }

        public void mannerofentering()
        {
            if (rdbwalking.Checked == true)
            {
                manner = "Walking";
            }

            if (rdbcarried.Checked == true)
            {
                manner = "Carried";
            }

            if (rdbwheelchair.Checked == true)
            {
                manner = "On Wheel Chair";
            }

            if (rdbstrecther.Checked == true)
            {
                manner = "On strecther";
            }

            if (rdbambulance.Checked == true)
            {
                manner = "Brought by ambulance";
            }

            if (rdber.Checked == true)
            {
                manner = "From Er";
            }
      
        }

        public void conditiononadmission()
        {
            if (rdbstrong.Checked == true)
            {
                condtion = "Strong";

            }

            if (rdbsuffering.Checked == true)
            {
                condtion = "Suffering from acute pain";
            }

            if (rdbfair.Checked == true)
            {
                condtion = "Fair";
            }

            if (rdbweak.Checked == true)
            {
                condtion = "Weak";
            }

            if (rdbbleeding.Checked == true)
            {
                condtion = "Bleeding";
            }

            if (rdbunconscious.Checked == true)
            {
                condtion = "Unconscious";
            }
        
        }

        public void services()
        {
            if (rdbobgyne.Checked == true)
            {
                service = "OB - Gyne";
            }

            if (rdbmedicine.Checked == true)
            {
                service = "Medicine";
            }

            if (rdbpediatrics.Checked == true)
            {
                service = "Pediatrics";
            }

            if (rdbsurgery.Checked == true)
            {
                service = "Surgey";
            }
        }


        public void discounts()
        {
            if (ckbsssno.Checked == true && ckbgsisno.Checked == true)
            {
                ckbphilhealthno.Enabled = false;
            }

            if (ckbsssno.Checked == false || ckbgsisno.Checked == false)
            {
                ckbphilhealthno.Enabled = true;
            }

            if (ckbsssno.Checked == true && ckbphilhealthno.Checked == true)
            {
                ckbgsisno.Enabled = false;
            }


            if (ckbsssno.Checked == false || ckbphilhealthno.Checked == false)
            {
                ckbgsisno.Enabled = true;
            }

            if (ckbgsisno.Checked == true && ckbphilhealthno.Checked == true)
            {
                ckbsssno.Enabled = false;
            }

            if (ckbgsisno.Checked == false || ckbphilhealthno.Checked == false)
            {
                ckbsssno.Enabled = true;
            }

            if (ckbphilhealthno.Checked == true && ckbsssno.Checked == true)
            {
                ckbgsisno.Enabled = false;
            }


            if (ckbphilhealthno.Checked == false || ckbsssno.Checked == false)
            {
                ckbgsisno.Enabled = true;
            }
        }

        public void patientstatus()
        {
            connection();
            query = "update db_its.tbl_basicinfo set patientstatus = '" + "In - Patient" + "' where hospitalnumber = '" + patientid + "' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void enteringinward()
        {
            if (cmbward.Text == "Medical Male Ward")
            {
                connection();
                query = "insert into db_its.tbl_maleward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_medicalmalewardroom set roomstatus = '" + "Taken" +"' where medicalmaleroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbward.Text == "Medical Female Ward")
            {
                connection();
                query = "insert into db_its.tbl_femaleward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_medicalfemalewardroom set roomstatus = '" + "Taken" + "' where medicalfemaleroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbward.Text == "OB - Gyne")
            {
                connection();
                query = "insert into db_its.tbl_obgyneward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_obgyneroom set roomstatus = '" + "Taken" + "' where obgyneroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbward.Text == "Surgical")
            {
                connection();
                query = "insert into db_its.tbl_surgicalward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_surgicalroom set roomstatus = '" + "Taken" + "' where surgicalroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbward.Text == "Pediatric")
            {
                connection();
                query = "insert into db_its.tbl_pediatricward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_pediatricroom set roomstatus = '" + "Taken" + "' where pediatricroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

            if (cmbward.Text == "Isolition")
            {
                connection();
                query = "insert into db_its.tbl_isolationward (admissionno, hospitalnumber, surname, firstname, middlename, age, sex, contact, address, dateaddmitted, timeaddmitted, admittingofficer, bednumber, physician) values ('" + lbladmittingid.Text + "','" + patientid + "','" + surname + "','" + firstname + "','" + middlename + "','" + txtage.Text + "','"
                        + cmbsex.Text + "','" + txtcontactpatient.Text + "','" + txtaddress.Text + "','" + dtpdateadmitted.Text + "','" + lbltimeadmitted.Text + "','" + txtadmittingofficer.Text + "','" + cmbroomnumber.Text + "','" + cmbdoctor.Text + "')";
                
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_isolationroom set roomstatus = '" + "Taken" + "' where isolationroomcount = '" + cmbroomnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Go Back to Main Menu " + "','" + date + " " + time + "')";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker1.Value;
            int year = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.AddYears(year) > DateTime.Now) year--;
            txtage.Text = year.ToString();

            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void btnadmit_Click(object sender, EventArgs e)
        {
            mannerofentering();
            conditiononadmission();
            services();

            if (txtsurname.Text == "" || txtfirstname.Text == "" || txtage.Text == "" || cmbsex.Text == ""
                || txtaddress.Text == "" || txtreligion.Text == "" || txtbusinessaddress.Text == ""
                || cmbward.Text == "" || cmbward.Text == "" || txtcompanion.Text == "" || txtrelation.Text == "" || txtaddresscompanion.Text == ""
                || txtremarks.Text == "" || txtresponsible.Text == "" || txtrelation2.Text == "" || txtaddressnumber.Text == "")
            {
                MessageBox.Show("Please fill up required fields");
            }



            else if (rdbwalking.Checked == false && rdbcarried.Checked == false && rdbstrecther.Checked == false && rdbambulance.Checked == false && rdber.Checked == false && rdbwheelchair.Checked == false)
            {
                MessageBox.Show("Please choose in the Manner of Entering section");
            }

            else if (rdbstrong.Checked == false && rdbsuffering.Checked == false && rdbfair.Checked == false && rdbweak.Checked == false && rdbbleeding.Checked == false && rdbunconscious.Checked == false)
            {
                MessageBox.Show("Please choose in the Condition on Admission section");
            }

            else if (rdbobgyne.Checked == false && rdbmedicine.Checked == false && rdbpediatrics.Checked == false && rdbsurgery.Checked == false)
            {
                MessageBox.Show("Please choose in the Service section");
            }

            else if (txtcontactpatient.Text.Length < 9 || txtcontactpatient.Text.Length < 13)
            {
                MessageBox.Show("Patient Contact number is Invalid");
            }

            else if (txtcontactbusiness.Text.Length < 9 || txtcontactbusiness.Text.Length < 13)
            {
                MessageBox.Show("Business contact number is Invalid");
            }

            else if (txtcontactbusiness.Text.Length < 9 || txtcontactbusiness.Text.Length < 13)
            {
                MessageBox.Show("Business contact number is Invalid");
            }

            else if (txtcontactcompanion.Text.Length < 9 || txtcontactcompanion.Text.Length < 13)
            {
                MessageBox.Show("Companion contact number is Invalid");
            }

           else if (ckbsssno.Checked == true && txtsssno.Text.Length < 15)
            {
                MessageBox.Show("SSS No. Is invalid");

            }

           else if (ckbgsisno.Checked == true && txtgsisno.Text.Length < 15)
            {
                MessageBox.Show("GSIS No. Is invalid");
            }

           else if (ckbphilhealthno.Checked == true && txtphilhealth.Text.Length <14)
            {

                MessageBox.Show("Philhealth No. Is invalid");
            }

            else if (txtadmittingofficer.Text == "")
            {
                MessageBox.Show("Insert the name of Admitting Officer");
            }

            else
            {



                connection();
                query = "insert into db_its.tbl_admission (admittedid, hospitalnumber, surname, firstname, middlename, birthdate, age, sex, address, contactpatient, dateadmitted, occupation, religion, businessaddress, contactbusiness, ward," +
                        "roomno, roomrate, timeadmitted, companion, relation, companionaddress, contactcompanion, responsibleforaccounts, responsiblerelation, responsibleteladdress, remarks, mannerofentering, conditiononadmission," +
                        "service, sssno, gsisnumber, philhealth, admittedofficer, physician) values ('" + lbladmittingid.Text
                        + "','" + patientid + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + dateTimePicker1.Text + "','" + txtage.Text + "','" + cmbsex.Text + "','" + txtaddress.Text.Replace("'", "''")
                        + "','" + txtcontactpatient.Text + "','" + dtpdateadmitted.Text + "','" + txtoccupation.Text.Replace("'", "''") + "','" + txtreligion.Text.Replace("'", "''") + "','" + txtbusinessaddress.Text.Replace("'", "''") + "','" + txtcontactbusiness.Text
                        + "','" + cmbward.Text + "','" + cmbroomnumber.Text + "','" + txtroomrate.Text + "','" + lbltimeadmitted.Text + "','" + txtcompanion.Text.Replace("'", "''") + "','" + txtrelation.Text.Replace("'", "''") + "','" + txtaddresscompanion.Text.Replace("'", "''")
                        + "','" + txtcontactcompanion.Text + "','" + txtresponsible.Text + "','" + txtrelation2.Text.Replace("'", "''") + "','" + txtaddressnumber.Text.Replace("'", "''") + "','" + txtremarks.Text + "','" + manner + "','" + condtion + "','" + service
                        + "','" + txtsssno.Text + "','" + txtgsisno.Text + "','" + txtphilhealth.Text + "','" + txtadmittingofficer.Text.Replace("'", "''") + "','" + cmbdoctor.Text + "')";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                 con.Close();

                MessageBox.Show("Patient Admission Record has been saved");

                patientstatus();
                enteringinward();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + patientid + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Admit a patient " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                txtage.Text = "0";
                cmbsex.SelectedIndex = -1;
                txtoccupation.Text = "";
                txtcontactpatient.Text = "";
                txtaddress.Text = "";
                txtreligion.Text = "";
                txtbusinessaddress.Text = "";
                txtcontactbusiness.Text = "";
                cmbward.SelectedIndex = -1;
                cmbroomnumber.SelectedIndex = -1;
                txtroomrate.Text = "";
                lbltimeadmitted.Text = "";
                txtcompanion.Text = "";
                txtrelation.Text = "";
                txtaddresscompanion.Text = "";
                txtcontactcompanion.Text = "";
                txtremarks.Text = "";
                txtresponsible.Text = "";
                txtrelation2.Text = "";
                txtaddressnumber.Text = "";
                rdbwalking.Checked = false;
                rdbcarried.Checked = false;
                rdbwheelchair.Checked = false;
                rdbstrecther.Checked = false;
                rdbambulance.Checked = false;
                rdbstrong.Checked = false;
                rdbsuffering.Checked = false;
                rdbfair.Checked = false;
                rdbweak.Checked = false;
                rdbbleeding.Checked = false;
                rdbobgyne.Checked = false;
                rdbmedicine.Checked = false;
                rdbpediatrics.Checked = false;
                rdbsurgery.Checked = false;
                ckbgsisno.Checked = false;
                ckbphilhealthno.Checked = false;
                ckbsssno.Checked = false;
                txtsssno.Text = "";
                txtgsisno.Text = "";
                txtphilhealth.Text = "";
                txtadmittingofficer.Text = "";
                ckbfromer.Checked = false;
                cmbdoctor.SelectedIndex = -1;
                listView1.Items.Clear();

                viewall();

                hospitalnumber();
            }
        }

        

        private void txtsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtmiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtreligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\'');  
        }

        private void txtoccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar));  
        }

        private void txtcompanion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\''); 
        }

        private void txtrelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\''); 
        }

        private void txtresponsible_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\''); 
        }

        private void txtrelation2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\''); 
        }

        private void txtsssno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '-');
        }

        private void txtgsisno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '-');
        }

        private void txtphilhealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '-');
        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {
            if ((txtsurname.Text.Length) == 1)
            {
                txtsurname.Text = txtsurname.Text[0].ToString().ToUpper();
                txtsurname.Select(2, 1);

            }
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

        private void txtoccupation_TextChanged(object sender, EventArgs e)
        {
            if ((txtoccupation.Text.Length) == 1)
            {
                txtoccupation.Text = txtoccupation.Text[0].ToString().ToUpper();
                txtoccupation.Select(2, 1);

            }
        }

        private void txtreligion_TextChanged(object sender, EventArgs e)
        {
            if ((txtreligion.Text.Length) == 1)
            {
                txtreligion.Text = txtreligion.Text[0].ToString().ToUpper();
                txtreligion.Select(2, 1);

            }
        }

        private void txtcompanion_TextChanged(object sender, EventArgs e)
        {
            if ((txtcompanion.Text.Length) == 1)
            {
                txtcompanion.Text = txtcompanion.Text[0].ToString().ToUpper();
                txtcompanion.Select(2, 1);

            }
        }

        private void txtrelation_TextChanged(object sender, EventArgs e)
        {
            if ((txtrelation.Text.Length) == 1)
            {
                txtrelation.Text = txtrelation.Text[0].ToString().ToUpper();
                txtrelation.Select(2, 1);

            }
        }

        private void txtresponsible_TextChanged(object sender, EventArgs e)
        {
            if ((txtresponsible.Text.Length) == 1)
            {
                txtresponsible.Text = txtresponsible.Text[0].ToString().ToUpper();
                txtresponsible.Select(2, 1);

            }
        }

        private void txtrelation2_TextChanged(object sender, EventArgs e)
        {
            if ((txtrelation2.Text.Length) == 1)
            {
                txtrelation2.Text = txtrelation2.Text[0].ToString().ToUpper();
                txtrelation2.Select(2, 1);

            }
        }

        private void cmbward_SelectedIndexChanged(object sender, EventArgs e)
        {
                cmbroomnumber.Items.Clear();

            if (cmbward.Text == "Medical Male Ward")
            {
                connection();
                query = "select * from db_its.tbl_medicalmalewardroom where roomstatus = '"+ "Available" +"'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
               while (myreader.Read())
                {
                    
                    cmbroomnumber.Items.Add(myreader["medicalmaleroomcount"].ToString());
                    
                }
                con.Close();

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

            if (cmbward.Text == "Medical Female Ward")
            {
                connection();
                query = "select * from db_its.tbl_medicalfemalewardroom where roomstatus = '" + "Available" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    
                    cmbroomnumber.Items.Add(myreader["medicalfemaleroomcount"].ToString());
                    
                }
                con.Close();

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

            if (cmbward.Text == "OB - Gyne")
            {
                connection();
                query = "select * from db_its.tbl_obgyneroom where roomstatus = '" + "Available" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    cmbroomnumber.Items.Add(myreader["obgyneroomcount"].ToString());

                }
                con.Close();

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

            if (cmbward.Text == "Surgical")
            {
                connection();
                query = "select * from db_its.tbl_surgicalroom where roomstatus = '" + "Available" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    cmbroomnumber.Items.Add(myreader["surgicalroomcount"].ToString());

                }
                con.Close();

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

            if (cmbward.Text == "Pediatric")
            {
                connection();
                query = "select * from db_its.tbl_pediatricroom where roomstatus = '" + "Available" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    cmbroomnumber.Items.Add(myreader["pediatricroomcount"].ToString());

                }
                con.Close();

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

            if (cmbward.Text == "Isolition")
            {
                connection();
                query = "select * from db_its.tbl_isolationroom where roomstatus = '" + "Available" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    cmbroomnumber.Items.Add(myreader["isolationroomcount"].ToString());

                }
                con.Close();

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
        }





        private void btnviewall_Click(object sender, EventArgs e)
        {
            if (ckbfromer.Checked == false)
            {
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_basicinfo where patientstatus = '" + "Out - Patient" + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["birthdate"].ToString());
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    listView1.Items.Add(item);
                }

                con.Close();
            }

            if (ckbfromer.Checked == true)
            {
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_ertransfer";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString());
                    item.SubItems.Add(myreader["firstname"].ToString());
                    item.SubItems.Add(myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["birthdate"].ToString());
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contact"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    listView1.Items.Add(item);
                }

                con.Close();
            }

        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (ckbfromer.Checked == false)
            {
                if (txtsearchbox.Text == "")
                {
                    MessageBox.Show("Please insert either Patient - ID or Patient Surname");

                }
                else
                {
                    connection();
                    listView1.Items.Clear();
                    query = "select * from db_its.tbl_basicinfo where patientstatus = '" + "Out - Patient" + "' and hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' and patientstatus = '" + "Out - Patient" + "' ";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {


                        var item = new ListViewItem();
                        item.Text = myreader["hospitalnumber"].ToString();
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["birthdate"].ToString());
                        item.SubItems.Add(myreader["age"].ToString());
                        item.SubItems.Add(myreader["sex"].ToString());
                        item.SubItems.Add(myreader["occupation"].ToString());
                        item.SubItems.Add(myreader["contactnumber"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["philhealth"].ToString());
                        listView1.Items.Add(item);
                    }

                    con.Close();
                }
            }

            if (ckbfromer.Checked == true)
            {
                if (txtsearchbox.Text == "")
                {
                    MessageBox.Show("Please insert either Patient - ID or Patient Surname");

                }

                else
                {
                    connection();
                    listView1.Items.Clear();
                    query = "select * from db_its.tbl_ertransfer where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {


                        var item = new ListViewItem();
                        item.Text = myreader["hospitalnumber"].ToString();
                        item.SubItems.Add(myreader["surname"].ToString());
                        item.SubItems.Add(myreader["firstname"].ToString());
                        item.SubItems.Add(myreader["middlename"].ToString());
                        item.SubItems.Add(myreader["birthdate"].ToString());
                        item.SubItems.Add(myreader["age"].ToString());
                        item.SubItems.Add(myreader["sex"].ToString());
                        item.SubItems.Add(myreader["occupation"].ToString());
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["philhealth"].ToString());
                        listView1.Items.Add(item);
                    }

                    con.Close();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            txtsurname.Text = item.SubItems[1].Text;
            txtfirstname.Text = item.SubItems[2].Text;
            txtmiddlename.Text = item.SubItems[3].Text;
            dateTimePicker1.Text = item.SubItems[4].Text;
            txtage.Text = item.SubItems[5].Text;
            cmbsex.Text = item.SubItems[6].Text;
            txtoccupation.Text = item.SubItems[7].Text;
            txtcontactpatient.Text = item.SubItems[8].Text;
            txtaddress.Text = item.SubItems[9].Text;
            philhealth = item.SubItems[10].Text;

            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;

            patientid = item.SubItems[0].Text;
            

            if (philhealth == "With Philhealth")
            {
                ckbphilhealthno.Checked = true;
                txtphilhealth.Enabled = true;
            }

            if (philhealth != "With Philhealth")
            {
                ckbphilhealthno.Checked = false;
                txtphilhealth.Enabled = false;
            }
            
            
        }

        private void ckbsssno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbsssno.Checked == true)
            {
                txtsssno.Enabled = true;
            }

            if (ckbsssno.Checked == false)
            {
                txtsssno.Enabled = false;
            }

            discounts();
        
        }

        private void ckbgsisno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbgsisno.Checked == true)
            {
                txtgsisno.Enabled = true;
            }

            if (ckbgsisno.Checked == false)
            {
                txtgsisno.Enabled = false;
            }

            discounts();
        }

        private void ckbphilhealthno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbphilhealthno.Checked == true)
            {
               txtphilhealth.Enabled = true;
            }

            if (ckbphilhealthno.Checked == false)
            {
                txtphilhealth.Enabled = false;
            }

            discounts();
        }

        private void txtadmittingofficer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtadmittingofficer_TextChanged(object sender, EventArgs e)
        {
            if ((txtadmittingofficer.Text.Length) == 1)
            {
                txtadmittingofficer.Text = txtadmittingofficer.Text[0].ToString().ToUpper();
                txtadmittingofficer.Select(2, 1);

            }
        }

        private void ckbfromer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbfromer.Checked == true)
            {
                rdbwalking.Enabled = false;
                rdbcarried.Enabled = false;
                rdbwheelchair.Enabled = false;
                rdbstrecther.Enabled = false;
                rdbambulance.Enabled = false;
                rdber.Checked = true;
            }


            if (ckbfromer.Checked == false)
            {
                rdbwalking.Enabled = true;
                rdbcarried.Enabled = true;
                rdbwheelchair.Enabled = true;
                rdbstrecther.Enabled = true;
                rdbambulance.Enabled = true;
                rdber.Checked = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;
                hospitalnumber();
            }

            else
            {
                time1 = 5;
            }
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtage.Text) < 18)
            {
                ckbgsisno.Enabled = false;
                ckbsssno.Enabled = false;
                ckbphilhealthno.Enabled = false;
                txtbusinessaddress.Text = "N/A";
                txtbusinessaddress.Enabled = false;
                rdbpediatrics.Enabled = true;
            }

            if (int.Parse(txtage.Text) > 17)
            {
                ckbgsisno.Enabled = true;
                ckbsssno.Enabled = true;
                ckbphilhealthno.Enabled = true;
                txtbusinessaddress.Enabled = true;
                rdbpediatrics.Enabled = false;
            }
        }

        private void cmbsex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsex.Text == "Female")
            {
                rdbobgyne.Enabled = true;
            }

            if (cmbsex.Text != "Female")
            {
                rdbobgyne.Enabled = false;
            }
        }

    

       

    }
}
