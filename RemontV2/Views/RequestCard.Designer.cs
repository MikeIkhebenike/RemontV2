namespace RemontV2.Views
{
    partial class RequestCard
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
            this.ReqAdresslLbl = new System.Windows.Forms.Label();
            this.ReqDescriptionLbl = new System.Windows.Forms.Label();
            this.FioLbl = new System.Windows.Forms.Label();
            this.ClientTechLbl = new System.Windows.Forms.Label();
            this.techqtyLbl = new System.Windows.Forms.Label();
            this.phoneClientLbl = new System.Windows.Forms.Label();
            this.reqOpenLbl = new System.Windows.Forms.Label();
            this.reqCloseLbl = new System.Windows.Forms.Label();
            this.reqNumberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReqAdresslLbl
            // 
            this.ReqAdresslLbl.AutoSize = true;
            this.ReqAdresslLbl.Location = new System.Drawing.Point(29, 73);
            this.ReqAdresslLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ReqAdresslLbl.Name = "ReqAdresslLbl";
            this.ReqAdresslLbl.Size = new System.Drawing.Size(132, 23);
            this.ReqAdresslLbl.TabIndex = 18;
            this.ReqAdresslLbl.Text = "Адрес клиента: ";
            // 
            // ReqDescriptionLbl
            // 
            this.ReqDescriptionLbl.AutoSize = true;
            this.ReqDescriptionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReqDescriptionLbl.Location = new System.Drawing.Point(315, 73);
            this.ReqDescriptionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ReqDescriptionLbl.Name = "ReqDescriptionLbl";
            this.ReqDescriptionLbl.Size = new System.Drawing.Size(180, 23);
            this.ReqDescriptionLbl.TabIndex = 17;
            this.ReqDescriptionLbl.Text = "Описание проблемы: ";
            // 
            // FioLbl
            // 
            this.FioLbl.AutoSize = true;
            this.FioLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FioLbl.Location = new System.Drawing.Point(29, 9);
            this.FioLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FioLbl.Name = "FioLbl";
            this.FioLbl.Size = new System.Drawing.Size(121, 23);
            this.FioLbl.TabIndex = 17;
            this.FioLbl.Text = "ФИО клиента: ";
            // 
            // ClientTechLbl
            // 
            this.ClientTechLbl.AutoSize = true;
            this.ClientTechLbl.Location = new System.Drawing.Point(315, 9);
            this.ClientTechLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ClientTechLbl.Name = "ClientTechLbl";
            this.ClientTechLbl.Size = new System.Drawing.Size(149, 23);
            this.ClientTechLbl.TabIndex = 18;
            this.ClientTechLbl.Text = "Техника клиента: ";
            // 
            // techqtyLbl
            // 
            this.techqtyLbl.AutoSize = true;
            this.techqtyLbl.Location = new System.Drawing.Point(315, 43);
            this.techqtyLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.techqtyLbl.Name = "techqtyLbl";
            this.techqtyLbl.Size = new System.Drawing.Size(114, 23);
            this.techqtyLbl.TabIndex = 18;
            this.techqtyLbl.Text = "Количество:  ";
            // 
            // phoneClientLbl
            // 
            this.phoneClientLbl.AutoSize = true;
            this.phoneClientLbl.Location = new System.Drawing.Point(29, 43);
            this.phoneClientLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phoneClientLbl.Name = "phoneClientLbl";
            this.phoneClientLbl.Size = new System.Drawing.Size(88, 23);
            this.phoneClientLbl.TabIndex = 18;
            this.phoneClientLbl.Text = "Телефон: ";
            // 
            // reqOpenLbl
            // 
            this.reqOpenLbl.AutoSize = true;
            this.reqOpenLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reqOpenLbl.Location = new System.Drawing.Point(642, 9);
            this.reqOpenLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reqOpenLbl.Name = "reqOpenLbl";
            this.reqOpenLbl.Size = new System.Drawing.Size(188, 23);
            this.reqOpenLbl.TabIndex = 17;
            this.reqOpenLbl.Text = "Дата открытия заявки: ";
            // 
            // reqCloseLbl
            // 
            this.reqCloseLbl.AutoSize = true;
            this.reqCloseLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reqCloseLbl.Location = new System.Drawing.Point(644, 73);
            this.reqCloseLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reqCloseLbl.Name = "reqCloseLbl";
            this.reqCloseLbl.Size = new System.Drawing.Size(186, 23);
            this.reqCloseLbl.TabIndex = 17;
            this.reqCloseLbl.Text = "Дата закрытия заявки: ";
            // 
            // reqNumberLbl
            // 
            this.reqNumberLbl.AutoSize = true;
            this.reqNumberLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reqNumberLbl.Location = new System.Drawing.Point(5, 37);
            this.reqNumberLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reqNumberLbl.Name = "reqNumberLbl";
            this.reqNumberLbl.Size = new System.Drawing.Size(26, 33);
            this.reqNumberLbl.TabIndex = 18;
            this.reqNumberLbl.Text = "1";
            // 
            // RequestCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reqNumberLbl);
            this.Controls.Add(this.phoneClientLbl);
            this.Controls.Add(this.techqtyLbl);
            this.Controls.Add(this.ClientTechLbl);
            this.Controls.Add(this.ReqAdresslLbl);
            this.Controls.Add(this.FioLbl);
            this.Controls.Add(this.reqCloseLbl);
            this.Controls.Add(this.reqOpenLbl);
            this.Controls.Add(this.ReqDescriptionLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RequestCard";
            this.Size = new System.Drawing.Size(833, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ReqAdresslLbl;
        public System.Windows.Forms.Label ReqDescriptionLbl;
        public System.Windows.Forms.Label FioLbl;
        public System.Windows.Forms.Label ClientTechLbl;
        public System.Windows.Forms.Label techqtyLbl;
        public System.Windows.Forms.Label phoneClientLbl;
        public System.Windows.Forms.Label reqOpenLbl;
        public System.Windows.Forms.Label reqCloseLbl;
        public System.Windows.Forms.Label reqNumberLbl;
    }
}
