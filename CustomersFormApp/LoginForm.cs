using CustomersFormApp.Models;
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
   
    public partial class LoginForm : Form
    {
        CustomerDBContext db = new CustomerDBContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string[] myarr = new string[] { UserName, Password };
            if (Utilities.IsEmpty(myarr))
            {
                Customer selectedUser = db.Customers.FirstOrDefault(x => x.UserName == UserName);
                Admin selectedAdmin = db.Admins.FirstOrDefault(x => x.UserName == UserName);
                  
                if (selectedAdmin != null)
                {
                    if (UserName == selectedAdmin.UserName && Password == selectedAdmin.Password)
                    {
                        AdminForm adm = new AdminForm();
                        this.Close();
                        adm.ShowDialog();
                      
                    }
                }
               
                else if (selectedUser != null)
                {
                    if(UserName == selectedUser.UserName && selectedUser.Password==Password.Hashed())
                    {
                        CustomerForm csm = new CustomerForm(selectedUser);
                        this.Close();
                        csm.ShowDialog();
                        
                    }
                   
                }
                else
                {
                    MessageBox.Show("Musteri Movcud Deil");
                }
            
            }
            else
            {
                MessageBox.Show("UserName ve ya Password Daxil edin");
            }

        }
    }
}
