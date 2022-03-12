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
    public partial class CustomerForm : Form
    {
        CustomerDBContext db = new();
        Customer selectedCustomer;
        public CustomerForm( Customer custom)
        {
            selectedCustomer = custom;
            InitializeComponent();
        }

        private void FillTasksGrid()
        {
           
            
            dtgTasks.DataSource = db.CustomToTasks.Include(x=>x.Task).Where(x => x.CustomerId == selectedCustomer.CustomerId)
                .Select(x => new
            {
                   Tasks= x.Task.TaskName,
                   x.Task.ProductionDate,
                   EndDate=x.Task.EndTime,
                }).ToList();
        }
        private void CustomerForm_Load(object sender, EventArgs e)  
        {
         
            lblCustomer.Text = "Xos Gelmisen " + selectedCustomer.FullName;
            FillTasksGrid();

        }
    }
}
