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
    public partial class Patient : Form
    {
        public static List<Patientcs> listPatient { get; set; }
        public Patientcs patientSelected { get; set; }
        public Patient()
        {
            InitializeComponent();
            Patient.listPatient = new List<Patientcs>(); // khởi tạo mảng Doctor 
            CreateDataPatient(); // tạo dữ liệu mẫu cho Doctor
            InitListView();
            LoadPatient(); // load dữ liệu mẫu lên trên cái list view
        }
        public void InitListView()
        {
            listViewpatient.Columns.Add("No.");
            listViewpatient.Columns.Add("Id");
            listViewpatient.Columns.Add("Name");
            listViewpatient.Columns.Add("Phone");
            listViewpatient.Columns.Add("Gender");
            listViewpatient.Columns.Add("CCCD");
            listViewpatient.Columns.Add("Age");
            listViewpatient.Columns.Add("Domicle");
            listViewpatient.Columns.Add("IDBHXH");
            listViewpatient.Columns.Add("Address");
            listViewpatient.Columns.Add("Domicle");
            listViewpatient.Columns.Add("Note");


            listViewpatient.AutoArrange = true;
            listViewpatient.GridLines = true;
            listViewpatient.FullRowSelect = true;

            // view thành từng cột
            listViewpatient.View = View.Details;
        }
        public void LoadPatient()
        {
            listViewpatient.Items.Clear();
            // tạo ra sub item 
            // ví dụ 3 doctor -> 0, 1, 2 
            Patientcs temp;
            for (int i = 0; i < Patient.listPatient.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Patientcs)Patient.listPatient[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.idp.ToString());
                subItem.SubItems.Add(temp.name.ToString());
                subItem.SubItems.Add(temp.phone.ToString());
                subItem.SubItems.Add(temp.gender.ToString());
                subItem.SubItems.Add(temp.address.ToString());
                subItem.SubItems.Add(temp.cccd.ToString());
                subItem.SubItems.Add(temp.domicle.ToString());
                subItem.SubItems.Add(temp.age.ToString());
                subItem.SubItems.Add(temp.idbhxh.ToString());
                subItem.SubItems.Add(temp.nation.ToString());
                subItem.SubItems.Add(temp.note.ToString());

                listViewpatient.Items.Add(subItem);
            }
        }
        public void CreateDataPatient()
        {
            // tạo ra các Doctor
            Patientcs p1 = new Patientcs("0002", "Doctor 2", "1234565789", "123 Greenwich U", "a", "b", "c", "d", "e", "f", "g", "h");



            Patientcs p2 = new Patientcs("0002", "Doctor 2", "1234565789", "123 Greenwich U", "a", "b", "c", "d", "e", "f", "g", "h");
            Patientcs p3 = new Patientcs("0003", "Doctor 3", "1234565789", "123 Greenwich U", "a", "b", "c", "d", "e", "f", "g", "h");
            Patientcs p4 = new Patientcs("0004", "Doctor 4", "1234565789", "123 Greenwich U", "a", "b", "c", "d", "e", "f", "g", "h");

            // add vào list 
            listPatient.Add(p1);
            listPatient.Add(p2);
            listPatient.Add(p3);
            listPatient.Add(p4);

        }

        private void panelpatient_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openminiformaddpatient(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneladdpatientright.Controls.Add(childForm);
            paneladdpatientright.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            openminiformaddpatient(new Addpatient());
            Addpatient formAddPatient = new Addpatient("add");
            formAddPatient.ShowDialog();
            if (Addpatient.patient != null)
            {
                Patientcs p = new Patientcs(Addpatient.patient);
                // value type: int, double, char, string, boolean
                // reference type: Doctor, Patient, ...

                //AddDoctor.doctor; trong bộ nhớ address : 123
                //d trong bộ nhớ address: 234
                //d= AddDoctor.doctor; address của d = address của AddDoctor.doctor;

                if (string.IsNullOrEmpty(p.idp.ToString()) || string.IsNullOrEmpty(p.phone.ToString()) || string.IsNullOrEmpty(p.name.ToString()) || string.IsNullOrEmpty(p.gender.ToString()) || string.IsNullOrEmpty(p.address.ToString()) || string.IsNullOrEmpty(p.age.ToString()) || string.IsNullOrEmpty(p.cccd.ToString()) || string.IsNullOrEmpty(p.domicle.ToString()) || string.IsNullOrEmpty(p.idbhxh.ToString()) || string.IsNullOrEmpty(p.job.ToString()) || string.IsNullOrEmpty(p.nation.ToString()))
                {
                    // không có gì thay đổi vì thông tin nhập vào không đầy dủ
                }
                else
                {
                    listPatient.Add(p);
                    MessageBox.Show("Add successful");
                    LoadPatient();
                }
            }

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            openminiformaddpatient(new Addpatient());
            Addpatient formUpdate = new Addpatient("Update");
            int index = Patient.listPatient.IndexOf(this.patientSelected);
            Addpatient.patient.idp = patientSelected.idp;
            Addpatient.patient.name = patientSelected.name;
            Addpatient.patient.phone = patientSelected.phone;
            Addpatient.patient.gender = patientSelected.gender;
            Addpatient.patient.age = patientSelected.age;
            Addpatient.patient.cccd = patientSelected.cccd;
            Addpatient.patient.domicle = patientSelected.domicle;
            Addpatient.patient.idbhxh = patientSelected.idbhxh;
            Addpatient.patient.nation = patientSelected.nation;
            Addpatient.patient.address = patientSelected.address;
            Addpatient.patient.note = patientSelected.note;
            Addpatient.patient.job = patientSelected.job;
            formUpdate.ShowDialog();

            Patientcs p = (Patientcs)listPatient[index];
            p.idp = Addpatient.patient.idp;
            p.name = Addpatient.patient.name;
            p.gender = Addpatient.patient.gender;
            p.phone = Addpatient.patient.phone;
            p.cccd = Addpatient.patient.cccd;
            p.address = Addpatient.patient.address;
            p.idbhxh = Addpatient.patient.idbhxh;
            p.age = Addpatient.patient.age;
            p.domicle = Addpatient.patient.domicle;
            p.nation = Addpatient.patient.nation;
            p.note = Addpatient.patient.note;
            p.job = Addpatient.patient.job;
            Addpatient.patient = null;
            LoadPatient();
            MessageBox.Show("Update successful");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Patient.listPatient.Remove(this.patientSelected);
            LoadPatient();
            MessageBox.Show("Delete successful");
        }

        private void paneladdpatientright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewpatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                patientSelected = (Patientcs)Patient.listPatient[index];
            }
        }
    }
}
