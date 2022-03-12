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
    public partial class AddTasksForm : Form
    {
        CustomerDBContext db = new();
        public AddTasksForm()
        {
            InitializeComponent();
        }

        private void AddTasksForm_Load(object sender, EventArgs e)
        {
            FillTasksGrid();
            FillComboCustomers();
            FillFilterCombo();
        }
        private void FillTasksGrid()
        {
            dtgTasks.DataSource = db.CustomToTasks.Include(x=>x.Customer)
                .Where(x=>x.Customer.FullName.StartsWith(cmbFilterCustom.Text))
                .Select(x => new
            {
                x.Task.TaskName,
                x.Task.ProductionDate,
                x.Task.EndTime,
                x.Customer.FullName
            }).ToList();
        }
        private void FillComboCustomers()
        {
      
            cmbCustomers.Items.AddRange(db.Customers.Select(x => x.FullName).ToArray());
        }
        private void FillFilterCombo()
        {

            cmbFilterCustom.Items.AddRange(db.Customers.Select(x => x.FullName).ToArray());
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            int CustomId = db.Customers.FirstOrDefault(x => x.FullName == cmbCustomers.Text).CustomerId;    
            string Tasks = rchTasks.Text;
         
            DateTime EndTime = dtEnd.Value;
            if (DateTime.Now < EndTime)
            {
                MyTask newTask = new()
                {
                    TaskName = Tasks,
                   ProductionDate =DateTime.Now,
                    EndTime = EndTime,
                };
                db.MyTask.Add(newTask);
                db.SaveChanges();

                CustomToTask newCustomTask = new()
                {
                    CustomerId=CustomId,
                    TaskId=newTask.TaskId,
              
                };
                db.CustomToTasks.Add(newCustomTask);
                db.SaveChanges();
                MessageBox.Show("Tapsiriq Ugurla yaradildi","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FillTasksGrid();
                cmbCustomers.Text = "";
                rchTasks.Text = "";
                dtEnd.Value = DateTime.Now;
            }

            else
            {
                MessageBox.Show("Teqvimi duzgun daxil edin","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          

        }

        private void cmbFilterCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTasksGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTasksGrid();
        }

        private void dtgTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
