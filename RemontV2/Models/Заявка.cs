namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Заявка
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заявка()
        {
            Договор = new HashSet<Договор>();
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        public int ID_заявки { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО_клиента { get; set; }

        [Required]
        [StringLength(50)]
        public string Адрес_клиента { get; set; }

        [Required]
        [StringLength(50)]
        public string Описание_проблемы { get; set; }

        [Required]
        [StringLength(50)]
        public string Техника_клиента { get; set; }

        public int Количество { get; set; }

        [Required]
        [StringLength(50)]
        public string Контактный_номер { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаОткр { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаЗакр { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Договор> Договор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }
    }
}
