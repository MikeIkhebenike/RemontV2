namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Комплектующее
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Комплектующее()
        {
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        public int ID_комплектующего { get; set; }

        public int ID_поставщика { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        public int КоличествоВналич { get; set; }

        [Required]
        [StringLength(50)]
        public string СтоимостьШт { get; set; }

        [StringLength(50)]
        public string Изображение { get; set; }

        public virtual Поставщик Поставщик { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }
    }
}
