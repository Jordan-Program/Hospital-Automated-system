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
    public partial class Result : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public Result()
        {
            InitializeComponent();

            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            time2 = DateTime.Now.ToString("hh:mm:ss");
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date, hospitalnumber, surname, firstname, middlename, hemaphysician, date2, time2;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        public void viewall()
        {
            connection();
            lvclinicalrecord.Items.Clear();
            query = "select * from db_its.tbl_clinicalrecord";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

            connection();
            lvhematology.Items.Clear();
            query = "select * from db_its.tbl_hematology";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                hospitalnumber = myreader["hospitalnumber"].ToString();


                var item = new ListViewItem();
                item.Text = (myreader["hospitalnumber"].ToString());
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

            connection();
            lvxray.Items.Clear();
            query = "select * from db_its.tbl_xrayresult";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["xrayresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvxray.Items.Add(item);

            }
            con.Close();
        }

        public void selectionclinicalchemsvalues()
        {
            connection();
            query = "select * from db_its.tbl_clinicalchem_svalues where hospitalnumber = '" + hospitalnumber + "'";
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
            query = "select * from db_its.tbl_clinicalchem_conventionalvalues where hospitalnumber = '" + hospitalnumber + "'";
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

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            lvclinicalrecord.Items.Clear();
            query = "select * from db_its.tbl_clinicalrecord";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearchbox.Text == "")
            {
                MessageBox.Show("Please insert either Patient - ID or Patient Surname");

            }

            else
            {
                connection();
                lvclinicalrecord.Items.Clear();
                query = "select * from db_its.tbl_clinicalrecord  where hospitalnumber like '%" + txtsearchbox.Text + "%' or surname like '%" + txtsearchbox.Text + "%' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    var item = new ListViewItem();
                    item.Text = myreader["hospitalnumber"].ToString();
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["chiefcomplaint"].ToString());
                    item.SubItems.Add(myreader["hpi"].ToString());
                    item.SubItems.Add(myreader["htnmeds"].ToString());
                    item.SubItems.Add(myreader["dmmeds"].ToString());
                    item.SubItems.Add(myreader["asthmameds"].ToString());
                    item.SubItems.Add(myreader["allergymeds"].ToString());
                    item.SubItems.Add(myreader["sxmeds"].ToString());
                    item.SubItems.Add(myreader["chiefcomplaintother"].ToString());
                    item.SubItems.Add(myreader["diagnosis"].ToString());
                    item.SubItems.Add(myreader["ermanagement"].ToString());
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
                    item.SubItems.Add(myreader["residentonduty"].ToString());
                    item.SubItems.Add(myreader["time"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());


                    lvclinicalrecord.Items.Add(item);
                   


                }
                con.Close();
            }



        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearch.Text == "Clinical Record")
            {
                pnlclinicalrecord.Visible = true;
                pnllaboratory.Visible = false;
                pnlxray.Visible = false;
                pnlexg.Visible = false;
                pnlctscan.Visible = false;
                pnlmedicalrecord.Visible = false;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

            if (cmbsearch.Text == "Laboratory")
            {
                pnlclinicalrecord.Visible = false;
                pnllaboratory.Visible = true;
                pnlxray.Visible = false;
                pnlexg.Visible = false;
                pnlctscan.Visible = false;
                pnlmedicalrecord.Visible = false;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

            if (cmbsearch.Text == "Xray / Utrasound")
            {
                pnlclinicalrecord.Visible = false;
                pnllaboratory.Visible = false;
                pnlxray.Visible = true;
                pnlexg.Visible = false;
                pnlctscan.Visible = false;
                pnlmedicalrecord.Visible = false;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

            if (cmbsearch.Text == "Ecg")
            {
                pnlclinicalrecord.Visible = false;
                pnllaboratory.Visible = false;
                pnlxray.Visible = false;
                pnlexg.Visible = true;
                pnlctscan.Visible = false;
                pnlmedicalrecord.Visible = false;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

            if (cmbsearch.Text == "CT scan")
            {
                pnlclinicalrecord.Visible = false;
                pnllaboratory.Visible = false;
                pnlxray.Visible = false;
                pnlexg.Visible = false;
                pnlctscan.Visible = true;
                pnlmedicalrecord.Visible = false;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

            if (cmbsearch.Text == "Medical Record")
            {
                pnlclinicalrecord.Visible = false;
                pnllaboratory.Visible = false;
                pnlxray.Visible = false;
                pnlexg.Visible = false;
                pnlctscan.Visible = false;
                pnlmedicalrecord.Visible = true;
                lvclinicalrecord.Items.Clear();
                lvxray.Items.Clear();
                lvecg.Items.Clear();
                lvctscan.Items.Clear();
                lvmaleward.Items.Clear();
                lvfemaleward.Items.Clear();
                lvobgyne.Items.Clear();
                lvsurgical.Items.Clear();
                lvpediatric.Items.Clear();
                lvisolation.Items.Clear();
            }

        }

        private void btnviewall2_Click(object sender, EventArgs e)
        {
            if (cmblaboratory.Text == "")
            {
                MessageBox.Show("Please choose what laboratory result you want to view");

            }

            else
            {

            if (cmblaboratory.Text == "Hematology")
            {
                connection();
                lvhematology.Items.Clear();
                query = "select * from db_its.tbl_hematology";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    hospitalnumber = myreader["hospitalnumber"].ToString();


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

            else if (cmblaboratory.Text == "Urinalysis")
            {
                connection();
                lvurinalysis.Items.Clear();
                query = "select * from db_its.tbl_urinalysis";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    hospitalnumber = myreader["hospitalnumber"].ToString();


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

            else if (cmblaboratory.Text == "Fecalysis")
            {
                connection();
                lvfecalysis.Items.Clear();
                query = "select * from db_its.tbl_fecalysis";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    hospitalnumber = myreader["hospitalnumber"].ToString();


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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
            else if (cmblaboratory.Text == "Blood Banking")
            {
                connection();
                lvbloodbanking.Items.Clear();
                query = "select * from db_its.tbl_bloodbanking";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    hospitalnumber = myreader["hospitalnumber"].ToString();


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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

            else if (cmblaboratory.Text == "Clinical Chemistry I")
            {
                connection();
                lvclinicalchem.Items.Clear();
                query = "select * from db_its.tbl_clinicalchem_svalues";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    hospitalnumber = myreader["hospitalnumber"].ToString();


                    var item = new ListViewItem();
                    item.Text = (myreader["hospitalnumber"].ToString());
                    item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                    item.SubItems.Add(myreader["clinicalchemid"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());

                    lvclinicalchem.Items.Add(item);
                    



                }
                con.Close();
            }
        }

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
                txtboxsearch2.Text = "";
            }

            if (cmblaboratory.Text == "Urinalysis")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = true;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;
                txtboxsearch2.Text = "";
            }

            if (cmblaboratory.Text == "Fecalysis")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = true;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = false;
                txtboxsearch2.Text = "";
            }

            if (cmblaboratory.Text == "Blood Banking")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = true;
                pnlclinicalchem.Visible = false;
                txtboxsearch2.Text = "";
            }


            if (cmblaboratory.Text == "Clinical Chemistry I")
            {
                pnlhematology.Visible = false;
                pnlurinalysis.Visible = false;
                pnlfecalysis.Visible = false;
                pnlbloodbanking.Visible = false;
                pnlclinicalchem.Visible = true;
                txtboxsearch2.Text = "";
            }
        }

        private void lvhematology_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvhematology.SelectedItems.Count == 0) return;
                ListViewItem item = lvhematology.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname.Text = item.SubItems[1].Text;
                lblhematologyid.Text = item.SubItems[16].Text;
                txtphysician.Text = item.SubItems[17].Text;
                lbldate.Text = item.SubItems[18].Text;
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

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }

            }
            catch
            {
            }

            con.Close();
        }


        private void btnsearch2_Click(object sender, EventArgs e)
        {
            if (cmblaboratory.Text == "")
            {
                MessageBox.Show("Please choose what laboratory result you want to view");

            }

            else
            {
                if (cmblaboratory.Text == "Hematology")
                {
                    if (txtboxsearch2.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvhematology.Items.Clear();
                        query = "select * from db_its.tbl_hematology where hospitalnumber like '%" + txtboxsearch2.Text.Replace("'", "''") + "%' or surname like '%" + txtboxsearch2.Text.Replace("'", "''") + "%' ";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {

                            hospitalnumber = myreader["hospitalnumber"].ToString();


                            var item = new ListViewItem();
                            item.Text = (myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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
                }
                if (cmblaboratory.Text == "Urinalysis")
                {
                    if (txtboxsearch2.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvurinalysis.Items.Clear();
                        query = "select * from db_its.tbl_urinalysis where hospitalnumber like '%" + txtboxsearch2.Text + "%' or surname like '%" + txtboxsearch2.Text + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {

                            hospitalnumber = myreader["hospitalnumber"].ToString();


                            var item = new ListViewItem();
                            item.Text = (myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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
                }
                if (cmblaboratory.Text == "Fecalysis")
                {
                    if (txtboxsearch2.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvfecalysis.Items.Clear();
                        query = "select * from db_its.tbl_fecalysis where hospitalnumber like '%" + txtboxsearch2.Text + "%' or surname like '%" + txtboxsearch2.Text + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {

                            hospitalnumber = myreader["hospitalnumber"].ToString();


                            var item = new ListViewItem();
                            item.Text = (myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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
                }
                if (cmblaboratory.Text == "Blood Banking")
                {
                    if (txtboxsearch2.Text == "")
                    {
                        MessageBox.Show("Please Type Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvbloodbanking.Items.Clear();
                        query = "select * from db_its.tbl_bloodbanking where hospitalnumber like '%" + txtboxsearch2.Text + "%' or surname like '%" + txtboxsearch2.Text + "%'";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {

                            hospitalnumber = myreader["hospitalnumber"].ToString();


                            var item = new ListViewItem();
                            item.Text = (myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
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
                }

                if (cmblaboratory.Text == "Clinical Chemistry I")
                {
                    if (txtboxsearch2.Text == "")
                    {
                        MessageBox.Show("Please Type Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvclinicalchem.Items.Clear();
                        query = "select * from db_its.tbl_clinicalchem_svalues where hospitalnumber like '%" + txtboxsearch2.Text + "%' or surname like '%" + txtboxsearch2.Text + "%' ";
                        command = new MySqlCommand(query, con);
                        myreader = command.ExecuteReader();
                        while (myreader.Read())
                        {

                            hospitalnumber = myreader["hospitalnumber"].ToString();


                            var item = new ListViewItem();
                            item.Text = (myreader["hospitalnumber"].ToString());
                            item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                            item.SubItems.Add(myreader["clinicalchemid"].ToString());
                            item.SubItems.Add(myreader["physician"].ToString());
                            item.SubItems.Add(myreader["date"].ToString());

                            lvclinicalchem.Items.Add(item);
                            



                        }
                        con.Close();
                    }

                }
            }
        }

        private void lvurinalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvurinalysis.SelectedItems.Count == 0) return;
                ListViewItem item = lvurinalysis.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname2.Text = item.SubItems[1].Text;
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
                lblurinalysisid.Text = item.SubItems[17].Text;
                txtphysician2.Text = item.SubItems[18].Text;
                lbldate2.Text = item.SubItems[19].Text;


                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox2.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }
            catch
            {
            }
            con.Close();
        }

        private void lvfecalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvfecalysis.SelectedItems.Count == 0) return;
                ListViewItem item = lvfecalysis.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname3.Text = item.SubItems[1].Text;
                txtcolor2.Text = item.SubItems[2].Text;
                txtconsistency.Text = item.SubItems[3].Text;
                txtparasites.Text = item.SubItems[4].Text;
                txtleukocytes.Text = item.SubItems[5].Text;
                txterythrocytes.Text = item.SubItems[6].Text;
                txtfatglobules.Text = item.SubItems[7].Text;
                txtstrachgranules.Text = item.SubItems[8].Text;
                txtoccultblood.Text = item.SubItems[9].Text;
                txtremarks.Text = item.SubItems[10].Text;
                lblfecalysisid.Text = item.SubItems[11].Text;
                txtphysician3.Text = item.SubItems[12].Text;
                lbldate3.Text = item.SubItems[13].Text;


                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox3.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox3.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();

        }

        private void lvbloodbanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvbloodbanking.SelectedItems.Count == 0) return;
                ListViewItem item = lvbloodbanking.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname4.Text = item.SubItems[1].Text;
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
                lblbloodbankingid.Text = item.SubItems[14].Text;
                txtphysician4.Text = item.SubItems[15].Text;
                lbldate4.Text = item.SubItems[16].Text;


                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox4.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox4.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();

        }

        private void lvclinicalchem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvclinicalchem.SelectedItems.Count == 0) return;
                ListViewItem item = lvclinicalchem.SelectedItems[0];
                hospitalnumber = item.SubItems[0].Text;
                lblpatientname5.Text = item.SubItems[1].Text;
                lblclinicalchemid.Text = item.SubItems[2].Text;
                txtphysician5.Text = item.SubItems[3].Text;
                lbldate5.Text = item.SubItems[4].Text;

                selectionclinicalchemsvalues();
                selectionclinicalchemconventionalvalues();

                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox5.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox5.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();

        }

        private void btnviewall3_Click(object sender, EventArgs e)
        {
            connection();
            lvxray.Items.Clear();
            query = "select * from db_its.tbl_xrayresult";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["xrayresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvxray.Items.Add(item);

            }
            con.Close();
        }

        private void lvxray_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvxray.SelectedItems.Count == 0) return;
                ListViewItem item = lvxray.SelectedItems[0];
                txthospitalnumber2.Text = item.SubItems[0].Text;
                lblpatientsname.Text = item.SubItems[1].Text;
                txtxrayresult.Text = item.SubItems[2].Text;
                lbldate6.Text = item.SubItems[3].Text;




                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox6.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox6.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();

        }

        private void btnsearch3_Click(object sender, EventArgs e)
        {
            connection();
            lvxray.Items.Clear();
            query = "select * from db_its.tbl_xrayresult hospitalnumber like '%" + txtsearchbox3.Text + "%' or surname like '%" + txtsearchbox3.Text + "%'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["xrayresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvxray.Items.Add(item);

            }
            con.Close();
        }

        private void btnviewall4_Click(object sender, EventArgs e)
        {
            connection();
            lvecg.Items.Clear();
            query = "select * from db_its.tbl_ecgresult";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["ecgresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvecg.Items.Add(item);

            }
            con.Close();
        }

        private void btnsearch4_Click(object sender, EventArgs e)
        {
            connection();
            lvecg.Items.Clear();
            query = "select * from db_its.tbl_ecgresult hospitalnumber like '%" + txtsearch2.Text + "%' or surname like '%" + txtsearch2.Text + "%'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["ecgresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvecg.Items.Add(item);

            }
            con.Close();
        }

        private void lvecg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvecg.SelectedItems.Count == 0) return;
                ListViewItem item = lvecg.SelectedItems[0];
                txthospitalnumber3.Text = item.SubItems[0].Text;
                lblpatientname6.Text = item.SubItems[1].Text;
                txtecgresult.Text = item.SubItems[2].Text;
                lbldate7.Text = item.SubItems[3].Text;




                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox7.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox7.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();
        }

        private void btnviewall5_Click(object sender, EventArgs e)
        {
            connection();
            lvctscan.Items.Clear();
            query = "select * from db_its.tbl_ctscanresult";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {

                surname = myreader["surname"].ToString();
                firstname = myreader["firstname"].ToString();
                middlename = myreader["middlename"].ToString();

                var item = new ListViewItem();
                item.Text = myreader["hospitalnumber"].ToString();
                item.SubItems.Add(myreader["surname"].ToString() + ", " + myreader["firstname"].ToString() + " " + myreader["middlename"].ToString());
                item.SubItems.Add(myreader["ctscanresult"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                lvctscan.Items.Add(item);

            }
            con.Close();
        }

        private void btnsearch5_Click(object sender, EventArgs e)
        {
            connection();
            lvctscan.Items.Clear();
            query = "select * from db_its.tbl_ctscanresult where hospitalnumber like '%" + txtsearch3.Text + "%' or surname like '%" + txtsearch3.Text + "%'";
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

        private void lvctscan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvctscan.SelectedItems.Count == 0) return;
                ListViewItem item = lvctscan.SelectedItems[0];
                txthospitalnumber4.Text = item.SubItems[0].Text;
                lblpatientname7.Text = item.SubItems[1].Text;
                txtctscanresult.Text = item.SubItems[2].Text;
                lbldate8.Text = item.SubItems[3].Text;




                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox8.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox8.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();
        }

        private void lvclinicalrecord_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (lvclinicalrecord.SelectedItems.Count == 0) return;
                ListViewItem item = lvclinicalrecord.SelectedItems[0];
                txthospitalnumber.Text = item.SubItems[0].Text;
                lblpatientname8.Text = item.SubItems[1].Text;
                txtchiefcomplaint.Text = item.SubItems[2].Text;
                txthpi.Text = item.SubItems[3].Text;
                txthtnmeds.Text = item.SubItems[4].Text;
                txtdmmeds.Text = item.SubItems[5].Text;
                txtasthmameds.Text = item.SubItems[6].Text;
                txtallergymeds.Text = item.SubItems[7].Text;
                txtsxmeds.Text = item.SubItems[8].Text;
                txtother4.Text = item.SubItems[9].Text;
                txtbp.Text = item.SubItems[10].Text;
                txtcr.Text = item.SubItems[11].Text;
                txtrr.Text = item.SubItems[12].Text;
                txttemp.Text = item.SubItems[13].Text;
                txtheent.Text = item.SubItems[14].Text;
                txtlungs.Text = item.SubItems[15].Text;
                txtheart.Text = item.SubItems[16].Text;
                txtabdomen.Text = item.SubItems[17].Text;
                txtgenitouro.Text = item.SubItems[18].Text;
                txtextremities.Text = item.SubItems[19].Text;
                txtneuro.Text = item.SubItems[20].Text;
                txtothers2.Text = item.SubItems[21].Text;
                txtdiagnosis.Text = item.SubItems[22].Text;
                txtermanagement.Text = item.SubItems[23].Text;
                txtmeds.Text = item.SubItems[24].Text;
                lblphysician.Text = item.SubItems[25].Text;
                lbldate9.Text = item.SubItems[26].Text;


                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber = '" + hospitalnumber + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    byte[] image = (byte[])(myreader["Image"]);
                    if (image == null)
                    {
                        pictureBox9.Image = null;

                    }

                    else
                    {
                        MemoryStream mstream = new MemoryStream(image);
                        pictureBox9.Image = System.Drawing.Image.FromStream(mstream);
                        pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;


                    }
                }
            }

            catch
            {
            }
            con.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Go Back to Main Menu  " + "','" + date2 + " " + time2 + "')";
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

        private void btnprintclinicalrecord_Click(object sender, EventArgs e)
        {
            if (txthospitalnumber.Text == "")
            {

                MessageBox.Show("Please choose Patient record you want to print.");

            }
            else
            {
                connection();
                query = "select * from db_its.tbl_basicinfo where hospitalnumber = '" + txthospitalnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string philhealth = myreader["philhealth"].ToString();
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();
                    string birthdate = myreader["birthdate"].ToString();
                    string ht = myreader["ht"].ToString();
                    string wt = myreader["wt"].ToString();
                    string address = myreader["address"].ToString();
                    string occupation = myreader["occupation"].ToString();
                    string contact = myreader["contactnumber"].ToString();


                    new ClinicalRecordReports(philhealth,
                        txthospitalnumber.Text,
                        lbldate9.Text,
                        lblpatientname8.Text,
                        age,
                        sex,
                        birthdate,
                        ht,
                        wt,
                        address,
                        occupation,
                        contact,
                   txtchiefcomplaint.Text,
                   txthpi.Text,
                   txthtnmeds.Text,
                   txtdmmeds.Text,
                   txtasthmameds.Text,
                   txtallergymeds.Text,
                   txtsxmeds.Text,
                   txtother4.Text,
                   txtbp.Text,
                   txtcr.Text,
                   txtrr.Text,
                   txttemp.Text,
                   txtheent.Text,
                   txtlungs.Text,
                   txtheart.Text,
                   txtabdomen.Text,
                   txtgenitouro.Text,
                   txtextremities.Text,
                   txtneuro.Text,
                   txtothers2.Text,
                   txtdiagnosis.Text,
                   txtermanagement.Text,
                   txtmeds.Text,
                   lblphysician.Text).ShowDialog();

                    txthospitalnumber.Text = "";
                    lbldate9.Text = "";
                    lblpatientname8.Text = "";
                    age = "";
                    sex = "";
                    birthdate = "";
                    ht = "";
                    wt = "";
                    address = "";
                    occupation = "";
                    contact = "";
                    txtchiefcomplaint.Text = "";
                    txthpi.Text = "";
                    txthtnmeds.Text = "";
                    txtdmmeds.Text = "";
                    txtasthmameds.Text = "";
                    txtallergymeds.Text = "";
                    txtsxmeds.Text = "";
                    txtother4.Text = "";
                    txtbp.Text = "";
                    txtcr.Text = "";
                    txtrr.Text = "";
                    txttemp.Text = "";
                    txtheent.Text = "";
                    txtlungs.Text = "";
                    txtheart.Text = "";
                    txtabdomen.Text = "";
                    txtgenitouro.Text = "";
                    txtextremities.Text = "";
                    txtneuro.Text = "";
                    txtothers2.Text = "";
                    txtdiagnosis.Text = "";
                    txtermanagement.Text = "";
                    txtmeds.Text = "";
                    lblphysician.Text = "";
                    pictureBox9.Image = null;

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Clinical Record Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
            }



        }

        private void btnprinthematology_Click(object sender, EventArgs e)
        {
            if (lblpatientname.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_hematology where hematologyid = '" + lblhematologyid.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();

                    new HematologyRecordReports(lblpatientname.Text,
                        age,
                        sex,
                        lbldate.Text,
                        txtphysician.Text,
                        lblhematologyid.Text,
                        txthemoglobin.Text,
                        txthematocrit.Text,
                        txtrbccount.Text,
                        txtwbccount.Text,
                        txtplatelet.Text,
                        txtdifferentialcount.Text,
                        txtneutrophils.Text,
                        txtlymphocytes.Text,
                        txtmonocytes.Text,
                        txteosinophils.Text,
                        txtbasophils.Text,
                        txtstabs.Text,
                        txtothers.Text,
                        txtothertests.Text).ShowDialog();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Hematology Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
            }
        }

        private void btnprinturinalysis_Click(object sender, EventArgs e)
        {

            if (lblpatientname2.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_urinalysis where urinalysisid  = '" + lblurinalysisid.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();

                    new UrinalysisRecordReport(lblpatientname2.Text,
                        age,
                        sex,
                        lbldate2.Text,
                        txtphysician2.Text,
                        lblurinalysisid.Text,
                        txtcolor.Text,
                        txttransparency.Text,
                        txtph.Text,
                        txtspecificgravity.Text,
                        txtsugar.Text,
                        txtprotein.Text,
                        txtredbloodcells.Text,
                        txtpuscells.Text,
                        txtbacteria.Text,
                        txtepithelialcells.Text,
                        txtmucusthreads.Text,
                        txtcast.Text,
                        txtcrystals.Text,
                        txtamorphousmaterials.Text,
                        txtothertests2.Text).ShowDialog();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Urinalysis Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
            }
        }

        private void btnprintfecalysis_Click(object sender, EventArgs e)
        {
            if (lblpatientname3.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_fecalysis where fecalysisid  = '" + lblfecalysisid.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();

                    new FecalysisRecordReports(lblpatientname3.Text,
                        age,
                        sex,
                        lbldate3.Text,
                        txtphysician3.Text,
                        lblfecalysisid.Text,
                        txtcolor2.Text,
                        txtconsistency.Text,
                        txtparasites.Text,
                        txtleukocytes.Text,
                        txterythrocytes.Text,
                        txtfatglobules.Text,
                        txtstrachgranules.Text,
                        txtoccultblood.Text,
                        txtremarks.Text).ShowDialog();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Fecalysis Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
            }
        }

        private void btnprintbloodbanking_Click(object sender, EventArgs e)
        {
            if (lblpatientname4.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_bloodbanking where bloodbankingid  = '" + lblbloodbankingid.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();

                    new BloodBankingRecordReport(lblpatientname4.Text,
                        age,
                        sex,
                        lbldate4.Text,
                        txtphysician4.Text,
                        lblbloodbankingid.Text,
                        txtbloodbagserialnumber.Text,
                        txtbloodcomponent.Text,
                        txtdonorcontrolnumber.Text,
                        txtdonorabobloodtype.Text,
                        txtdonorrhbloodtype.Text,
                        txtpatientabobloodtype.Text,
                        txtpatientrhbloodtype.Text,
                        txtimmediatespinphase.Text,
                        txtenchancementmediaphase.Text,
                        txtantihumanglobinphase.Text,
                        txtautocontrol.Text,
                        txtothertests3.Text).ShowDialog();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Blood Banking Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                }
            }
        }

        private void btnprintclinicalchem_Click(object sender, EventArgs e)
        {
            if (lblpatientname5.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_clinicalchem_svalues where clinicalchemid  = '" + lblclinicalchemid.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    string age = myreader["age"].ToString();
                    string sex = myreader["sex"].ToString();

                    new ClinicalChemRecordReports(lblpatientname5.Text,
                         age,
                         sex,
                         lbldate5.Text,
                         txtphysician5.Text,
                         lblclinicalchemid.Text,
                         txtglucose.Text,
                         txtureanitrogen.Text,
                         txtcreatinine.Text,
                         txturicacid.Text,
                         txttriglycerides.Text,
                         txtcholesterol.Text,
                         txthdl.Text,
                         txtldl.Text,
                         txtsgpt.Text,
                         txtsgot.Text,
                         txtsodium.Text,
                         txtpotassium.Text,
                         txtchloride.Text,
                         txtglucose2.Text,
                         txtureanitrogen2.Text,
                         txtcreatinine2.Text,
                         txturicacid2.Text,
                         txttriglycerides2.Text,
                         txtcholesterol2.Text,
                         txthdl2.Text,
                         txtldl2.Text,
                         txtsgpt2.Text,
                         txtsgot2.Text,
                         txtsodium2.Text,
                         txtpotassium2.Text,
                         txtchloride2.Text,
                         txtremarks2.Text).ShowDialog();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Clinical Chemistry I Result " + "','" + date2 + " " + time2 + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
            }
        }

        private void btnviewall6_Click(object sender, EventArgs e)
        {
            if (cmbmedecalresult.Text == "")
            {
                MessageBox.Show("Please Choose a medical record you want to view.");
            }

            else
            {

                if (cmbmedecalresult.Text == "Medical Male Ward")
                {
                    connection();
                    lvmaleward.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvmaleward.Items.Add(item);
                    }
                    con.Close();
                }


                if (cmbmedecalresult.Text == "Medical Female Ward")
                {
                    connection();
                    lvfemaleward.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvfemaleward.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbmedecalresult.Text == "OB - Gyne")
                {
                    connection();
                    lvobgyne.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvobgyne.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbmedecalresult.Text == "Surgical")
                {
                    connection();
                    lvsurgical.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvsurgical.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbmedecalresult.Text == "Pediatric")
                {
                    connection();
                    lvpediatric.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvpediatric.Items.Add(item);
                    }
                    con.Close();
                }

                if (cmbmedecalresult.Text == "Isolation")
                {
                    connection();
                    lvisolation.Items.Clear();
                    query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "'";
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
                        item.SubItems.Add(myreader["dateadmitted"].ToString());
                        item.SubItems.Add(myreader["timeadmitted"].ToString());
                        item.SubItems.Add(myreader["dateofobservation"].ToString());
                        item.SubItems.Add(myreader["timeofobservation"].ToString());
                        item.SubItems.Add(myreader["observation"].ToString());
                        lvisolation.Items.Add(item);
                    }
                    con.Close();
                }
            }

        }

        private void cmbmedecalresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmedecalresult.Text == "Medical Male Ward")
            {
                pnlmaleward.Visible = true;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;
            }

            if (cmbmedecalresult.Text == "Medical Female Ward")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = true;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;
            }


            if (cmbmedecalresult.Text == "OB - Gyne")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = true;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;
            }

            if (cmbmedecalresult.Text == "Surgical")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = true;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = false;
            }

            if (cmbmedecalresult.Text == "Pediatric")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = true;
                pnlisolation.Visible = false;
            }

            if (cmbmedecalresult.Text == "Isolation")
            {
                pnlmaleward.Visible = false;
                pnlfemaleward.Visible = false;
                pnlobgyne.Visible = false;
                pnlsurgical.Visible = false;
                pnlpediatric.Visible = false;
                pnlisolation.Visible = true;
            }
        }

        private void btnsearch6_Click(object sender, EventArgs e)
        {
            if (cmbmedecalresult.Text == "")
            {
                MessageBox.Show("Please Choose a medical record you want to view.");
            }

            else
            {
                if (cmbmedecalresult.Text == "Medical Male Ward")
                {
                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }
                    else
                    {
                        connection();
                        lvmaleward.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvmaleward.Items.Add(item);
                        }
                        con.Close();
                    }
                }

                if (cmbmedecalresult.Text == "Medical Female Ward")
                {
                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvfemaleward.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvfemaleward.Items.Add(item);
                        }
                        con.Close();
                    }

                }

                if (cmbmedecalresult.Text == "OB - Gyne")
                {
                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvobgyne.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvobgyne.Items.Add(item);
                        }
                        con.Close();
                    }

                }

                if (cmbmedecalresult.Text == "Surgical")
                {
                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvsurgical.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvsurgical.Items.Add(item);
                        }
                        con.Close();
                    }
                }


                if (cmbmedecalresult.Text == "Pediatric")
                {
                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvpediatric.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvpediatric.Items.Add(item);
                        }
                        con.Close();
                    }
                }


                if (cmbmedecalresult.Text == "Isolation")
                {

                    if (txtsearch4.Text == "")
                    {
                        MessageBox.Show("Please insert either Patient - ID or Patient Surname");
                    }

                    else
                    {
                        connection();
                        lvisolation.Items.Clear();
                        query = "select * from db_its.tbl_medicalrecord where wardtype = '" + cmbmedecalresult.Text + "' and hospitalnumber like '%" + txtsearch4.Text.Replace("'", "''") + "%' or surname like '%" + txtsearch4.Text.Replace("'", "''") + "%' and  wardtype = '" + cmbmedecalresult.Text + "'";
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
                            item.SubItems.Add(myreader["dateadmitted"].ToString());
                            item.SubItems.Add(myreader["timeadmitted"].ToString());
                            item.SubItems.Add(myreader["dateofobservation"].ToString());
                            item.SubItems.Add(myreader["timeofobservation"].ToString());
                            item.SubItems.Add(myreader["observation"].ToString());
                            lvisolation.Items.Add(item);
                        }
                        con.Close();
                    }
                }

            }

        }
        private void lvmaleward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvmaleward.SelectedItems.Count == 0) return;
            ListViewItem item = lvmaleward.SelectedItems[0];
            lblhospitalnumber.Text = item.SubItems[0].Text;
            lblpatientnameward.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage.Text = item.SubItems[4].Text;
            lblsex.Text = item.SubItems[5].Text;
            lblcontact.Text = item.SubItems[6].Text;
            lbladdress.Text = item.SubItems[7].Text;
            lbldateaddmitted.Text = item.SubItems[8].Text;
            lbltimeaddmitted.Text = item.SubItems[9].Text;
            lbldateofobservation.Text = item.SubItems[10].Text;
            lbltimeofobservation.Text = item.SubItems[11].Text;
            txtobservation.Text =  item.SubItems[12].Text;
            
        }

        private void lvfemaleward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvfemaleward.SelectedItems.Count == 0) return;
            ListViewItem item = lvfemaleward.SelectedItems[0];
            lblhospitalnumber2.Text = item.SubItems[0].Text;
            lblpatientnameward2.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage2.Text = item.SubItems[4].Text;
            lblsex2.Text = item.SubItems[5].Text;
            lblcontact2.Text = item.SubItems[6].Text;
            lbladdress2.Text = item.SubItems[7].Text;
            lbldateaddmitted2.Text = item.SubItems[8].Text;
            lbltimeaddmitted2.Text = item.SubItems[9].Text;
            lbldateofobservation2.Text = item.SubItems[10].Text;
            lbltimeofobservation2.Text = item.SubItems[11].Text;
            txtobservation2.Text = item.SubItems[12].Text;
        }

        private void lvobgyne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvobgyne.SelectedItems.Count == 0) return;
            ListViewItem item = lvobgyne.SelectedItems[0];
            lblhospitalnumber3.Text = item.SubItems[0].Text;
            lblpatientnameward3.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage3.Text = item.SubItems[4].Text;
            lblsex3.Text = item.SubItems[5].Text;
            lblcontact3.Text = item.SubItems[6].Text;
            lbladdress3.Text = item.SubItems[7].Text;
            lbldateaddmitted3.Text = item.SubItems[8].Text;
            lbltimeaddmitted3.Text = item.SubItems[9].Text;
            lbldateofobservation3.Text = item.SubItems[10].Text;
            lbltimeofobservation3.Text = item.SubItems[11].Text;
            txtobservation3.Text = item.SubItems[12].Text;
        }

        private void lvsurgical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsurgical.SelectedItems.Count == 0) return;
            ListViewItem item = lvsurgical.SelectedItems[0];
            lblhospitalnumber4.Text = item.SubItems[0].Text;
            lblpatientnameward4.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage4.Text = item.SubItems[4].Text;
            lblsex4.Text = item.SubItems[5].Text;
            lblcontact4.Text = item.SubItems[6].Text;
            lbladdress4.Text = item.SubItems[7].Text;
            lbldateaddmitted4.Text = item.SubItems[8].Text;
            lbltimeaddmitted4.Text = item.SubItems[9].Text;
            lbldateofobservation4.Text = item.SubItems[10].Text;
            lbltimeofobservation4.Text = item.SubItems[11].Text;
            txtobservation4.Text = item.SubItems[12].Text;
        }

        private void lvpediatric_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvpediatric.SelectedItems.Count == 0) return;
            ListViewItem item = lvpediatric.SelectedItems[0];
            lblhospitalnumber5.Text = item.SubItems[0].Text;
            lblpatientnameward5.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage5.Text = item.SubItems[4].Text;
            lblsex5.Text = item.SubItems[5].Text;
            lblcontact5.Text = item.SubItems[6].Text;
            lbladdress5.Text = item.SubItems[7].Text;
            lbldateaddmitted5.Text = item.SubItems[8].Text;
            lbltimeaddmitted5.Text = item.SubItems[9].Text;
            lbldateofobservation5.Text = item.SubItems[10].Text;
            lbltimeofobservation5.Text = item.SubItems[11].Text;
            txtobservation5.Text = item.SubItems[12].Text;
        }

        private void lvisolation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvisolation.SelectedItems.Count == 0) return;
            ListViewItem item = lvisolation.SelectedItems[0];
            lblhospitalnumber6.Text = item.SubItems[0].Text;
            lblpatientnameward6.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
            lblage6.Text = item.SubItems[4].Text;
            lblsex6.Text = item.SubItems[5].Text;
            lblcontact6.Text = item.SubItems[6].Text;
            lbladdress6.Text = item.SubItems[7].Text;
            lbldateaddmitted6.Text = item.SubItems[8].Text;
            lbltimeaddmitted6.Text = item.SubItems[9].Text;
            lbldateofobservation6.Text = item.SubItems[10].Text;
            lbltimeofobservation6.Text = item.SubItems[11].Text;
            txtobservation6.Text = item.SubItems[12].Text;
        }

        private void btnprintctscan_Click(object sender, EventArgs e)
        {
            if (txtctscanresult.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }
            else
            {
                new CtscanResultReport(lblpatientname7.Text,
                    lbldate8.Text,
                    txtctscanresult.Text).ShowDialog();

                txthospitalnumber4.Text = "";
                lblpatientname7.Text = "";
                lbldate8.Text = "";
                txtctscanresult.Text = "";
                pictureBox8.Image = null;

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a CT scan Result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
        }

        private void btnprintecg_Click(object sender, EventArgs e)
        {
            if (txtecgresult.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }
            else
            {
                new EcgResultReport(lblpatientname6.Text,
                    lbldate7.Text,
                    txtecgresult.Text).ShowDialog();

                txthospitalnumber3.Text = "";
                lblpatientname6.Text = "";
                lbldate7.Text = "";
                txtecgresult.Text = "";
                pictureBox7.Image = null;

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a ECG Result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
        }

        private void btnprintxray_Click(object sender, EventArgs e)
        {
            if (txtxrayresult.Text == "")
            {
                MessageBox.Show("Please choose Patient record you want to print.");
            }
            else
            {
                new XrayResultReport(lblpatientsname.Text,
                    lbldate6.Text,
                    txtxrayresult.Text).ShowDialog();

                txthospitalnumber2.Text = "";
                lblpatientsname.Text = "";
                lbldate6.Text = "";
                txtxrayresult.Text = "";
                pictureBox6.Image = null;

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Print a Xray/Ultrasound Result " + "','" + date2 + " " + time2 + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
        }

       
    }
}