using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITSProject
{
    public partial class AncillaryReceipt : Form
    {
        
        public string patiendid;
        public string transactionnumber;
        public string patientname;
        public string otherfee;
        public string doctorfee;
        public string amountdue;
        public string discount;
        public string amountpaid;
        public string change;
        public string name;
        public string billingstatus;

        public AncillaryReceipt(string patiendid,
        string transactionnumber,
        string patientname,
        string otherfee,
        string doctorfee,
        string amountdue,
        string discount,
        string amountpaid,
        string change,
        string name,
        string billingstatus)
        {
            this.patiendid = patiendid;
            this.transactionnumber = transactionnumber;
            this.patientname = patientname;
            this.otherfee = otherfee;
            this.doctorfee = doctorfee;
            this.amountdue = amountdue;
            this.discount = discount;
            this.amountpaid = amountpaid;
            this.change = change;
            this.name = name;
            this.billingstatus = billingstatus;

            InitializeComponent();
        }

        private void AncillaryReceipt_Load(object sender, EventArgs e)
        {
            crsancillaryreceipt ob = new crsancillaryreceipt();
            ob.SetParameterValue("number", transactionnumber);
            ob.SetParameterValue("patientid", patiendid);
            ob.SetParameterValue("received", patientname);
            ob.SetParameterValue("othersfee", otherfee);
            ob.SetParameterValue("doctorfee", doctorfee);
            ob.SetParameterValue("amountdue", amountdue);
            ob.SetParameterValue("discount", discount);
            ob.SetParameterValue("amountpaid", amountpaid);
            ob.SetParameterValue("change", change);
            ob.SetParameterValue("name",name);
            ob.SetParameterValue("billingstatus", billingstatus);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
