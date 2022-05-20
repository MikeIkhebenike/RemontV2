namespace RemontV2.Views
{
    partial class EmployeeCard
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
            this.positionLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.employeeNameLbl = new System.Windows.Forms.Label();
            this.employeepictureBox = new System.Windows.Forms.PictureBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(212, 75);
            this.positionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(122, 22);
            this.positionLbl.TabIndex = 12;
            this.positionLbl.Text = "Должность: ";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(212, 41);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(72, 22);
            this.genderLbl.TabIndex = 11;
            this.genderLbl.Text = "Пол: М";
            // 
            // employeeNameLbl
            // 
            this.employeeNameLbl.AutoSize = true;
            this.employeeNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeNameLbl.Location = new System.Drawing.Point(211, 5);
            this.employeeNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.employeeNameLbl.Name = "employeeNameLbl";
            this.employeeNameLbl.Size = new System.Drawing.Size(123, 22);
            this.employeeNameLbl.TabIndex = 10;
            this.employeeNameLbl.Text = "Роль | ФИО";
            // 
            // employeepictureBox
            // 
            this.employeepictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employeepictureBox.Image = global::RemontV2.Properties.Resources.picture;
            this.employeepictureBox.Location = new System.Drawing.Point(6, 5);
            this.employeepictureBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.employeepictureBox.Name = "employeepictureBox";
            this.employeepictureBox.Size = new System.Drawing.Size(193, 140);
            this.employeepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeepictureBox.TabIndex = 9;
            this.employeepictureBox.TabStop = false;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(471, 41);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(256, 22);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email: example@gmail.com";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(212, 114);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(227, 22);
            this.phoneLbl.TabIndex = 12;
            this.phoneLbl.Text = "Телефон: 79999999999";
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.employeeNameLbl);
            this.Controls.Add(this.employeepictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(765, 150);
            ((System.ComponentModel.ISupportInitialize)(this.employeepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.PictureBox employeepictureBox;
        public System.Windows.Forms.Label emailLbl;
        public System.Windows.Forms.Label phoneLbl;
        public System.Windows.Forms.Label genderLbl;
        public System.Windows.Forms.Label employeeNameLbl;
    }
}
