using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class CustomToTask
    {
     
        public int ID { get; set; }
        public int? CustomerId { get; set; }
        public int? TaskId { get; set; }
        
       

        public virtual Customer Customer { get; set; }
        public virtual MyTask Task { get; set; }
    }
}
