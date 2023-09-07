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
    
    public partial class AdmissionReceipt : Form
    {
        public string transactionid;
        public string patientid;
        public string patientname;
        public string username;
        public string ward;
        public string bed;
        public string hema;
        public string uri;
        public string feca;
        public string blood;
        public string chem;
        public string xray;
        public string ecg;
        public string ctscan;
        public string otherfee;
        public string totalchargebed;
        public string overall;
        public string discount;
        public string amountpaid;
        public string change;
        public string sss;
        public string gsis;
        public string phil;
        public string billingstat;

        public AdmissionReceipt()
        {
            InitializeComponent();
        }

        private void AdmissionReceipt_Load(object sender, EventArgs e)
        {
            crsadmissionreceip ob = new crsadmissionreceip();
             ob.SetParameterValue("number", transactionid );
             ob.SetParameterValue("received", patientname );
             ob.SetParameterValue("name", username );
             ob.SetParameterValue("patientid", patientid );
             ob.SetParameterValue("ward", ward );
             ob.SetParameterValue("bed", bed );
             ob.SetParameterValue("hema", hema );
             ob.SetParameterValue("uri", uri );
             ob.SetParameterValue("feca", feca );
             ob.SetParameterValue("blood", blood );
             ob.SetParameterValue("chem", chem );
             ob.SetParameterValue("xray", xray );
             ob.SetParameterValue("ecg", ecg );
             ob.SetParameterValue("ctscan", ctscan );
             ob.SetParameterValue("otherfee", otherfee );
             ob.SetParameterValue("totalchargebed", totalchargebed );
             ob.SetParameterValue("overall", overall );
             ob.SetParameterValue("discount", discount );
             ob.SetParameterValue("amountpaid", amountpaid );
             ob.SetParameterValue("change", change );
             ob.SetParameterValue("sss", sss);
             ob.SetParameterValue("gsis", gsis);
             ob.SetParameterValue("phil", phil);
             ob.SetParameterValue("billingstatus", billingstat);
             crystalReportViewer1.ReportSource = ob;
             crystalReportViewer1.Refresh();
        }
    }
}
