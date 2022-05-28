namespace RemontV2.Views
{
    partial class SuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.AddSupplierBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveSupplierBtn = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.SupplierflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddSupplierBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSupplierBtn
            // 
            this.AddSupplierBtn.Image = global::RemontV2.Properties.Resources.add;
            this.AddSupplierBtn.Location = new System.Drawing.Point(751, 2);
            this.AddSupplierBtn.Name = "AddSupplierBtn";
            this.AddSupplierBtn.Size = new System.Drawing.Size(62, 44);
            this.AddSupplierBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddSupplierBtn.TabIndex = 16;
            this.AddSupplierBtn.TabStop = false;
            this.AddSupplierBtn.Click += new System.EventHandler(this.AddSupplierBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveSupplierBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 45);
            this.panel1.TabIndex = 15;
            // 
            // RemoveSupplierBtn
            // 
            this.RemoveSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveSupplierBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveSupplierBtn.Location = new System.Drawing.Point(5, 2);
            this.RemoveSupplierBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveSupplierBtn.Name = "RemoveSupplierBtn";
            this.RemoveSupplierBtn.Size = new System.Drawing.Size(203, 42);
            this.RemoveSupplierBtn.TabIndex = 2;
            this.RemoveSupplierBtn.Text = "Удалить поставщика";
            this.RemoveSupplierBtn.UseVisualStyleBackColor = false;
            this.RemoveSupplierBtn.Visible = false;
            this.RemoveSupplierBtn.Click += new System.EventHandler(this.RemoveSupplierBtn_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "ID",
            "Наименование"});
            this.sortComboBox.Location = new System.Drawing.Point(283, 11);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(167, 29);
            this.sortComboBox.TabIndex = 12;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 13);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 27);
            this.searchTextBox.TabIndex = 11;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(459, 13);
            this.descCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(135, 25);
            this.descCheckBox.TabIndex = 13;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // SupplierflowLayoutPanel
            // 
            this.SupplierflowLayoutPanel.AutoScroll = true;
            this.SupplierflowLayoutPanel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierflowLayoutPanel.Location = new System.Drawing.Point(0, 54);
            this.SupplierflowLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SupplierflowLayoutPanel.Name = "SupplierflowLayoutPanel";
            this.SupplierflowLayoutPanel.Size = new System.Drawing.Size(833, 410);
            this.SupplierflowLayoutPanel.TabIndex = 10;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(604, 11);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 29);
            this.filterComboBox.TabIndex = 14;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.AddSupplierBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.SupplierflowLayoutPanel);
            this.Controls.Add(this.filterComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddSupplierBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddSupplierBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveSupplierBtn;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.FlowLayoutPanel SupplierflowLayoutPanel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}