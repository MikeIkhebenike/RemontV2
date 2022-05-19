namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class СтатусРабот
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public СтатусРабот()
        {
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        public int ID_статуса { get; set; }

        [StringLength(50)]
        public string Наименование { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }
    }
}
