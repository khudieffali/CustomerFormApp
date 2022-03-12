using System;
using System.Collections.Generic;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class Comment
    {
        public int? CustomerId { get; set; }
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
