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
    public partial class ClinicalChemRecordReports : Form
    {
        public string patientname;
        public string age;
        public string sex;
        public string date;
        public string physician;
        public string labid;
        public string glucose;
        public string urea;
        public string creatinine;
        public string uricacid;
        public string triglycerides;
        public string cholesterol;
        public string hdl;
        public string ldl;
        public string sgpt;
        public string sgot;
        public string sodium;
        public string potassium;
        public string chloride;
        
        public string glucose2;
        public string urea2;
        public string creatinine2;
        public string uricacid2;
        public string triglycerides2;
        public string cholesterol2;
        public string hdl2;
        public string ldl2;
        public string sgpt2;
        public string sgot2;
        public string sodium2;
        public string potassium2;
        public string chloride2;

        public string remarks;

        public ClinicalChemRecordReports(string patientname,
        string age,
        string sex,
        string date,
        string physician,
        string labid,
        string glucose,
        string urea,
        string creatinine,
        string uricacid,
        string triglycerides,
        string cholesterol,
        string hdl,
        string ldl,
        string sgpt,
        string sgot,
        string sodium,
        string potassium,
        string chloride,
        string glucose2,
        string urea2,
        string creatinine2,
        string uricacid2,
        string triglycerides2,
        string cholesterol2,
        string hdl2,
        string ldl2,
        string sgpt2,
        string sgot2,
        string sodium2,
        string potassium2,
        string chloride2,
        string remarks)
        {

            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.date = date;
            this.physician = physician;
            this.labid = labid;
            this.glucose = glucose;
            this.urea = urea;
            this.creatinine = creatinine;
            this.uricacid = uricacid;
            this.triglycerides = triglycerides;
            this.cholesterol = cholesterol;
            this.hdl = hdl;
            this.ldl = ldl;
            this.sgpt = sgpt;
            this.sgot = sgot;
            this.sodium = sodium;
            this.potassium = potassium;
            this.chloride = chloride;

            this.glucose2 = glucose2;
            this.urea2 = urea2;
            this.creatinine2 = creatinine2;
            this.uricacid2 = uricacid2;
            this.triglycerides2 = triglycerides2;
            this.cholesterol2 = cholesterol2;
            this.hdl2 = hdl2;
            this.ldl2 = ldl2;
            this.sgpt2 = sgpt2;
            this.sgot2 = sgot2;
            this.sodium2 = sodium2;
            this.potassium2 = potassium2;
            this.chloride2 = chloride2;

            this.remarks = remarks;

            InitializeComponent();
        }

        private void ClinicalChemRecordReports_Load(object sender, EventArgs e)
        {
            crsclinicalchem ob = new crsclinicalchem();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("physician", physician);
            ob.SetParameterValue("age", age);
            ob.SetParameterValue("sex", sex);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("labid", labid);
            ob.SetParameterValue("glucose", glucose);
            ob.SetParameterValue("ureanitrogen", urea);
            ob.SetParameterValue("creatinine", creatinine);
            ob.SetParameterValue("uricacid", uricacid);
            ob.SetParameterValue("triglycerides", triglycerides);
            ob.SetParameterValue("cholesterol", cholesterol);
            ob.SetParameterValue("hdl", hdl);
            ob.SetParameterValue("ldl", ldl);
            ob.SetParameterValue("sgpt", sgpt);
            ob.SetParameterValue("sgot", sgot);
            ob.SetParameterValue("sodium", sodium);
            ob.SetParameterValue("potassium", potassium);
            ob.SetParameterValue("chloride", chloride);
            ob.SetParameterValue("glucose2", glucose2);
            ob.SetParameterValue("ureanitrogen2", urea2);
            ob.SetParameterValue("creatinine2", creatinine2);
            ob.SetParameterValue("uricacid2", uricacid2);
            ob.SetParameterValue("triglycerides2", triglycerides2);
            ob.SetParameterValue("cholesterol2", cholesterol2);
            ob.SetParameterValue("hdl2", hdl2);
            ob.SetParameterValue("ldl2", ldl2);
            ob.SetParameterValue("sgpt2", sgpt2);
            ob.SetParameterValue("sgot2", sgot2);
            ob.SetParameterValue("sodium2", sodium2);
            ob.SetParameterValue("potassium2", potassium2);
            ob.SetParameterValue("chloride2", chloride2);
            ob.SetParameterValue("remarks", remarks);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
