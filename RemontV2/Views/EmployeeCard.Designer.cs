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
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.employeepictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionLbl.Location = new System.Drawing.Point(192, 77);
            this.positionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(104, 23);
            this.positionLbl.TabIndex = 12;
            this.positionLbl.Text = "Должность: ";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLbl.Location = new System.Drawing.Point(192, 42);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(69, 23);
            this.genderLbl.TabIndex = 11;
            this.genderLbl.Text = "Пол: М";
            // 
            // employeeNameLbl
            // 
            this.employeeNameLbl.AutoSize = true;
            this.employeeNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeNameLbl.Location = new System.Drawing.Point(192, 8);
            this.employeeNameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.employeeNameLbl.Name = "employeeNameLbl";
            this.employeeNameLbl.Size = new System.Drawing.Size(97, 23);
            this.employeeNameLbl.TabIndex = 10;
            this.employeeNameLbl.Text = "Роль | ФИО";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.Location = new System.Drawing.Point(557, 55);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(200, 23);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email: example@gmail.com";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.Location = new System.Drawing.Point(192, 116);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(198, 23);
            this.phoneLbl.TabIndex = 12;
            this.phoneLbl.Text = "Телефон: 79999999999";
            // 
            // employeepictureBox
            // 
            this.employeepictureBox.Image = global::RemontV2.Properties.Resources.picture;
            this.employeepictureBox.Location = new System.Drawing.Point(5, 5);
            this.employeepictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.employeepictureBox.Name = "employeepictureBox";
            this.employeepictureBox.Size = new System.Drawing.Size(177, 143);
            this.employeepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeepictureBox.TabIndex = 9;
            this.employeepictureBox.TabStop = false;
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.employeeNameLbl);
            this.Controls.Add(this.employeepictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(800, 150);
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
