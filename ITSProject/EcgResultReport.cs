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
    public partial class EcgResultReport : Form
    {
        public string patientname;
        public string date;
        public string ecgresult;

        public EcgResultReport(string patientname,
         string date,
         string ecgresult)
        {

            this.patientname = patientname;
            this.date = date;
            this.ecgresult = ecgresult;

            InitializeComponent();
        }

        private void EcgResultReport_Load(object sender, EventArgs e)
        {
            crsecg ob = new crsecg();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("result", ecgresult);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
