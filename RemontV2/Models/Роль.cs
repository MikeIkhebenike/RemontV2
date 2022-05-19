namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Роль
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Роль()
        {
            Сотрудник = new HashSet<Сотрудник>();
        }

        [Key]
        public int ID_роли { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник> Сотрудник { get; set; }
    }
}
