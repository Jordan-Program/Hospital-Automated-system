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
    public partial class HematologyRecordReports : Form
    {
        public string patientname;
        public string age;
        public string sex;
        public string date;
        public string physician;
        public string labid;
        public string hemoglobin;
        public string hematocrit;
        public string rbccount;
        public string wbccount;
        public string plateletcount;
        public string differentialcount;
        public string neutrophils;
        public string lymphocytes;
        public string monocytes;
        public string eosinophils;
        public string basophils;
        public string stabs;
        public string others;
        public string othertests;

        public HematologyRecordReports(  string patientname,
          string age,
          string sex,
          string date,
          string physician,
          string labid,
          string hemoglobin,
          string hematocrit,
          string rbccount,
          string wbccount,
          string plateletcount,
          string differentialcount,
          string neutrophils,
          string lymphocytes,
          string monocytes,
          string eosinophils,
          string basophils,
          string stabs,
          string others,
          string othertests)
        {

            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.date = date;
            this.physician = physician;
            this.labid = labid;
            this.hemoglobin = hemoglobin;
            this.hematocrit = hematocrit;
            this.rbccount = rbccount;
            this.wbccount = wbccount;
            this.plateletcount = plateletcount;
            this.differentialcount = differentialcount;
            this.neutrophils = neutrophils;
            this.lymphocytes = lymphocytes;
            this.monocytes = monocytes;
            this.eosinophils = eosinophils;
            this.basophils = basophils;
            this.stabs = stabs;
            this.others = others;
            this.othertests = othertests;

            InitializeComponent();
        }

        private void HematologyRecordReports_Load(object sender, EventArgs e)
        {
            crshematology ob = new crshematology();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("age", age);
            ob.SetParameterValue("sex", sex);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("physician", physician);
            ob.SetParameterValue("labid", labid);
            ob.SetParameterValue("hemoglobin", hemoglobin);
            ob.SetParameterValue("hematocrit", hematocrit);
            ob.SetParameterValue("rbccount", rbccount);
            ob.SetParameterValue("wbccount", wbccount);
            ob.SetParameterValue("plateletcount", plateletcount);
            ob.SetParameterValue("differentialcount", differentialcount);
            ob.SetParameterValue("neutrophils", neutrophils);
            ob.SetParameterValue("lymphocytes", lymphocytes);
            ob.SetParameterValue("monocytes", monocytes);
            ob.SetParameterValue("eosinophils", eosinophils);
            ob.SetParameterValue("basophils", basophils);
            ob.SetParameterValue("stabs", stabs);
            ob.SetParameterValue("other", others);
            ob.SetParameterValue("othertest", othertests);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
