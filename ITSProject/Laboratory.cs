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
    public partial class Laboratory : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Laboratory()
        {
            InitializeComponent();
            viewall();

            Timer DateTimer = new Timer();
            DateTimer.Interval = 1000;
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss");
        
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date, time, surname, firstname, middlename, hospitalnumber, date2, time2;

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
            listView1.Items.Clear();
            query = "select * from db_its.tbl_laboratorypendingcheckup where hematology = '" + "Yes" + "' or urinalysis = '" + "Yes" + "' or fecalysis = '" + "Yes" + "' or bloodbanking = '" + "Yes" + "' or clinicalchem = '" + "Yes" + "'";
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
                listView1.Items.Add(item);
            }

            con.Close();
        }

        private void Laboratory_Load(object sender, EventArgs e)
        {
            hematologyid();
            urinalysisid();
            fecalysisid();
            bloodbankingid();
            clinicalchemid();
            deletionofpendingcheckup();

            timer1.Start();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void selectphysician()
        {
            

            connection();
            query = "select * from db_its.tbl_laboratorypendingcheckup where hospitalnumber = '" + hospitalnumber + "' order by patientcount desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                txtphysician.Text = myreader["physician"].ToString();
                txtphysician2.Text = myreader["physician"].ToString();
                txtphysician3.Text = myreader["physician"].ToString();
                txtphysician4.Text = myreader["physician"].ToString();
                txtphysician5.Text = myreader["physician"].ToString();

                con.Close();
            }
        }   
      
        private void DateTimer_Tick(Object sender, EventArgs e)
        {

       
            date = DateTime.Now.ToString("MMMM dd, yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");

        }

        public void hematologyid()
        {
           
            connection();
            query = "select * from db_its.tbl_hematology order by hospitalnumber desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                int count = myreader["hematologyid"].ToString().Length;

                if (count == 5)
                {
                    string hematologyid = myreader["hematologyid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["hematologyid"].ToString().Substring(4, 1)) + 1;

                    lblhematologyid.Text = hematologyid + id;
                }

                if (count == 6)
                {
                    string hematologyid = myreader["hematologyid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["hematologyid"].ToString().Substring(4, 2)) + 1;

                    lblhematologyid.Text = hematologyid + id;
                }

                if (count == 7)
                {
                    string hematologyid = myreader["hematologyid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["hematologyid"].ToString().Substring(4, 3)) + 1;

                    lblhematologyid.Text = hematologyid + id;
                }


                if (count == 8)
                {
                    string hematologyid = myreader["hematologyid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["hematologyid"].ToString().Substring(4, 4)) + 1;

                    lblhematologyid.Text = hematologyid + id;
                }
            }

            con.Close();
        }

        public void urinalysisid()
        {

            connection();
            query = "select * from db_its.tbl_urinalysis order by hospitalnumber desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                int count = myreader["urinalysisid"].ToString().Length;

                if (count == 6)
                {
                    string urinalysis = myreader["urinalysisid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["urinalysisid"].ToString().Substring(5, 1)) + 1;

                    lblurinalysisid.Text = urinalysis + id;
                }

                if (count == 7)
                {
                    string urinalysis = myreader["urinalysisid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["urinalysisid"].ToString().Substring(5, 2)) + 1;

                    lblurinalysisid.Text = urinalysis + id;
                }

                if (count == 8)
                {
                    string urinalysis = myreader["urinalysisid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["urinalysisid"].ToString().Substring(5, 3)) + 1;

                    lblurinalysisid.Text = urinalysis + id;
                }

                if (count == 9)
                {
                    string urinalysis = myreader["urinalysisid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["urinalysisid"].ToString().Substring(5, 4)) + 1;

                    lblurinalysisid.Text = urinalysis + id;
                }
            }

            con.Close();
        }

        public void fecalysisid()
        {

            connection();
            query = "select * from db_its.tbl_fecalysis order by hospitalnumber desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                int count = myreader["fecalysisid"].ToString().Length;

                if (count == 5)
                {
                    string fecalysisid = myreader["fecalysisid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["fecalysisid"].ToString().Substring(4, 1)) + 1;

                    lblfecalysisid.Text = fecalysisid + id;
                }

                if (count == 6)
                {
                    string fecalysisid = myreader["fecalysisid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["fecalysisid"].ToString().Substring(4, 2)) + 1;

                    lblfecalysisid.Text = fecalysisid + id;
                }


                if (count == 7)
                {
                    string fecalysisid = myreader["fecalysisid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["fecalysisid"].ToString().Substring(4, 3)) + 1;

                    lblfecalysisid.Text = fecalysisid + id;
                }

                if (count == 8)
                {
                    string fecalysisid = myreader["fecalysisid"].ToString().Substring(0, 4);
                    id = int.Parse(myreader["fecalysisid"].ToString().Substring(4, 4)) + 1;

                    lblfecalysisid.Text = fecalysisid + id;
                }
            }

            con.Close();
        }

        public void bloodbankingid()
        {

            connection();
            query = "select * from db_its.tbl_bloodbanking order by hospitalnumber desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                int count = myreader["bloodbankingid"].ToString().Length;

                if (count == 6)
                {
                    string bloodbanking = myreader["bloodbankingid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["bloodbankingid"].ToString().Substring(5, 1)) + 1;

                    lblbloodbankingid.Text = bloodbanking + id;
                }


                if (count == 7)
                {
                    string bloodbanking = myreader["bloodbankingid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["bloodbankingid"].ToString().Substring(5, 2)) + 1;

                    lblbloodbankingid.Text = bloodbanking + id;
                }


                if (count == 8)
                {
                    string bloodbanking = myreader["bloodbankingid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["bloodbankingid"].ToString().Substring(5, 3)) + 1;

                    lblbloodbankingid.Text = bloodbanking + id;
                }

                if (count == 9)
                {
                    string bloodbanking = myreader["bloodbankingid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["bloodbankingid"].ToString().Substring(5, 4)) + 1;

                    lblbloodbankingid.Text = bloodbanking + id;
                }
       
            
            }

            con.Close();
        }

        public void clinicalchemid()
        {

            connection();
            query = "select * from db_its.tbl_clinicalchem_svalues order by hospitalnumber desc";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                int count = myreader["clinicalchemid"].ToString().Length;

                if (count == 6)
                {
                    string clinicalchemid = myreader["clinicalchemid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["clinicalchemid"].ToString().Substring(5, 1)) + 1;

                    lblclinicalchemid.Text = clinicalchemid + id;
                }

                if (count == 7)
                {
                    string clinicalchemid = myreader["clinicalchemid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["clinicalchemid"].ToString().Substring(5, 2)) + 1;

                    lblclinicalchemid.Text = clinicalchemid + id;
                }

                if (count == 8)
                {
                    string clinicalchemid = myreader["clinicalchemid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["clinicalchemid"].ToString().Substring(5, 3)) + 1;

                    lblclinicalchemid.Text = clinicalchemid + id;
                }

                if (count == 9)
                {
                    string clinicalchemid = myreader["clinicalchemid"].ToString().Substring(0, 5);
                    id = int.Parse(myreader["clinicalchemid"].ToString().Substring(5, 4)) + 1;

                    lblclinicalchemid.Text = clinicalchemid + id;
                }
            
            }

            con.Close();
        }

        public void choosenlab()
        {
            string hematology, urinalysis, fecalysis, bloodbanking, clinicalchem;
            connection();
            query = "select * from db_its.tbl_laboratorypendingcheckup where hospitalnumber = '"+ hospitalnumber +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                hematology = myreader["hematology"].ToString();
                urinalysis = myreader["urinalysis"].ToString();
                fecalysis = myreader["fecalysis"].ToString();
                bloodbanking = myreader["bloodbanking"].ToString();
                clinicalchem = myreader["clinicalchem"].ToString();

                if (hematology == "Yes")
                {
                    hematologyToolStripMenuItem.Enabled = true;
                }

                if (urinalysis == "Yes")
                {
                    urinalysisToolStripMenuItem.Enabled = true;
                }

                if (fecalysis == "Yes")
                {
                    fecalysisToolStripMenuItem.Enabled = true;
                }

                if (bloodbanking == "Yes")
                {
                    bloodBankingToolStripMenuItem.Enabled = true;
                }

                if (clinicalchem == "Yes")
                {
                    clinicalChemistry1ToolStripMenuItem.Enabled = true;
                }

                if (hematology == "No")
                {
                    hematologyToolStripMenuItem.Enabled = false;
                }

                if (urinalysis == "No")
                {
                    urinalysisToolStripMenuItem.Enabled = false;
                }

                if (fecalysis == "No")
                {
                    fecalysisToolStripMenuItem.Enabled = false;
                }

                if (bloodbanking == "No")
                {
                    bloodBankingToolStripMenuItem.Enabled = false;
                }

                if (clinicalchem == "No")
                {
                    clinicalChemistry1ToolStripMenuItem.Enabled = false;
                }
            
            }
            con.Close();
        }

        public void inserthematology()
        {
            connection();
            query = "insert into db_its.tbl_hematology (hospitalnumber, surname, firstname, middlename, age, sex, physician, service, hematologyid, hemoglobin, hematocrit, rbccount, wbccount, plateletcount, differentialcount, neutrophils, lymphocytes, monocytes, eosinophils, basophils, stabs, others, othertest, date) values ('" + hospitalnumber + "','"
                + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + txtphysician.Text + "','" + lbloutpatient.Text + "','" + lblhematologyid.Text + "','" + txthemoglobin.Text + "','" + txthematocrit.Text.Replace(".", ".") + "','" + txtrbccount.Text.Replace(".", ".") + "','" + txtwbccount.Text + "','"
                + txtplatelet.Text + "','" + txtdifferentialcount.Text + "','" + txtneutrophils.Text + "','" + txtlymphocytes.Text + "','" + txtmonocytes.Text + "','" + txteosinophils.Text + "','" + txtbasophils.Text + "','" + txtstabs.Text + "','" + txtothers.Text + "','" + txtothertests.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void insertionurinalysis()
        {
            connection();
            query = "insert into db_its.tbl_urinalysis (hospitalnumber, surname, firstname, middlename, age, sex, physician, roomcompany, urinalysisid, color, transparency, ph, specificgravity, sugar, protein, redbloodcells, puscells, bacteria, epithelialcells, mucusthreads, cast, crystals, amorphousmaterials, othertest, date) values ('" + hospitalnumber + "','"
                + surname + "','" + firstname + "','" + middlename + "','" + lblage2.Text + "','" + lblsex2.Text + "','" + txtphysician2.Text + "','" + lbloutpatient2.Text + "','" + lblurinalysisid.Text + "','" + txtcolor.Text + "','" + txttransparency.Text + "','" + txtph.Text.Replace(".", ".") + "','" + txtspecificgravity.Text.Replace(".", ".") + "','" + txtsugar.Text + "','" + txtprotein.Text + "','"
                + txtredbloodcells.Text + "','" + txtpuscells.Text + "','" + txtbacteria.Text + "','" + txtepithelialcells.Text + "','" + txtmucusthreads.Text + "','" + txtcast.Text + "','" + txtcrystals.Text + "','" + txtamorphousmaterials.Text + "','" + txtothertests2.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void insertionfecalysis()
        {
            connection();
            query = "insert into db_its.tbl_fecalysis (hospitalnumber, surname, firstname, middlename, age, sex, physician, service, fecalysisid, color, consistency, parasites, leukocytes, erythrocytes, fatglobules, starchgranules, occultblood, remark, date) values ('" + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage3.Text + "','"
                + lblsex3.Text + "','" + txtphysician3.Text + "','" + lbler.Text + "','" + lblfecalysisid.Text + "','" + txtcolor2.Text + "','" + txtconsistency.Text + "','" + txtparasites.Text + "','" + txtleukocytes.Text + "','" + txterythrocytes.Text + "','" + txtfatglobules.Text + "','" + txtstrachgranules.Text + "','" + txtoccultblood.Text + "','" + txtremarks.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void insertionbloodbanking()
        {
            connection();
            query = "insert into db_its.tbl_bloodbanking (hospitalnumber, surname, firstname, middlename, age, sex, physician, service, bloodbankingid, bloodbagserialnumber, bloodcomponent, donorcontrolnumber, donorabobloodtype, donorrhbloodtype, patientabobloodtype, patientrhbloodtype, immediatespinphase, enchancementmediaphase, antihumanglobulinphase, autocontrol, othertest, date) values ('" + hospitalnumber + "','" 
                + surname + "','" + firstname + "','" + middlename + "','" + lblage4.Text + "','" + lblsex4.Text + "','" + txtphysician4.Text + "','" + lbler2.Text + "','" + lblbloodbankingid.Text + "','" + txtbloodbagserialnumber.Text + "','" + txtbloodcomponent.Text + "','" + txtdonorcontrolnumber.Text + "','" + txtdonorabobloodtype.Text + "','" + txtdonorrhbloodtype.Text + "','"
                + txtpatientabobloodtype.Text + "','" + txtpatientrhbloodtype.Text + "','" + txtimmediatespinphase.Text + "','" + txtenchancementmediaphase.Text + "','" + txtantihumanglobinphase.Text + "','" + txtautocontrol.Text + "','" + txtothertests3.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void insertionclinicalchem_svalues()
        {
            connection();
            query = "insert into db_its.tbl_clinicalchem_svalues (hospitalnumber, surname, firstname, middlename, age, sex, physician, service, clinicalchemid, glucose, ureanitrogen, creatinine, uricacid, triglycerides, cholesterol, hdl, ldl, sgpt, sgot, sodium, potassium, chloride, remarks, date) values ('" + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage5.Text + "','"
                + lblsex5.Text + "','" + txtphysician5.Text + "','" + lbloutpatient3.Text + "','" + lblclinicalchemid.Text + "','" + txtglucose.Text.Replace(".", ".") + "','" + txtureanitrogen.Text.Replace(".", ".") + "','" + txtcreatinine.Text + "','" + txturicacid.Text + "','" + txttriglycerides.Text.Replace(".", ".") + "','" + txtcholesterol.Text.Replace(".", ".") + "','" + txthdl.Text.Replace(".", ".") + "','" + txtldl.Text.Replace(".", ".") + "','" + txtsgpt.Text + "','" + txtsgot.Text + "','"
                + txtsodium.Text + "','" + txtpotassium.Text.Replace(".", ".") + "','" + txtchloride.Text + "','" + txtremarks2.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void insertionclinicalchem_conventionalvalues()
        {
            connection();
            query = "insert into db_its.tbl_clinicalchem_conventionalvalues (hospitalnumber, surname, firstname, middlename, age, sex, physician, service, clinicalchemid, glucose, ureanitrogen, creatinine, uricacid, triglycerides, cholesterol, hdl, ldl, sgpt, sgot, sodium, potassium, chloride, remarks, date) values ('" + hospitalnumber + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage5.Text + "','"
                + lblsex5.Text + "','" + txtphysician5.Text + "','" + lbloutpatient3.Text + "','" + lblclinicalchemid.Text + "','" + txtglucose2.Text.Replace(".", ".") + "','" + txtureanitrogen2.Text.Replace(".", ".") + "','" + txtcreatinine2.Text + "','" + txturicacid2.Text + "','" + txttriglycerides2.Text.Replace(".", ".") + "','" + txtcholesterol2.Text.Replace(".", ".") + "','" + txthdl2.Text.Replace(".", ".") + "','" + txtldl2.Text.Replace(".", ".") + "','" + txtsgpt2.Text + "','" + txtsgot2.Text + "','"
                + txtsodium2.Text + "','" + txtpotassium2.Text.Replace(".", ".") + "','" + txtchloride2.Text + "','" + txtremarks2.Text.Replace("'", "''") + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatependingcheckuphematolgy()
        {
            connection();
            query = "update db_its.tbl_laboratorypendingcheckup set hematology = '"+ "No" +"' where hospitalnumber = '"+ hospitalnumber +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatependingcheckupurinalysis()
        {
            connection();
            query = "update db_its.tbl_laboratorypendingcheckup set urinalysis = '" + "No" + "' where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatependingcheckupfecalysis()
        {
            connection();
            query = "update db_its.tbl_laboratorypendingcheckup set fecalysis = '" + "No" + "' where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatependingcheckupbloodbanking()
        {
            connection();
            query = "update db_its.tbl_laboratorypendingcheckup set bloodbanking = '" + "No" + "' where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void updatependingcheckupclinicalchem()
        {
            connection();
            query = "update db_its.tbl_laboratorypendingcheckup set clinicalchem = '" + "No" + "' where hospitalnumber = '" + hospitalnumber + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void clear()
        {
            lblpatientname.Text = "";
            lblpatientname2.Text = "";
            lblpatientname3.Text = "";
            lblpatientname4.Text = "";
            lblpatientname5.Text = "";

            lblage.Text = "";
            lblage2.Text = "";
            lblage3.Text = "";
            lblage4.Text = "";
            lblage5.Text = "";

            lblsex.Text = "";
            lblsex2.Text = "";
            lblsex3.Text = "";
            lblsex4.Text = "";
            lblsex5.Text = "";

            lbldate.Text = "";
            lbldate2.Text = "";
            lbldate3.Text = "";
            lbldate4.Text = "";
            lbldate5.Text = "";

            txtphysician.Text = "";
            txtphysician2.Text = "";
            txtphysician3.Text = "";
            txtphysician4.Text = "";
            txtphysician5.Text = "";

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
            txttransparency.SelectedIndex = -1;
            txtph.Text = "";
            txtspecificgravity.Text = "";
            txtsugar.SelectedIndex = -1;
            txtprotein.SelectedIndex = -1;
            txtredbloodcells.Text = "";
            txtpuscells.Text = "";
            txtbacteria.SelectedIndex = -1;
            txtepithelialcells.SelectedIndex = -1;
            txtmucusthreads.SelectedIndex = -1;
            txtcast.SelectedIndex = -1;
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

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;

        }

        public void deletionofpendingcheckup()
        {
            connection();
            query = "delete from db_its.tbl_laboratorypendingcheckup where hematology = '" + "No" + "' and urinalysis = '"+ "No" +"' and fecalysis = '"+ "No" +"' and bloodbanking = '"+ "No" +"' and clinicalchem = '"+ "No" +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
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
                listView1.Items.Clear();
                query = "select * from db_its.tbl_laboratorypendingcheckup where hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%'";
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
                    listView1.Items.Add(item);
                }
                con.Close();
                choosenlab();
            }
        }

       
        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_laboratorypendingcheckup where hematology = '"+ "Yes" +"' or urinalysis = '"+ "Yes" +"' or fecalysis = '"+ "Yes" +"' or bloodbanking = '"+ "Yes" +"' or clinicalchem = '"+ "Yes" +"'";
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
                listView1.Items.Add(item);
            }

            con.Close();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.listView1.SelectedItems.Count <= 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem item = listView1.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname.Text = item.SubItems[1].Text +", "+ item.SubItems[2].Text +" "+ item.SubItems[3].Text;
                lblage.Text = item.SubItems[4].Text;
                lblsex.Text = item.SubItems[5].Text;
                lbldate.Text = date;


                lblpatientname2.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage2.Text = item.SubItems[4].Text;
                lblsex2.Text = item.SubItems[5].Text;
                lbldate2.Text = date;


                lblpatientname3.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage3.Text = item.SubItems[4].Text;
                lblsex3.Text = item.SubItems[5].Text;
                lbldate3.Text = date;

                lblpatientname4.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage4.Text = item.SubItems[4].Text;
                lblsex4.Text = item.SubItems[5].Text;
                lbldate4.Text = date;

                lblpatientname5.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblage5.Text = item.SubItems[4].Text;
                lblsex5.Text = item.SubItems[5].Text;
                lbldate5.Text = date;

                surname = item.SubItems[1].Text;
                firstname = item.SubItems[2].Text;
                middlename = item.SubItems[3].Text;

                choosenlab();

                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        pictureBox5.Image = null;
                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox4.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox5.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                        con.Close();
                    }
                }

            }

            catch
            {
 
            }
        
        }

        private void hematologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlhematology.Visible = true;
            pnlurinalysis.Visible = false;
            pnlfecalysis.Visible = false;
            pnlbloodbanking.Visible = false;
            pnlclinicalchem.Visible = false;

            selectphysician();

        }
        
        private void urinalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlhematology.Visible = false;
            pnlurinalysis.Visible = true;
            pnlfecalysis.Visible = false;
            pnlbloodbanking.Visible = false;
            pnlclinicalchem.Visible = false;

            selectphysician();
        }
          
        private void fecalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlhematology.Visible = false;
            pnlurinalysis.Visible = false;
            pnlfecalysis.Visible = true;
            pnlbloodbanking.Visible = false;
            pnlclinicalchem.Visible = false;

            selectphysician();
        }
        
        private void bloodBankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlhematology.Visible = false;
            pnlurinalysis.Visible = false;
            pnlfecalysis.Visible = false;
            pnlbloodbanking.Visible = true;
            pnlclinicalchem.Visible = false;

            selectphysician();
        }
        
        private void clinicalChemistry1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlhematology.Visible = false;
            pnlurinalysis.Visible = false;
            pnlfecalysis.Visible = false;
            pnlbloodbanking.Visible = false;
            pnlclinicalchem.Visible = true;

            selectphysician();
        }
       
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtphysician.Text == "")
            {
                MessageBox.Show("Please type Physician name");
            }

            else if (txthemoglobin.Text == "" || txthematocrit.Text == ""
                || txtrbccount.Text == "" || txtwbccount.Text == "" || txtplatelet.Text == ""
                || txtdifferentialcount.Text == "" || txtneutrophils.Text == ""
                || txtlymphocytes.Text == "" || txtmonocytes.Text == ""
                || txteosinophils.Text == "" || txtbasophils.Text == "" || txtstabs.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a Hematogy result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                inserthematology();
                updatependingcheckuphematolgy();
                listView1.Items.Clear();
                deletionofpendingcheckup();
                hematologyid();
                MessageBox.Show("Patient Hematology result has been saved. Come back tommorow for the result.");
                clear();

                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                viewall();
            }
        }

        private void txthemoglobin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txthematocrit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtrbccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtwbccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtplatelet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtneutrophils_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtlymphocytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtmonocytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txteosinophils_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtbasophils_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtstabs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtphysician_TextChanged(object sender, EventArgs e)
        {
            if ((txtphysician.Text.Length) == 1)
            {
                txtphysician.Text = txtphysician.Text[0].ToString().ToUpper();
                txtphysician.Select(2, 1);

            }
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            if (txtphysician2.Text == "")
            {
                MessageBox.Show("Please type Physician name");
            }
            else if (txtcolor.Text == "" || txttransparency.Text == "" || txtph.Text == "" || txtspecificgravity.Text == "" || txtsugar.Text == "" || txtprotein.Text == ""
                || txtredbloodcells.Text == "" || txtpuscells.Text == "" || txtepithelialcells.Text == "" || txtmucusthreads.Text == "" || txtcast.Text == ""
                || txtcrystals.Text == "" || txtamorphousmaterials.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a Urinalysis result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                insertionurinalysis();
                updatependingcheckupurinalysis();
                listView1.Items.Clear();
                deletionofpendingcheckup();
                urinalysisid();
                MessageBox.Show("Patient Urinalysis test has been saved. Come back tommorow for the result.");
                clear();

                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                viewall();
            }
        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar))); 
        }

        private void txtph_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtspecificgravity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtsugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)); 
        }

        private void txtprotein_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)); 
        }

        private void txtredbloodcells_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtpuscells_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtbacteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtepithelialcells_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtmucusthreads_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtcast_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void btnsave3_Click(object sender, EventArgs e)
        {
            if (txtphysician3.Text == "")
            {
                MessageBox.Show("Please type Physician name");
            }

            else if (txtcolor2.Text == "" || txtconsistency.Text == "" || txtparasites.Text == "" || txtleukocytes.Text == ""
                 || txterythrocytes.Text == "" || txtfatglobules.Text == "" || txtstrachgranules.Text == "" || txtoccultblood.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a Fecalysis result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                insertionfecalysis();
                updatependingcheckupfecalysis();
                listView1.Items.Clear();
                deletionofpendingcheckup();
                fecalysisid();
                MessageBox.Show("Patient Fecalysis result has been saved. Come back tommorow for the result.");
                clear();

                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                viewall();
            }

        
        }

        private void btnsave4_Click(object sender, EventArgs e)
        {
            if (txtphysician4.Text == "")
            {
                MessageBox.Show("Please type Physician name");
            }

           else if (txtbloodbagserialnumber.Text.Length < 13)
            {

                MessageBox.Show("Invalid Bag Serial Number.");
                
            }
            
            else if ( txtbloodcomponent.Text == ""
               || txtdonorcontrolnumber.Text == "" || txtdonorabobloodtype.Text == ""
               || txtdonorrhbloodtype.Text == "" || txtimmediatespinphase.Text == ""
               || txtenchancementmediaphase.Text == "" || txtantihumanglobinphase.Text == ""
               || txtautocontrol.Text == "")
            {
                MessageBox.Show("Please fill up all fields.");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a Blood Banking result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                insertionbloodbanking();
                updatependingcheckupbloodbanking();
                listView1.Items.Clear();
                deletionofpendingcheckup();
                bloodbankingid();
                MessageBox.Show("Patient Blood Banking result has been saved. Come back tommorow for the result.");
                clear();

                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;

                viewall();
            }

        }

        private void txtglucose_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtureanitrogen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtcreatinine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txturicacid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txttriglycerides_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtcholesterol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txthdl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtldl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtsgpt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtsgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtsodium_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtpotassium_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtchloride_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtglucose2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtureanitrogen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtcreatinine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txturicacid2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txttriglycerides2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtcholesterol2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txthdl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtldl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtsgpt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtsgot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtsodium2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void txtpotassium2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void txtchloride2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void btnsave5_Click(object sender, EventArgs e)
        {
            if (txtphysician5.Text == "")
            {
                MessageBox.Show("Please type Physician name");
            }

            else if (txtglucose.Text == "" || txtureanitrogen.Text == "" || txtcreatinine.Text == "" || txturicacid.Text == "" || txttriglycerides.Text == "" 
                || txtcholesterol.Text == "" || txthdl.Text == "" || txtldl.Text == "" || txtsgpt.Text == "" || txtsgot.Text == "" || txtsodium.Text == "" || txtpotassium.Text == "" 
                || txtchloride.Text == "" || txtglucose2.Text == "" || txtureanitrogen2.Text == "" || txtcreatinine2.Text == "" || txturicacid2.Text == "" || txttriglycerides2.Text == "" 
                || txtcholesterol2.Text == "" || txthdl2.Text == "" || txtldl2.Text == "" || txtsgpt2.Text == "" || txtsgot2.Text == "" || txtsodium2.Text == "" || txtpotassium2.Text == "" || txtchloride2.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
            }

            else
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Add a Clinical Chemistry I result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                insertionclinicalchem_svalues();
                insertionclinicalchem_conventionalvalues();
                updatependingcheckupclinicalchem();
                listView1.Items.Clear();
                deletionofpendingcheckup();
                clinicalchemid();

                MessageBox.Show("Patient Clinical Chemistry result has been saved. Come back tommorow for the result.");
                clear();
                viewall();
                
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;
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

        private void txtphysician2_TextChanged(object sender, EventArgs e)
        {
            if ((txtphysician2.Text.Length) == 1)
            {
                txtphysician2.Text = txtphysician2.Text[0].ToString().ToUpper();
                txtphysician2.Select(2, 1);

            }
        }

        private void txtphysician5_TextChanged(object sender, EventArgs e)
        {
            if ((txtphysician5.Text.Length) == 1)
            {
                txtphysician5.Text = txtphysician5.Text[0].ToString().ToUpper();
                txtphysician5.Select(2, 1);

            }
        }

        private void txtphysician4_TextChanged(object sender, EventArgs e)
        {
            if ((txtphysician4.Text.Length) == 1)
            {
                txtphysician4.Text = txtphysician4.Text[0].ToString().ToUpper();
                txtphysician4.Select(2, 1);

            }
        }

        private void txtphysician3_TextChanged(object sender, EventArgs e)
        {
            if ((txtphysician3.Text.Length) == 1)
            {
                txtphysician3.Text = txtphysician3.Text[0].ToString().ToUpper();
                txtphysician3.Select(2, 1);

            }
        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {
            if ((txtcolor.Text.Length) == 1)
            {
                txtcolor.Text = txtcolor.Text[0].ToString().ToUpper();
                txtcolor.Select(2, 1);

            }
        }

        private void txtbacteria_TextChanged(object sender, EventArgs e)
        {
            if ((txtbacteria.Text.Length) == 1)
            {
                txtbacteria.Text = txtbacteria.Text[0].ToString().ToUpper();
                txtbacteria.Select(2, 1);

            }
        }

        private void txtepithelialcells_TextChanged(object sender, EventArgs e)
        {
            if ((txtepithelialcells.Text.Length) == 1)
            {
                txtepithelialcells.Text = txtepithelialcells.Text[0].ToString().ToUpper();
                txtepithelialcells.Select(2, 1);

            }
        }

        private void txtmucusthreads_TextChanged(object sender, EventArgs e)
        {
            if ((txtmucusthreads.Text.Length) == 1)
            {
                txtmucusthreads.Text = txtmucusthreads.Text[0].ToString().ToUpper();
                txtmucusthreads.Select(2, 1);

            }
        }

        private void txtcast_TextChanged(object sender, EventArgs e)
        {
            if ((txtcast.Text.Length) == 1)
            {
                txtcast.Text = txtcast.Text[0].ToString().ToUpper();
                txtcast.Select(2, 1);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;

                hematologyid();
                urinalysisid();
                fecalysisid();
                bloodbankingid();
                clinicalchemid();
                deletionofpendingcheckup();
            }

            else
            {
                time1 = 5;
            }
        }

        private void txtcolor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

        private void txtconsistency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)); 
        }

     

    }
}
