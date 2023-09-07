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
    public partial class ErmergencyRoom : Form
    {
        public string name;
        public string userid;
        public string acoountposition;

        public ErmergencyRoom()
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

        public string health, date, date2, time2;

        public int id, time1 = 5;


        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void viewall()
        {
            connection();
            lvold.Items.Clear();
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
                item.SubItems.Add(myreader["age"].ToString());
                item.SubItems.Add(myreader["sex"].ToString());
                item.SubItems.Add(myreader["birthdate"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["philhealth"].ToString());
                lvold.Items.Add(item);
            }

            con.Close();
        }

        private void ErmergencyRoom_Load(object sender, EventArgs e)
        {
            errooms();
            hospitalnumber();
            viewall();

            timer1.Start();
            
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbltime2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbltime3.Text = DateTime.Now.ToString("hh:mm:ss tt");

            dateTimePicker2.MaxDate = DateTime.Today;

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void hospitalnumber()
        {
            date = DateTime.Now.ToString("Mddyyyy");

            connection();
            query = "select * from db_its.tbl_basicinfo order by patientcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {


                int count = myreader["hospitalnumber"].ToString().Length;

                if (count == 11)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 1)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                    txthospitalnumber3.Text = date + " - " + id;
                }

                if (count == 12)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 2)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                    txthospitalnumber3.Text = date + " - " + id;
                }

                if (count == 13)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 3)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                    txthospitalnumber3.Text = date + " - " + id;
                }


                if (count == 14)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 4)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                    txthospitalnumber3.Text = date + " - " + id;
                }




            }

            con.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker2.Value;
            int year = DateTime.Now.Year - dateTimePicker2.Value.Year;
            if (dateTimePicker2.Value.AddYears(year) > DateTime.Now) year--;
            txtage.Text = year.ToString();
        }

        public void errooms()
        {
            

            connection();
            query = "select * from db_its.tbl_erroom where roomstatus = '" + "Available" + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                
  
                cmberbed.Items.Add(myreader["erroomcount"].ToString());
                cmberbed2.Items.Add(myreader["erroomcount"].ToString());
                cmberbed3.Items.Add(myreader["erroomcount"].ToString());
            
            }

            con.Close();
        }

        public void patientstatus()
        {
            connection();
            query = "update db_its.tbl_basicinfo set patientstatus = '" + "In - Patient" + "' where hospitalnumber = '" + txthospitalnumber2.Text + "' ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void clear()
        {
            rdnwith.Checked = false;
            rdnwithout.Checked = false;
            txtsurname.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            txtage.Text = "";
            txtht.Text = "";
            txtwt.Text = "";
            txtoccupation.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            cmbsex.SelectedIndex = -1;
            txtcause.Text = "";
            cmberbed.SelectedIndex = -1;

            txthospitalnumber2.Text = "";
            txtsurname2.Text = "";
            txtfirstname2.Text = "";
            txtmiddlename2.Text = "";
            txtage2.Text = "";
            txtht2.Text = "";
            txtwt2.Text = "";
            txtoccupation2.Text = "";
            txtcontact2.Text = "";
            txtaddress2.Text = "";
            cmbsex2.SelectedIndex = -1;
            txtcause2.Text = "";
            cmberbed2.SelectedIndex = -1;

           
            rdbwithout.Checked = false;
            txtsurname3.Text = "";
            txtfirstname3.Text = "";
            txtmiddlename3.Text = "";
            txtage3.Text = "";
            txtht3.Text = "";
            txtwt3.Text = "";
            txtoccupation3.Text = "";
            txtcontact3.Text = "";
            txtaddress3.Text = "";
            cmbsex3.SelectedIndex = -1;
            txtcause3.Text = "";
            cmberbed3.SelectedIndex = -1;

            lvold.Items.Clear();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            date2 = DateTime.Now.ToString("MMMM dd, yyyy");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");

            if (txtsurname.Text == "" || txtfirstname.Text == ""
                 || txtage.Text == "" || cmbsex.Text == "" || txtht.Text == "" || txtwt.Text == ""
                 || txtaddress.Text == "" || txtcause.Text == "")
            {
                MessageBox.Show("Please fill up required fields");
            }

            else if (txtcontact.Text.Length < 13 || txtcontact.Text.Length <9 && txtcontact.Text.Length > 9)
            {
                MessageBox.Show("Please put your Contact number. or Your number is Invalid");
            }

            else if (cmberbed.Text == "")
            {
                MessageBox.Show("Choose room that available");
            }

            else
            {
               string path = @"C:\Users\DatuinMelchisedeck\Desktop\My Files\ITS Project\icons\png\user.png";

                byte[] imagebt = null;
                FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagebt = br.ReadBytes((int)fstream.Length);

                connection();
                query = "insert into db_its.tbl_basicinfo (hospitalnumber,surname,firstname,middlename,birthdate,age,sex,ht,wt,address,occupation,contactnumber,philhealth,patientstatus,time,date,image) values ('"
                    + txthospitalnumber.Text + "','" + txtsurname.Text + " " + "','" + txtfirstname.Text + " " + "','" + txtmiddlename.Text + "','" + dateTimePicker1.Text + "','" + txtage.Text + "','"
                    + cmbsex.Text + "','" + txtht.Text.Replace("'", "''") + "','" + txtwt.Text + "','" + txtaddress.Text + "','" + txtoccupation.Text + "','" + txtcontact.Text + "','" + health + "','"
                    + "In - Patient" + "','" + time2 + "','" + date2 + "',@IMG)";

                command = new MySqlCommand(query, con);
                command.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                myreader = command.ExecuteReader();
                MessageBox.Show("Patient info has been saved");
                MessageBox.Show("Please proceed to Emergency Room");
                con.Close();

                connection();
                query = "insert into db_its.tbl_emergency (hospitalnumber, surname, firstname, middlename, birthdate, age, sex, ht, wt, contact, address, causeofincident, date, time, roomnumber status) values ('" + txthospitalnumber.Text + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + dateTimePicker1.Text + "','" + txtage.Text + "','" + cmbsex.Text + "','" + txtht.Text.Replace("'", "''") + "','" + txtwt.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtcause.Text.Replace("'", "''") + "','" + time2 + "','" + date2 + "','" + cmberbed.Text + "','" + "In Er room" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_erroom set roomstatus = '" + "Taken" + "' where erroomcount = '" + cmberbed.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_erward (hospitalnumber, surname, firstname, middlename, age, sex, birthdate, contact, address, occupation, date, time, cause, bednumber, philhealth) values ('" + txthospitalnumber.Text + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtage.Text + "','" + cmbsex.Text + "','" + dateTimePicker1.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtoccupation.Text + "','" + date2 + "','" + time2 + "','" + txtcause.Text.Replace("'", "''") + "','" + cmberbed.Text + "','" + health + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                cmberbed.Items.Clear();
                errooms();
            }
        }

        private void cmregistertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cmregistertype.Text == "New Patient")
            {
                pnlregister.Visible = true;
                pnlold.Visible = false;
                pnlunidentified.Visible = false;
            }

            if (cmregistertype.Text == "Old Patient")
            {
                pnlregister.Visible = false;
                pnlold.Visible = true;
                pnlunidentified.Visible = false;
            }

            if (cmregistertype.Text == "Unidentified Patient")
            {
                pnlregister.Visible = false;
                pnlold.Visible = false;
                pnlunidentified.Visible = true;
            }
        }

        private void rdnwith_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnwith.Checked == true)
            {
                health = "With Philhealth";
            }
        }

        private void rdnwithout_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnwithout.Checked == true)
            {
                health = "Without Philhealth";
            }
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
                lvold.Items.Clear();
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
                    item.SubItems.Add(myreader["age"].ToString());
                    item.SubItems.Add(myreader["sex"].ToString());
                    item.SubItems.Add(myreader["birthdate"].ToString());
                    item.SubItems.Add(myreader["ht"].ToString());
                    item.SubItems.Add(myreader["wt"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    lvold.Items.Add(item);
                }
                con.Close();
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            
            connection();
            lvold.Items.Clear();
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
                item.SubItems.Add(myreader["age"].ToString());
                item.SubItems.Add(myreader["sex"].ToString());
                item.SubItems.Add(myreader["birthdate"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["philhealth"].ToString());
                lvold.Items.Add(item);
            }

            con.Close();
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

        private void txtoccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtht_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '\'');
        }

        private void txtwt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void lvold_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvold.SelectedItems.Count == 0) return;
                ListViewItem item = lvold.SelectedItems[0];
                txthospitalnumber2.Text = item.SubItems[0].Text;
                txtsurname2.Text = item.SubItems[1].Text;
                txtfirstname2.Text = item.SubItems[2].Text;
                txtmiddlename2.Text = item.SubItems[3].Text;
                txtage2.Text = item.SubItems[4].Text;
                cmbsex2.Text = item.SubItems[5].Text;
                dateTimePicker3.Text = item.SubItems[6].Text;
                txtht2.Text = item.SubItems[7].Text;
                txtwt2.Text = item.SubItems[8].Text;
                txtaddress2.Text = item.SubItems[9].Text;
                txtoccupation2.Text = item.SubItems[10].Text;
                txtcontact2.Text = item.SubItems[11].Text;
                health = item.SubItems[12].Text;
         
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            date2 = DateTime.Now.ToString("MMMM dd, yyyy");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");

            if (txtcause2.Text == "")
            {
                MessageBox.Show("Please insert the cause of Incident");
            }

           else if (cmberbed2.Text == "")
            {
                MessageBox.Show("Choose room that available");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_emergency (hospitalnumber, surname, firstname, middlename, birthdate, age, sex, ht, wt, contact, address, causeofincident, date, time, roomnumber, status) values ('" + txthospitalnumber2.Text + "','" + txtsurname2.Text + "','" + txtfirstname2.Text + "','" + txtmiddlename2.Text + "','" + dateTimePicker3.Text + "','" + txtage2.Text + "','" + cmbsex2.Text + "','" + txtht2.Text.Replace("'", "''") + "','" + txtwt2.Text + "','" + txtcontact2.Text + "','" + txtaddress2.Text + "','" + txtcause2.Text.Replace("'", "''") + "','" + time2 + "','" + date2 + "','" + cmberbed2.Text + "','" + "In Er room" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
               
                connection();
                query = "update db_its.tbl_erroom set roomstatus = '" + "Taken" + "' where erroomcount = '" + cmberbed2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_erward (hospitalnumber, surname, firstname, middlename, age, sex, birthdate, contact, address, occupation, date, time, cause, bednumber, philhealth) values ('" + txthospitalnumber2.Text + "','" + txtsurname2.Text + "','" + txtfirstname2.Text + "','" + txtmiddlename2.Text + "','" + txtage2.Text + "','" + cmbsex2.Text + "','" + dateTimePicker3.Text + "','" + txtcontact2.Text + "','" + txtaddress2.Text + "','" + txtoccupation2.Text + "','" + date2 + "','" + time2 + "','" + txtcause2.Text.Replace("'", "''") + "','" + cmberbed2.Text + "','" + health + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Please proceed to Emergency Room");

                cmberbed2.Items.Clear();
                errooms();
                patientstatus();
                clear();
                viewall();
            }
        }

        private void cmbsex3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsex3.Text == "Male")
            {
                txtsurname3.Text = "Doe";
                txtfirstname3.Text = "John";
                txtmiddlename3.Text = "Unidentified";
                txtage3.Text = "Unidentified";
                txtwt3.Text = "Unidentified";
                txtht3.Text = "Unidentified";
                txtoccupation3.Text = "Unidentified";
                txtcontact3.Text = "Unidentified";
                txtaddress3.Text = "Unidentified";
            }

            if (cmbsex3.Text == "Female")
            {
                txtsurname3.Text = "Doe";
                txtfirstname3.Text = "Jane";
                txtmiddlename3.Text = "Unidentified";
                txtage3.Text = "Unidentified";
                txtwt3.Text = "Unidentified";
                txtht3.Text = "Unidentified";
                txtoccupation3.Text = "Unidentified";
                txtcontact3.Text = "Unidentified";
                txtaddress3.Text = "Unidentified";
            }
        }

        private void btnsave3_Click(object sender, EventArgs e)
        {
            date2 = DateTime.Now.ToString("MMMM dd, yyyy");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");

            if (txtcause3.Text == "")
            {
                MessageBox.Show("Please insert the cause of Incident");
            }

            else if (cmberbed3.Text == "")
            {
                MessageBox.Show("Choose room that available");
            }

            else
            {
                string path = @"C:\Users\DatuinMelchisedeck\Desktop\My Files\ITS Project\icons\png\user.png";

                byte[] imagebt = null;
                FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagebt = br.ReadBytes((int)fstream.Length);

                connection();
                query = "insert into db_its.tbl_basicinfo (hospitalnumber,surname,firstname,middlename,birthdate,age,sex,ht,wt,address,occupation,contactnumber,philhealth,patientstatus,time,date,image) values ('"
                    + txthospitalnumber3.Text + "','" + txtsurname3.Text + " " + "','" + txtfirstname3.Text + " " + "','" + txtmiddlename3.Text + "','" + dateTimePicker5.Text + "','" + txtage3.Text + "','"
                    + cmbsex3.Text + "','" + txtht3.Text.Replace("'", "''") + "','" + txtwt3.Text + "','" + txtaddress3.Text + "','" + txtoccupation3.Text + "','" + txtcontact3.Text + "','" + health + "','"
                    + "In - Patient" + "','" + time2 + "','" + date2 + "',@IMG)";

                command = new MySqlCommand(query, con);
                command.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                myreader = command.ExecuteReader();
                MessageBox.Show("Patient info has been saved");
                MessageBox.Show("Please proceed to Emergency Room");
                con.Close();

                connection();
                query = "insert into db_its.tbl_emergency (hospitalnumber, surname, firstname, middlename, birthdate, age, sex, ht, wt, contact, address, causeofincident, date, time, roomnumber, status) values ('" + txthospitalnumber3.Text + "','" + txtsurname3.Text + "','" + txtfirstname3.Text + "','" + txtmiddlename3.Text + "','" + dateTimePicker5.Text + "','" + txtage3.Text + "','" + cmbsex3.Text + "','" + txtht3.Text.Replace("'", "''") + "','" + txtwt3.Text + "','" + txtcontact3.Text + "','" + txtaddress3.Text + "','" + txtcause3.Text.Replace("'", "''") + "','" + time2 + "','" + date2 + "','" + cmberbed3.Text + "','" + "In Er room" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_erroom set roomstatus = '" + "Taken" + "' where erroomcount = '" + cmberbed3.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_erward (hospitalnumber, surname, firstname, middlename, age, sex, birthdate, contact, address, occupation, date, time, cause, bednumber, philhealth) values ('" + txthospitalnumber3.Text + "','" + txtsurname3.Text + "','" + txtfirstname3.Text + "','" + txtmiddlename3.Text + "','" + txtage3.Text + "','" + cmbsex3.Text + "','" + dateTimePicker5.Text + "','" + txtcontact3.Text + "','" + txtaddress3.Text + "','" + txtoccupation3.Text + "','" + date2 + "','" + time2 + "','" + txtcause3.Text.Replace("'", "''") + "','" + cmberbed3.Text + "','" + health + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                clear();
                hospitalnumber();
                cmberbed3.Items.Clear();
                errooms();
            }
        }

        private void rdbwithout_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbwithout.Checked == true)
            {
                health = "Without Philhealth";
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

       
        private void timer1_Tick_1(object sender, EventArgs e)
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

    }
}
