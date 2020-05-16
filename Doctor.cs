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
using Hospitalagain5.Winform;

namespace Hospitalagain5.Winform
{
    public partial class Doctor : Form
    {
        public static List<Doctorcs> listDoctor { get; set; }
        public Doctorcs doctorSelected { get; set; }
        public Doctor()
        {
            InitializeComponent();
            Doctor.listDoctor = new List<Doctorcs>(); // khởi tạo mảng Doctor 
            CreateDataDoctor(); // tạo dữ liệu mẫu cho Doctor
            InitListView();
            LoadDoctor(); // load dữ liệu mẫu lên trên cái list view
        }
        public void InitListView()
        {
            listViewdoctor.Columns.Add("No.");
            listViewdoctor.Columns.Add("Id");
            listViewdoctor.Columns.Add("Name");
            listViewdoctor.Columns.Add("Phone");
            listViewdoctor.Columns.Add("Address");
            listViewdoctor.AutoArrange = true;
            listViewdoctor.GridLines = true;
            listViewdoctor.FullRowSelect = true;

            // view thành từng cột
            listViewdoctor.View = View.Details;
        }
        public void LoadDoctor()
        {
            listViewdoctor.Items.Clear();
            // tạo ra sub item 
            // ví dụ 3 doctor -> 0, 1, 2 
            Doctorcs temp;
            for (int i = 0; i < Doctor.listDoctor.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Doctorcs)Doctor.listDoctor[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.id.ToString());
                subItem.SubItems.Add(temp.name.ToString());
                subItem.SubItems.Add(temp.phone.ToString());
                subItem.SubItems.Add(temp.gender.ToString());


                listViewdoctor.Items.Add(subItem);
            }
        }
        public void CreateDataDoctor()
        {
            // tạo ra các Doctor
            Doctorcs d1 = new Doctorcs("0001", "Doctor 1", "1234565789", "123 Greenwich U");

           

            Doctorcs d2 = new Doctorcs("0002", "Doctor 2", "1234565789", "123 Greenwich U");
            Doctorcs d3 = new Doctorcs("0003", "Doctor 3", "1234565789", "123 Greenwich U");
            Doctorcs d4 = new Doctorcs("0004", "Doctor 4", "1234565789", "123 Greenwich U");

            // add vào list 
            listDoctor.Add(d1);
            listDoctor.Add(d2);
            listDoctor.Add(d3);
            listDoctor.Add(d4);

        }
      

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openminiformadddoctor(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneladddoctorright.Controls.Add(childForm);
            paneladddoctorright.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            openminiformadddoctor(new Adddoctor());
            Adddoctor formAddDoctor = new Adddoctor("add");
            formAddDoctor.ShowDialog();
            if (Adddoctor.doctor != null)
            {
                Doctorcs d = new Doctorcs(Adddoctor.doctor);
                // value type: int, double, char, string, boolean
                // reference type: Doctor, Patient, ...

                //AddDoctor.doctor; trong bộ nhớ address : 123
                //d trong bộ nhớ address: 234
                //d= AddDoctor.doctor; address của d = address của AddDoctor.doctor;

                if (string.IsNullOrEmpty(d.id.ToString()) || string.IsNullOrEmpty(d.phone.ToString()) || string.IsNullOrEmpty(d.name.ToString()) || string.IsNullOrEmpty(d.gender.ToString()))
                {
                    // không có gì thay đổi vì thông tin nhập vào không đầy dủ
                }
                else
                {
                    listDoctor.Add(d);
                    MessageBox.Show("Add successful");
                    LoadDoctor();
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            openminiformadddoctor(new Adddoctor());
            Adddoctor formUpdate = new Adddoctor("Update");
            int index = Doctor.listDoctor.IndexOf(this.doctorSelected);
            Adddoctor.doctor.id = doctorSelected.id;
            Adddoctor.doctor.name = doctorSelected.name;
            Adddoctor.doctor.phone = doctorSelected.phone;
            Adddoctor.doctor.gender = doctorSelected.gender;
            formUpdate.ShowDialog();

            Doctorcs d = (Doctorcs)listDoctor[index];
            d.id = Adddoctor.doctor.id;
            d.name = Adddoctor.doctor.name;
            d.gender = Adddoctor.doctor.gender;
            d.phone = Adddoctor.doctor.phone;
            Adddoctor.doctor = null;
            LoadDoctor();
            MessageBox.Show("Update successful");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Doctor.listDoctor.Remove(this.doctorSelected);
            LoadDoctor();
            MessageBox.Show("Delete successful");
        }

        private void listViewdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                doctorSelected = (Doctorcs)Doctor.listDoctor[index];
            }
        }
    }
}
