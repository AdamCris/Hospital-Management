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
    public partial class Fooddrink : Form
    {
        public static List<Fooddrinkcs> listFooddrink { get; set; }
        public Fooddrinkcs fooddrinkSelected { get; set; }
        public Fooddrink()
        {
            InitializeComponent();
            Fooddrink.listFooddrink = new List<Fooddrinkcs>(); // khởi tạo mảng Doctor 
            CreateDataFooddrink(); // tạo dữ liệu mẫu cho Doctor
            InitListView();
            LoadFooddrink(); // load dữ liệu mẫu lên trên cái list view
        }
        public void InitListView()
        {
            listViewfooddrink.Columns.Add("No.");
            listViewfooddrink.Columns.Add("Id");
            listViewfooddrink.Columns.Add("Name");
            listViewfooddrink.Columns.Add("Quantity");
            listViewfooddrink.Columns.Add("Dayimport");
            listViewfooddrink.Columns.Add("Dayout");
            listViewfooddrink.AutoArrange = true;
            listViewfooddrink.GridLines = true;
            listViewfooddrink.FullRowSelect = true;

            // view thành từng cột
            listViewfooddrink.View = View.Details;
        }
        public void LoadFooddrink()
        {
            listViewfooddrink.Items.Clear();
            // tạo ra sub item 
            // ví dụ 3 doctor -> 0, 1, 2 
            Fooddrinkcs temp;
            for (int i = 0; i < Fooddrink.listFooddrink.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Fooddrinkcs)Fooddrink.listFooddrink[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.id.ToString());
                subItem.SubItems.Add(temp.name.ToString());
                subItem.SubItems.Add(temp.quantity.ToString());
                subItem.SubItems.Add(temp.dayimport.ToString());
                subItem.SubItems.Add(temp.dayout.ToString());


                listViewfooddrink.Items.Add(subItem);
            }
        }
        public void CreateDataFooddrink()
        {
            // tạo ra các Doctor
            Fooddrinkcs f1 = new Fooddrinkcs("0001", "Nuoc khoang", "1234565789", "123 Greenwich U", "asd");



            Fooddrinkcs f2 = new Fooddrinkcs("0002", "Com", "1234565789", "123 Greenwich U", "asda");
            Fooddrinkcs f3 = new Fooddrinkcs("0003", "Chao", "1234565789", "123 Greenwich U", "asdf");
            Fooddrinkcs f4 = new Fooddrinkcs("0004", "Sua", "1234565789", "123 Greenwich U", "asdfg");
            

            // add vào list 
            listFooddrink.Add(f1);
            listFooddrink.Add(f2);
            listFooddrink.Add(f3);
            listFooddrink.Add(f4);

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activeForm = null;
        private void openminiformaddfooddrink(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneladdfooddrinkright.Controls.Add(childForm);
            paneladdfooddrinkright.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            openminiformaddfooddrink(new Addfooddrink());
            Addfooddrink formAddfooddrink = new Addfooddrink("add");
            formAddfooddrink.ShowDialog();
            if (Addfooddrink.fooddrink != null)
            {
                Fooddrinkcs p = new Fooddrinkcs(Addfooddrink.fooddrink);
                // value type: int, double, char, string, boolean
                // reference type: Doctor, Patient, ...

                //AddDoctor.doctor; trong bộ nhớ address : 123
                //d trong bộ nhớ address: 234
                //d= AddDoctor.doctor; address của d = address của AddDoctor.doctor;

                if (string.IsNullOrEmpty(p.id.ToString()) || string.IsNullOrEmpty(p.quantity.ToString()) || string.IsNullOrEmpty(p.name.ToString()) || string.IsNullOrEmpty(p.dayimport.ToString()) || string.IsNullOrEmpty(p.dayout.ToString()))
                {
                    // không có gì thay đổi vì thông tin nhập vào không đầy dủ
                }
                else
                {
                    listFooddrink.Add(p);
                    MessageBox.Show("Add successful");
                    LoadFooddrink();
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            openminiformaddfooddrink(new Addfooddrink());
            Addfooddrink formUpdate = new Addfooddrink("Update");
            int index = Fooddrink.listFooddrink.IndexOf(this.fooddrinkSelected);
            Addfooddrink.fooddrink.id = fooddrinkSelected.id;
            Addfooddrink.fooddrink.name = fooddrinkSelected.name;
            Addfooddrink.fooddrink.quantity = fooddrinkSelected.quantity;
            Addfooddrink.fooddrink.dayimport = fooddrinkSelected.dayimport;
            Addfooddrink.fooddrink.dayout = fooddrinkSelected.dayout;
            formUpdate.ShowDialog();

            Fooddrinkcs p = (Fooddrinkcs)listFooddrink[index];
            p.id = Addfooddrink.fooddrink.id;
            p.name = Addfooddrink.fooddrink.name;
            p.quantity = Addfooddrink.fooddrink.quantity;
            p.dayimport = Addfooddrink.fooddrink.dayimport;
            p.dayout = Addfooddrink.fooddrink.dayout;
            Addfooddrink.fooddrink = null;
            LoadFooddrink();
            MessageBox.Show("Update successful");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Fooddrink.listFooddrink.Remove(this.fooddrinkSelected);
            LoadFooddrink();
            MessageBox.Show("Delete successful");
        }

        private void listViewfooddrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                fooddrinkSelected = (Fooddrinkcs)Fooddrink.listFooddrink[index];
            }
        }
    }
}
