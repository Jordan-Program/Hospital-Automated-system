using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITSProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public string its;
        public MySqlConnection con;
        public MySqlCommand command;
        public MySqlDataReader myreader;
        public string query;
        int count = 0, count2 = 0;

        public string username, username1, name, date, time, userid, accountstatus, adminuser = "overcomer", adminpass = "overcomer", acoountposition;
        public string password;
        public string defaultpass = "Solidians";
        public string pass;



        public void connection()
        {
            its = "datasource=localhost;port=3306;username=root;password=";
            con = new MySqlConnection(its);
            con.Open();
        }



        public void attempt()
        {
            connection();
            query = "update db_its.tbl_accounts set attempts = attempts + 1 where username = '" + txtusername.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();

        }

        public void resetpass()
        {
            connection();
            query = "update db_its.tbl_accounts set password = '" + defaultpass + "' where username = '" + txtusername.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        public void resetattept()
        {
            connection();
            query = "update db_its.tbl_accounts set attempts = 0 where username = '" + txtusername.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss tt");

            connection();
            query = "select accountposition, username, password, accountstat from db_its.tbl_accounts where username = '" + txtusername.Text + "'";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                pass = myreader["password"].ToString();
                username1 = myreader["username"].ToString();
                accountstatus = myreader["accountstat"].ToString();
                acoountposition = myreader["accountposition"].ToString();



            }
            con.Close();

            if (txtusername.Text == adminuser && txtpassword.Text == adminpass)
            {
                userid = "0000";
                name = "Developers";
                
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Login Succes" + "','" + "User " + userid + "Succesfully Log in " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                MessageBox.Show("Login Successful");
                resetattept();
                this.Hide();
                MainMenu f2 = new MainMenu();
                f2.userid = userid;
                f2.name = name;
                f2.acoountposition = acoountposition;
                f2.ShowDialog();

                this.Hide();
                this.Close();
            }

            else if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Input Username and Password");
            }

            else if (txtusername.Text != username1 && txtpassword.Text != pass)
            {
                MessageBox.Show("Unknown user and pass");
            }

            else if (accountstatus != "Active")
            {
                MessageBox.Show("This Account is no longer available");
            }

            else if (pass == defaultpass)
            {
                MessageBox.Show("This account has been Blocked");
            }



            else
            {

                connection();
                query = "select username,password,firstname,attempts from db_its.tbl_accounts where username = '" + txtusername.Text + "' and password ='" + txtpassword.Text + "';";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {


                    count2 = Convert.ToInt32(myreader["attempts"].ToString());
                    count++;
                }

                con.Close();

                connection();
                query = "select username,password,surname,firstname,middlename,attempts,userid from db_its.tbl_accounts where username = '" + txtusername.Text + "';";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    name = (myreader["surname"].ToString());
                    count2 = Convert.ToInt32(myreader["attempts"].ToString());
                    userid = myreader["userid"].ToString();
                }

                con.Close();

                if (count == 1)
                {



                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Login Succes" + "','" + "User " + userid + "Succesfully Log in " + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Login Successful");
                    resetattept();
                    this.Hide();
                    MainMenu f2 = new MainMenu();
                    f2.userid = userid;
                    f2.name = name;
                    f2.acoountposition = acoountposition;
                    f2.ShowDialog();



                    this.Close();




                }
                else if (txtusername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Please Input Your UserName and Password");
                    txtusername.Focus();
                }

                else if (count2 == 0 && name != "" && acoountposition != "Admin")
                {

                    MessageBox.Show("Incorrect Password: first attempt for " + name + " account");

                    attempt();
                    txtpassword.Text = "";
                    txtusername.Text = "";

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Log - in error" + "','" + "User " + userid + " have a wrong pass. First attempt" + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }

                else if (count2 == 1 && name != "" && acoountposition != "Admin")
                {
                    MessageBox.Show("Incorrect Password: second attempt for " + name + " account");

                    attempt();
                    txtpassword.Text = "";
                    txtusername.Text = "";

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Log - in error" + "','" + "User " + userid + " have a wrong pass. Second attempt" + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }
                else if (count2 == 2 && name != "" && acoountposition != "Admin")
                {
                    MessageBox.Show("You have incorrectly logged in " + name + " account. This account will be Blocked after this Message");


                    attempt();
                    resetpass();
                    resetattept();
                    txtpassword.Text = "";
                    txtusername.Text = "";

                    connection();
                    query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Log - in error" + "','" + "User " + userid + " have a wrong pass. Three attempt. User Account blocked" + "','" + date + " " + time + "')";
                    command = new MySqlCommand(query, con);
                    myreader = command.ExecuteReader();
                    con.Close();
                }


                else
                {
                    MessageBox.Show("Incorrect User and Pass");
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection();
                query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + userid + "','" + "Login Succes" + "','" + "User " + userid + "Close the system " + "','" + date + " " + time + "')";
                command = new MySqlCommand(query, con);
                myreader = command.ExecuteReader();
                con.Close();

                this.Hide();
                this.Close();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            date = DateTime.Now.ToString("yyyy-MM-dd");
            time = DateTime.Now.ToString("hh:mm:ss tt");

            connection();
            query = "insert into db_its.tbl_audittrail (user,action,message,datetime) values ('" + "System" + "','" + "System Start" + "','" + " System Start... " + "','" + date + " " + time + "')";
            command = new MySqlCommand(query, con);
            myreader = command.ExecuteReader();
            con.Close();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && ((!char.IsDigit(e.KeyChar)));
        }

        

    }
}