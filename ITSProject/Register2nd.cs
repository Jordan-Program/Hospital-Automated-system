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
    public partial class Register2nd : Form
    {
        public string name;
        public string userid;
        public string acoountposition;

        public Register2nd()
        {
            InitializeComponent();

            Timer DateTimer = new Timer();
            DateTimer.Interval = 1000;
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();


            date3 = DateTime.Now.ToString("yyyy-MM-dd");
            time3 = DateTime.Now.ToString("hh:mm:ss");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string hospitalnumber ,date, time, surname, firstname, middlename, date2, time2, laboratory, ecg, xray, ctscan, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, status = "pending", date3, time3;

        

        private void DateTimer_Tick(Object sender, EventArgs e)
        {

            
            date = DateTime.Now.ToString("MMMM dd, yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");

        }

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        public void viewall()
        {
            date = DateTime.Now.ToString("MMMM dd, yyyy");
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_clinicalrecord where residentonduty like '%" + name + "%' and diagnosis is null or residentonduty like '%" + name + "%' and diagnosis = '" + "" + "'";
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
                listView1.Items.Add(item);
            }

            con.Close();
        }

        private void Register2nd_Load(object sender, EventArgs e)
        {
            viewall();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void selectphysician()
        {
            connection();
            query = "select * from db_its.tbl_clinicalrecord where hospitalnumber = '" + txthospitalnumber.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtresidentonduty.Text = myreader["residentonduty"].ToString();
                con.Close();
            }

            con.Close();
        }   

        public void insertionofchiefcomplaint()
        {
            connection();
            query = "update db_its.tbl_clinicalrecord set htnmeds = '" + txthtnmeds.Text + "', dmmeds = '" 
                + txtdmmeds.Text + "', asthmameds = '" + txtasthmameds.Text + "', allergymeds = '" 
                + txtallergymeds.Text + "', sxmeds = '" + txtsxmeds.Text + "', chiefcomplaintother = '" 
                + txtothers.Text + "', diagnosis = '" + txtdiagnosis.Text + "', ermanagement = '" 
                + txtermanagement.Text + "', heent = '" + txtheent.Text + "', lungs = '" + txtlungs.Text 
                + "', heart = '" + txtheart.Text + "', abdomen = '" + txtabdomen.Text + "', genitouro = '" 
                + txtgenitouro.Text + "', extremities = '" + txtextremities.Text + "', neuro = '" + txtneuro.Text
                + "', vitalsignother = '" + txtothers2.Text.Replace("'", "''") + "', meds = '" + txtmed.Text.Replace("'", "''") + "', residentonduty = '" + txtresidentonduty.Text + "' where date = '" + date + "' and hospitalnumber = '" + txthospitalnumber.Text + "';";
            
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
            
        }

        public void selectionofchiefandvital()
        {

            connection();
            query = "select * from db_its.tbl_clinicalrecord where hospitalnumber = '" + txthospitalnumber.Text + "' order by patientcount desc ";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtchiefcomplaint.Text = myreader["chiefcomplaint"].ToString();
                txthpi.Text = myreader["hpi"].ToString();
                txtbp.Text = myreader["bp"].ToString();
                txtcr.Text = myreader["cr"].ToString();
                txtrr.Text = myreader["rr"].ToString();
                txttemp.Text = myreader["temp"].ToString();
            }
            con.Close();
        }

        public void selecttimeanddate()
        {
            connection();
            query = "select * from db_its.tbl_clinicalrecord where hospitalnumber = '" + txthospitalnumber.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
               date2 = myreader["date"].ToString();
               time2 = myreader["time"].ToString();
            }
            con.Close();
        }

        public void ancillarybilling()
        {
            connection();
            query = "insert into db_its.tbl_pendingbill_ancillary (hospitalnumber, surname, firstname, middlename, age, sex, xray, ecg, ctscan, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, otherfee, physician, status, time, date) values ('" 
                + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','"
                + xray + "','" + ecg + "','" + ctscan + "','" + hematology + "','" + urinalysis + "','" + fecalysis + "','" + bloodbanking + "','" + clinicalchem + "','" + txtothersfee.Text +"','" + txtresidentonduty.Text + "','" + status + "','" + time + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void ancillarycheckboxs()
        {
            if (ckbhematology.Checked == false)
            {
                hematology = "No";
            }

            if (ckbhematology.Checked == true)
            {
                hematology = "Yes";
            }

            if (ckburinalysis.Checked == false)
            {
                urinalysis = "No";
            }

            if (ckburinalysis.Checked == true)
            {
                urinalysis = "Yes";
            }

            if (ckbfecalysis.Checked == false)
            {
                fecalysis = "No";
            }

            if (ckbfecalysis.Checked == true)
            {
                fecalysis = "Yes";
            }

            if (ckbbloodbanking.Checked == false)
            {
                bloodbanking = "No";
            }

            if (ckbbloodbanking.Checked == true)
            {
                bloodbanking = "Yes";
            }

            if (ckbclinicalchem.Checked == false)
            {
                clinicalchem = "No";
            }

            if (ckbclinicalchem.Checked == true)
            {
                clinicalchem = "Yes";
            }

            if (ckbxray.Checked == false)
            {
                xray = "No";
            }

            if (ckbxray.Checked == true)
            {
                xray = "Yes";
            }

            if (ckbecg.Checked == false)
            {
                ecg = "No";
            }

            if (ckbecg.Checked == true)
            {
                ecg = "Yes";
            }

            if (ckbctscan.Checked == false)
            {
                ctscan = "No";
            }

            if (ckbctscan.Checked == true)
            {
                ctscan = "Yes";
            }
        }

        public void selectionclinicalchemsvalues()
        {
            connection();
            query = "select * from db_its.tbl_clinicalchem_svalues where hospitalnumber = '" + txthospitalnumber.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtglucose.Text = myreader["glucose"].ToString();
                txtureanitrogen.Text = myreader["ureanitrogen"].ToString();
                txtcreatinine.Text = myreader["creatinine"].ToString();
                txturicacid.Text = myreader["uricacid"].ToString();
                txttriglycerides.Text = myreader["triglycerides"].ToString();
                txtcholesterol.Text = myreader["cholesterol"].ToString();
                txthdl.Text = myreader["hdl"].ToString();
                txtldl.Text = myreader["ldl"].ToString();
                txtsgpt.Text = myreader["sgpt"].ToString();
                txtsgot.Text = myreader["sgot"].ToString();
                txtsodium.Text = myreader["sodium"].ToString();
                txtpotassium.Text = myreader["potassium"].ToString();
                txtchloride.Text = myreader["chloride"].ToString();
                txtremarks2.Text = myreader["remarks"].ToString();

            }
            con.Close();
        }

        public void selectionclinicalchemconventionalvalues()
        {
            connection();
            query = "select * from db_its.tbl_clinicalchem_conventionalvalues where hospitalnumber = '" + txthospitalnumber.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtglucose2.Text = myreader["glucose"].ToString();
                txtureanitrogen2.Text = myreader["ureanitrogen"].ToString();
                txtcreatinine2.Text = myreader["creatinine"].ToString();
                txturicacid2.Text = myreader["uricacid"].ToString();
                txttriglycerides2.Text = myreader["triglycerides"].ToString();
                txtcholesterol2.Text = myreader["cholesterol"].ToString();
                txthdl2.Text = myreader["hdl"].ToString();
                txtldl2.Text = myreader["ldl"].ToString();
                txtsgpt2.Text = myreader["sgpt"].ToString();
                txtsgot2.Text = myreader["sgot"].ToString();
                txtsodium2.Text = myreader["sodium"].ToString();
                txtpotassium2.Text = myreader["potassium"].ToString();
                txtchloride2.Text = myreader["chloride"].ToString();
                txtremarks2.Text = myreader["remarks"].ToString();

            }
            con.Close();
        }

        public void clear()
        {
            
            txthemoglobin.Text = "";
            txthematocrit.Text = "";
            txtrbccount.Text = "";
            txtwbccount.Text = "";
            txtplatelet.Text = "";
            txtdifferentialcount.Text = "";
            txtneutrophils.Text = "";
            txtlymphocytes.Text = "";
            txtmonocytes.Text = "";
            txteosinophils.Text = "";
            txtbasophils.Text = "";
            txtstabs.Text = "";
            txtothers.Text = "";
            txtothertests.Text = "";

            txtcolor.Text = "";
            txttransparency.Text = "";
            txtph.Text = "";
            txtspecificgravity.Text = "";
            txtsugar.Text = "";
            txtprotein.Text = "";
            txtredbloodcells.Text = "";
            txtpuscells.Text = "";
            txtbacteria.Text = "";
            txtepithelialcells.Text = "";
            txtmucusthreads.Text = "";
            txtcast.Text = "";
            txtcrystals.Text = "";
            txtamorphousmaterials.Text = "";
            txtothertests2.Text = "";

            txtcolor2.Text = "";
            txtconsistency.Text = "";
            txtparasites.Text = "";
            txtleukocytes.Text = "";
            txterythrocytes.Text = "";
            txtfatglobules.Text = "";
            txtstrachgranules.Text = "";
            txtoccultblood.Text = "";
            txtremarks.Text = "";

            txtbloodbagserialnumber.Text = "";
            txtbloodcomponent.Text = "";
            txtdonorcontrolnumber.Text = "";
            txtdonorabobloodtype.Text = "";
            txtdonorrhbloodtype.Text = "";
            txtpatientabobloodtype.Text = "";
            txtpatientrhbloodtype.Text = "";
            txtimmediatespinphase.Text = "";
            txtenchancementmediaphase.Text = "";
            txtantihumanglobinphase.Text = "";
            txtautocontrol.Text = "";
            txtothertests3.Text = "";

            txtglucose.Text = "";
            txtureanitrogen.Text = "";
            txtcreatinine.Text = "";
            txturicacid.Text = "";
            txttriglycerides.Text = "";
            txtcholesterol.Text = "";
            txthdl.Text = "";
            txtldl.Text = "";
            txtsgpt.Text = "";
            txtsgot.Text = "";
            txtsodium.Text = "";
            txtpotassium.Text = "";
            txtchloride.Text = "";
            txtremarks2.Text = "";

            txtglucose2.Text = "";
            txtureanitrogen2.Text = "";
            txtcreatinine2.Text = "";
            txturicacid2.Text = "";
            txttriglycerides2.Text = "";
            txtcholesterol2.Text = "";
            txthdl2.Text = "";
            txtldl2.Text = "";
            txtsgpt2.Text = "";
            txtsgot2.Text = "";
            txtsodium2.Text = "";
            txtpotassium2.Text = "";
            txtchloride2.Text = "";
            txtremarks2.Text = "";

            txtctscanresult.Text = "";
            txtecgresult.Text = "";
            txtxrayresult.Text = "";

            txthospitalnumber2.Text = "";
            lblpatientname8.Text = "";
            txtchiefcomplaint2.Text = "";
            txthpi2.Text = "";
            txthtnmeds2.Text = "";
            txtdmmeds2.Text = "" ; 
            txtasthmameds2.Text = "" ; 
            txtallergymeds2.Text = "" ;
            txtsxmeds2.Text = "" ; 
            txtother2.Text = "" ;
            txtbp2.Text = "" ; 
            txtcr2.Text = "" ; 
            txtrr2.Text = "" ; 
            txttemp2.Text = "" ; 
            txtheent2.Text = "" ; 
            txtlungs2.Text = "" ; 
            txtheart2.Text = "" ; 
            txtabdomen2.Text = "" ; 
            txtgenitouro2.Text = "" ; 
            txtextremities2.Text = "" ; 
            txtneuro2.Text = "" ; 
            txtothers3.Text = "" ; 
            txtdiagnosis2.Text = "" ; 
            txtermanagement2.Text = "" ; 
            txtmeds.Text = "" ; 
            lblphysician.Text = "" ; 
            lbldate9.Text = "" ; 
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (txtsearchbox.Text == "")
            {
                MessageBox.Show("Please insert either Patient - ID or Patient Surname");

            }
            else
            {
                date = DateTime.Now.ToString("MMMM dd, yyyy");
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_clinicalrecord where residentonduty like '%" + name + "%' and diagnosis is null and hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or  residentonduty like '%" + name + "%' and diagnosis is null  and  surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or residentonduty like '%" + name + "%' and diagnosis = '" + "" + "' and hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or residentonduty like '%" + name + "%' and diagnosis = '" + " " + "'and  surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
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
                    listView1.Items.Add(item);
                }
                con.Close();
            }
        }
        private void btnviewall_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("MMMM dd, yyyy");
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_clinicalrecord where residentonduty like '%" + name + "%' and diagnosis is null or residentonduty like '%" + name + "%' and diagnosis = '"+ "" +"'";
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
                listView1.Items.Add(item);
            }

            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            

            try
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem item = listView1.SelectedItems[0];
                txthospitalnumber.Text = item.SubItems[0].Text;
                lblpatientsname.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage.Text = item.SubItems[4].Text;
                lblsex.Text = item.SubItems[5].Text;
                lblbirthdate.Text = item.SubItems[6].Text;
                lblht.Text = item.SubItems[7].Text;
                lblwt.Text = item.SubItems[8].Text;
                lbladdress.Text = item.SubItems[9].Text;
                lbloccupation.Text = item.SubItems[10].Text;
                lblcontact.Text = item.SubItems[11].Text;

                surname = item.SubItems[1].Text;
                firstname = item.SubItems[2].Text;
                middlename = item.SubItems[3].Text;
                hospitalnumber = item.SubItems[0].ToString();

                btnviewancillary.Visible = true;
                selectphysician();

                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + txthospitalnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox1.Image = null;
                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        con.Close();
                    }

                }

            }

            catch
            {
 
            }
            con.Close();
        }

        private void ckbhtnmeds_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbhtnmeds.Checked == true)
            {
                txthtnmeds.Enabled = true;  
            }

           else if (ckbhtnmeds.Checked == false)
            {
                txthtnmeds.Enabled = false;
            }
     
        }

        private void ckbdmmeds_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdmmeds.Checked == true)
            {
                txtdmmeds.Enabled = true;
            }

            else if (ckbdmmeds.Checked == false)
            {
                 txtdmmeds.Enabled = false;
            }
        }

        private void ckbasthmameds_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbasthmameds.Checked == true)
            {
                txtasthmameds.Enabled = true;
            }

            else if (ckbasthmameds.Checked == false)
            {
                txtasthmameds.Enabled = false;
            }
        }

        private void ckballergymeds_CheckedChanged(object sender, EventArgs e)
        {

            if (ckballergymeds.Checked == true)
            {
                txtallergymeds.Enabled = true;
            }

            else if (ckballergymeds.Checked == false)
            {
               txtallergymeds.Enabled = false;
            }
        }

        private void ckbsxmeds_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbsxmeds.Checked == true)
            {
                txtsxmeds.Enabled = true;
            }

            else if (ckbsxmeds.Checked == false)
            {
                txtsxmeds.Enabled = false;
            }
        }

        private void ckbothers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbothers.Checked == true)
            {
                txtothers.Enabled = true;
            }

            else if (ckbothers.Checked == false)
            {
                txtothers.Enabled = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txthospitalnumber.Text == "")
            {
                MessageBox.Show("Please select a patient");
            }

            else if (txtchiefcomplaint.Text == "" || txthpi.Text == "" || ckbhtnmeds.Checked == true && txthtnmeds.Text == ""
                || ckbdmmeds.Checked == true && txtdmmeds.Text == "" || ckbasthmameds.Checked == true && txtasthmameds.Text == ""
                || ckballergymeds.Checked == true && txtallergymeds.Text == "" || ckbsxmeds.Checked == true && txtsxmeds.Text == ""
                || ckbothers.Checked == true && txtothers.Text == "" || txtdiagnosis.Text == "" || txtermanagement.Text == "" 
                || txtbp.Text == "" || txtcr.Text == "" || txtrr.Text == "" || txttemp.Text == "" 
                || txtheent.Text == "" || txtlungs.Text == "" || txtheart.Text == "" || txtabdomen.Text == "" || txtgenitouro.Text == "" 
                || txtextremities.Text == "" || txtneuro.Text == "")
            {
                MessageBox.Show("Please fill up Required fields");
            }

            else
            {
                if (ckbecg.Checked == false && ckbxray.Checked == false && ckbctscan.Checked == false && ckbhematology.Checked == false && 
                    ckburinalysis.Checked == false && ckbfecalysis.Checked == false && ckbbloodbanking.Checked == false && ckbclinicalchem.Checked == false)
                {
                    if (MessageBox.Show("Are you sure you want to save it?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        insertionofchiefcomplaint();
                        ancillarycheckboxs();
                        ancillarybilling();
                        
                        MessageBox.Show("Patient clinical record has been saved");
                        MessageBox.Show("Procced to Billing");

                        

                        txthospitalnumber.Text = "";
                        lblpatientsname.Text = "";
                        lblage.Text = "";
                        lblsex.Text = "";
                        lblbirthdate.Text = "";
                        lblht.Text = "";
                        lblwt.Text = "";
                        lbladdress.Text = "";
                        lbloccupation.Text = "";
                        lblcontact.Text = "";
                        txtchiefcomplaint.Text = "";
                        txthpi.Text = "";
                        ckbhtnmeds.Checked = false;
                        ckbdmmeds.Checked = false;
                        ckbasthmameds.Checked = false;
                        ckballergymeds.Checked = false;
                        ckbsxmeds.Checked = false;
                        ckbothers.Checked = false;
                        txthtnmeds.Text = "";
                        txtdmmeds.Text = "";
                        txtasthmameds.Text = "";
                        txtallergymeds.Text = "";
                        txtsxmeds.Text = "";
                        txtothers.Text = "";
                        txtdiagnosis.Text = "";
                        txtermanagement.Text = "";
                        txtbp.Text = "";
                        txtcr.Text = "";
                        txtrr.Text = "";
                        txttemp.Text = "";
                        txtheart.Text = "";
                        txtlungs.Text = "";
                        txtheart.Text = "";
                        txtabdomen.Text = "";
                        txtgenitouro.Text = "";
                        txtextremities.Text = "";
                        txtneuro.Text = "";
                        txtothers2.Text = "";
                        txtresidentonduty.Text = "";
                        txtheent.Text = "";
                        btnviewancillary.Visible = false;
                        txtmed.Text = "";
                        txtothersfee.Text = "";
                        pictureBox1.Image = null;
                        viewall();

                        connection();
                        query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Save a patient new Clinical record " + "','" + date3 + " " + time3 + "')";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();
                        
                    }
                }

                else if (ckbecg.Checked == true || ckbxray.Checked == true || ckbctscan.Checked == true || ckbhematology.Checked == true ||
                    ckburinalysis.Checked == true || ckbfecalysis.Checked == true || ckbbloodbanking.Checked == true || ckbclinicalchem.Checked == true)
                {   
                    if(MessageBox.Show("Are you sure you want to save it?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        insertionofchiefcomplaint();
                        MessageBox.Show("Patient record has been saved");
                        MessageBox.Show("Procced to Billing");

                        ancillarycheckboxs();
                        ancillarybilling();

                        txthospitalnumber.Text = "";
                        lblpatientsname.Text = "";
                        lblage.Text = "";
                        lblsex.Text = "";
                        lblbirthdate.Text = "";
                        lblht.Text = "";
                        lblwt.Text = "";
                        lbladdress.Text = "";
                        lbloccupation.Text = "";
                        lblcontact.Text = "";
                        txtchiefcomplaint.Text = "";
                        txthpi.Text = "";
                        ckbhtnmeds.Checked = false;
                        ckbdmmeds.Checked = false;
                        ckbasthmameds.Checked = false;
                        ckballergymeds.Checked = false;
                        ckbsxmeds.Checked = false;
                        ckbothers.Checked = false;
                        txthtnmeds.Text = "";
                        txtdmmeds.Text = "";
                        txtasthmameds.Text = "";
                        txtallergymeds.Text = "";
                        txtsxmeds.Text = "";
                        txtothers.Text = "";
                        txtdiagnosis.Text = "";
                        txtermanagement.Text = "";
                        txtbp.Text = "";
                        txtcr.Text = "";
                        txtrr.Text = "";
                        txttemp.Text = "";
                        txtheart.Text = "";
                        txtlungs.Text = "";
                        txtheart.Text = "";
                        txtabdomen.Text = "";
                        txtgenitouro.Text = "";
                        txtextremities.Text = "";
                        txtneuro.Text = "";
                        txtothers2.Text = "";
                        txtresidentonduty.Text = "";
                        txtheent.Text = "";
                        ckbhematology.Checked = false;
                        ckburinalysis.Checked = false;
                        ckbfecalysis.Checked = false;
                        ckbbloodbanking.Checked = false;
                        ckbclinicalchem.Checked = false;
                        ckbecg.Checked = false;
                        ckbctscan.Checked = false;
                        ckbxray.Checked = false;
                        btnviewancillary.Visible = false;
                        txtmed.Text = "";
                        txtothersfee.Text = "";
                        viewall();

                        connection();
                        query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Save a patient new Clinical record " + "','" + date3 + " " + time3 + "')";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        con.Close();
                    }
                }
            }
        
        }

        private void txtchiefcomplaint_TextChanged(object sender, EventArgs e)
        {

            if ((txtchiefcomplaint.Text.Length) == 1)
            {
                txtchiefcomplaint.Text = txtchiefcomplaint.Text[0].ToString().ToUpper();
                txtchiefcomplaint.Select(2, 1);

            }
        }

        private void txthpi_TextChanged(object sender, EventArgs e)
        {
            if ((txthpi.Text.Length) == 1)
            {
                txthpi.Text = txthpi.Text[0].ToString().ToUpper();
                txthpi.Select(2, 1);

            }
        }

        private void txthtnmeds_TextChanged(object sender, EventArgs e)
        {
            if ((txthtnmeds.Text.Length) == 1)
            {
                txthtnmeds.Text = txthtnmeds.Text[0].ToString().ToUpper();
                txthtnmeds.Select(2, 1);

            }
        }

        private void txtdmmeds_TextChanged(object sender, EventArgs e)
        {
            if ((txtdmmeds.Text.Length) == 1)
            {
                txtdmmeds.Text = txtdmmeds.Text[0].ToString().ToUpper();
                txtdmmeds.Select(2, 1);

            }
        }

        private void txtasthmameds_TextChanged(object sender, EventArgs e)
        {
            if ((txtasthmameds.Text.Length) == 1)
            {
                txtasthmameds.Text = txtasthmameds.Text[0].ToString().ToUpper();
                txtasthmameds.Select(2, 1);

            }
        }

        private void txtallergymeds_TextChanged(object sender, EventArgs e)
        {
            if ((txtallergymeds.Text.Length) == 1)
            {
                txtallergymeds.Text = txtallergymeds.Text[0].ToString().ToUpper();
                txtallergymeds.Select(2, 1);

            }
        }

        private void txtsxmeds_TextChanged(object sender, EventArgs e)
        {
            if ((txtsxmeds.Text.Length) == 1)
            {
                txtsxmeds.Text = txtsxmeds.Text[0].ToString().ToUpper();
                txtsxmeds.Select(2, 1);

            }
        }

        private void txtothers_TextChanged(object sender, EventArgs e)
        {
            if ((txtothers.Text.Length) == 1)
            {
                txtothers.Text = txtothers.Text[0].ToString().ToUpper();
                txtothers.Select(2, 1);

            }
        }

        private void txtdiagnosis_TextChanged(object sender, EventArgs e)
        {
            if ((txtdiagnosis.Text.Length) == 1)
            {
                txtdiagnosis.Text = txtdiagnosis.Text[0].ToString().ToUpper();
                txtdiagnosis.Select(2, 1);

            }
        }

        private void txtermanagement_TextChanged(object sender, EventArgs e)
        {

            if ((txtermanagement.Text.Length) == 1)
            {
                txtermanagement.Text = txtermanagement.Text[0].ToString().ToUpper();
                txtermanagement.Select(2, 1);

            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Go Back to Main Menu " + "','" + date3 + " " + time3 + "')";
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
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtresidentonduty_TextChanged(object sender, EventArgs e)
        {
            if ((txtresidentonduty.Text.Length) == 1)
            {
                txtresidentonduty.Text = txtresidentonduty.Text[0].ToString().ToUpper();
                txtresidentonduty.Select(2, 1);

            }
        }

        private void txtresidentonduty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.';
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            selectionofchiefandvital();
            selecttimeanddate();
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "Laboratory")
            {

                pnllaboratory.Visible = true;
                pnlctscan.Visible = false;
                pnlecg.Visible = false;
                pnlxray.Visible = false;
                pnlclinicalrecord.Visible = false;

            }

            else if (cmbsearch.Text == "CT scan")
            {
                pnllaboratory.Visible = false;   
                pnlctscan.Visible = true;
                pnlecg.Visible = false;
                pnlxray.Visible = false;
                pnlclinicalrecord.Visible = false;

                connection();
                lvctscan.Items.Clear();
                query = "select * from db_its.tbl_ctscanresult where hospitalnumber = '"+ txthospitalnumber.Text +"'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    surname = myreader["surname"].ToString();
                    firstname = myreader["firstname"].ToString();
                    middlename = myreader["middlename"].ToString();

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString() +", "+ myreader["firstname"].ToString() +" "+ myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["ctscanresult"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());
                    lvctscan.Items.Add(item);

                }
                con.Close();
                
            }

            else if (cmbsearch.Text == "Clinical Record")
            {
                pnlclinicalrecord.Visible = true;
                pnllaboratory.Visible = false;
                pnlxray.Visible = false;
                pnlecg.Visible = false;
                pnlctscan.Visible = false;

                connection();
                lvclinicalrecord.Items.Clear();
                query = "select * from db_its.tbl_clinicalrecord where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString() + "," + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["chiefcomplaint"].ToString());
                    item.SubItems.Add(myreader["hpi"].ToString());
                    item.SubItems.Add(myreader["htnmeds"].ToString());
                    item.SubItems.Add(myreader["dmmeds"].ToString());
                    item.SubItems.Add(myreader["asthmameds"].ToString());
                    item.SubItems.Add(myreader["allergymeds"].ToString());
                    item.SubItems.Add(myreader["sxmeds"].ToString());
                    item.SubItems.Add(myreader["chiefcomplaintother"].ToString());
                    item.SubItems.Add(myreader["bp"].ToString());
                    item.SubItems.Add(myreader["cr"].ToString());
                    item.SubItems.Add(myreader["rr"].ToString());
                    item.SubItems.Add(myreader["temp"].ToString());
                    item.SubItems.Add(myreader["heent"].ToString());
                    item.SubItems.Add(myreader["lungs"].ToString());
                    item.SubItems.Add(myreader["heart"].ToString());
                    item.SubItems.Add(myreader["abdomen"].ToString());
                    item.SubItems.Add(myreader["genitouro"].ToString());
                    item.SubItems.Add(myreader["extremities"].ToString());
                    item.SubItems.Add(myreader["neuro"].ToString());
                    item.SubItems.Add(myreader["vitalsignother"].ToString());
                    item.SubItems.Add(myreader["diagnosis"].ToString());
                    item.SubItems.Add(myreader["ermanagement"].ToString());
                    item.SubItems.Add(myreader["meds"].ToString());
                    item.SubItems.Add(myreader["residentonduty"].ToString());
                    item.SubItems.Add(myreader["time"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());
                    lvclinicalrecord.Items.Add(item);




                }

                con.Close();
            }

           else if (cmbsearch.Text == "Ecg")
            {
                pnllaboratory.Visible = false;
                pnlecg.Visible = true;
                pnlctscan.Visible = false;
                pnlxray.Visible = false;
                pnlclinicalrecord.Visible = false;

                connection();
                lvecg.Items.Clear();
                query = "select * from db_its.tbl_ecgresult where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    surname = myreader["surname"].ToString();
                    firstname = myreader["firstname"].ToString();
                    middlename = myreader["middlename"].ToString();

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString() + "," + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["ecgresult"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());
                    lvecg.Items.Add(item);

                }
                con.Close();
            
            }

           else if (cmbsearch.Text == "Xray / Utrasound")
            {
                
                pnllaboratory.Visible = false;
                pnlxray.Visible = true;
                pnlecg.Visible = false;
                pnlctscan.Visible = false;
                pnlclinicalrecord.Visible = false;

                connection();
                lvxray.Items.Clear();
                query = "select * from db_its.tbl_xrayresult where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    surname = myreader["surname"].ToString();
                    firstname = myreader["firstname"].ToString();
                    middlename = myreader["middlename"].ToString();

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString() + "," + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["xrayresult"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());
                    lvxray.Items.Add(item);

                }
                con.Close();
                
            }

            
        }

        private void btnviewancillary_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            cmblaboratory.SelectedIndex = -1;
            cmbsearch.SelectedIndex = -1;

            pnlclinicalrecord.Visible = false;
            pnllaboratory.Visible = false;
            pnlctscan.Visible = false;
            pnlctscan.Visible = false;
            pnlxray.Visible = false;
            
            pnlhematology.Visible = false;
            pnlurinalysis.Visible = false;
            pnlfecalysis.Visible = false;
            pnlbloodbanking.Visible = false;
            pnlclinicalchem.Visible = false;
            
           
            lvhematology.Items.Clear();
            lvurinalysis.Items.Clear();
            lvfecalysis.Items.Clear();
            lvbloodbanking.Items.Clear();
            lvclinicalchem.Items.Clear();
            lvctscan.Items.Clear();
            lvecg.Items.Clear();

            clear();
            
            groupBox3.Visible = false;
        }

        private void cmblaboratory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblaboratory.Text == "Hematology")
            {
                pnlhematology.Visible = true;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;
                
                connection();
                lvhematology.Items.Clear();
                query = "select * from db_its.tbl_hematology where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["hemoglobin"].ToString());
                    item.SubItems.Add(myreader["hematocrit"].ToString());
                    item.SubItems.Add(myreader["rbccount"].ToString());
                    item.SubItems.Add(myreader["wbccount"].ToString());
                    item.SubItems.Add(myreader["plateletcount"].ToString());
                    item.SubItems.Add(myreader["differentialcount"].ToString());
                    item.SubItems.Add(myreader["neutrophils"].ToString());
                    item.SubItems.Add(myreader["lymphocytes"].ToString());
                    item.SubItems.Add(myreader["monocytes"].ToString());
                    item.SubItems.Add(myreader["eosinophils"].ToString());
                    item.SubItems.Add(myreader["basophils"].ToString());
                    item.SubItems.Add(myreader["stabs"].ToString());
                    item.SubItems.Add(myreader["others"].ToString());
                    item.SubItems.Add(myreader["othertest"].ToString());
                    item.SubItems.Add(myreader["hematologyid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvhematology.Items.Add(item);
                    



                }
                con.Close();
            }


            if (cmblaboratory.Text == "Urinalysis")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = true;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                connection();
                lvurinalysis.Items.Clear();
                query = "select * from db_its.tbl_urinalysis where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["color"].ToString());
                    item.SubItems.Add(myreader["transparency"].ToString());
                    item.SubItems.Add(myreader["ph"].ToString());
                    item.SubItems.Add(myreader["specificgravity"].ToString());
                    item.SubItems.Add(myreader["sugar"].ToString());
                    item.SubItems.Add(myreader["protein"].ToString());
                    item.SubItems.Add(myreader["redbloodcells"].ToString());
                    item.SubItems.Add(myreader["puscells"].ToString());
                    item.SubItems.Add(myreader["bacteria"].ToString());
                    item.SubItems.Add(myreader["epithelialcells"].ToString());
                    item.SubItems.Add(myreader["mucusthreads"].ToString());
                    item.SubItems.Add(myreader["cast"].ToString());
                    item.SubItems.Add(myreader["crystals"].ToString());
                    item.SubItems.Add(myreader["amorphousmaterials"].ToString());
                    item.SubItems.Add(myreader["othertest"].ToString());
                    item.SubItems.Add(myreader["urinalysisid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvurinalysis.Items.Add(item);
                    


                }
                con.Close();
            }

            if (cmblaboratory.Text == "Fecalysis")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = true;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                connection();
                lvfecalysis.Items.Clear();
                query = "select * from db_its.tbl_fecalysis where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["color"].ToString());
                    item.SubItems.Add(myreader["consistency"].ToString());
                    item.SubItems.Add(myreader["parasites"].ToString());
                    item.SubItems.Add(myreader["leukocytes"].ToString());
                    item.SubItems.Add(myreader["erythrocytes"].ToString());
                    item.SubItems.Add(myreader["fatglobules"].ToString());
                    item.SubItems.Add(myreader["starchgranules"].ToString());
                    item.SubItems.Add(myreader["occultblood"].ToString());
                    item.SubItems.Add(myreader["remark"].ToString());
                    item.SubItems.Add(myreader["fecalysisid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvfecalysis.Items.Add(item);
                    


                }
                con.Close();
             
            }
           
            if (cmblaboratory.Text == "Blood Banking")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = true;
                pnlclinicalchem.Visible = false;

                connection();
                lvbloodbanking.Items.Clear();
                query = "select * from db_its.tbl_bloodbanking  where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["bloodbagserialnumber"].ToString());
                    item.SubItems.Add(myreader["bloodcomponent"].ToString());
                    item.SubItems.Add(myreader["donorcontrolnumber"].ToString());
                    item.SubItems.Add(myreader["donorabobloodtype"].ToString());
                    item.SubItems.Add(myreader["donorrhbloodtype"].ToString());
                    item.SubItems.Add(myreader["patientabobloodtype"].ToString());
                    item.SubItems.Add(myreader["patientrhbloodtype"].ToString());
                    item.SubItems.Add(myreader["immediatespinphase"].ToString());
                    item.SubItems.Add(myreader["enchancementmediaphase"].ToString());
                    item.SubItems.Add(myreader["antihumanglobulinphase"].ToString());
                    item.SubItems.Add(myreader["autocontrol"].ToString());
                    item.SubItems.Add(myreader["othertest"].ToString());
                    item.SubItems.Add(myreader["bloodbankingid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvbloodbanking.Items.Add(item);
                    


                }
                con.Close();
            }

            if (cmblaboratory.Text == "Clinical Chemistry I")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = true;

                connection();
                lvclinicalchem.Items.Clear();
                query = "select * from db_its.tbl_clinicalchem_svalues where hospitalnumber = '" + txthospitalnumber.Text + "'";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + myreader["firstname"].ToString() + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["clinicalchemid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvclinicalchem.Items.Add(item);
                    


                }
                con.Close();
            }
        }

        private void lvhematology_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvhematology.SelectedItems.Count == 0) return;
            ListViewItem item = lvhematology.SelectedItems[0];
            txthemoglobin.Text = item.SubItems[2].Text;
            txthematocrit.Text = item.SubItems[3].Text;
            txtrbccount.Text = item.SubItems[4].Text;
            txtwbccount.Text = item.SubItems[5].Text;
            txtplatelet.Text = item.SubItems[6].Text;
            txtdifferentialcount.Text = item.SubItems[7].Text;
            txtneutrophils.Text = item.SubItems[8].Text;
            txtlymphocytes.Text = item.SubItems[9].Text;
            txtmonocytes.Text = item.SubItems[10].Text;
            txteosinophils.Text = item.SubItems[11].Text;
            txtbasophils.Text = item.SubItems[12].Text;
            txtstabs.Text = item.SubItems[13].Text;
            txtothers.Text = item.SubItems[14].Text;
            txtothertests.Text = item.SubItems[15].Text;

        }

       

        private void lvurinalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvurinalysis.SelectedItems.Count == 0) return;
            ListViewItem item = lvurinalysis.SelectedItems[0];
            txtcolor.Text = item.SubItems[2].Text;
            txttransparency.Text = item.SubItems[3].Text;
            txtph.Text = item.SubItems[4].Text;
            txtspecificgravity.Text = item.SubItems[5].Text;
            txtsugar.Text = item.SubItems[6].Text;
            txtprotein.Text = item.SubItems[7].Text;
            txtredbloodcells.Text = item.SubItems[8].Text;
            txtpuscells.Text = item.SubItems[9].Text;
            txtbacteria.Text = item.SubItems[10].Text;
            txtepithelialcells.Text = item.SubItems[11].Text;
            txtmucusthreads.Text = item.SubItems[12].Text;
            txtcast.Text = item.SubItems[13].Text;
            txtcrystals.Text = item.SubItems[14].Text;
            txtamorphousmaterials.Text = item.SubItems[15].Text;
            txtothertests2.Text = item.SubItems[16].Text;
        }

        private void lvbloodbanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvbloodbanking.SelectedItems.Count == 0) return;
            ListViewItem item = lvbloodbanking.SelectedItems[0];
            txtbloodbagserialnumber.Text = item.SubItems[2].Text;
            txtbloodcomponent.Text = item.SubItems[3].Text;
            txtdonorcontrolnumber.Text = item.SubItems[4].Text;
            txtdonorabobloodtype.Text = item.SubItems[5].Text;
            txtdonorrhbloodtype.Text = item.SubItems[6].Text;
            txtpatientabobloodtype.Text = item.SubItems[7].Text;
            txtpatientrhbloodtype.Text = item.SubItems[8].Text;
            txtimmediatespinphase.Text = item.SubItems[9].Text;
            txtenchancementmediaphase.Text = item.SubItems[10].Text;
            txtantihumanglobinphase.Text = item.SubItems[11].Text;
            txtautocontrol.Text = item.SubItems[12].Text;
            txtothertests3.Text = item.SubItems[13].Text;
            
        }

        private void lvclinicalchem_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionclinicalchemsvalues();
            selectionclinicalchemconventionalvalues();
        }

        private void lvfecalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvfecalysis.SelectedItems.Count == 0) return;
            ListViewItem item = lvfecalysis.SelectedItems[0];
            txtcolor2.Text = item.SubItems[2].Text;
            txtconsistency.Text = item.SubItems[3].Text;
            txtparasites.Text = item.SubItems[4].Text;
            txtleukocytes.Text = item.SubItems[5].Text;
            txterythrocytes.Text = item.SubItems[6].Text;
            txtfatglobules.Text = item.SubItems[7].Text;
            txtstrachgranules.Text = item.SubItems[8].Text;
            txtoccultblood.Text = item.SubItems[9].Text;
            txtremarks.Text = item.SubItems[10].Text;
            
        }

        private void lvctscan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvctscan.SelectedItems.Count == 0) return;
            ListViewItem item = lvctscan.SelectedItems[0];
            txtctscanresult.Text = item.SubItems[2].Text;
            
        }

        private void lvecg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvecg.SelectedItems.Count == 0) return;
            ListViewItem item = lvecg.SelectedItems[0];
            txtecgresult.Text = item.SubItems[2].Text;
        
        }

        private void lvxray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvxray.SelectedItems.Count == 0) return;
            ListViewItem item = lvxray.SelectedItems[0];
            txtxrayresult.Text = item.SubItems[2].Text;
            

        }

        private void txtothersfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void lvclinicalrecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvclinicalrecord.SelectedItems.Count == 0) return;
            ListViewItem item = lvclinicalrecord.SelectedItems[0];
            txthospitalnumber2.Text = item.SubItems[0].Text;
            lblpatientname8.Text = item.SubItems[1].Text;
            txtchiefcomplaint2.Text = item.SubItems[2].Text;
            txthpi2.Text = item.SubItems[3].Text;
            txthtnmeds2.Text = item.SubItems[4].Text;
            txtdmmeds2.Text = item.SubItems[5].Text;
            txtasthmameds2.Text = item.SubItems[6].Text;
            txtallergymeds2.Text = item.SubItems[7].Text;
            txtsxmeds2.Text = item.SubItems[8].Text;
            txtother2.Text = item.SubItems[9].Text;
            txtbp2.Text = item.SubItems[10].Text;
            txtcr2.Text = item.SubItems[11].Text;
            txtrr2.Text = item.SubItems[12].Text;
            txttemp2.Text = item.SubItems[13].Text;
            txtheent2.Text = item.SubItems[14].Text;
            txtlungs2.Text = item.SubItems[15].Text;
            txtheart2.Text = item.SubItems[16].Text;
            txtabdomen2.Text = item.SubItems[17].Text;
            txtgenitouro2.Text = item.SubItems[18].Text;
            txtextremities2.Text = item.SubItems[19].Text;
            txtneuro2.Text = item.SubItems[20].Text;
            txtothers3.Text = item.SubItems[21].Text;
            txtdiagnosis2.Text = item.SubItems[22].Text;
            txtermanagement2.Text = item.SubItems[23].Text;
            txtmeds.Text = item.SubItems[24].Text;
            lblphysician.Text = item.SubItems[25].Text;
            lbldate9.Text = item.SubItems[27].Text;
        }

        
    }
}
