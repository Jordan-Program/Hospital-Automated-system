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
    

    public partial class AncillaryBilling : Form
    {
        public string name;
        public string userid;
        public string acoountposition;
        
        public AncillaryBilling()
        {
            InitializeComponent();
            qnumber();
            ancillaryprice();
            doctor();
            deletepaid();

            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss");

            label35.Text = "Maximum Queue number for laboratory is " + labq + ".";
            label36.Text = "Maximum Queue number for Xray / Ultrasound is " + xrayq + ".";
            label37.Text = "Maximum Queue number for Ecg is " + ecgq + ".";
            label38.Text = "Maximum Queue number for CT scan is " + ctsanq + ".";
            lbldoctorfee.Text = doctorprice.ToString();
            
            connection();
            query = "select * from db_its.tbl_discount";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                string dis = myreader["discount"].ToString();
                discount = Convert.ToDouble(dis);
            }

            con.Close();
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date, time, date2, time2, surname, firstname, middlename, status = "pending", paid = "paid", labq, ecgq, ctsanq, xrayq, qlabnum, qecgnum, qctscannum, qxraynum, kindofindigent;

        public int labprice, xrayprice, ctscanprice, ecgprice, doctorprice, time1 = 5;

        public double discount;

        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }

        private void DateTimer_Tick(Object sender, EventArgs e)
        {


            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss tt");

        }

        public void viewall()
        {
            date = DateTime.Now.ToString("yyyy-MM-dd");

            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_pendingbill_ancillary where status = '" + status + "' and date = '" + date + "' or status = '" + status + "'";
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
                item.SubItems.Add(myreader["xray"].ToString());
                item.SubItems.Add(myreader["ecg"].ToString());
                item.SubItems.Add(myreader["ctscan"].ToString());
                item.SubItems.Add(myreader["hematology"].ToString());
                item.SubItems.Add(myreader["urinalysis"].ToString());
                item.SubItems.Add(myreader["fecalysis"].ToString());
                item.SubItems.Add(myreader["bloodbanking"].ToString());
                item.SubItems.Add(myreader["clinicalchem"].ToString());
                item.SubItems.Add(myreader["otherfee"].ToString());
                item.SubItems.Add(myreader["physician"].ToString());



                listView1.Items.Add(item);
            }

            con.Close();
        }
        
        public void deletepaid()
        {
            connection();
            query = "delete from db_its.tbl_pendingbill_ancillary where status = '" + paid + "'";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void qnumber()
        {
            connection();
            query = "select * from db_its.tbl_qnumbers";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                labq = myreader["qnumberlab"].ToString();
                xrayq = myreader["qnumberxray"].ToString();
                ctsanq = myreader["qnumberctscan"].ToString();
                ecgq = myreader["qnumberecg"].ToString();
            }
            con.Close();
        }

        public void doctor()
        {
            connection();
            query = "select * from db_its.tbl_doctorprice";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                doctorprice = int.Parse(myreader["doctorprice"].ToString());
            }
            con.Close();
        }

        public void ancillaryprice()
        {
            connection();
            query = "select * from db_its.tbl_ancillaryprice";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {
                labprice = int.Parse(myreader["labprice"].ToString());
                xrayprice = int.Parse(myreader["xrayprice"].ToString());
                ctscanprice = int.Parse(myreader["ctscanprice"].ToString());
                ecgprice = int.Parse(myreader["ecgprice"].ToString());
            }
            con.Close();
        }

        public void updateofpendingbill()
        {
            date = DateTime.Now.ToString("MMMM dd, yyyy");

            connection();
            query = "update db_its.tbl_pendingbill_ancillary set status = '"+ paid +"' where hospitalnumber = '"+ txthospitalnumber.Text +"'";
                
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void computation()
        {
            int xray = xrayprice, ecg = ecgprice, ctscan = ctscanprice, hematology = labprice, urinalysis = labprice, fecalysis = labprice, bloodbanking = labprice, clinicalchem = labprice, compute = 0, othersfee = 0, doctorfee = doctorprice, total;

            if (lblhematology.Text == "Yes")
            {
                compute = compute + hematology;
            }

            if (lblurinalysis.Text == "Yes")
            {
                compute = compute + urinalysis;
            }

            if (lblfecalysis.Text == "Yes")
            {
                compute = compute + fecalysis;
            }

            if (lblbloodbanking.Text == "Yes")
            {
                compute = compute + bloodbanking;
            }

            if (lblclinicalchem.Text == "Yes")
            {
                compute = compute + clinicalchem;
            }

            if(lblxray.Text == "Yes")
            {
                compute = compute + xray;
            }

            if(lblecg.Text == "Yes")
            {
                compute = compute + ecg;
            }

            if(lblctscan.Text == "Yes")
            {
                compute = compute + ctscan;
            }

            if (lblotherfee.Text != "")
            {
               
                othersfee = int.Parse(lblotherfee.Text);

                total = doctorfee + compute + othersfee;

                txttotal.Text = total.ToString();
            }

            if (lblotherfee.Text == "")
            {
                doctorfee = int.Parse(lbldoctorfee.Text);


                total = doctorfee + compute;

                txttotal.Text = total.ToString();
            }
            
        }

        public void ancillarytransaction()
        {
            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss tt");

            date2 = DateTime.Now.ToString("MMddyyyy");
            time2 = DateTime.Now.ToString("hhmmss");

            connection();
            query = "insert into db_its.tbl_ancillary_transaction (transactionid, hospitalnumber, surname, firstname, middlename, total, discount, amount, changed, username, billingstatus, time, date) values ('" 
                + date2 + time2 + "','" + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + txttotal.Text + "','" + txtdiscount.Text + "','"
                + txtamount.Text + "','" + txtchange.Text + "','" + name + "','" + kindofindigent + "','" + time + "','" + date + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void laboratorypendingcheckup()
        {
            connection();
            query = "insert into db_its.tbl_laboratorypendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, hematology, urinalysis, fecalysis, bloodbanking, clinicalchem, physician) values ('"
                + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblhematology.Text + "','" + lblurinalysis.Text
                + "','" + lblfecalysis.Text + "','" + lblbloodbanking.Text + "','" + lblclinicalchem.Text + "','" + lblphysician.Text + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void xraypendingcheckup()
        {
            connection();
            query = "insert into db_its.tbl_xraypendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblphysician.Text + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void ecgpendingcheckup()
        {
            connection();
            query = "insert into db_its.tbl_ecgpendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblphysician.Text + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void ctscanpendingcheckup()
        {
            connection();
            query = "insert into db_its.tbl_ctscanpendingcheckup (hospitalnumber, surname, firstname, middlename, age, sex, physician) values ('"
                + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblphysician.Text + "')";

            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void qlaboratory()
        {
            qnumberlaboratory.Maximum = int.Parse(labq);

            connection();
            query = "select * from db_its.tbl_qnumbers";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

               qlabnum = myreader["qlabvalue"].ToString();
            }
            con.Close();


            if (qlabnum == labq)
            {
                MessageBox.Show("Maximum patient reached in Laboratory. Queue number for Laboratory will now reset");
                

                connection();
                query = "update db_its.tbl_qnumbers set qlabvalue = '" + "1" + "'";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    qnumberlaboratory.Value = int.Parse(myreader["qlabvalue"].ToString());
                }

                con.Close();

                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qnumberlaboratory.Value = int.Parse(myreader["qlabvalue"].ToString());
                }
                con.Close();   
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qlabnum = myreader["qlabvalue"].ToString();

                    int count = int.Parse(qlabnum);
                    ++count;

                    connection();
                    query = "update db_its.tbl_qnumbers set qlabvalue = '" + count + "'";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                    qnumberlaboratory.Value = count;
                }
                con.Close();
            }
        }

        public void qecg()
        {
            qnumberecg.Maximum = int.Parse(ecgq);

            connection();
            query = "select * from db_its.tbl_qnumbers";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                qecgnum = myreader["qecgvalue"].ToString();
            }
            con.Close();


            if (qecgnum == ecgq)
            {
                MessageBox.Show("Maximum patient reached in Ecg. Queue number for Ecg will now reset");
                
               

                connection();
                query = "update db_its.tbl_qnumbers set qecgvalue = '" + "1" + "'";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    qnumberecg.Value = int.Parse(myreader["qecgvalue"].ToString());
                }

                con.Close();

                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qnumberecg.Value = int.Parse(myreader["qecgvalue"].ToString());
                }
                con.Close();   
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qecgnum = myreader["qecgvalue"].ToString();

                    int count = int.Parse(qecgnum);
                    count++;

                    connection();
                    query = "update db_its.tbl_qnumbers set qecgvalue = '" + count + "'";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                    qnumberecg.Value = count;
                }
                con.Close();
            }
        }

        public void qxray()
        {
            qnumberxray.Maximum = int.Parse(xrayq);

            connection();
            query = "select * from db_its.tbl_qnumbers";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                qecgnum = myreader["qxrayvalue"].ToString();
            }
            con.Close();


            if (qxraynum == xrayq)
            {
                MessageBox.Show("Maximum patient reached in Xray / Ultrasound. Queue number for Xray / Ultrasound will now reset");

                connection();
                query = "update db_its.tbl_qnumbers set qxrayvalue = '" + "1" + "'";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    qnumberxray.Value = int.Parse(myreader["qxrayvalue"].ToString());
                }

                con.Close();

                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qnumberxray.Value = int.Parse(myreader["qxrayvalue"].ToString());
                }
                con.Close();   
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qxraynum = myreader["qxrayvalue"].ToString();

                    int count = int.Parse(qxraynum);
                    count++;

                    connection();
                    query = "update db_its.tbl_qnumbers set qxrayvalue = '" + count + "'";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                    qnumberxray.Value = count;
                }
                con.Close();
            }
        }

        public void qctscan()
        {
           qnumberctscan.Maximum = int.Parse(ctsanq);

            connection();
            query = "select * from db_its.tbl_qnumbers";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            if (myreader.Read())
            {

                qctscannum = myreader["qctscanvalue"].ToString();
            }
            con.Close();


            if (qctscannum == ctsanq)
            {
                MessageBox.Show("Maximum patient reached in Xray / Ultrasound. Queue number for Xray / Ultrasound will now reset");

                connection();
                query = "update db_its.tbl_qnumbers set qctscanvalue = '" + "1" + "'";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {
                    qnumberctscan.Value = int.Parse(myreader["qctscanvalue"].ToString());
                }

                con.Close();

                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qnumberctscan.Value = int.Parse(myreader["qctscanvalue"].ToString());
                }
                con.Close();   
            }

            else
            {
                connection();
                query = "select * from db_its.tbl_qnumbers";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                if (myreader.Read())
                {

                    qctscannum = myreader["qctscanvalue"].ToString();

                    int count = int.Parse(qctscannum);
                    count++;

                    connection();
                    query = "update db_its.tbl_qnumbers set qctscanvalue = '" + count + "'";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                    qnumberctscan.Value = count;
                }
                con.Close();
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("yyyy-MM-dd");
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_pendingbill_ancillary where status = '" + status + "' and date = '" + date + "' or status = '"+ status +"'";
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
                item.SubItems.Add(myreader["xray"].ToString());
                item.SubItems.Add(myreader["ecg"].ToString());
                item.SubItems.Add(myreader["ctscan"].ToString());
                item.SubItems.Add(myreader["hematology"].ToString());
                item.SubItems.Add(myreader["urinalysis"].ToString());
                item.SubItems.Add(myreader["fecalysis"].ToString());
                item.SubItems.Add(myreader["bloodbanking"].ToString());
                item.SubItems.Add(myreader["clinicalchem"].ToString());
                item.SubItems.Add(myreader["otherfee"].ToString());
                item.SubItems.Add(myreader["physician"].ToString());

                
                
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
                lblpatientsname.Text = item.SubItems[1].Text +", "+ item.SubItems[2].Text +" "+ item.SubItems[3].Text;
                lblage.Text = item.SubItems[4].Text;
                lblsex.Text = item.SubItems[5].Text;
                lblxray.Text = item.SubItems[6].Text;
                lblecg.Text = item.SubItems[7].Text;
                lblctscan.Text = item.SubItems[8].Text;
                lblhematology.Text = item.SubItems[9].Text;
                lblurinalysis.Text = item.SubItems[10].Text;
                lblfecalysis.Text = item.SubItems[11].Text;
                lblbloodbanking.Text = item.SubItems[12].Text;
                lblclinicalchem.Text = item.SubItems[13].Text;
                lblotherfee.Text = item.SubItems[14].Text;
                lblphysician.Text = item.SubItems[15].Text;

                surname = item.SubItems[1].Text;
                firstname = item.SubItems[2].Text;
                middlename = item.SubItems[3].Text;


                if (lblhematology.Text == "Yes")
                {
                    lblhemafee.Text = labprice.ToString();
                }

                if (lblurinalysis.Text == "Yes")
                {
                    lblurifee.Text = labprice.ToString();
                }

                if (lblfecalysis.Text == "Yes")
                {
                    lblfecafee.Text = labprice.ToString();
                }

                if (lblbloodbanking.Text == "Yes")
                {
                    lblbloodbankingfee.Text = labprice.ToString();
                }

                if (lblclinicalchem.Text == "Yes")
                {
                    lblclinicalchemfee.Text = labprice.ToString();
                }

                if (lblxray.Text == "Yes")
                {
                    lblxrayfee.Text = xrayprice.ToString();
                }

                if (lblecg.Text == "Yes")
                {
                    lblecgfee.Text = ecgprice.ToString();
                }

                if (lblctscan.Text == "Yes")
                {
                    lblctscanfee.Text = ctscanprice.ToString();
                }

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

                int a = int.Parse(lblage.Text);

                if (a <= 59)
                {
                    rdbseniorcitizen.Enabled = false;
                }

                else if (a > 59)
                {
                    rdbseniorcitizen.Enabled = true;
                }
            }

            catch 
            {

            }

            computation();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearchbox.Text == "")
            {
                MessageBox.Show("Please insert either Patient - ID or Patient Surname");
            }

            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
                connection();
                listView1.Items.Clear();
                query = "select * from db_its.tbl_pendingbill_ancillary where  status = '" + status + "' and date = '" + date + "' or status = '" + status + "' and hospitalnumber like  '%" + txthospitalnumber.Text.Replace("'", "''") + "%' and surname like '%" + txthospitalnumber.Text.Replace("'", "''") + "%'";
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
                    item.SubItems.Add(myreader["xray"].ToString());
                    item.SubItems.Add(myreader["ecg"].ToString());
                    item.SubItems.Add(myreader["ctscan"].ToString());
                    item.SubItems.Add(myreader["hematology"].ToString());
                    item.SubItems.Add(myreader["urinalysis"].ToString());
                    item.SubItems.Add(myreader["fecalysis"].ToString());
                    item.SubItems.Add(myreader["bloodbanking"].ToString());
                    item.SubItems.Add(myreader["clinicalchem"].ToString());
                    item.SubItems.Add(myreader["otherfee"].ToString());
                    item.SubItems.Add(myreader["physician"].ToString());


                    listView1.Items.Add(item);
                }

                con.Close();
            }
        }
        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            if (txtamount.Text == "")
            {
                txtchange.Text = "";
                txtdiscount.Text = "0";
            }
            
            else
            {
                if (txtamount.Text != "")
                {
                    double a, b, c;

                    a = int.Parse(txttotal.Text);
                    b = int.Parse(txtamount.Text);

                    c = b - a;


                    txtchange.Text = c.ToString();
                }

                if (rdbseniorcitizen.Checked == true && txtamount.Text != "")
                {
                    double a, b, c, d, f;

                    a = int.Parse(txttotal.Text);
                    c = int.Parse(txtamount.Text);

                    b = a * discount;

                    d = a - b;

                    f = c - d;

                    txtdiscount.Text = b.ToString();
                    txtchange.Text = f.ToString();
                }

                if (rdbpwd.Checked == true && txtamount.Text != "")
                {
                    double a, b, c, d, f;

                    a = int.Parse(txttotal.Text);
                    c = int.Parse(txtamount.Text);

                    b = a * discount;

                    d = a - b;

                    f = c - d;

                    txtdiscount.Text = b.ToString();
                    txtchange.Text = f.ToString();
                }


            }
        }
        
        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }



        private void btnsavetransaction_Click(object sender, EventArgs e)
        {
            
            if (ckbindijent.Checked == false)
            {
                string billingstat = "";

                date2 = DateTime.Now.ToString("MMddyyyy");
                time2 = DateTime.Now.ToString("hhmmss");


                if (txthospitalnumber.Text == "")
                {
                    MessageBox.Show("Please choose a patient");
                }

                else if (txtamount.Text == "")
                {
                    MessageBox.Show("Amount field is Blank. Please input the right amount");
                }

                else if (int.Parse(txtamount.Text) < int.Parse(txttotal.Text))
                {
                    MessageBox.Show("Payment is insufficient");
                }


                else if (lblhematology.Text == "No" && lblurinalysis.Text == "No" && lblfecalysis.Text == "No" && lblbloodbanking.Text == "No" && lblclinicalchem.Text == "No" && lblxray.Text == "No" && lblecg.Text == "No" && lblctscan.Text == "No")
                {

                    ancillarytransaction();
                    updateofpendingbill();



                    MessageBox.Show("Transaction has been saved.");

                    new AncillaryReceipt(txthospitalnumber.Text,
                        date2 + time2,
                        lblpatientsname.Text,
                        lblotherfee.Text,
                        lbldoctorfee.Text,
                        txttotal.Text,
                        txtdiscount.Text,
                        txtamount.Text,
                        txtchange.Text,
                        name,
                        billingstat).ShowDialog();


                    listView1.Items.Clear();
                    txthospitalnumber.Text = "";
                    lblpatientsname.Text = "";
                    lblage.Text = "";
                    lblsex.Text = "";
                    lblphysician.Text = "";
                    lblhematology.Text = "";
                    lblurinalysis.Text = "";
                    lblfecalysis.Text = "";
                    lblbloodbanking.Text = "";
                    lblclinicalchem.Text = "";
                    lblotherfee.Text = "";
                    lblxray.Text = "";
                    lblecg.Text = "";
                    lblctscan.Text = "";
                    rdbseniorcitizen.Checked = false;
                    rdbpwd.Checked = false;
                    txttotal.Text = "";
                    txtdiscount.Text = "";
                    txtamount.Text = "";
                    txtchange.Text = "";
                    lblhemafee.Text = "0";
                    lblurifee.Text = "0";
                    lblfecafee.Text = "0";
                    lblbloodbankingfee.Text = "0";
                    lblclinicalchemfee.Text = "0";
                    lblxrayfee.Text = "0";
                    lblecgfee.Text = "0";
                    lblctscanfee.Text = "0";
                    listView1.Items.Clear();

                    viewall();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }

                else
                {


                    if (lblhematology.Text == "Yes" || lblurinalysis.Text == "Yes" || lblfecalysis.Text == "Yes" || lblbloodbanking.Text == "Yes" || lblclinicalchem.Text == "Yes" || lblxray.Text == "Yes" || lblecg.Text == "Yes" || lblctscan.Text == "Yes")
                    {

                        ancillarytransaction();

                    }


                    if (lblhematology.Text == "Yes" || lblurinalysis.Text == "Yes" || lblfecalysis.Text == "Yes" || lblbloodbanking.Text == "Yes" || lblclinicalchem.Text == "Yes")
                    {
                        laboratorypendingcheckup();
                        updateofpendingbill();
                        qlaboratory();
                    }

                    if (lblxray.Text == "Yes")
                    {


                        xraypendingcheckup();
                        updateofpendingbill();
                        qxray();



                    }

                    if (lblecg.Text == "Yes")
                    {


                        ecgpendingcheckup();
                        updateofpendingbill();
                        qecg();



                    }

                    if (lblctscan.Text == "Yes")
                    {


                        ctscanpendingcheckup();
                        updateofpendingbill();
                        qctscan();



                    }

                    MessageBox.Show("Transaction has been saved. Please proceed to the designated Ancillary");

                    new AncillaryReceipt(txthospitalnumber.Text,
                       date2 + time2,
                       lblpatientsname.Text,
                       lblotherfee.Text,
                       lbldoctorfee.Text,
                       txttotal.Text,
                       txtdiscount.Text,
                       txtamount.Text,
                       txtchange.Text,
                       name,
                       billingstat).ShowDialog();

                    listView1.Items.Clear();
                    txthospitalnumber.Text = "";
                    lblpatientsname.Text = "";
                    lblage.Text = "";
                    lblsex.Text = "";
                    lblphysician.Text = "";
                    lblhematology.Text = "";
                    lblurinalysis.Text = "";
                    lblfecalysis.Text = "";
                    lblbloodbanking.Text = "";
                    lblclinicalchem.Text = "";
                    lblotherfee.Text = "";
                    lblxray.Text = "";
                    lblecg.Text = "";
                    lblctscan.Text = "";
                    rdbseniorcitizen.Checked = false;
                    rdbpwd.Checked = false;
                    txttotal.Text = "";
                    txtdiscount.Text = "";
                    txtamount.Text = "";
                    txtchange.Text = "";
                    lblhemafee.Text = "0";
                    lblurifee.Text = "0";
                    lblfecafee.Text = "0";
                    lblbloodbankingfee.Text = "0";
                    lblclinicalchemfee.Text = "0";
                    lblxrayfee.Text = "0";
                    lblecgfee.Text = "0";
                    lblctscanfee.Text = "0";
                    listView1.Items.Clear();

                    viewall();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }

            }

            if (ckbindijent.Checked == true)
            {
                string billingstat = kindofindigent +" Cause for being Indigent."+ txtindigent.Text;

                txtamount.Enabled = false;
                txtamount.Text = txttotal.Text;
                
                

                if (txthospitalnumber.Text == "")
                {
                    MessageBox.Show("Please choose a patient");
                }

                else if (lblhematology.Text == "No" && lblurinalysis.Text == "No" && lblfecalysis.Text == "No" && lblbloodbanking.Text == "No" && lblclinicalchem.Text == "No" && lblxray.Text == "No" && lblecg.Text == "No" && lblctscan.Text == "No")
                {



                    date = DateTime.Now.ToString("yyyy-MM-dd");
                    time = DateTime.Now.ToString("hh:mm:ss tt");

                    date2 = DateTime.Now.ToString("MMddyyyy");
                    time2 = DateTime.Now.ToString("hhmmss");

                    connection();
                    query = "insert into db_its.tbl_ancillary_transaction (transactionid, hospitalnumber, surname, firstname, middlename, total, discount, amount, changed, username, time, date) values ('"
                        + date2 + time2 + "','" + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + txttotal.Text + "','" + txtdiscount.Text + "','"
                        + "Idigent" + "','" + txtchange.Text + "','" + name + "','" + time + "','" + date + "')";

                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();


                    updateofpendingbill();



                    MessageBox.Show("Transaction has been saved.");

                    new AncillaryReceipt(txthospitalnumber.Text,
                        date2 + time2,
                        lblpatientsname.Text,
                        lblotherfee.Text,
                        lbldoctorfee.Text,
                        txttotal.Text,
                        txtdiscount.Text,
                        txtamount.Text,
                        txtchange.Text,
                        name,
                        billingstat).ShowDialog();


                    listView1.Items.Clear();
                    txthospitalnumber.Text = "";
                    lblpatientsname.Text = "";
                    lblage.Text = "";
                    lblsex.Text = "";
                    lblphysician.Text = "";
                    lblhematology.Text = "";
                    lblurinalysis.Text = "";
                    lblfecalysis.Text = "";
                    lblbloodbanking.Text = "";
                    lblclinicalchem.Text = "";
                    lblotherfee.Text = "";
                    lblxray.Text = "";
                    lblecg.Text = "";
                    lblctscan.Text = "";
                    rdbseniorcitizen.Checked = false;
                    rdbpwd.Checked = false;
                    txttotal.Text = "";
                    txtdiscount.Text = "";
                    txtamount.Text = "";
                    txtchange.Text = "";
                    lblhemafee.Text = "0";
                    lblurifee.Text = "0";
                    lblfecafee.Text = "0";
                    lblbloodbankingfee.Text = "0";
                    lblclinicalchemfee.Text = "0";
                    lblxrayfee.Text = "0";
                    lblecgfee.Text = "0";
                    lblctscanfee.Text = "0";
                    txtindigent.Text = "";
                    ckbindijent.Checked = false;
                    rdbgsis.Checked = false;
                    rdbpcso.Checked = false;
                    listView1.Items.Clear();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }

                else
                {


                    if (lblhematology.Text == "Yes" || lblurinalysis.Text == "Yes" || lblfecalysis.Text == "Yes" || lblbloodbanking.Text == "Yes" || lblclinicalchem.Text == "Yes" || lblxray.Text == "Yes" || lblecg.Text == "Yes" || lblctscan.Text == "Yes")
                    {

                        ancillarytransaction();

                    }


                    if (lblhematology.Text == "Yes" || lblurinalysis.Text == "Yes" || lblfecalysis.Text == "Yes" || lblbloodbanking.Text == "Yes" || lblclinicalchem.Text == "Yes")
                    {
                        laboratorypendingcheckup();
                        updateofpendingbill();
                        qlaboratory();
                    }

                    if (lblxray.Text == "Yes")
                    {


                        xraypendingcheckup();
                        updateofpendingbill();
                        qxray();



                    }

                    if (lblecg.Text == "Yes")
                    {


                        ecgpendingcheckup();
                        updateofpendingbill();
                        qecg();



                    }

                    if (lblctscan.Text == "Yes")
                    {


                        ctscanpendingcheckup();
                        updateofpendingbill();
                        qctscan();



                    }

                    MessageBox.Show("Transaction has been saved. Please proceed to the designated Ancillary");

                    new AncillaryReceipt(txthospitalnumber.Text,
                       date2 + time2,
                       lblpatientsname.Text,
                       lblotherfee.Text,
                       lbldoctorfee.Text,
                       txttotal.Text,
                       txtdiscount.Text,
                       txtamount.Text,
                       txtchange.Text,
                       name,
                       billingstat).ShowDialog();

                    listView1.Items.Clear();
                    txthospitalnumber.Text = "";
                    lblpatientsname.Text = "";
                    lblage.Text = "";
                    lblsex.Text = "";
                    lblphysician.Text = "";
                    lblhematology.Text = "";
                    lblurinalysis.Text = "";
                    lblfecalysis.Text = "";
                    lblbloodbanking.Text = "";
                    lblclinicalchem.Text = "";
                    lblotherfee.Text = "";
                    lblxray.Text = "";
                    lblecg.Text = "";
                    lblctscan.Text = "";
                    rdbseniorcitizen.Checked = false;
                    rdbpwd.Checked = false;
                    txttotal.Text = "";
                    txtdiscount.Text = "";
                    txtamount.Text = "";
                    txtchange.Text = "";
                    listView1.Items.Clear();

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Perform a Billing to a Patient " + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
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
            mn.name = name;
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void AncillaryBilling_Load(object sender, EventArgs e)
        {
            qlaboratory();
            qecg();
            qctscan();
            qxray();

            qnumber();
            ancillaryprice();
            doctor();
            deletepaid();

            viewall();

            timer1.Start();



            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time1 != 0)
            {
                time1 = time1 - 1;

                
                qnumber();
                ancillaryprice();
                doctor();
                deletepaid();
            }

            else
            {
                time1 = 5;
            }
        }

        private void ckbindijent_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbindijent.Checked == true)
            {
                gpbdiscounts.Enabled = false;
                txtamount.Enabled = false;
                rdbpwd.Checked = false;
                rdbseniorcitizen.Checked = false;
                groupBox1.Enabled = true;
                
            }

            if (ckbindijent.Checked == false)
            {
                gpbdiscounts.Enabled = true;
                txtamount.Enabled = true;
                rdbpwd.Checked = true;
                rdbseniorcitizen.Checked = true;
                groupBox1.Enabled = false;
            }
            
            
        }

        private void rdbgsis_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbgsis.Checked == true)
            {
                kindofindigent = "Indigent patient and paid by DSWD";
            }
            
        }

        private void rdbpcso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpcso.Checked == true)
            {
                kindofindigent = "Indigent patient and paid by PSCO";
            }

        }

        
      
  }
    
}
