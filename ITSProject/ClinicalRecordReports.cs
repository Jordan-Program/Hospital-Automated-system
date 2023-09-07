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
    public partial class ClinicalRecordReports : Form
    {
        public string philhealth;
        public string patientid;
        public string date;
        public string patientname;
        public string age;
        public string sex;
        public string birthdate;
        public string ht;
        public string wt;
        public string address;
        public string occupation;
        public string contact;
        public string chiefcomplain;
        public string hpi;
        public string htnmeds;
        public string dmmeds;
        public string asthmameds;
        public string allergymeds;
        public string sxmeds;
        public string other;
        public string bp;
        public string cr;
        public string rr;
        public string temp;
        public string heent;
        public string lungs;
        public string heart;
        public string abdomen;
        public string genito;
        public string extremities;
        public string neuro;
        public string others;
        public string diagnosis;
        public string ermanagement;
        public string meds;
        public string physician;


        public  ClinicalRecordReports(string philhealth,
          string patientid,
          string date,
          string patientname,
          string age,
          string sex,
          string birthdate,
          string ht,
          string wt,
          string address,
          string occupation,
          string contact,
          string chiefcomplain,
          string hpi,
          string htnmeds,
          string dmmeds,
          string asthmameds,
          string allergymeds,
          string sxmeds,
          string other,
          string bp,
          string cr,
          string rr,
          string temp,
          string heent,
          string lungs,
          string heart,
          string abdomen,
          string genito,
          string extremities,
          string neuro,
          string others,
          string diagnosis,
          string ermanagement,
          string meds,
          string physician)

          

        {

            this.philhealth = philhealth;
            this.patientid = patientid;
            this.date = date;
            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.birthdate = birthdate;
            this.ht = ht;
            this.wt = wt;
            this.address = address;
            this.occupation = occupation;
            this.contact = contact;
            this.chiefcomplain = chiefcomplain;
            this.hpi = hpi;
            this.htnmeds = htnmeds;
            this.dmmeds = dmmeds;
            this.asthmameds = asthmameds;
            this.allergymeds = allergymeds;
            this.sxmeds = sxmeds;
            this.other = other;
            this.bp = bp;
            this.cr = cr;
            this.rr = rr;
            this.temp = temp;
            this.heent = heent;
            this.lungs = lungs;
            this.heart = heart;
            this.abdomen = abdomen;
            this.genito = genito;
            this.extremities = extremities;
            this.neuro = neuro;
            this.others = others;
            this.diagnosis = diagnosis;
            this.ermanagement = ermanagement;
            this.meds = meds;
            this.physician = physician;
            InitializeComponent();
        }

          private void ClinicalRecordReports_Load(object sender, EventArgs e)
          {
              crsclinicalrecord ob = new crsclinicalrecord();
              ob.SetParameterValue("philhealth", philhealth );
              ob.SetParameterValue("patientid", patientid );
              ob.SetParameterValue("date", date );
              ob.SetParameterValue("patientname", patientname );
              ob.SetParameterValue("age", age );
              ob.SetParameterValue("sex", sex );
              ob.SetParameterValue("birthdate", birthdate );
              ob.SetParameterValue("ht", ht );
              ob.SetParameterValue("wt", wt );
              ob.SetParameterValue("address", address );
              ob.SetParameterValue("occupation", occupation );
              ob.SetParameterValue("contact", contact );
              ob.SetParameterValue("chiefcomplaint", chiefcomplain );
              ob.SetParameterValue("hpi", hpi );
              ob.SetParameterValue("htnmeds", htnmeds );
              ob.SetParameterValue("dmmeds", dmmeds );
              ob.SetParameterValue("asthmameds", asthmameds );
              ob.SetParameterValue("allergymeds", allergymeds );
              ob.SetParameterValue("sxmeds", sxmeds );
              ob.SetParameterValue("others", other );
              ob.SetParameterValue("bp", bp );
              ob.SetParameterValue("cr", cr );
              ob.SetParameterValue("rr", rr );
              ob.SetParameterValue("temp", temp );
              ob.SetParameterValue("heent", heent );
              ob.SetParameterValue("lungs", lungs );
              ob.SetParameterValue("heart", heart );
              ob.SetParameterValue("abdomen", abdomen );
              ob.SetParameterValue("genito", genito );
              ob.SetParameterValue("extremities", extremities );
              ob.SetParameterValue("neuro", neuro );
              ob.SetParameterValue("other2", others );
              ob.SetParameterValue("diagnosis", diagnosis );
              ob.SetParameterValue("ermanagement", ermanagement );
              ob.SetParameterValue("meds", meds);
              ob.SetParameterValue("physician", physician );
              crystalReportViewer1.ReportSource = ob;
              crystalReportViewer1.Refresh();
          }
    }
}
