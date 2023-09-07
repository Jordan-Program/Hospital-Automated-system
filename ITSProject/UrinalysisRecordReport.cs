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
    public partial class UrinalysisRecordReport : Form
    {
        public string patientname;
        public string age;
        public string sex;
        public string date;
        public string physician;
        public string labid;
        public string color;
        public string transparency;
        public string ph;
        public string specificgravity;
        public string sugar;
        public string protein;
        public string redbloodcells;
        public string puscells;
        public string bacteria;
        public string epithelialcells;
        public string muscusthreads;
        public string cast;
        public string crystals;
        public string amorhousmaterials;
        public string othertest;

        public UrinalysisRecordReport(string patientname,
          string age,
          string sex,
          string date,
          string physician,
          string labid,
          string color,
          string transparency,
          string ph,
          string specificgravity,
          string sugar,
          string protein,
          string redbloodcells,
          string puscells,
          string bacteria,
          string epithelialcells,
          string muscusthreads,
          string cast,
          string crystals,
          string amorhousmaterials,
          string othertest)
        {
            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.date = date;
            this.physician = physician;
            this.labid = labid;
            this.color = color;
            this.transparency = transparency;
            this.ph = ph;
            this.specificgravity = specificgravity;
            this.sugar = sugar;
            this.protein = protein;
            this.redbloodcells = redbloodcells;
            this.puscells = puscells;
            this.bacteria = bacteria;
            this.epithelialcells = epithelialcells;
            this.muscusthreads = muscusthreads;
            this.cast = cast;
            this.crystals = crystals;
            this.amorhousmaterials = amorhousmaterials;
            this.othertest = othertest;

            InitializeComponent();
        }

        private void UrinalysisRecordReport_Load(object sender, EventArgs e)
        {
            crsurinalysis ob = new crsurinalysis();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("age", age);
            ob.SetParameterValue("sex", sex);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("physician", physician);
            ob.SetParameterValue("labid", labid);
            ob.SetParameterValue("Color", color);
            ob.SetParameterValue("transparency", transparency);
            ob.SetParameterValue("ph", ph);
            ob.SetParameterValue("specific gravity", specificgravity);
            ob.SetParameterValue("sugar", sugar);
            ob.SetParameterValue("protein", protein);
            ob.SetParameterValue("redbloodcells", redbloodcells);
            ob.SetParameterValue("puscells", puscells);
            ob.SetParameterValue("bacteria", bacteria);
            ob.SetParameterValue("epithelialcells", epithelialcells);
            ob.SetParameterValue("mucusthreads", muscusthreads);
            ob.SetParameterValue("cast", cast);
            ob.SetParameterValue("crystals", crystals);
            ob.SetParameterValue("amorphousmaterials", amorhousmaterials);
            ob.SetParameterValue("othertest", othertest);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }

        
    }
}
