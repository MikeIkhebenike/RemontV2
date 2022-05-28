namespace RemontV2.Views
{
    partial class SuppliersCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adresslLbl = new System.Windows.Forms.Label();
            this.supplierNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adresslLbl
            // 
            this.adresslLbl.AutoSize = true;
            this.adresslLbl.Location = new System.Drawing.Point(427, 10);
            this.adresslLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.adresslLbl.Name = "adresslLbl";
            this.adresslLbl.Size = new System.Drawing.Size(56, 23);
            this.adresslLbl.TabIndex = 16;
            this.adresslLbl.Text = "Адрес";
            // 
            // supplierNameLbl
            // 
            this.supplierNameLbl.AutoSize = true;
            this.supplierNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierNameLbl.Location = new System.Drawing.Point(142, 10);
            this.supplierNameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.supplierNameLbl.Name = "supplierNameLbl";
            this.supplierNameLbl.Size = new System.Drawing.Size(121, 23);
            this.supplierNameLbl.TabIndex = 14;
            this.supplierNameLbl.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Компания:";
            // 
            // SuppliersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresslLbl);
            this.Controls.Add(this.supplierNameLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SuppliersCard";
            this.Size = new System.Drawing.Size(700, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label adresslLbl;
        public System.Windows.Forms.Label supplierNameLbl;
        private System.Windows.Forms.Label label1;
    }
}
