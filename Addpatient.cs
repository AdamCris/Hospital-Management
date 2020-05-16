using Hospitalagain5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitalagain5.Winform
{
    public partial class Addpatient : Form
    {
        public static Patientcs patient = new Patientcs();
        public string action { get; set; }
        public Addpatient(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        public Addpatient()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // b1: kiểm tra form hợp lệ
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                patient.idp = txtid.Text.ToString();
                patient.name = txtname.Text.ToString();
                patient.phone = txtphone.Text.ToString();
                patient.gender = txtgender.Text.ToString();
                patient.address = txtaddress.Text.ToString();
                patient.cccd = txtcccd.Text.ToString();
                patient.age = txtage.Text.ToString();
                patient.domicle = txtdomicle.Text.ToString();
                patient.idbhxh = txtidbhxh.Text.ToString();
                patient.nation = txtnation.Text.ToString();
                patient.note = txtnote.Text.ToString();
                patient.job = txtjob.Text.ToString();
                MessageBox.Show(patient.name);
                this.Close();
            }
        }
        public bool CheckAvailible()
        {
            string name = txtphone.Text.ToString();
            string phone = txtage.Text.ToString();
            string gender = txtgender.Text.ToString();
            string address = txtaddress.Text.ToString();
            string age = txtage.Text.ToString();
            string cccd = txtcccd.Text.ToString();
            string job = txtjob.Text.ToString();
            string idbhxh = txtidbhxh.Text.ToString();
            string note = txtnote.Text.ToString();
            string nation = txtnation.Text.ToString();
            string domicle = txtdomicle.Text.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone is empty");
                return false;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is empty");
                return false;
            }
            if (string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Age is empty");
                return false;
            }
            if (string.IsNullOrEmpty(job))
            {
                MessageBox.Show("Job is empty");
                return false;
            }
            if (string.IsNullOrEmpty(idbhxh))
            {
                MessageBox.Show("IDBHXH is empty");
                return false;
            }
            if (string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("CCCD is empty");
                return false;
            }
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Note is empty");
                return false;
            }
            if (string.IsNullOrEmpty(nation))
            {
                MessageBox.Show("Nation is empty");
                return false;
            }
            if (string.IsNullOrEmpty(domicle))
            {
                MessageBox.Show("Domicle is empty");
                return false;
            }

            return true;
        }
        private void AddPatient_Load(object sender, EventArgs e)
        {
            if (this.action == "add")
            {
                txtid.Text = Helper.LastIdPatient(Patient.listPatient);
                buttonadd.Text = "Add";
            }
            else if (this.action == "update")
            {
                txtid.Text = patient.idp.ToString();
                txtgender.Text = patient.gender.ToString();
                txtname.Text = Addpatient.patient.name;
                txtaddress.Text = Addpatient.patient.address;
                txtcccd.Text = Addpatient.patient.cccd;
                txtage.Text = Addpatient.patient.age;
                txtdomicle.Text = Addpatient.patient.domicle;
                txtidbhxh.Text = Addpatient.patient.idbhxh;
                txtphone.Text = Addpatient.patient.phone;
                txtjob.Text = Addpatient.patient.job;
                txtnote.Text = Addpatient.patient.note;
                buttonadd.Text = "Update";
            }
            txtid.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
