using System.Data.Entity;

namespace RemontV2.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ServiceDb")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Авторизация> Авторизация { get; set; }
        public virtual DbSet<Договор> Договор { get; set; }
        public virtual DbSet<Доставка> Доставка { get; set; }
        public virtual DbSet<Заявка> Заявка { get; set; }
        public virtual DbSet<ЗаявкаНаПоставку> ЗаявкаНаПоставку { get; set; }
        public virtual DbSet<Комплектующее> Комплектующее { get; set; }
        public virtual DbSet<Поставка> Поставка { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Ремонт> Ремонт { get; set; }
        public virtual DbSet<Роль> Роль { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<СтатусРабот> СтатусРабот { get; set; }
        public virtual DbSet<Услуга> Услуга { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Договор>()
                .HasMany(e => e.Доставка)
                .WithRequired(e => e.Договор)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Заявка>()
                .HasMany(e => e.Договор)
                .WithRequired(e => e.Заявка)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Заявка>()
                .HasMany(e => e.Ремонт)
                .WithRequired(e => e.Заявка)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ЗаявкаНаПоставку>()
                .HasMany(e => e.Поставка)
                .WithRequired(e => e.ЗаявкаНаПоставку)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Комплектующее>()
                .HasMany(e => e.Ремонт)
                .WithRequired(e => e.Комплектующее)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.ЗаявкаНаПоставку)
                .WithRequired(e => e.Поставщик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Комплектующее)
                .WithRequired(e => e.Поставщик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Поставка)
                .WithRequired(e => e.Поставщик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ремонт>()
                .HasMany(e => e.Договор)
                .WithRequired(e => e.Ремонт)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Роль>()
                .HasMany(e => e.Сотрудник)
                .WithRequired(e => e.Роль)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Авторизация)
                .WithRequired(e => e.Сотрудник)
                .HasForeignKey(e => e.ID_auth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Договор)
                .WithRequired(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Доставка)
                .WithRequired(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.ЗаявкаНаПоставку)
                .WithRequired(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Поставка)
                .WithRequired(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудник>()
                .HasMany(e => e.Ремонт)
                .WithRequired(e => e.Сотрудник)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<СтатусРабот>()
                .HasMany(e => e.Ремонт)
                .WithRequired(e => e.СтатусРабот)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Услуга>()
                .HasMany(e => e.Ремонт)
                .WithRequired(e => e.Услуга)
                .WillCascadeOnDelete(false);
        }
    }
}
