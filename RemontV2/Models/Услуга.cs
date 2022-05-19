namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Услуга
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Услуга()
        {
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        public int ID_услуги { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Стоимость { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }
    }
}
