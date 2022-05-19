namespace RemontV2.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            Авторизация = new HashSet<Авторизация>();
            Договор = new HashSet<Договор>();
            Доставка = new HashSet<Доставка>();
            ЗаявкаНаПоставку = new HashSet<ЗаявкаНаПоставку>();
            Поставка = new HashSet<Поставка>();
            Ремонт = new HashSet<Ремонт>();
        }

        [Key]
        public int ID_сотрудника { get; set; }

        public int ID_роли { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО { get; set; }

        [StringLength(10)]
        public string Пол { get; set; }

        [Required]
        [StringLength(50)]
        public string Должность { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Контактный_телефон { get; set; }

        [StringLength(50)]
        public string Фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Авторизация> Авторизация { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Договор> Договор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Доставка> Доставка { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаявкаНаПоставку> ЗаявкаНаПоставку { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Поставка> Поставка { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ремонт> Ремонт { get; set; }

        public virtual Роль Роль { get; set; }
    }
}
