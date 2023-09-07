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
    public partial class XrayResultReport : Form
    {
        public string patientname;
        public string date;
        public string xrayresult;

        public XrayResultReport(string patientname,
         string date,
         string xrayresult)
        {
            this.patientname = patientname;
            this.date = date;
            this.xrayresult = xrayresult;


            InitializeComponent();
        }

        private void XrayResultReport_Load(object sender, EventArgs e)
        {
            crsxray ob = new crsxray();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("result", xrayresult);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
