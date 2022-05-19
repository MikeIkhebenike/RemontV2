namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Ремонт
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ремонт()
        {
            Договор = new HashSet<Договор>();
        }

        [Key]
        public int ID_работы { get; set; }

        public int ID_заявки { get; set; }

        [Required]
        [StringLength(50)]
        public string Характер_ремонта { get; set; }

        public int ID_сотрудника { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаНач { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаЗаверш { get; set; }

        public int ID_статуса { get; set; }

        public int ID_услуги { get; set; }

        public int ID_комплектующего { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Договор> Договор { get; set; }

        public virtual Заявка Заявка { get; set; }

        public virtual Комплектующее Комплектующее { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }

        public virtual СтатусРабот СтатусРабот { get; set; }

        public virtual Услуга Услуга { get; set; }
    }
}
