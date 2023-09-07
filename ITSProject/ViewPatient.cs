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
    public partial class ViewPatient : Form
    {
        public string userid;
        public string acoountposition;
        public string name;

        public ViewPatient()
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

        public string date, time, health;

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
                item.SubItems.Add(myreader["philhealth"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            viewall();

            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(x, y);
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
                    item.SubItems.Add(myreader["philhealth"].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }
        }
        private void btnviewall_Click(object sender, EventArgs e)
        {
            connection();
            listView1.Items.Clear();
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
                item.SubItems.Add(myreader["philhealth"].ToString());
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
                health = item.SubItems[12].Text;

                if (health == "With Philhealth")
                {
                    rdnwith.Checked = true;
                }

                if (health == "Without Philhealth")
                {
                    rdnwithout.Checked = true;
                }

                connection();
                query = "select image from db_its.tbl_basicinfo where hospitalnumber like '%" + txthospitalnumber.Text + "%' ";
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

            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (txthospitalnumber.Text == "")
            {
                MessageBox.Show("Please select a patient");
            }

           else if(txtsurname.Text == "" || txtfirstname.Text == "" || cmbsex.Text == "" || txtaddress.Text == "" || txtht.Text == "" || txtwt.Text == "")
            {
                MessageBox.Show("Please fill up all required fields");
            }

            else if (txtcontact.Text.Length < 13 || txtcontact.Text.Length < 9 && txtcontact.Text.Length > 9)
            {
                MessageBox.Show("Please put your Contact number. or Your number is Invalid");
            }

            else if (txtfilepath.Text == "")
            {
                connection();
                query = "update db_its.tbl_basicinfo set surname = '" + txtsurname.Text + " " + "', firstname = '" + txtfirstname.Text + " " + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text.Replace("'", "''") + "', occupation = '" + txtoccupation.Text + "', contactnumber = '" + txtcontact.Text.Replace("'", "''") + "', ht = '" + txtht.Text.Replace("'", "''") + "', wt = '" + txtwt.Text + "', philhealth = '" + health + "'   where hospitalnumber = '" + txthospitalnumber.Text + "' ";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                MessageBox.Show("Patient Info has been Updated");
                con.Close();

                txtfilepath.Text = "";
                txthospitalnumber.Text = "";
                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                txtage.Text = "0";
                cmbsex.Text = "";
                txtcontact.Text = "";
                txtoccupation.Text = "";
                txtaddress.Text = "";
                listView1.Items.Clear();

                viewall();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Update a patient basic info " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            }
            else
            {

                byte[] imagebt = null;
                FileStream fstream = new FileStream(this.txtfilepath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagebt = br.ReadBytes((int)fstream.Length);

                connection();
                query = "update db_its.tbl_basicinfo set surname = '" + txtsurname.Text + "', firstname = '" + txtfirstname.Text + "', middlename = '" + txtmiddlename.Text + "', birthdate = '" + dateTimePicker1.Text + "', age = '" + txtage.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddress.Text + "', occupation = '" + txtoccupation.Text + "', contactnumber = '" + txtcontact.Text + "', image = @IMG where hospitalnumber like '%" + txthospitalnumber.Text + "%' ";
                command = new MySqlCommand(query, con);
                command.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                myreader = command.ExecuteReader();
                MessageBox.Show("Patient Info has been Updated");
                con.Close();

                txtfilepath.Text = "";
                txthospitalnumber.Text = "";
                txtsurname.Text = "";
                txtfirstname.Text = "";
                txtmiddlename.Text = "";
                txtage.Text = "0";
                cmbsex.SelectedIndex = -1;
                txtcontact.Text = "";
                txtoccupation.Text = "";
                txtaddress.Text = "";
                pictureBox1.Image = null;
                listView1.Items.Clear();

                viewall();

                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Click a button" + "','" + "User " + userid + " Update a patient basic info " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();
            
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

        private void txtht_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar) && e.KeyChar != '\'');
        }

        private void txtwt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
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