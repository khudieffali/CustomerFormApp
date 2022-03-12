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
    public partial class AddCommentForm : Form
    {
        CustomerDBContext db = new();
      
        public AddCommentForm()
        {
            InitializeComponent();
        }

        private void AddCommentForm_Load(object sender, EventArgs e)
        {
            FillCustomersCombo();
            FillGridComment();
        }
        private void FillCustomersCombo() 
        {
            cmbCustomers.Items.AddRange(db.Customers.Select(x => x.FullName).ToArray());

        }
        private void FillGridComment()
        {
            dtgComments.DataSource = db.Comments.Include(x=>x.Customer).Select(x => new 
            {
              Reyler=x.Description,
              Tarix=x.CommentDate,
              Musteri=x.Customer.FullName
            }).ToList();
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            string ComboCustom = cmbCustomers.Text;
            int CustomId = db.Customers.FirstOrDefault(x => x.FullName == ComboCustom).CustomerId;
            string Descript = rchCommnet.Text;
           
            Comment newComment = new()
            {
                Description = Descript,
                CommentDate = DateTime.Now,
                CustomerId=CustomId

            };
            db.Comments.Add(newComment);
            db.SaveChanges();
            MessageBox.Show("Rey Elave Olundu","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FillGridComment();
            cmbCustomers.Text = "";
            rchCommnet.Text = "";
        }
    }
}
