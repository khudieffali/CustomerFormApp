using System;
using System.Collections.Generic;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Comments = new HashSet<Comment>();
        }

        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        public bool isDeleted { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
