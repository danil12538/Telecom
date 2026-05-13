namespace Telecom.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tickets
    {
        [Key]
        public int TicketID { get; set; }

        public int ClientID { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Priority { get; set; }

        [StringLength(15)]
        public string Status { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ResolvedAt { get; set; }

        [StringLength(50)]
        public string AssignedTo { get; set; }

        public virtual Clients Clients { get; set; }
    }
}
