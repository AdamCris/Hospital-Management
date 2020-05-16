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
    public partial class Medicine : Form
    {
        public static List<Medicinecs> listMedicine { get; set; }
        public Medicinecs medicineSelected { get; set; }
        public Medicine()
        {
            InitializeComponent();
            Medicine.listMedicine = new List<Medicinecs>(); // khởi tạo mảng Doctor 
            CreateDataMedicine(); // tạo dữ liệu mẫu cho Doctor
            InitListView();
            LoadMedicine(); // load dữ liệu mẫu lên trên cái list view
        }
        public void InitListView()
        {
            listViewmedicine.Columns.Add("No.");
            listViewmedicine.Columns.Add("Id");
            listViewmedicine.Columns.Add("Name");
            listViewmedicine.Columns.Add("Quantity");
            listViewmedicine.Columns.Add("Unit");
            listViewmedicine.Columns.Add("Kind");
            listViewmedicine.AutoArrange = true;
            listViewmedicine.GridLines = true;
            listViewmedicine.FullRowSelect = true;

            // view thành từng cột
            listViewmedicine.View = View.Details;
        }
        public void LoadMedicine()
        {
            listViewmedicine.Items.Clear();
            // tạo ra sub item 
            // ví dụ 3 doctor -> 0, 1, 2 
            Medicinecs temp;
            for (int i = 0; i < Medicine.listMedicine.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Medicinecs)Medicine.listMedicine[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.id.ToString());
                subItem.SubItems.Add(temp.name.ToString());
                subItem.SubItems.Add(temp.quantity.ToString());
                subItem.SubItems.Add(temp.unit.ToString());
                subItem.SubItems.Add(temp.kind.ToString());


                listViewmedicine.Items.Add(subItem);
            }
        }
        public void CreateDataMedicine()
        {
            // tạo ra các Doctor
            Medicinecs m1 = new Medicinecs("0001", "Nuoc khoang", "1234565789", "123 Greenwich U", "asd");



            Medicinecs m2 = new Medicinecs("0002", "Com", "1234565789", "123 Greenwich U", "asda");
            Medicinecs m3 = new Medicinecs("0003", "Chao", "1234565789", "123 Greenwich U", "asdf");
            Medicinecs m4 = new Medicinecs("0004", "Sua", "1234565789", "123 Greenwich U", "asdfg");


            // add vào list 
            listMedicine.Add(m1);
            listMedicine.Add(m2);
            listMedicine.Add(m3);
            listMedicine.Add(m4);

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            openminiformaddmedicine(new Addmedicine());
            Addmedicine formAddmedicine = new Addmedicine("Add");
            formAddmedicine.ShowDialog();
            if (Addmedicine.medicine != null)
            {
                Medicinecs m = new Medicinecs(Addmedicine.medicine);
                // value type: int, double, char, string, boolean
                // reference type: Doctor, Patient, ...

                //AddDoctor.doctor; trong bộ nhớ address : 123
                //d trong bộ nhớ address: 234
                //d= AddDoctor.doctor; address của d = address của AddDoctor.doctor;

                if (string.IsNullOrEmpty(m.id.ToString()) || string.IsNullOrEmpty(m.quantity.ToString()) || string.IsNullOrEmpty(m.name.ToString()) || string.IsNullOrEmpty(m.unit.ToString()) || string.IsNullOrEmpty(m.kind.ToString()))
                {
                    // không có gì thay đổi vì thông tin nhập vào không đầy dủ
                }
                else
                {
                    listMedicine.Add(m);
                    MessageBox.Show("Add successful");
                    LoadMedicine();
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            openminiformaddmedicine(new Addmedicine());
            Addmedicine formUpdate = new Addmedicine("Update");
            int index = Medicine.listMedicine.IndexOf(this.medicineSelected);
            Addmedicine.medicine.id = medicineSelected.id;
            Addmedicine.medicine.name = medicineSelected.name;
            Addmedicine.medicine.quantity = medicineSelected.quantity;
            Addmedicine.medicine.unit = medicineSelected.unit;
            Addmedicine.medicine.kind = medicineSelected.kind;
            formUpdate.ShowDialog();

            Medicinecs m = (Medicinecs)listMedicine[index];
            m.id = Addmedicine.medicine.id;
            m.name = Addmedicine.medicine.name;
            m.quantity = Addmedicine.medicine.quantity;
            m.unit = Addmedicine.medicine.unit;
            m.kind = Addmedicine.medicine.kind;
            Addmedicine.medicine = null;
            LoadMedicine();
            MessageBox.Show("Update successful");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Medicine.listMedicine.Remove(this.medicineSelected);
            LoadMedicine();
            MessageBox.Show("Delete successful");
        }

        private void listViewmedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                medicineSelected = (Medicinecs)Medicine.listMedicine[index];
            }
        }
        private Form activeForm = null;
        private void openminiformaddmedicine(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneladdmedicineright.Controls.Add(childForm);
            paneladdmedicineright.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
