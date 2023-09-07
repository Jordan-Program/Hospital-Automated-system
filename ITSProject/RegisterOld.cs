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
    public partial class RegisterOld : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public RegisterOld()
        {
            InitializeComponent();
            doctors();


            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss");

        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;

        public string date, time, surname, firstname, middlename;


        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }
        
        private void RegisterOld_Load(object sender, EventArgs e)
        {
            viewall();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
        }


        public void viewall()
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
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView1.Items.Add(item);
            }

            con.Close();
        }

        public void doctors()
        {
            connection();
            query = "select * from db_its.tbl_doctor where department = '" + cmbdepartment.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                cmbdoctor.Items.Add(myreader["doctorname"].ToString());
            }

            con.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
            query = "select * from db_its.tbl_basicinfo where patientstatus = '"+ "Out - Patient" +"'";
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
                item.SubItems.Add(myreader["ht"].ToString());
                item.SubItems.Add(myreader["wt"].ToString());
                item.SubItems.Add(myreader["address"].ToString());
                item.SubItems.Add(myreader["occupation"].ToString());
                item.SubItems.Add(myreader["contactnumber"].ToString());
                item.SubItems.Add(myreader["time"].ToString());
                item.SubItems.Add(myreader["date"].ToString());
                listView1.Items.Add(item);
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
                listView1.Items.Clear();
                query = "select * from db_its.tbl_basicinfo where patientstatus = '" + "Out - Patient" + "' and hospitalnumber like '%" + txtsearchbox.Text.Replace("'", "''") + "%' or patientstatus = '" + "Out - Patient" + "' and surname like '%" + txtsearchbox.Text.Replace("'", "''") + "%' ";
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
                    item.SubItems.Add(myreader["ht"].ToString());
                    item.SubItems.Add(myreader["wt"].ToString());
                    item.SubItems.Add(myreader["address"].ToString());
                    item.SubItems.Add(myreader["occupation"].ToString());
                    item.SubItems.Add(myreader["contactnumber"].ToString());
                    item.SubItems.Add(myreader["time"].ToString());
                    item.SubItems.Add(myreader["date"].ToString());
                    listView1.Items.Add(item);

                }
                con.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0) return;
                ListViewItem item = listView1.SelectedItems[0];
                txthospitalnumber.Text = item.SubItems[0].Text;
                lblpatientsname.Text = item.SubItems[1].Text + ", " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                lblbirthdate.Text = item.SubItems[4].Text;
                lblage.Text = item.SubItems[5].Text;
                lblsex.Text = item.SubItems[6].Text;
                lblht.Text = item.SubItems[7].Text;
                lblwt.Text = item.SubItems[8].Text;
                lbladdress.Text = item.SubItems[9].Text;
                lbloccupation.Text = item.SubItems[10].Text;
                lblcontact.Text = item.SubItems[11].Text;

                surname = item.SubItems[1].Text;
                firstname = item.SubItems[2].Text;
                middlename = item.SubItems[3].Text;


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
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txthospitalnumber.Text == "")
            {
                MessageBox.Show("Choose a patient");
            }

            if (txtchiefcomplaint.Text == "" || txthpi.Text == "" || txtbp.Text == "" || txtcr.Text == "" || txtrr.Text == "" || txttemp.Text == "")
            {
                MessageBox.Show("Please fill up all required field");

            }

            if (cmbdoctor.Text == "")
            {
                MessageBox.Show("Please choose a Doctor");
            }

            else
            {
                date = DateTime.Now.ToString("MMMM dd, yyyy");
                time = DateTime.Now.ToString("hh:mm:ss tt");

                connection();
                query = "insert into db_its.tbl_clinicalrecord (hospitalnumber, surname, firstname, middlename, age, sex, birthdate, ht, wt, address, occupation, contactnumber, chiefcomplaint, hpi, bp, cr, rr, temp, residentonduty, time, date) values ('"
                    + txthospitalnumber.Text + "','" + surname + "','" + firstname + "','" + middlename + "','" + lblage.Text + "','" + lblsex.Text + "','" + lblbirthdate.Text + "','" + lblht.Text.Replace("'", "''") + "','"
                    + lblwt.Text + "','" + lbladdress.Text.Replace("'", "''") + "','" + lbloccupation.Text.Replace("'", "''") + "','" + lblcontact.Text + "','" + txtchiefcomplaint.Text.Replace("'", "''") + "','" + txthpi.Text.Replace("'", "''") + "','" + txtbp.Text + "','" + txtcr.Text + "','" + txtrr.Text + "','" + txttemp.Text + "','" + cmbdoctor.Text + "','" + time + "','" + date + "')";

                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Record Saved");

                txthospitalnumber.Text = "";
                lblpatientsname.Text = "";
                lblage.Text = "";
                lblsex.Text = "";
                lblbirthdate.Text = "";
                lblwt.Text = "";
                lblht.Text = "";
                lbladdress.Text = "";
                lbloccupation.Text = "";
                lblcontact.Text = "";
                txtchiefcomplaint.Text = "";
                txthpi.Text = "";
                txtbp.Text = "";
                txtcr.Text = "";
                txtrr.Text = "";
                txttemp.Text = "";
                pictureBox1.Image = null;
                cmbdoctor.SelectedIndex = -1;
                cmbdepartment.SelectedIndex = -1;
                listView1.Items.Clear();

                viewall();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Examine old Patient " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
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

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.userid = userid;
            mn.acoountposition = acoountposition;
            mn.name = name;
            mn.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void cmbdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            doctors();
        }

    }

      
}
