namespace Telecom.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subscriptions
    {
        [Key]
        public int SubID { get; set; }

        public int ClientID { get; set; }

        public int TariffID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Tariffs Tariffs { get; set; }
    }
}
