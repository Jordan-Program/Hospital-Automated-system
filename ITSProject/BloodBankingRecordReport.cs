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
    public partial class BloodBankingRecordReport : Form
    {
        public string patientname;
        public string age;
        public string sex;
        public string date;
        public string physician;
        public string labid;
        public string bloodbagserial;
        public string bloodcomponent;
        public string donorcontrol;
        public string donorabo;
        public string donorrh;
        public string patientabo;
        public string patientrh;
        public string immediatespin;
        public string enchancementmedia;
        public string antihuman;
        public string autocontrol;
        public string others;

        public BloodBankingRecordReport(string patientname,
        string age,
        string sex,
        string date,
        string physician,
        string labid,
        string bloodbagserial,
        string bloodcomponent,
        string donorcontrol,
        string donorabo,
        string donorrh,
        string patientabo,
        string patientrh,
        string immediatespin,
        string enchancementmedia,
        string antihuman,
        string autocontrol,
        string others)
        {

            this.patientname = patientname;
            this.age = age;
            this.sex = sex;
            this.date = date;
            this.physician = physician;
            this.labid = labid;
            this.bloodbagserial = bloodbagserial;
            this.bloodcomponent = bloodcomponent;
            this.donorcontrol = donorcontrol;
            this.donorabo = donorabo;
            this.donorrh = donorrh;
            this.patientabo = patientabo;
            this.patientrh = patientrh;
            this.immediatespin = immediatespin;
            this.enchancementmedia = enchancementmedia;
            this.antihuman = antihuman;
            this.autocontrol = autocontrol;
            this.others = others;

            InitializeComponent();
        }

        private void BloodBankingRecordReport_Load(object sender, EventArgs e)
        {
            crsbloodbanking ob = new crsbloodbanking();
            ob.SetParameterValue("patientname", patientname);
            ob.SetParameterValue("physician", physician);
            ob.SetParameterValue("age", age);
            ob.SetParameterValue("sex", sex);
            ob.SetParameterValue("date", date);
            ob.SetParameterValue("labid", labid);
            ob.SetParameterValue("bloodbagserialnumber", bloodbagserial);
            ob.SetParameterValue("bloodcomponent", bloodcomponent);
            ob.SetParameterValue("donorcontrolnumber", donorcontrol);
            ob.SetParameterValue("donorabobloodtype", donorabo);
            ob.SetParameterValue("donorrhbloodtype", donorrh);
            ob.SetParameterValue("patientabobloodtype", patientabo);
            ob.SetParameterValue("patientrhbloodtype", patientrh);
            ob.SetParameterValue("immediatespinphase", immediatespin);
            ob.SetParameterValue("enchancementmediaphase", enchancementmedia);
            ob.SetParameterValue("antihumanglobulinphase", antihuman);
            ob.SetParameterValue("autocontrol", autocontrol);
            ob.SetParameterValue("others", others);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
