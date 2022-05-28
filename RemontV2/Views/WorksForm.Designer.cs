namespace RemontV2.Views
{
    partial class WorksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksForm));
            this.AddWorkBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangeStatusBtn = new System.Windows.Forms.Button();
            this.RemoveWorkBtn = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.WorksflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddWorkBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddWorkBtn
            // 
            this.AddWorkBtn.Image = global::RemontV2.Properties.Resources.add;
            this.AddWorkBtn.Location = new System.Drawing.Point(759, 1);
            this.AddWorkBtn.Name = "AddWorkBtn";
            this.AddWorkBtn.Size = new System.Drawing.Size(62, 44);
            this.AddWorkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddWorkBtn.TabIndex = 31;
            this.AddWorkBtn.TabStop = false;
            this.AddWorkBtn.Click += new System.EventHandler(this.AddWorkBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangeStatusBtn);
            this.panel1.Controls.Add(this.RemoveWorkBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 45);
            this.panel1.TabIndex = 30;
            // 
            // ChangeStatusBtn
            // 
            this.ChangeStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeStatusBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStatusBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeStatusBtn.Location = new System.Drawing.Point(14, 0);
            this.ChangeStatusBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ChangeStatusBtn.Name = "ChangeStatusBtn";
            this.ChangeStatusBtn.Size = new System.Drawing.Size(225, 42);
            this.ChangeStatusBtn.TabIndex = 3;
            this.ChangeStatusBtn.Text = "Изменить дату закрытия";
            this.ChangeStatusBtn.UseVisualStyleBackColor = false;
            this.ChangeStatusBtn.Visible = false;
            this.ChangeStatusBtn.Click += new System.EventHandler(this.ChangeStatusBtn_Click);
            // 
            // RemoveWorkBtn
            // 
            this.RemoveWorkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveWorkBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveWorkBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveWorkBtn.Location = new System.Drawing.Point(594, 0);
            this.RemoveWorkBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveWorkBtn.Name = "RemoveWorkBtn";
            this.RemoveWorkBtn.Size = new System.Drawing.Size(225, 42);
            this.RemoveWorkBtn.TabIndex = 2;
            this.RemoveWorkBtn.Text = "Удалить заявку";
            this.RemoveWorkBtn.UseVisualStyleBackColor = false;
            this.RemoveWorkBtn.Visible = false;
            this.RemoveWorkBtn.Click += new System.EventHandler(this.RemoveWorkBtn_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Ответственный за работу",
            "Характер ремонта",
            "Дата начала"});
            this.sortComboBox.Location = new System.Drawing.Point(283, 10);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(167, 29);
            this.sortComboBox.TabIndex = 27;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 12);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 27);
            this.searchTextBox.TabIndex = 26;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(459, 12);
            this.descCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(135, 25);
            this.descCheckBox.TabIndex = 28;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // WorksflowLayoutPanel
            // 
            this.WorksflowLayoutPanel.AutoScroll = true;
            this.WorksflowLayoutPanel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorksflowLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.WorksflowLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.WorksflowLayoutPanel.Name = "WorksflowLayoutPanel";
            this.WorksflowLayoutPanel.Size = new System.Drawing.Size(833, 410);
            this.WorksflowLayoutPanel.TabIndex = 25;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(604, 10);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 29);
            this.filterComboBox.TabIndex = 29;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // WorksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.AddWorkBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.WorksflowLayoutPanel);
            this.Controls.Add(this.filterComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WorksForm";
            this.Text = "WorksForm";
            this.Load += new System.EventHandler(this.WorksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddWorkBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddWorkBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeStatusBtn;
        private System.Windows.Forms.Button RemoveWorkBtn;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.FlowLayoutPanel WorksflowLayoutPanel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}