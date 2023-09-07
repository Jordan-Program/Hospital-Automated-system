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
    public partial class MainMenu : Form
    {
        public string name;
        public string userid;
        public string acoountposition;
        
        public MainMenu()
        {
            InitializeComponent();


            Timer DateTimer = new Timer();

            DateTimer.Interval = 1000;
            DateTimer.Tick += DateTimer_Tick;
            DateTimer.Start();




            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss tt");

           

            
        }
        
        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public int count = 0;

        public string date, time;


        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void DateTimer_Tick(Object sender, EventArgs e)
        {
            lbldates.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lbltimes.Text = DateTime.Now.ToString("hh:mm tt");

        }



        private void MainMenu_Load(object sender, EventArgs e)
        {

            lbluserid.Text = userid;
            lblaccountposition.Text = acoountposition;
            usercontrol();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);

            
        }

        public void usercontrol()
        {
            string register, doctor, view, ancillary, result, billing, report, emergency, admitting, ward;

            connection();
            query = "select * from db_its.tbl_usercontrol where userid = '"+ userid +"'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                register = myreader["register"].ToString();
                doctor = myreader["doctor"].ToString();
                view = myreader["viewpatient"].ToString();
                ancillary = myreader["ancillary"].ToString();
                result = myreader["result"].ToString();
                billing = myreader["billing"].ToString();
                report = myreader["reports"].ToString();
                emergency = myreader["emergency"].ToString();
                admitting = myreader["admitting"].ToString();
                ward = myreader["ward"].ToString();

                if (register == "Access")
                {
                    btn1ststepregister.Enabled = true;
                }

                if (register == "Denied")
                {
                    btn1ststepregister.Enabled = false;
                }

                if (doctor == "Access")
                {
                    btn2ndstepregister.Enabled = true;
                }

                if (doctor == "Denied")
                {
                    btn2ndstepregister.Enabled = false;
                }

                if (view == "Access")
                {
                    btnviewpatient.Enabled = true;
                }

                if (view == "Denied")
                {
                    btnviewpatient.Enabled = false;
                }

                if (ancillary == "Access")
                {
                    btnancillaryprocedures.Enabled = true;
                }

                if (ancillary == "Denied")
                {
                    btnancillaryprocedures.Enabled = false;
                }

                if (result == "Access")
                {
                    btnresult.Enabled = true;
                }

                if (result == "Denied")
                {
                    btnresult.Enabled = false;
                }

                if (billing == "Access")
                {
                    btnbilling.Enabled = true;
                }

                if (billing == "Denied")
                {
                    btnbilling.Enabled = false;
                }

                if (report == "Access")
                {
                    btntransaction.Enabled = true;
                }

                if (report == "Denied")
                {
                    btntransaction.Enabled = false;
                }

                if (emergency == "Access")
                {
                    btnemergency.Enabled = true;
                }

                if (emergency == "Denied")
                {
                    btnemergency.Enabled = false;
                }

                if (admitting == "Access")
                {
                    btnadmit.Enabled = true;
                }

                if (admitting == "Denied")
                {
                    btnadmit.Enabled = false;
                }

                if (ward == "Access")
                {
                    btnroom.Enabled = true;
                }

                if (ward == "Denied")
                {
                    btnroom.Enabled = false;
                }

            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.timer6.Enabled = false;
                this.timer5.Enabled = true;
                count = 1;
            }

            else if (count == 1)
            {
                this.timer6.Enabled = true;
                this.timer5.Enabled = false;
                count = 0;
            }


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.timer10.Enabled = false;
                this.timer9.Enabled = true;
                count = 1;
            }

            else if (count == 1)
            {
                this.timer10.Enabled = true;
                this.timer9.Enabled = false;
                count = 0;
            }

        }



        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log - out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will now log out " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                this.Hide();
                Form1 fr = new Form1();
                fr.ShowDialog();
                this.Close();
            }
        }

        private void btn2ndstepregister_Click(object sender, EventArgs e)
        {

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Doctor module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Register2nd register2 = new Register2nd();
            register2.name = name;
            register2.userid = userid;
            register2.acoountposition = acoountposition;
            register2.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnancillaryprocedures_Click(object sender, EventArgs e)
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
            if (panel1.Size.Height >= 207) this.timer1.Enabled = false;
            else panel1.Height += 12;
            if (panel1.Size.Height != 10)
            {
                panel1.Visible = true;
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Size.Height <= 10) this.timer2.Enabled = false;
            else panel1.Height -= 12;
            if (panel1.Size.Height == 10)
            {
                panel1.Visible = false;
            }
        }

        private void btnxray_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Xray/Ultrasound Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Xray xray = new Xray();
            xray.userid = userid;
            xray.acoountposition = acoountposition;
            xray.name = name;
            xray.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnecg_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to ECG Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Ecg ecg = new Ecg();
            ecg.userid = userid;
            ecg.acoountposition = acoountposition;
            ecg.name = name;
            ecg.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnctscan_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to CTscan module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Ctscan ctscan = new Ctscan();
            ctscan.userid = userid;
            ctscan.acoountposition = acoountposition;
            ctscan.name = name;
            ctscan.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Laboratory Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Laboratory lab = new Laboratory();
            lab.userid = userid;
            lab.acoountposition = acoountposition;
            lab.name = name;
            lab.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Result Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Result res = new Result();
            res.userid = userid;
            res.acoountposition = acoountposition;
            res.name = name;
            res.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel9.Size.Height >= 94) this.timer3.Enabled = false;
            else panel9.Height += 12;
            if (panel9.Size.Height != 10)
            {
                panel9.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel9.Size.Height <= 10) this.timer4.Enabled = false;
            else panel9.Height -= 12;
            if (panel9.Size.Height == 10)
            {
                panel9.Visible = false;
            }
        }

        private void btnbilling_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.timer4.Enabled = false;
                this.timer3.Enabled = true;
                count = 1;
            }

            else if (count == 1)
            {
                this.timer4.Enabled = true;
                this.timer3.Enabled = false;
                count = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (panel10.Size.Height >= 124) this.timer5.Enabled = false;
            else panel10.Height += 12;
            if (panel10.Size.Height != 10)
            {
                panel10.Visible = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (panel10.Size.Height <= 10) this.timer6.Enabled = false;
            else panel10.Height -= 12;
            if (panel10.Size.Height == 10)
            {
                panel10.Visible = false;
            }
        }

        private void btnregisternewpatient_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to register new patient module" + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Register register = new Register();
            register.userid = userid;
            register.acoountposition = acoountposition;
            register.name = name;
            register.ShowDialog();
            this.Hide();
            this.Close();

        }

        private void btnoldpatient_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to register old patient module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            RegisterOld old = new RegisterOld();
            old.userid = userid;
            old.acoountposition = acoountposition;
            old.name = name;
            old.ShowDialog();
            this.Hide();
            this.Close();

        }

        private void btnacillarybilling_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Ancillary Billin Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            AncillaryBilling ab = new AncillaryBilling();
            ab.name = name;
            ab.userid = userid;
            ab.acoountposition = acoountposition;
            ab.ShowDialog();
            this.Hide();
            this.Close();
        }

        

        

        private void btntransaction_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Ancillart Transaction Report Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Transaction tran = new Transaction();
            tran.userid = userid;
            tran.acoountposition = acoountposition;
            tran.name = name;
            tran.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnfilemaintenance_Click(object sender, EventArgs e)
        {

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to File Maintenance Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            FileMaintenance file = new FileMaintenance();
            file.acoountposition = acoountposition;
            file.name = name;
            file.useridd = userid;
            file.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btn1ststepregister_MouseHover(object sender, EventArgs e)
        {
            
            btn1ststepregister.Text = "Register";
        }



        private void btnancillaryprocedures_MouseHover(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
            this.timer1.Enabled = true;
            count = 1;
        }

        private void btnbilling_MouseHover(object sender, EventArgs e)
        {
            btnbilling.Text = "Billing";
        }

        private void btntransaction_MouseHover(object sender, EventArgs e)
        {
            btntransaction.Text = "Transaction";
        }

        private void btnadmit_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Admitting Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Admitting ad = new Admitting();
            ad.userid = userid;
            ad.acoountposition = acoountposition;
            ad.name = name;
            ad.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnancillaryprocedures_MouseHover_1(object sender, EventArgs e)
        {
            btnancillaryprocedures.Text = "Ancillary";
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Ward Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            Ward wr = new Ward();
            wr.userid = userid;
            wr.acoountposition = acoountposition;
            wr.name = name;
            wr.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnadmission_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Admission Billing Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            AdmissionBilling ad = new AdmissionBilling();
            ad.userid = userid;
            ad.name = name;
            ad.acoountposition = acoountposition;
            ad.ShowDialog();
            this.Hide();
            this.Close();

        }

        private void btn1ststepregister_MouseLeave(object sender, EventArgs e)
        {
            btn1ststepregister.Text = "";
        }

        private void btn2ndstepregister_MouseHover(object sender, EventArgs e)
        {
            btn2ndstepregister.Text = "Doctor";
        }

        private void btn2ndstepregister_MouseLeave(object sender, EventArgs e)
        {
            btn2ndstepregister.Text = "";
        }

        private void btnviewpatient_MouseHover(object sender, EventArgs e)
        {
            btnviewpatient.Text = "View Patient";
        }

        private void btnviewpatient_MouseLeave(object sender, EventArgs e)
        {
            btnviewpatient.Text = "";
        }

        private void btnancillaryprocedures_MouseLeave(object sender, EventArgs e)
        {
            btnancillaryprocedures.Text = "";
        }

        private void btnresult_MouseHover(object sender, EventArgs e)
        {
            btnresult.Text = "Results";
        }

        private void btnresult_MouseLeave(object sender, EventArgs e)
        {
            btnresult.Text = "";
        }

        private void btnbilling_MouseLeave(object sender, EventArgs e)
        {
            btnbilling.Text = "";
        }

        private void btntransaction_MouseLeave(object sender, EventArgs e)
        {
            btntransaction.Text = "";
        }

        private void btnadmit_MouseHover(object sender, EventArgs e)
        {
            btnadmit.Text = "Admitting";
        }

        private void btnadmit_MouseLeave(object sender, EventArgs e)
        {
            btnadmit.Text = "";
        }

        private void btnfilemaintenance_MouseHover(object sender, EventArgs e)
        {
            btnfilemaintenance.Text = "File Maintenance";
        }

        private void btnfilemaintenance_MouseLeave(object sender, EventArgs e)
        {
            btnfilemaintenance.Text = "";
        }

        
        private void btnroom_MouseHover(object sender, EventArgs e)
        {
            btnroom.Text = "Ward";
        }

        private void btnlogout_MouseHover(object sender, EventArgs e)
        {
            btnlogout.Text = "Log - out";
        }

        private void btnlogout_MouseLeave(object sender, EventArgs e)
        {
            btnlogout.Text = "";
        }

        private void btnroom_MouseLeave(object sender, EventArgs e)
        {

            btnroom.Text = "";
        }

        private void btnemergency_MouseHover(object sender, EventArgs e)
        {
            btnemergency.Text = "Emergency";
        }

        private void btnemergency_MouseLeave(object sender, EventArgs e)
        {
            btnemergency.Text = "";
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (panel2.Size.Height >= 155) this.timer7.Enabled = false;
            else panel2.Height += 12;
            if (panel2.Size.Height != 10)
            {
                panel2.Visible = true;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {

            if (panel2.Size.Height <= 10) this.timer8.Enabled = false;
            else panel2.Height -= 12;
            if (panel2.Size.Height == 10)
            {
                panel2.Visible = false;
            }
        }

        private void btnemergency_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                this.timer8.Enabled = false;
                this.timer7.Enabled = true;
                count = 1;
            }

            else if (count == 1)
            {
                this.timer8.Enabled = true;
                this.timer7.Enabled = false;
                count = 0;
            }
        }

        private void btnerrigister_Click(object sender, EventArgs e)
        {
            this.Hide();
            ErmergencyRoom err = new ErmergencyRoom();
            err.acoountposition = acoountposition;
            err.name = name;
            err.userid = userid;
            err.ShowDialog();
            this.Hide();
            this.Close();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Emergency Room Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void btnerviewtransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ErViewAndTransfer erv = new ErViewAndTransfer();
            erv.acoountposition = acoountposition;
            erv.userid = userid;
            erv.name = name;
            erv.ShowDialog();
            this.Hide();
            this.Close();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Emergency View and Transfer Module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void btnerhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyHistory em = new EmergencyHistory();
            em.acoountposition =  acoountposition;
            em.name = name;
            em.userid = userid;
            em.ShowDialog();
            this.Hide();
            this.Close();

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Emergency History " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void btnupdateinfo_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to View patient module " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

            this.Hide();
            ViewPatient viewpatient = new ViewPatient();
            viewpatient.userid = userid;
            viewpatient.acoountposition = acoountposition;
            viewpatient.name = name;
            viewpatient.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (panel3.Size.Height >= 92) this.timer9.Enabled = false;
            else panel3.Height += 12;
            if (panel3.Size.Height != 10)
            {
                panel3.Visible = true;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (panel3.Size.Height <= 10) this.timer10.Enabled = false;
            else panel3.Height -= 12;
            if (panel3.Size.Height == 10)
            {
                panel3.Visible = false;
            }
        }

        private void btnmergepatient_Click(object sender, EventArgs e)
        {
            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " will go to Merge new patient history to old patient history " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
            
            this.Hide();
            MergeOldNewPatientHistory mer = new MergeOldNewPatientHistory();
            mer.acoountposition = acoountposition;
            mer.userid = userid;
            mer.name = name;
            mer.ShowDialog();
            this.Hide();
            this.Close();
        }

       
        
       
    }
}