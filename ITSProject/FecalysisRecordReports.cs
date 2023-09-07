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
    public partial class FecalysisRecordReports : Form
    {
        public string patientname;
        public string age;
        public string sex;
        public string date;
        public string physician;
        public string labid;
        public string color;
        public string consistency;
        public string parasites;
        public string leukocytes;
        public string erythrocytes;
        public string fatglobules;
        public string starchgranules;
        public string occultblood;
        public string remarks;

        public FecalysisRecordReports(string patientname,
         string age,
         string sex,
         string date,
         string physician,
         string labid,
         string color,
         string consistency,
         string parasites,
         string leukocytes,
         string erythrocytes,
         string fatglobules,
         string starchgranules,
         string occultblood,
         string remarks)
        {
            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.date = date;
            this.physician = physician;
            this.labid = labid;
            this.color = color;
            this.consistency = consistency;
            this.parasites = parasites;
            this.leukocytes = leukocytes;
            this.erythrocytes = erythrocytes;
            this.fatglobules = fatglobules;
            this.starchgranules = starchgranules;
            this.occultblood = occultblood;
            this.remarks = remarks;

            InitializeComponent();
        }

        private void FecalysisRecordReports_Load(object sender, EventArgs e)
        {
            crsfecalysis ob = new crsfecalysis();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("physician", physician);
            ob.SetParameterValue("age", age);
            ob.SetParameterValue("sex", sex);
            ob.SetParameterValue("labid", labid);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("color", color);
            ob.SetParameterValue("consistency", consistency);
            ob.SetParameterValue("parasites", parasites);
            ob.SetParameterValue("leukocytes", leukocytes);
            ob.SetParameterValue("erythrocytes", erythrocytes);
            ob.SetParameterValue("fatglobules", fatglobules);
            ob.SetParameterValue("starchgranules", starchgranules);
            ob.SetParameterValue("occultblood", occultblood);
            ob.SetParameterValue("remarks", remarks);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();

        }   

        
    }
}
