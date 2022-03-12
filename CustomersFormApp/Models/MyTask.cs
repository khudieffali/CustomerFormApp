using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class MyTask
    {
      [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
