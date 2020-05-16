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
    public partial class Addmedicine : Form
    {
        public static Medicinecs medicine = new Medicinecs();
        public string action { get; set; }
        public Addmedicine(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        public Addmedicine()
        {
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                medicine.id = txtid.Text.ToString();
                medicine.name = txtname.Text.ToString();
                medicine.quantity = txtquantity.Text.ToString();
                medicine.unit = txtimport.Text.ToString();
                medicine.kind = txtout.Text.ToString();
                MessageBox.Show(medicine.name);
                this.Close();
            }
        }
        public bool CheckAvailible()
        {
            string name = txtname.Text.ToString();
            string quantity = txtquantity.Text.ToString();
            string unit = txtimport.Text.ToString();
            string kind = txtout.Text.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Quantity is empty");
                return false;
            }
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Unit is empty");
                return false;
            }
            if (string.IsNullOrEmpty(kind))
            {
                MessageBox.Show("Kind is empty");
                return false;
            }

            return true;
        }
        private void AddMedicine_Load(object sender, EventArgs e)
        {
            if (this.action == "add")
            {
                txtid.Text = Helper.LastIdMedicine(Medicine.listMedicine);
                buttonadd.Text = "Add";
            }
            else if (this.action == "update")
            {
                txtid.Text = medicine.id.ToString();
                txtquantity.Text = medicine.quantity.ToString();
                txtname.Text = Addmedicine.medicine.name;
                txtimport.Text = Addmedicine.medicine.unit;
                txtout.Text = Addmedicine.medicine.kind;
                buttonadd.Text = "Update";
            }
            txtid.Enabled = false;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
