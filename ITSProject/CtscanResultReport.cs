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
    public partial class CtscanResultReport : Form
    {
        public string patientname;
        public string date;
        public string ctscanresult;

        public CtscanResultReport(string patientname,
         string date,
         string ctscanresult)

        {

            this.patientname = patientname;
            this.date = date;
            this.ctscanresult = ctscanresult;

            InitializeComponent();
        }

        private void CtscanResultReport_Load(object sender, EventArgs e)
        {
            crsctscan ob = new crsctscan();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("result", ctscanresult);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
