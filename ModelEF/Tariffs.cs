namespace Telecom.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tariffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tariffs()
        {
            Subscriptions = new HashSet<Subscriptions>();
        }

        [Key]
        public int TariffID { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; }

        public decimal MonthlyFee { get; set; }

        public int? SpeedMbps { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}
