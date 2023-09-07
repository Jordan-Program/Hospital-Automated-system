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
    public partial class Register : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Register()
        {
            InitializeComponent();
            doctors();
            

            Timer DateTimer = new Timer();
            DateTimer.Interval = 1000;
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string health, sec, date, time, date2, time2;

        public int id, time1 = 5;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void DateTimer_Tick(Object sender, EventArgs e)
        {
            
            
            lbldates.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lbltimes.Text = DateTime.Now.ToString("hh:mm:ss tt");

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
                }

                if (count == 12)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 2)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                }

                if (count == 13)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 3)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                }


                if (count == 14)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 4)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                }

                if (count == 15)
                {
                    id = int.Parse(myreader["hospitalnumber"].ToString().Substring(10, 5)) + 1;

                    txthospitalnumber.Text = date + " - " + id;
                }
               

            }
               
            con.Close();
        }

        public void insertionofchiefcomplaint()
        {
            connection();
            query = "insert into db_its.tbl_clinicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, birthdate, ht, wt, address, occupation, contactnumber, chiefcomplaint, hpi, bp, cr, rr, temp, residentonduty, time, date) values ('"
                + txthospitalnumber.Text + "','" + txtsurname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtage.Text + "','" + cmbsex.Text + "','" + dateTimePicker1.Text + "','" + txtht.Text.Replace("'", "''") + "','"
                + txtwt.Text + "','" + txtaddress.Text + "','" + txtoccupation.Text + "','" + txtcontact.Text + "','" + txtchiefcomplaint.Text + "','" + txthpi.Text + "','" + txtbp.Text + "','" + txtcr.Text + "','" + txtrr.Text + "','" + txttemp.Text 
                + "','" + cmbdoctor.Text + "','" + lbltimes.Text + "','" + lbldates.Text + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string picloc = openfile.FileName.ToString();
                txtfilepath.Text = picloc;
                pictureBox1.ImageLocation = picloc;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker1.Value;
            int year = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.AddYears(year) > DateTime.Now) year--;
            txtage.Text = year.ToString();

            
        }

        public void doctors()
        {
            connection();
            query = "select * from db_its.tbl_doctor where department = '"+ cmbdepartment.Text +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                cmbdoctor.Items.Add(myreader["doctorname"].ToString());
            }

            con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
                if (rdnwith.Checked == false && rdnwithout.Checked == false)
                {
                    MessageBox.Show("Please fill up required fields");
                }

                else if (txtsurname.Text == "" || txtfirstname.Text == ""
                    || txtage.Text == "" || cmbsex.Text == "" || txtht.Text == "" || txtwt.Text == ""
                    || txtaddress.Text == "" || txtchiefcomplaint.Text == ""
                    || txthpi.Text == "" || txtbp.Text == "" || txtcr.Text == "" || txtrr.Text == "" || txttemp.Text == "")
                {
                    MessageBox.Show("Please fill up required fields");
                }

                else if (txtcontact.Text.Length < 13 || txtcontact.Text.Length < 9 && txtcontact.Text.Length > 9)
                {
                    MessageBox.Show("Please put your Contact number. or Your number is Invalid");
                }

                else if (cmbdepartment.Text == "")
                {
                    MessageBox.Show("Please Selecet Specialization");
                }

                else if (cmbdoctor.Text == "")
                {
                    MessageBox.Show("Choose a Doctor");
                }

                else if (txtfilepath.Text == "")
                {
                    if (MessageBox.Show("Are you sure you want to save it?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        patientinfo pi = new patientinfo();
                        pi.hospitalnumber = txthospitalnumber.Text;
                        pi.surname = txtsurname.Text;
                        pi.firstname = txtfirstname.Text;
                        pi.middlename = txtmiddlename.Text;
                        pi.birthdate = dateTimePicker1.Text;
                        pi.age = txtage.Text;
                        pi.sex = cmbsex.Text;
                        pi.ht = txtht.Text;
                        pi.wt = txtwt.Text;
                        pi.address = txtaddress.Text;
                        pi.occupation = txtoccupation.Text;
                        pi.contactnumber = txtcontact.Text;
                        pi.philhealth = health;
                        pi.time = lbltimes.Text;
                        pi.date = lbldates.Text;

                        ListViewItem newList = new ListViewItem(pi.hospitalnumber);
                        newList.SubItems.Add(pi.surname);
                        newList.SubItems.Add(pi.firstname);
                        newList.SubItems.Add(pi.middlename);
                        newList.SubItems.Add(pi.birthdate);
                        newList.SubItems.Add(pi.age);
                        newList.SubItems.Add(pi.sex);
                        newList.SubItems.Add(pi.ht);
                        newList.SubItems.Add(pi.wt);
                        newList.SubItems.Add(pi.address);
                        newList.SubItems.Add(pi.occupation);
                        newList.SubItems.Add(pi.contactnumber);
                        newList.SubItems.Add(pi.philhealth);
                        newList.SubItems.Add(pi.time);
                        newList.SubItems.Add(pi.date);
                        listView1.Items.Add(newList);

                        txtfilepath.Text = @"C:\Users\DatuinMelchisedeck\Desktop\My Files\ITS Project\icons\png\user.png";

                        byte[] imagebt = null;
                        FileStream fstream = new FileStream(this.txtfilepath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imagebt = br.ReadBytes((int)fstream.Length);

                        connection();
                        query = "insert into db_its.tbl_basicinfo (hospitalnumber,surname,firstname,middlename,birthdate,age,sex,ht,wt,address,occupation,contactnumber,philhealth,patientstatus,time,date,image) values ('"
                            + txthospitalnumber.Text + "','" + txtsurname.Text + " " + "','" + txtfirstname.Text + " " + "','" + txtmiddlename.Text + "','" + dateTimePicker1.Text + "','" + txtage.Text + "','"
                            + cmbsex.Text + "','" + txtht.Text.Replace("'", "''") + "','" + txtwt.Text + "','" + txtaddress.Text.Replace("'", "''") + "','" + txtoccupation.Text.Replace("'", "''") + "','" + txtcontact.Text + "','" + health + "','"
                            + "Out - Patient" + "','" + lbltimes.Text + "','" + lbldates.Text + "',@IMG)";

                        command = new MySqlCommand(query, con);
                        command.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                        myreader = command.ExecuteReader();
                        MessageBox.Show("Patient info has been saved");
                        MessageBox.Show("Please proceed to the doctor");
                        con.Close();

                        insertionofchiefcomplaint();



                        txtfilepath.Text = "";
                        rdnwith.Checked = false;
                        rdnwithout.Checked = false;
                        txtsurname.Text = "";
                        txtfirstname.Text = "";
                        txtmiddlename.Text = "";
                        txtage.Text = "0";
                        txtht.Text = "";
                        txtwt.Text = "";
                        txtoccupation.Text = "";
                        txtcontact.Text = "";
                        txtaddress.Text = "";
                        cmbsex.SelectedIndex = -1;
                        txtchiefcomplaint.Text = "";
                        txthpi.Text = "";
                        txtbp.Text = "";
                        txtcr.Text = "";
                        txtrr.Text = "";
                        txttemp.Text = "";
                        cmbdoctor.SelectedIndex = -1;
                        cmbdepartment.SelectedIndex = -1;
                        hospitalnumber();

                        connection();
                        query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " insert new Patient " + "','" + date2 + " " + time2 + "')";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();
                    }

                }

                else if (txtfilepath.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to save it?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        patientinfo pi = new patientinfo();
                        pi.hospitalnumber = txthospitalnumber.Text;
                        pi.surname = txtsurname.Text;
                        pi.firstname = txtfirstname.Text;
                        pi.middlename = txtmiddlename.Text;
                        pi.birthdate = dateTimePicker1.Text;
                        pi.age = txtage.Text;
                        pi.sex = cmbsex.Text;
                        pi.ht = txtht.Text;
                        pi.wt = txtwt.Text;
                        pi.address = txtaddress.Text;
                        pi.occupation = txtoccupation.Text;
                        pi.contactnumber = txtcontact.Text;
                        pi.philhealth = health;
                        pi.time = lbltimes.Text;
                        pi.date = lbldates.Text;

                        ListViewItem newList = new ListViewItem(pi.hospitalnumber);
                        newList.SubItems.Add(pi.surname);
                        newList.SubItems.Add(pi.firstname);
                        newList.SubItems.Add(pi.middlename);
                        newList.SubItems.Add(pi.birthdate);
                        newList.SubItems.Add(pi.age);
                        newList.SubItems.Add(pi.sex);
                        newList.SubItems.Add(pi.ht);
                        newList.SubItems.Add(pi.wt);
                        newList.SubItems.Add(pi.address);
                        newList.SubItems.Add(pi.occupation);
                        newList.SubItems.Add(pi.contactnumber);
                        newList.SubItems.Add(pi.philhealth);
                        newList.SubItems.Add(pi.time);
                        newList.SubItems.Add(pi.date);
                        listView1.Items.Add(newList);

                        byte[] imagebt = null;
                        FileStream fstream = new FileStream(this.txtfilepath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imagebt = br.ReadBytes((int)fstream.Length);

                        connection();
                        query = "insert into db_its.tbl_basicinfo (hospitalnumber,surname,firstname,middlename,birthdate,age,sex,ht,wt,address,occupation,contactnumber,philhealth,time,date,image) values ('"
                            + txthospitalnumber.Text + "','" + txtsurname.Text + " " + " " + "','" + txtfirstname.Text + " " + "','" + txtmiddlename.Text + "','" + dateTimePicker1.Text + "','" + txtage.Text + "','"
                            + cmbsex.Text + "','" + txtht.Text.Replace("'", "''") + "','" + txtwt.Text + "','" + txtaddress.Text.Replace("'", "''") + "','" + txtoccupation.Text.Replace("'", "''") + "','" + txtcontact.Text + "','" + health + "','"
                            + lbltimes.Text + "','" + lbldates.Text + "',@IMG)";

                        command = new MySqlCommand(query, con);
                        command.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                        myreader = command.ExecuteReader();
                        MessageBox.Show("Patient info has been saved");
                        MessageBox.Show("Please procced to the doctor");
                        con.Close();

                        insertionofchiefcomplaint();



                        txtfilepath.Text = "";
                        rdnwith.Checked = false;
                        rdnwithout.Checked = false;
                        txtsurname.Text = "";
                        txtfirstname.Text = "";
                        txtmiddlename.Text = "";
                        txtage.Text = "0";
                        txtht.Text = "";
                        txtwt.Text = "";
                        txtoccupation.Text = "";
                        txtcontact.Text = "";
                        txtaddress.Text = "";
                        cmbsex.Text = "";
                        txtchiefcomplaint.Text = "";
                        txthpi.Text = "";
                        txtbp.Text = "";
                        txtcr.Text = "";
                        txtrr.Text = "";
                        txttemp.Text = "";
                        pictureBox1.Image = null;
                        cmbdoctor.SelectedIndex = -1;
                        cmbdepartment.SelectedIndex = -1;
                        hospitalnumber();
                    }

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " insert new Patient " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                }
           
        
        } 
      

        private void Register_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;

            hospitalnumber();

            timer1.Start();


            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
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

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

            if ((txtaddress.Text.Length) == 1)
            {
                txtaddress.Text = txtaddress.Text[0].ToString().ToUpper();
                txtaddress.Select(2, 1);

            }
        }

        

        private void txtwt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Go back to Main menu " + "','" + date2 + " " + time2 + "')";
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

        private void txtht_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '\'');
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

        private void txtbp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '/');
        }

        private void txtcr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtrr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txttemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;
                dateTimePicker1.MaxDate = DateTime.Today;

                hospitalnumber();
            }

            else
            {
                time1 = 5;
            }
        }

        private void cmbdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            doctors();
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtage.Text) < 18)
            {
                rdnwith.Enabled = false;
                rdnwithout.Enabled = false;

                rdnwith.Checked = false;
                rdnwithout.Checked = true;
            }

            if (int.Parse(txtage.Text) > 18)
            {
                rdnwith.Enabled = true;
                rdnwithout.Enabled = true;
                rdnwithout.Checked = false;
            }
        }

    }
}
