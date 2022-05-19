namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            ЗаявкаНаПоставку = new HashSet<ЗаявкаНаПоставку>();
            Комплектующее = new HashSet<Комплектующее>();
            Поставка = new HashSet<Поставка>();
        }

        [Key]
        public int ID_поставщика { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Адрес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаявкаНаПоставку> ЗаявкаНаПоставку { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Комплектующее> Комплектующее { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Поставка> Поставка { get; set; }
    }
}
