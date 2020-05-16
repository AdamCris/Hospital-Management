using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospitalagain5.Model;

namespace Hospitalagain5.Winform
{
    public partial class Adddoctor : Form
    {
        public static Doctorcs doctor = new Doctorcs();
        public string action { get; set; }
        public Adddoctor(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        public Adddoctor()
        {
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelid_Click(object sender, EventArgs e)
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
                doctor.id = textBox1.Text.ToString();
                doctor.name = textBox2.Text.ToString();
                doctor.phone = textBox3.Text.ToString();
                doctor.gender = textBox4.Text.ToString();
                MessageBox.Show(doctor.name);
                this.Close();
            }
        }
        public bool CheckAvailible()
        {
            string name = textBox2.Text.ToString();
            string phone = textBox3.Text.ToString();
            string gender = textBox4.Text.ToString();

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

            return true;
        }
        private void AddDoctor_Load(object sender, EventArgs e)
        {
            if (this.action == "add")
            {
                textBox1.Text = Helper.LastIdDoctor(Doctor.listDoctor);
                button1.Text = "Add";
            }
            else if (this.action == "update")
            {
                textBox1.Text = doctor.id.ToString();
                textBox4.Text = doctor.gender.ToString();
                textBox2.Text = Adddoctor.doctor.name;
                textBox3.Text = Adddoctor.doctor.phone;
                button1.Text = "Update";
            }
            textBox1.Enabled = false;
        }

    }
}
