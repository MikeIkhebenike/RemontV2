namespace RemontV2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Авторизация
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_auth { get; set; }

        [Key]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }
    }
}
