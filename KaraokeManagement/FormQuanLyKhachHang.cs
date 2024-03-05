using KaraokeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManagement
{
    public partial class FormQuanLyKhachHang : Form
    {

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        public FormQuanLyKhachHang(int customerId)
        {

            InitializeComponent();

            var db = new KaraDB();
            var customerList = db.Customers.Find(customerId);
            customerBindingSource.DataSource = customerList;

        }

        void LoadData()
        {
            var db = new KaraDB();
            var customerList = db.Customers.OrderBy(sv => (sv.FirstName + sv.LastName)).ToList();
            customerBindingSource.DataSource = customerList;
        }
        private void tblKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCustomer = customerBindingSource.Current as Customer;
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = tblKhachHang.Rows[e.RowIndex];
            Customer sp = (Customer)row.DataBoundItem;
            txtId.Text = sp.CustomerID.ToString();
            txtFirstName.Text = sp.FirstName;
            txtLastName.Text = sp.LastName;
            txtPhoneNum.Text = sp.PhoneNumber;
            txtEmail.Text = sp.Email;
            txtAddress.Text = sp.Email;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new KaraDB();
                db.Database.EnsureCreated();
                Customer newCustomer = new Customer()
                {
                    //ServiceID = Convert.ToInt32(txtId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNum.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
                MessageBox.Show("Đã thêm khách hàng");
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Customer editedCustomer = new Customer()
                {
                    CustomerID = Convert.ToInt32(txtId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNum.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                };
                var db = new KaraDB();
                db.Database.EnsureCreated();
                var obj = db.Customers.Find(editedCustomer.CustomerID);
                if (obj != null)
                {
                    obj.FirstName = editedCustomer.FirstName;
                    obj.LastName = editedCustomer.LastName;
                    obj.LastName = editedCustomer.LastName;
                    obj.PhoneNumber = editedCustomer.PhoneNumber;
                    obj.Email = editedCustomer.Email;
                    obj.Address = editedCustomer.Address;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Đã thay đổi thông tin khách hàng!");
                }

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var customerList = db.Customers.OrderBy(sv => (sv.FirstName + sv.LastName)).Where(c => (c.FirstName + c.LastName).Contains(txtTimKH.Text)).ToList();
            customerBindingSource.DataSource = customerList;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var obj = db.Customers.Find(Convert.ToInt32(txtId.Text));
            if (obj != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    db.Customers.Remove(obj);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }
    }
}
