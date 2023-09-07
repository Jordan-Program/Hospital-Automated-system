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
    public partial class MergeOldNewPatientHistory : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public MergeOldNewPatientHistory()
        {
            InitializeComponent();

            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date, time;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void patientold()
        {
            connection();
            lvoldpatient.Items.Clear();
            query = "select * from db_its.tbl_basicinfo";
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
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                lvoldpatient.Items.Add(item);
            }
            con.Close();
        }

        public void patientnew()
        {
            connection();
            lvnewpatient.Items.Clear();
            query = "select * from db_its.tbl_basicinfo where hospitalnumber != '" + txthospitalnumber.Text + "'";
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
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                lvnewpatient.Items.Add(item);
            }

            con.Close();
        }

        public void deleteNewPatientId()
        {
            connection();
            query = "delete from db_its.tbl_basicinfo where hospitalnumber = '" + txthospitalnumber2.Text + "'";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void MergeOldNewPatientHistory_Load(object sender, EventArgs e)
        {
            patientold();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            lvoldpatient.Items.Clear();
            lvnewpatient.Items.Clear();
            query = "select * from db_its.tbl_basicinfo";
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
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                lvoldpatient.Items.Add(item);
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
                lvoldpatient.Items.Clear();
                query = "select * from db_its.tbl_basicinfo where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["ht"].ToString());
                    item.SubItems.Add(myreader["wt"].ToString());
                    lvoldpatient.Items.Add(item);
                }
                con.Close();
            }
        }

        private void lvoldpatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvoldpatient.SelectedItems.Count == 0) return;
            ListViewItem item = lvoldpatient.SelectedItems[0];
            txthospitalnumber.Text = item.SubItems[0].Text;
            txtsurname.Text = item.SubItems[1].Text;
            txtfirstname.Text = item.SubItems[2].Text;
            txtmiddlename.Text = item.SubItems[3].Text;
            dateTimePicker1.Text = item.SubItems[4].Text;
            txtage.Text = item.SubItems[5].Text;
            cmbsex.Text = item.SubItems[6].Text;
            txtaddress.Text = item.SubItems[7].Text;
            txtoccupation.Text = item.SubItems[8].Text;
            txtcontact.Text = item.SubItems[9].Text;
            txtht.Text = item.SubItems[10].Text;
            txtwt.Text = item.SubItems[11].Text;

            patientnew();
        }

        private void lvnewpatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvnewpatient.SelectedItems.Count == 0) return;
            ListViewItem item = lvnewpatient.SelectedItems[0];
            txthospitalnumber2.Text = item.SubItems[0].Text;
            txtsurname2.Text = item.SubItems[1].Text;
            txtfirstname2.Text = item.SubItems[2].Text;
            txtmiddlename2.Text = item.SubItems[3].Text;
            dateTimePicker2.Text = item.SubItems[4].Text;
            txtage2.Text = item.SubItems[5].Text;
            cmbsex2.Text = item.SubItems[6].Text;
            txtaddress2.Text = item.SubItems[7].Text;
            txtoccupation2.Text = item.SubItems[8].Text;
            txtcontact2.Text = item.SubItems[9].Text;
            txtht2.Text = item.SubItems[10].Text;
            txtwt2.Text = item.SubItems[11].Text;
        }

        private void btnviewall2_Click(object sender, EventArgs e)
        {
            connection();
            lvnewpatient.Items.Clear();
            query = "select * from db_its.tbl_basicinfo where hospitalnumber != '"+ txthospitalnumber.Text +"'";
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
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                lvnewpatient.Items.Add(item);
            }

            con.Close();
        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            if (txtsearchbox2.Text == "")
            {
                MessageBox.Show("Please insert either Patient - ID or Patient Surname");
            }
            else
            {
                connection();
                lvnewpatient.Items.Clear();
                query = "select * from db_its.tbl_basicinfo where hospitalnumber != '" + txthospitalnumber.Text + "' and  hospitalnumber like '%" + txtsearchbox2.Text.Replace("'", "''") + "%' or hospitalnumber != '" + txthospitalnumber.Text + "' and surname like '%" + txtsearchbox2.Text.Replace("'", "''") + "%' ";
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
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["ht"].ToString());
                    item.SubItems.Add(myreader["wt"].ToString());
                    lvnewpatient.Items.Add(item);
                }
                con.Close();
            }
        }

        private void btnmerge_Click(object sender, EventArgs e)
        {
            if (txthospitalnumber2.Text == "")
            {
                MessageBox.Show("Please choose a data you want to merge");
            }

            else
            {
                connection();
                query = "update db_its.tbl_admission set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contactpatient = '" + txtcontact.Text.Replace("'", "''") + "', occupation = '"+ txtoccupation.Text +"' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ancillary_transaction set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_bloodbanking set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_clinicalchem_conventionalvalues set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_clinicalchem_svalues set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_clinicalrecord set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contactnumber = '" + txtcontact.Text.Replace("'", "''") + "', occupation = '" + txtoccupation.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ctscanpendingcheckup set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ctscanresult set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_discharge_transaction set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ecgpendingcheckup set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ecgresult set hospitalnumber = '" + txthospitalnumber.Text + "', surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_emergency set hospitalnumber = '"+ txthospitalnumber.Text +"', surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contact = '" + txtcontact.Text.Replace("'", "''") + "', ht = '" + txtht.Text.Replace("'", "''") + "', wt = '" + txtwt.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_ertransfer set hospitalnumber = '" + txthospitalnumber.Text + "', surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contact = '" + txtcontact.Text.Replace("'", "''") + "', occupation = '"+ txtoccupation.Text +"' where hospitalnumber = '" + txthospitalnumber2.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_erward set hospitalnumber = '" + txthospitalnumber.Text + "', surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contact = '" + txtcontact.Text.Replace("'", "''") + "', occupation = '" + txtoccupation.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_fecalysis set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_femaleward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '"+ txtcontact.Text +"', address = '"+ txtaddress.Text +"' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_hematology set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_isolationward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '" + txtcontact.Text + "', address = '" + txtaddress.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_laboratorypendingcheckup set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_maleward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '" + txtcontact.Text + "', address = '" + txtaddress.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_medicalrecord set hospitalnumber = '" + txthospitalnumber.Text + "', surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', contact = '" + txtcontact.Text.Replace("'", "''") + "' where hospitalnumber = '" + txthospitalnumber2.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_obgyneward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '" + txtcontact.Text + "', address = '" + txtaddress.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_pediatricward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '" + txtcontact.Text + "', address = '" + txtaddress.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_pediatricward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_surgicalward set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', contact = '" + txtcontact.Text + "', address = '" + txtaddress.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_urinalysis set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_urinalysis set hospitalnumber = '" + txthospitalnumber.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_xraypendingcheckup set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "update db_its.tbl_xrayresult set hospitalnumber = '" + txthospitalnumber.Text + "' ,surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "' where hospitalnumber = '" + txthospitalnumber2.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                deleteNewPatientId();

                MessageBox.Show("Merging New Patient id and history to Old Patient id and history successed");

                patientold();
                lvnewpatient.Items.Clear();


                txthospitalnumber.Text = "";
                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                dateTimePicker1.Text = "";
                txtage.Text = "";
                cmbsex.SelectedIndex = -1;
                txtaddress.Text = ""; 
                txtoccupation.Text = ""; 
                txtcontact.Text = "";
                txtht.Text = "";
                txtwt.Text = "";

                txthospitalnumber2.Text = "";
                txtsurname2.Text = "";
                txtfirstname2.Text = "";
                txtmiddlename2.Text = "";
                dateTimePicker2.Text = "";
                txtage2.Text = "";
                cmbsex2.SelectedIndex = 1;
                txtaddress2.Text = "";
                txtoccupation2.Text = "";
                txtcontact2.Text = "";
                txtht2.Text = "";
                txtwt2.Text = "";

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Merge a New patient Id and History to Old patient History " + "','" + date + " " + time + "')";
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
    }
}