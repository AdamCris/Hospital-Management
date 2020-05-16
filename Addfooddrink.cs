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
    public partial class Addfooddrink : Form
    {
        public static Fooddrinkcs fooddrink = new Fooddrinkcs();
        public string action { get; set; }
        public Addfooddrink(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        public Addfooddrink()
        {
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            // b1: kiểm tra form hợp lệ
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                fooddrink.id = txtid.Text.ToString();
                fooddrink.name = txtname.Text.ToString();
                fooddrink.quantity = txtquantity.Text.ToString();
                fooddrink.dayimport = txtimport.Text.ToString();
                fooddrink.dayout = txtout.Text.ToString();
                MessageBox.Show(fooddrink.name);
                this.Close();
            }
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckAvailible()
        {
            string name = txtname.Text.ToString();
            string quantity = txtquantity.Text.ToString();
            string dayimport = txtimport.Text.ToString();
            string dayout = txtout.Text.ToString();

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
            if (string.IsNullOrEmpty(dayimport))
            {
                MessageBox.Show("Import is empty");
                return false;
            }
            if (string.IsNullOrEmpty(dayout))
            {
                MessageBox.Show("Out is empty");
                return false;
            }

            return true;
        }
        private void AddFooddrink_Load(object sender, EventArgs e)
        {
            if (this.action == "add")
            {
                txtid.Text = Helper.LastIdFooddrink(Fooddrink.listFooddrink);
                buttonadd.Text = "Add";
            }
            else if (this.action == "update")
            {
                txtid.Text = fooddrink.id.ToString();
                txtquantity.Text = fooddrink.quantity.ToString();
                txtname.Text = Addfooddrink.fooddrink.name;
                txtimport.Text = Addfooddrink.fooddrink.dayimport;
                txtout.Text = Addfooddrink.fooddrink.dayout;
                buttonadd.Text = "Update";
            }
            txtid.Enabled = false;
        }

    }
}
