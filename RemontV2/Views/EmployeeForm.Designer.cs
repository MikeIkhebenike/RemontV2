namespace RemontV2.Views
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ChangePlaceBtn = new System.Windows.Forms.Button();
            this.EmployeeflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveEmployeeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(459, 14);
            this.descCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(135, 25);
            this.descCheckBox.TabIndex = 6;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged_1);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(604, 12);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 29);
            this.filterComboBox.TabIndex = 7;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged_1);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Должность",
            "Роль"});
            this.sortComboBox.Location = new System.Drawing.Point(283, 12);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(167, 29);
            this.sortComboBox.TabIndex = 5;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 14);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 27);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged_1);
            // 
            // ChangePlaceBtn
            // 
            this.ChangePlaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangePlaceBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePlaceBtn.ForeColor = System.Drawing.Color.White;
            this.ChangePlaceBtn.Location = new System.Drawing.Point(12, 1);
            this.ChangePlaceBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ChangePlaceBtn.Name = "ChangePlaceBtn";
            this.ChangePlaceBtn.Size = new System.Drawing.Size(203, 42);
            this.ChangePlaceBtn.TabIndex = 2;
            this.ChangePlaceBtn.Text = "Изменить должность";
            this.ChangePlaceBtn.UseVisualStyleBackColor = false;
            this.ChangePlaceBtn.Visible = false;
            this.ChangePlaceBtn.Click += new System.EventHandler(this.changePriorityBtn_Click);
            // 
            // EmployeeflowLayoutPanel1
            // 
            this.EmployeeflowLayoutPanel1.AutoScroll = true;
            this.EmployeeflowLayoutPanel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeflowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.EmployeeflowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeeflowLayoutPanel1.Name = "EmployeeflowLayoutPanel1";
            this.EmployeeflowLayoutPanel1.Size = new System.Drawing.Size(833, 410);
            this.EmployeeflowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveEmployeeBtn);
            this.panel1.Controls.Add(this.ChangePlaceBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 45);
            this.panel1.TabIndex = 8;
            // 
            // RemoveEmployeeBtn
            // 
            this.RemoveEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveEmployeeBtn.Location = new System.Drawing.Point(262, 1);
            this.RemoveEmployeeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            this.RemoveEmployeeBtn.Size = new System.Drawing.Size(203, 42);
            this.RemoveEmployeeBtn.TabIndex = 2;
            this.RemoveEmployeeBtn.Text = "Удалить сотрудника";
            this.RemoveEmployeeBtn.UseVisualStyleBackColor = false;
            this.RemoveEmployeeBtn.Visible = false;
            this.RemoveEmployeeBtn.Click += new System.EventHandler(this.RemoveEmployeeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(751, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.EmployeeflowLayoutPanel1);
            this.Controls.Add(this.filterComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangePlaceBtn;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel EmployeeflowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveEmployeeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}