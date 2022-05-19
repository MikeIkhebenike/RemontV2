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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changePriorityBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 351);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descCheckBox);
            this.panel1.Controls.Add(this.filterComboBox);
            this.panel1.Controls.Add(this.sortComboBox);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 57);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.changePriorityBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 69);
            this.panel2.TabIndex = 2;
            // 
            // changePriorityBtn
            // 
            this.changePriorityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.changePriorityBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePriorityBtn.Location = new System.Drawing.Point(23, 9);
            this.changePriorityBtn.Name = "changePriorityBtn";
            this.changePriorityBtn.Size = new System.Drawing.Size(135, 48);
            this.changePriorityBtn.TabIndex = 2;
            this.changePriorityBtn.Text = "Изменить приоритет на...";
            this.changePriorityBtn.UseVisualStyleBackColor = false;
            this.changePriorityBtn.Visible = false;
            this.changePriorityBtn.Click += new System.EventHandler(this.changePriorityBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(199, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить приоритет на...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(117)))), ((int)(((byte)(238)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(367, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить приоритет на...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(422, 14);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(157, 26);
            this.descCheckBox.TabIndex = 6;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(627, 12);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(135, 30);
            this.filterComboBox.TabIndex = 7;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Наименоание",
            "Приоритет"});
            this.sortComboBox.Location = new System.Drawing.Point(241, 12);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(163, 30);
            this.sortComboBox.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(211, 31);
            this.searchTextBox.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(765, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changePriorityBtn;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}