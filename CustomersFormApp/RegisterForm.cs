using CustomersFormApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersFormApp
{
    public partial class RegisterForm : Form
    {
        CustomerDBContext db = new();
        Customer selectedCustom;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string Adres = txtAddress.Text;
            string Phone = txtPhone.Text;
            string[] Empty = new string[] { FullName, UserName, Password, Adres, Phone };
            if (Utilities.IsEmpty(Empty))
            {
                Customer selectedUser = db.Customers.FirstOrDefault(x => x.UserName == UserName);
                if (selectedUser == null)
                {
                    Customer newUser = new()
                    {
                        FullName = FullName,
                        UserName = UserName,
                        Password = Password.Hashed(),
                        Address = Adres,
                        PhoneNumber = Phone
                    };
                    db.Customers.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Musteri Ugurla Yaradildi");
                    CreateCustomers();
                }
                else
                {
                    MessageBox.Show("Bele Musteri Movcuddur");
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CreateCustomers();
        }

        private void CreateCustomers()
        {
            dtgCustomer.DataSource = db.Customers.Where(x=>!x.isDeleted).Select(x => new
            {
                x.CustomerId,
                x.FullName,
                x.UserName,
                x.Address,
                Phone = x.PhoneNumber
                

            }).ToList();
            dtgCustomer.Columns[0].Visible = false;
           
        }

        private void dtgCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CustomId = (int) dtgCustomer.Rows[e.RowIndex].Cells[0].Value;
            selectedCustom = db.Customers.FirstOrDefault(x => x.CustomerId == CustomId);
            txtFullName.Text = selectedCustom.FullName;
            txtUserName.Text = selectedCustom.UserName;
            txtPassword.Text = selectedCustom.Password;
            txtPhone.Text = selectedCustom.PhoneNumber;
            txtAddress.Text = selectedCustom.Address;
            EnableBtn("a");

        }
  

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Name = txtFullName.Text;
            string UserName = txtUserName.Text;
            string pas = txtPassword.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            int CusId = db.Customers.FirstOrDefault(x => x.FullName == txtFullName.Text).CustomerId;
            selectedCustom.FullName = Name;
            selectedCustom.UserName = UserName;
            selectedCustom.Password = pas.Hashed();
            selectedCustom.PhoneNumber = Phone;
            selectedCustom.Address = Address;
            db.SaveChanges();
            CreateCustomers();
            ClearText();
            EnableBtn("b");


        }
     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Silmek Isteyirsiniz","deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                selectedCustom.isDeleted = true;
                db.SaveChanges();
                CreateCustomers();
                ClearText();
                EnableBtn("b");


            }

            
        }
        private void ClearText()
        {

            txtFullName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void EnableBtn(string txt)
        {
            if (txt == "a")
            {
                btnCreate.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnCreate.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
}
    

