namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Договор
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Договор()
        {
            Доставка = new HashSet<Доставка>();
        }

        [Key]
        public int ID_договора { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО_клиента { get; set; }

        public int ID_заявки { get; set; }

        public int ID_сотрудника { get; set; }

        public int ID_работы { get; set; }

        [Required]
        [StringLength(50)]
        public string ЭлектроныйДокум { get; set; }

        public virtual Заявка Заявка { get; set; }

        public virtual Ремонт Ремонт { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Доставка> Доставка { get; set; }
    }
}
