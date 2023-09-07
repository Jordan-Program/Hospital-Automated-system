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
    public partial class Ward : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Ward()
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

        public string hospitalnumber, surname, firstname, middlename, date, time, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, ecg, xray, ctscan, sex, age;

        public int count = 0, x = 1, time1 = 5;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void Ward_Load(object sender, EventArgs e)
        {
            doctors();

            timer3.Start();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
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


        public void clear()
        {
            lblhospitalnumber6.Text = "";
            lblpatientname6.Text = "";
            lblage6.Text = "";
            lblsex6.Text = "";
            lblcontact6.Text = "";
            lbladdress6.Text = "";
            lbldateaddmitted6.Text = "";
            lbltimeaddmitted6.Text = "";
            lblbednumber6.Text = "";
            txtobservation6.Text = "";
            lvisolation.Items.Clear();

            lblhospitalnumber5.Text = "";
            lblpatientname5.Text = "";
            lblage5.Text = "";
            lblsex5.Text = "";
            lblcontact5.Text = "";
            lbladdress5.Text = "";
            lbldateaddmitted5.Text = "";
            lbltimeaddmitted5.Text = "";
            lblbednumber5.Text = "";
            txtobservation5.Text = "";
            lvpediatric.Items.Clear();

            lblhospitalnumber4.Text = "";
            lblpatientname4.Text = "";
            lblage4.Text = "";
            lblsex4.Text = "";
            lblcontact4.Text = "";
            lbladdress4.Text = "";
            lbldateaddmitted4.Text = "";
            lbltimeaddmitted4.Text = "";
            lblbednumber4.Text = "";
            txtobservation4.Text = "";
            lvsurgical.Items.Clear();

            lblhospitalnumber3.Text = "";
            lblpatientname3.Text = "";
            lblage3.Text = "";
            lblsex3.Text = "";
            lblcontact3.Text = "";
            lbladdress3.Text = "";
            lbldateaddmitted3.Text = "";
            lbltimeaddmitted3.Text = "";
            lblbednumber3.Text = "";
            txtobservation3.Text = "";
            lvobgyne.Items.Clear();

            lblhospitalnumber2.Text = "";
            lblpatientname2.Text = "";
            lblage2.Text = "";
            lblsex2.Text = "";
            lblcontact2.Text = "";
            lbladdress2.Text = "";
            lbldateaddmitted2.Text = "";
            lbltimeaddmitted2.Text = "";
            lblbednumber2.Text = "";
            txtobservation2.Text = "";
            lvfemaleward.Items.Clear();

            lblhospitalnumber.Text = "";
            lblpatientname.Text = "";
            lblage.Text = "";
            lblsex.Text = "";
            lblcontact.Text = "";
            lbladdress.Text = "";
            lbldateaddmitted.Text = "";
            lbltimeaddmitted.Text = "";
            lblbednumber.Text = "";
            txtobservation.Text = "";
            lvmaleward.Items.Clear();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "")
            {
                MessageBox.Show("Please Choose a ward you want to view.");
            }
            else
            {
                if (cmbsearch.Text == "Medical Male Ward")
                {
                    connection();
                    lvmaleward.Items.Clear();
                    query = "select * from db_its.tbl_maleward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvmaleward.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Medical Female Ward")
                {
                    connection();
                    lvfemaleward.Items.Clear();
                    query = "select * from db_its.tbl_femaleward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvfemaleward.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "OB - Gyne")
                {
                    connection();
                    lvobgyne.Items.Clear();
                    query = "select * from db_its.tbl_obgyneward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvobgyne.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Surgical")
                {
                    connection();
                    lvsurgical.Items.Clear();
                    query = "select * from db_its.tbl_surgicalward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvsurgical.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Pediatric")
                {
                    connection();
                    lvpediatric.Items.Clear();
                    query = "select * from db_its.tbl_pediatricward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvpediatric.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Isolation")
                {
                    connection();
                    lvisolation.Items.Clear();
                    query = "select * from db_its.tbl_isolationward";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvisolation.Items.Add(item);
                    }
                    con.Close();
                }
            }
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "")
            {
                MessageBox.Show("Please Choose a ward you want to view.");
            }

            else
            {
                if (cmbsearch.Text == "Medical Male Ward")
                {
                    if (txtsearchbox.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvmaleward.Items.Clear();
                        query = "select * from db_its.tbl_maleward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                            item.SubItems.Add(myreader["contact"].ToString());
                            item.SubItems.Add(myreader["address"].ToString());
                            item.SubItems.Add(myreader["dateaddmitted"].ToString());
                            item.SubItems.Add(myreader["timeaddmitted"].ToString());
                            item.SubItems.Add(myreader["admittingofficer"].ToString());
                            item.SubItems.Add(myreader["bednumber"].ToString());
                            lvmaleward.Items.Add(item);
                        }
                        con.Close();
                    }
                }


                if (cmbsearch.Text == "Medical Female Ward")
                {
                    connection();
                    lvmaleward.Items.Clear();
                    query = "select * from db_its.tbl_femaleward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvfemaleward.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "OB - Gyne")
                {
                    connection();
                    lvobgyne.Items.Clear();
                    query = "select * from db_its.tbl_obgyneward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvobgyne.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Surgical")
                {
                    connection();
                    lvsurgical.Items.Clear();
                    query = "select * from db_its.tbl_obgyneward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvsurgical.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Pediatric")
                {
                    connection();
                    lvpediatric.Items.Clear();
                    query = "select * from db_its.tbl_pediatricward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvpediatric.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbsearch.Text == "Isolation")
                {
                    connection();
                    lvisolation.Items.Clear();
                    query = "select * from db_its.tbl_isolationward where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                        item.SubItems.Add(myreader["contact"].ToString());
                        item.SubItems.Add(myreader["address"].ToString());
                        item.SubItems.Add(myreader["dateaddmitted"].ToString());
                        item.SubItems.Add(myreader["timeaddmitted"].ToString());
                        item.SubItems.Add(myreader["admittingofficer"].ToString());
                        item.SubItems.Add(myreader["bednumber"].ToString());
                        lvisolation.Items.Add(item);
                    }
                    con.Close();
                }
            }
        }


        private void lvmaleward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvmaleward.SelectedItems.Count == 0) return;
            ListViewItem item = lvmaleward.SelectedItems[0];
            lblhospitalnumber.Text = item.SubItems[0].Text;
            lblpatientname.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage.Text = item.SubItems[4].Text;
            lblsex.Text = item.SubItems[5].Text;
            lblcontact.Text = item.SubItems[6].Text;
            lbladdress.Text = item.SubItems[7].Text;
            lbldateaddmitted.Text = item.SubItems[8].Text;
            lbltimeaddmitted.Text = item.SubItems[9].Text;
            lblbednumber.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }
            else if (txtobservation.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblcontact.Text
                        + "','" + lbladdress.Text + "','" + lbldateaddmitted.Text + "','" + lbltimeaddmitted.Text + "','" + lblbednumber.Text + "','"
                        + txtobservation.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber.Text = "";
                lblpatientname.Text = "";
                lblage.Text = "";
                lblsex.Text = "";
                lblcontact.Text = "";
                lbladdress.Text = "";
                lbldateaddmitted.Text = "";
                lbltimeaddmitted.Text = "";
                lblbednumber.Text = "";
                txtobservation.Text = "";
                lvmaleward.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();


                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to Medical Male Ward " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

            }

        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "Medical Male Ward")
            {
                pnlmaleward.Visible = true;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;

                clear();
            }

            if (cmbsearch.Text == "Medical Female Ward")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = true;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;

                clear();
            }


            if (cmbsearch.Text == "OB - Gyne")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = true;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;

                clear();
            }

            if (cmbsearch.Text == "Surgical")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = true;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;

                clear();
            }

            if (cmbsearch.Text == "Pediatric")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = true;
                pnlisolation.Visible = false;

                clear();
            }


            if (cmbsearch.Text == "Isolation")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = true;

                clear();
            }

        }

        private void lvfemaleward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvfemaleward.SelectedItems.Count == 0) return;
            ListViewItem item = lvfemaleward.SelectedItems[0];
            lblhospitalnumber2.Text = item.SubItems[0].Text;
            lblpatientname2.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage2.Text = item.SubItems[4].Text;
            lblsex2.Text = item.SubItems[5].Text;
            lblcontact2.Text = item.SubItems[6].Text;
            lbladdress2.Text = item.SubItems[7].Text;
            lbldateaddmitted2.Text = item.SubItems[8].Text;
            lbltimeaddmitted2.Text = item.SubItems[9].Text;
            lblbednumber2.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber2.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }
            else if (txtobservation2.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber2.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage2.Text + "','" + lblsex2.Text + "','" + lblcontact2.Text
                        + "','" + lbladdress2.Text + "','" + lbldateaddmitted2.Text + "','" + lbltimeaddmitted2.Text + "','" + lblbednumber2.Text + "','"
                        + txtobservation2.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber2.Text = "";
                lblpatientname2.Text = "";
                lblage2.Text = "";
                lblsex2.Text = "";
                lblcontact2.Text = "";
                lbladdress2.Text = "";
                lbldateaddmitted2.Text = "";
                lbltimeaddmitted2.Text = "";
                lblbednumber2.Text = "";
                txtobservation2.Text = "";
                lvfemaleward.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to Medical Female Ward " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

            }
        }

        private void lvobgyne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvobgyne.SelectedItems.Count == 0) return;
            ListViewItem item = lvobgyne.SelectedItems[0];
            lblhospitalnumber3.Text = item.SubItems[0].Text;
            lblpatientname3.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage3.Text = item.SubItems[4].Text;
            lblsex3.Text = item.SubItems[5].Text;
            lblcontact3.Text = item.SubItems[6].Text;
            lbladdress3.Text = item.SubItems[7].Text;
            lbldateaddmitted3.Text = item.SubItems[8].Text;
            lbltimeaddmitted3.Text = item.SubItems[9].Text;
            lblbednumber3.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave3_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber3.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }

            else if (txtobservation3.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber3.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage3.Text + "','" + lblsex3.Text + "','" + lblcontact3.Text
                        + "','" + lbladdress3.Text + "','" + lbldateaddmitted3.Text + "','" + lbltimeaddmitted3.Text + "','" + lblbednumber3.Text + "','"
                        + txtobservation3.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber3.Text = "";
                lblpatientname3.Text = "";
                lblage3.Text = "";
                lblsex3.Text = "";
                lblcontact3.Text = "";
                lbladdress3.Text = "";
                lbldateaddmitted3.Text = "";
                lbltimeaddmitted3.Text = "";
                lblbednumber3.Text = "";
                txtobservation3.Text = "";
                lvobgyne.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to OB - Gyne Ward " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

            }
        }

        private void lvsurgical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsurgical.SelectedItems.Count == 0) return;
            ListViewItem item = lvsurgical.SelectedItems[0];
            lblhospitalnumber4.Text = item.SubItems[0].Text;
            lblpatientname4.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage4.Text = item.SubItems[4].Text;
            lblsex4.Text = item.SubItems[5].Text;
            lblcontact4.Text = item.SubItems[6].Text;
            lbladdress4.Text = item.SubItems[7].Text;
            lbldateaddmitted4.Text = item.SubItems[8].Text;
            lbltimeaddmitted4.Text = item.SubItems[9].Text;
            lblbednumber4.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave4_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber4.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }

            else if (txtobservation4.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber4.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage4.Text + "','" + lblsex4.Text + "','" + lblcontact4.Text
                        + "','" + lbladdress4.Text + "','" + lbldateaddmitted4.Text + "','" + lbltimeaddmitted4.Text + "','" + lblbednumber4.Text + "','"
                        + txtobservation4.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber4.Text = "";
                lblpatientname4.Text = "";
                lblage4.Text = "";
                lblsex4.Text = "";
                lblcontact4.Text = "";
                lbladdress4.Text = "";
                lbldateaddmitted4.Text = "";
                lbltimeaddmitted4.Text = "";
                lblbednumber4.Text = "";
                txtobservation4.Text = "";
                lvsurgical.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to Surgical Ward " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

            }
        }

        private void lvpediatric_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvpediatric.SelectedItems.Count == 0) return;
            ListViewItem item = lvpediatric.SelectedItems[0];
            lblhospitalnumber5.Text = item.SubItems[0].Text;
            lblpatientname5.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage5.Text = item.SubItems[4].Text;
            lblsex5.Text = item.SubItems[5].Text;
            lblcontact5.Text = item.SubItems[6].Text;
            lbladdress5.Text = item.SubItems[7].Text;
            lbldateaddmitted5.Text = item.SubItems[8].Text;
            lbltimeaddmitted5.Text = item.SubItems[9].Text;
            lblbednumber5.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave5_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber5.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }

            else if (txtobservation5.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber5.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage5.Text + "','" + lblsex5.Text + "','" + lblcontact5.Text
                        + "','" + lbladdress5.Text + "','" + lbldateaddmitted5.Text + "','" + lbltimeaddmitted5.Text + "','" + lblbednumber5.Text + "','"
                        + txtobservation5.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber5.Text = "";
                lblpatientname5.Text = "";
                lblage5.Text = "";
                lblsex5.Text = "";
                lblcontact5.Text = "";
                lbladdress5.Text = "";
                lbldateaddmitted5.Text = "";
                lbltimeaddmitted5.Text = "";
                lblbednumber5.Text = "";
                txtobservation5.Text = "";
                lvpediatric.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to Pediatring Ward " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }



        }

        private void lvisolation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvisolation.SelectedItems.Count == 0) return;
            ListViewItem item = lvisolation.SelectedItems[0];
            lblhospitalnumber6.Text = item.SubItems[0].Text;
            lblpatientname6.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage6.Text = item.SubItems[4].Text;
            lblsex6.Text = item.SubItems[5].Text;
            lblcontact6.Text = item.SubItems[6].Text;
            lbladdress6.Text = item.SubItems[7].Text;
            lbldateaddmitted6.Text = item.SubItems[8].Text;
            lbltimeaddmitted6.Text = item.SubItems[9].Text;
            lblbednumber6.Text = item.SubItems[11].Text;

            hospitalnumber = item.SubItems[0].Text;
            surname = item.SubItems[1].Text;
            firstname = item.SubItems[2].Text;
            middlename = item.SubItems[3].Text;
            age = item.SubItems[4].Text;
            sex = item.SubItems[5].Text;

            btnrequest.Visible = true;
        }

        private void btnsave6_Click(object sender, EventArgs e)
        {
            if (lblhospitalnumber6.Text == "")
            {
                MessageBox.Show("Please select a patient");

            }

            else if (txtobservation6.Text == "")
            {
                MessageBox.Show("Please type in Observation");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_medicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, contact, address," +
                        "dateadmitted, timeadmitted, bednumber, observation, dateofobservation, timeofobservation, wardtype) values ('" + lblhospitalnumber6.Text
                        + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage6.Text + "','" + lblsex6.Text + "','" + lblcontact6.Text
                        + "','" + lbladdress6.Text + "','" + lbldateaddmitted6.Text + "','" + lbltimeaddmitted6.Text + "','" + lblbednumber6.Text + "','"
                        + txtobservation6.Text.Replace("'", "''") + "','" + date + "','" + time + "','" + cmbsearch.Text + "')";

                MessageBox.Show("Patient's medical record has been saved");

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                lblhospitalnumber6.Text = "";
                lblpatientname6.Text = "";
                lblage6.Text = "";
                lblsex6.Text = "";
                lblcontact6.Text = "";
                lbladdress6.Text = "";
                lbldateaddmitted6.Text = "";
                lbltimeaddmitted6.Text = "";
                lblbednumber6.Text = "";
                txtobservation6.Text = "";
                lvisolation.Items.Clear();

                connection();
                query = "insert into db_its.tbl_wardrequestcheckup (hospitalnumber,hematology,urinalysis,fecalysis,bloodbanking,clinicalchem,ecg,ctscan,xray) values ('" + hospitalnumber + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add Medical record to Isolation Ward " + "','" + date + " " + time + "')";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlreq.Size.Height >= 244) this.timer1.Enabled = false;
            else pnlreq.Height += 12;
            if (pnlreq.Size.Height != 10)
            {
                pnlreq.Visible = true;
                btnsave.Enabled = false;
                btnsave2.Enabled = false;
                btnsave3.Enabled = false;
                btnsave4.Enabled = false;
                btnsave5.Enabled = false;
                btnsave6.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlreq.Size.Height <= 10) this.timer2.Enabled = false;
            else pnlreq.Height -= 12;
            if (pnlreq.Size.Height == 10)
            {
                pnlreq.Visible = false;
                btnsave.Enabled = true;
                btnsave2.Enabled = true;
                btnsave3.Enabled = true;
                btnsave4.Enabled = true;
                btnsave5.Enabled = true;
                btnsave6.Enabled = true;
            }
        }

        private void btnmalerequest_Click(object sender, EventArgs e)
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
                        + "','" + fecalysis + "','" + bloodbanking + "','" + clinicalchem + "','" + cmbdoctor.Text + "')";

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
                clear();
                this.timer2.Enabled = true;
                this.timer1.Enabled = false;
                count = 0;

                ckbmalehematolgy.Checked = false;
                ckbmaleurinalysis.Checked = false;
                ckbmalefecalysis.Checked = false;
                ckbmalebloodbanking.Checked = false;
                ckbmaleclinicalchem.Checked = false;
                ckbmaleecg.Checked = false;
                ckbmalectscan.Checked = false;
                ckbmalexray.Checked = false;
                cmbdoctor.SelectedIndex = -1;

                btnsave.Enabled = true;
                btnsave2.Enabled = true;
                btnsave3.Enabled = true;
                btnsave4.Enabled = true;
                btnsave5.Enabled = true;
                btnsave6.Enabled = true;
            }



        }

        private void cmbsearch_Click(object sender, EventArgs e)
        {
            btnrequest.Visible = false;

            this.timer2.Enabled = true;
            this.timer1.Enabled = false;
            count = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
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
       
       
        
        private void ckbviewall_CheckedChanged(object sender, EventArgs e)
        {
            // var item = new ListViewItem();//

            lvviewall.Items.Clear();
            if (ckbviewall.Checked == true)
            {
                pnlviewall.Visible = true;
                query = "select * from db_its.tbl_maleward";
                MySqlDataAdapter sql_adapt = new MySqlDataAdapter(query, con);
                con.Open();
                DataTable dt = new DataTable();
                sql_adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    //item.Text = myreader["hospitalnumber"].ToString();
                    ListViewItem item = new ListViewItem(dr["hospitalnumber"].ToString());

                    item.SubItems.Add(dr["surname"].ToString());
                    item.SubItems.Add(dr["firstname"].ToString());
                    item.SubItems.Add(dr["middlename"].ToString());
                    item.SubItems.Add(dr["age"].ToString());
                    item.SubItems.Add(dr["sex"].ToString());
                    item.SubItems.Add(dr["contact"].ToString());
                    item.SubItems.Add(dr["address"].ToString());
                    item.SubItems.Add(dr["dateaddmitted"].ToString());
                    item.SubItems.Add(dr["timeaddmitted"].ToString());
                    item.SubItems.Add(dr["admittingofficer"].ToString());
                    item.SubItems.Add(dr["bednumber"].ToString());
                    con.Close();
                    lvviewall.Items.Add(item);
                }
                connection();
                // lvfemaleward.Items.Clear();
                query = "select * from db_its.tbl_femaleward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item2 = new ListViewItem(myreader["hospitalnumber"].ToString());
                    item2.SubItems.Add(myreader["surname"].ToString());
                    item2.SubItems.Add(myreader["firstname"].ToString());
                    item2.SubItems.Add(myreader["middlename"].ToString());
                    item2.SubItems.Add(myreader["age"].ToString());
                    item2.SubItems.Add(myreader["sex"].ToString());
                    item2.SubItems.Add(myreader["contact"].ToString());
                    item2.SubItems.Add(myreader["address"].ToString());
                    item2.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item2.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item2.SubItems.Add(myreader["admittingofficer"].ToString());
                    item2.SubItems.Add(myreader["bednumber"].ToString());
                    lvviewall.Items.Add(item2);
                }
                con.Close();

                connection();
                query = "select * from db_its.tbl_surgicalward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item3 = new ListViewItem();
                    item3.Text = myreader["hospitalnumber"].ToString();
                    item3.SubItems.Add(myreader["surname"].ToString());
                    item3.SubItems.Add(myreader["firstname"].ToString());
                    item3.SubItems.Add(myreader["middlename"].ToString());
                    item3.SubItems.Add(myreader["age"].ToString());
                    item3.SubItems.Add(myreader["sex"].ToString());
                    item3.SubItems.Add(myreader["contact"].ToString());
                    item3.SubItems.Add(myreader["address"].ToString());
                    item3.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item3.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item3.SubItems.Add(myreader["admittingofficer"].ToString());
                    item3.SubItems.Add(myreader["bednumber"].ToString());
                    lvviewall.Items.Add(item3);
                }
                con.Close();

                connection();
                query = "select * from db_its.tbl_obgyneward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item4 = new ListViewItem();
                    item4.Text = myreader["hospitalnumber"].ToString();
                    item4.SubItems.Add(myreader["surname"].ToString());
                    item4.SubItems.Add(myreader["firstname"].ToString());
                    item4.SubItems.Add(myreader["middlename"].ToString());
                    item4.SubItems.Add(myreader["age"].ToString());
                    item4.SubItems.Add(myreader["sex"].ToString());
                    item4.SubItems.Add(myreader["contact"].ToString());
                    item4.SubItems.Add(myreader["address"].ToString());
                    item4.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item4.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item4.SubItems.Add(myreader["admittingofficer"].ToString());
                    item4.SubItems.Add(myreader["bednumber"].ToString());
                    lvviewall.Items.Add(item4);
                }
                con.Close();

                connection();
                query = "select * from db_its.tbl_pediatricward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item5 = new ListViewItem();
                    item5.Text = myreader["hospitalnumber"].ToString();
                    item5.SubItems.Add(myreader["surname"].ToString());
                    item5.SubItems.Add(myreader["firstname"].ToString());
                    item5.SubItems.Add(myreader["middlename"].ToString());
                    item5.SubItems.Add(myreader["age"].ToString());
                    item5.SubItems.Add(myreader["sex"].ToString());
                    item5.SubItems.Add(myreader["contact"].ToString());
                    item5.SubItems.Add(myreader["address"].ToString());
                    item5.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item5.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item5.SubItems.Add(myreader["admittingofficer"].ToString());
                    item5.SubItems.Add(myreader["bednumber"].ToString());
                    lvviewall.Items.Add(item5);
                }
                con.Close();

                connection();
                query = "select * from db_its.tbl_isolationward";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {



                    var item6 = new ListViewItem();
                    item6.Text = myreader["hospitalnumber"].ToString();
                    item6.SubItems.Add(myreader["surname"].ToString());
                    item6.SubItems.Add(myreader["firstname"].ToString());
                    item6.SubItems.Add(myreader["middlename"].ToString());
                    item6.SubItems.Add(myreader["age"].ToString());
                    item6.SubItems.Add(myreader["sex"].ToString());
                    item6.SubItems.Add(myreader["contact"].ToString());
                    item6.SubItems.Add(myreader["address"].ToString());
                    item6.SubItems.Add(myreader["dateaddmitted"].ToString());
                    item6.SubItems.Add(myreader["timeaddmitted"].ToString());
                    item6.SubItems.Add(myreader["admittingofficer"].ToString());
                    item6.SubItems.Add(myreader["bednumber"].ToString());
                    lvviewall.Items.Add(item6);
                }
                con.Close();
            }

            if (ckbviewall.Checked == false)
            {
                pnlviewall.Visible = false;

            }

        }
    }
}