namespace RemontV2.Views
{
    partial class ListOfRequestsCard
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
            this.titleListOfReqLbl = new System.Windows.Forms.Label();
            this.qtyListOfReqLbl = new System.Windows.Forms.Label();
            this.employeeListOfReqIDLbl = new System.Windows.Forms.Label();
            this.ListOfReqIDLbl = new System.Windows.Forms.Label();
            this.ListOfReqCloseLbl = new System.Windows.Forms.Label();
            this.ListOfReqOpenLbl = new System.Windows.Forms.Label();
            this.supplierListOfReqLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleListOfReqLbl
            // 
            this.titleListOfReqLbl.AutoSize = true;
            this.titleListOfReqLbl.Location = new System.Drawing.Point(34, 5);
            this.titleListOfReqLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titleListOfReqLbl.Name = "titleListOfReqLbl";
            this.titleListOfReqLbl.Size = new System.Drawing.Size(131, 23);
            this.titleListOfReqLbl.TabIndex = 33;
            this.titleListOfReqLbl.Text = "Наименование: ";
            // 
            // qtyListOfReqLbl
            // 
            this.qtyListOfReqLbl.AutoSize = true;
            this.qtyListOfReqLbl.Location = new System.Drawing.Point(34, 47);
            this.qtyListOfReqLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.qtyListOfReqLbl.Name = "qtyListOfReqLbl";
            this.qtyListOfReqLbl.Size = new System.Drawing.Size(104, 23);
            this.qtyListOfReqLbl.TabIndex = 34;
            this.qtyListOfReqLbl.Text = "Количество:";
            // 
            // employeeListOfReqIDLbl
            // 
            this.employeeListOfReqIDLbl.AutoSize = true;
            this.employeeListOfReqIDLbl.Location = new System.Drawing.Point(326, 5);
            this.employeeListOfReqIDLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.employeeListOfReqIDLbl.Name = "employeeListOfReqIDLbl";
            this.employeeListOfReqIDLbl.Size = new System.Drawing.Size(96, 23);
            this.employeeListOfReqIDLbl.TabIndex = 36;
            this.employeeListOfReqIDLbl.Text = "Сотрудник:";
            // 
            // ListOfReqIDLbl
            // 
            this.ListOfReqIDLbl.AutoSize = true;
            this.ListOfReqIDLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfReqIDLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListOfReqIDLbl.Location = new System.Drawing.Point(5, 23);
            this.ListOfReqIDLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ListOfReqIDLbl.Name = "ListOfReqIDLbl";
            this.ListOfReqIDLbl.Size = new System.Drawing.Size(22, 29);
            this.ListOfReqIDLbl.TabIndex = 28;
            this.ListOfReqIDLbl.Text = "1";
            // 
            // ListOfReqCloseLbl
            // 
            this.ListOfReqCloseLbl.AutoSize = true;
            this.ListOfReqCloseLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListOfReqCloseLbl.Location = new System.Drawing.Point(657, 47);
            this.ListOfReqCloseLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ListOfReqCloseLbl.Name = "ListOfReqCloseLbl";
            this.ListOfReqCloseLbl.Size = new System.Drawing.Size(132, 23);
            this.ListOfReqCloseLbl.TabIndex = 29;
            this.ListOfReqCloseLbl.Text = "Дата закрытия: ";
            // 
            // ListOfReqOpenLbl
            // 
            this.ListOfReqOpenLbl.AutoSize = true;
            this.ListOfReqOpenLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListOfReqOpenLbl.Location = new System.Drawing.Point(660, 5);
            this.ListOfReqOpenLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ListOfReqOpenLbl.Name = "ListOfReqOpenLbl";
            this.ListOfReqOpenLbl.Size = new System.Drawing.Size(129, 23);
            this.ListOfReqOpenLbl.TabIndex = 30;
            this.ListOfReqOpenLbl.Text = "Дата создания: ";
            // 
            // supplierListOfReqLbl
            // 
            this.supplierListOfReqLbl.AutoSize = true;
            this.supplierListOfReqLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierListOfReqLbl.Location = new System.Drawing.Point(326, 47);
            this.supplierListOfReqLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.supplierListOfReqLbl.Name = "supplierListOfReqLbl";
            this.supplierListOfReqLbl.Size = new System.Drawing.Size(107, 23);
            this.supplierListOfReqLbl.TabIndex = 31;
            this.supplierListOfReqLbl.Text = "Поставщик: ";
            // 
            // ListOfRequestsCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.titleListOfReqLbl);
            this.Controls.Add(this.qtyListOfReqLbl);
            this.Controls.Add(this.employeeListOfReqIDLbl);
            this.Controls.Add(this.ListOfReqIDLbl);
            this.Controls.Add(this.ListOfReqCloseLbl);
            this.Controls.Add(this.ListOfReqOpenLbl);
            this.Controls.Add(this.supplierListOfReqLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ListOfRequestsCard";
            this.Size = new System.Drawing.Size(833, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titleListOfReqLbl;
        public System.Windows.Forms.Label qtyListOfReqLbl;
        public System.Windows.Forms.Label employeeListOfReqIDLbl;
        public System.Windows.Forms.Label ListOfReqIDLbl;
        public System.Windows.Forms.Label ListOfReqCloseLbl;
        public System.Windows.Forms.Label ListOfReqOpenLbl;
        public System.Windows.Forms.Label supplierListOfReqLbl;
    }
}
