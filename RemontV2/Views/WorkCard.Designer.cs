namespace RemontV2.Views
{
    partial class WorkCard
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
            this.wkCostLbl = new System.Windows.Forms.Label();
            this.repairTypeLbl = new System.Windows.Forms.Label();
            this.serviceNameLbl = new System.Windows.Forms.Label();
            this.workStatusLbl = new System.Windows.Forms.Label();
            this.employeeIDLbl = new System.Windows.Forms.Label();
            this.reqIDLbl = new System.Windows.Forms.Label();
            this.wkCloseLbl = new System.Windows.Forms.Label();
            this.wkOpenLbl = new System.Windows.Forms.Label();
            this.usedAccessoriesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wkCostLbl
            // 
            this.wkCostLbl.AutoSize = true;
            this.wkCostLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wkCostLbl.Location = new System.Drawing.Point(289, 57);
            this.wkCostLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wkCostLbl.Name = "wkCostLbl";
            this.wkCostLbl.Size = new System.Drawing.Size(162, 23);
            this.wkCostLbl.TabIndex = 23;
            this.wkCostLbl.Text = "Стоимость работы: ";
            this.wkCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repairTypeLbl
            // 
            this.repairTypeLbl.AutoSize = true;
            this.repairTypeLbl.Location = new System.Drawing.Point(3, 57);
            this.repairTypeLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.repairTypeLbl.Name = "repairTypeLbl";
            this.repairTypeLbl.Size = new System.Drawing.Size(158, 23);
            this.repairTypeLbl.TabIndex = 24;
            this.repairTypeLbl.Text = "Характер ремонта: ";
            // 
            // serviceNameLbl
            // 
            this.serviceNameLbl.AutoSize = true;
            this.serviceNameLbl.Location = new System.Drawing.Point(289, 13);
            this.serviceNameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.serviceNameLbl.Name = "serviceNameLbl";
            this.serviceNameLbl.Size = new System.Drawing.Size(73, 23);
            this.serviceNameLbl.TabIndex = 25;
            this.serviceNameLbl.Text = "Услуга: ";
            // 
            // workStatusLbl
            // 
            this.workStatusLbl.AutoSize = true;
            this.workStatusLbl.Location = new System.Drawing.Point(710, 57);
            this.workStatusLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.workStatusLbl.Name = "workStatusLbl";
            this.workStatusLbl.Size = new System.Drawing.Size(118, 23);
            this.workStatusLbl.TabIndex = 26;
            this.workStatusLbl.Text = "Статус работ: ";
            // 
            // employeeIDLbl
            // 
            this.employeeIDLbl.AutoSize = true;
            this.employeeIDLbl.Location = new System.Drawing.Point(3, 101);
            this.employeeIDLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.employeeIDLbl.Name = "employeeIDLbl";
            this.employeeIDLbl.Size = new System.Drawing.Size(219, 23);
            this.employeeIDLbl.TabIndex = 27;
            this.employeeIDLbl.Text = "Ответственный за работу:  ";
            // 
            // reqIDLbl
            // 
            this.reqIDLbl.AutoSize = true;
            this.reqIDLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reqIDLbl.Location = new System.Drawing.Point(3, 13);
            this.reqIDLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reqIDLbl.Name = "reqIDLbl";
            this.reqIDLbl.Size = new System.Drawing.Size(129, 23);
            this.reqIDLbl.TabIndex = 19;
            this.reqIDLbl.Text = "Номер заявки:  ";
            // 
            // wkCloseLbl
            // 
            this.wkCloseLbl.AutoSize = true;
            this.wkCloseLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wkCloseLbl.Location = new System.Drawing.Point(638, 101);
            this.wkCloseLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wkCloseLbl.Name = "wkCloseLbl";
            this.wkCloseLbl.Size = new System.Drawing.Size(195, 23);
            this.wkCloseLbl.TabIndex = 20;
            this.wkCloseLbl.Text = "Дата завершения работ: ";
            // 
            // wkOpenLbl
            // 
            this.wkOpenLbl.AutoSize = true;
            this.wkOpenLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wkOpenLbl.Location = new System.Drawing.Point(668, 13);
            this.wkOpenLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wkOpenLbl.Name = "wkOpenLbl";
            this.wkOpenLbl.Size = new System.Drawing.Size(165, 23);
            this.wkOpenLbl.TabIndex = 21;
            this.wkOpenLbl.Text = "Дата начала работ:  ";
            // 
            // usedAccessoriesLbl
            // 
            this.usedAccessoriesLbl.AutoSize = true;
            this.usedAccessoriesLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usedAccessoriesLbl.Location = new System.Drawing.Point(289, 100);
            this.usedAccessoriesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usedAccessoriesLbl.Name = "usedAccessoriesLbl";
            this.usedAccessoriesLbl.Size = new System.Drawing.Size(266, 23);
            this.usedAccessoriesLbl.TabIndex = 22;
            this.usedAccessoriesLbl.Text = "Используемые комплектующие: ";
            // 
            // WorkCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wkCostLbl);
            this.Controls.Add(this.repairTypeLbl);
            this.Controls.Add(this.serviceNameLbl);
            this.Controls.Add(this.workStatusLbl);
            this.Controls.Add(this.employeeIDLbl);
            this.Controls.Add(this.reqIDLbl);
            this.Controls.Add(this.wkCloseLbl);
            this.Controls.Add(this.wkOpenLbl);
            this.Controls.Add(this.usedAccessoriesLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WorkCard";
            this.Size = new System.Drawing.Size(833, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label wkCostLbl;
        public System.Windows.Forms.Label repairTypeLbl;
        public System.Windows.Forms.Label serviceNameLbl;
        public System.Windows.Forms.Label workStatusLbl;
        public System.Windows.Forms.Label employeeIDLbl;
        public System.Windows.Forms.Label reqIDLbl;
        public System.Windows.Forms.Label wkCloseLbl;
        public System.Windows.Forms.Label wkOpenLbl;
        public System.Windows.Forms.Label usedAccessoriesLbl;
    }
}
