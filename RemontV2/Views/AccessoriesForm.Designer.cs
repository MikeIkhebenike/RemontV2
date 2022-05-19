namespace RemontV2.Views
{
    partial class AccessoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoriesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.AccessoriesflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangePriceBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangePriceBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 64);
            this.panel1.TabIndex = 0;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Стоимость",
            "Наименование"});
            this.sortComboBox.Location = new System.Drawing.Point(306, 14);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(167, 29);
            this.sortComboBox.TabIndex = 9;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(5, 16);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 27);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(483, 18);
            this.descCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(135, 25);
            this.descCheckBox.TabIndex = 10;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(679, 14);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 29);
            this.filterComboBox.TabIndex = 11;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // AccessoriesflowLayoutPanel
            // 
            this.AccessoriesflowLayoutPanel.AutoScroll = true;
            this.AccessoriesflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccessoriesflowLayoutPanel.Location = new System.Drawing.Point(0, 63);
            this.AccessoriesflowLayoutPanel.Name = "AccessoriesflowLayoutPanel";
            this.AccessoriesflowLayoutPanel.Size = new System.Drawing.Size(817, 346);
            this.AccessoriesflowLayoutPanel.TabIndex = 12;
            // 
            // ChangePriceBtn
            // 
            this.ChangePriceBtn.Location = new System.Drawing.Point(12, 16);
            this.ChangePriceBtn.Name = "ChangePriceBtn";
            this.ChangePriceBtn.Size = new System.Drawing.Size(210, 33);
            this.ChangePriceBtn.TabIndex = 0;
            this.ChangePriceBtn.Text = "Изменить стоимость";
            this.ChangePriceBtn.UseVisualStyleBackColor = true;
            this.ChangePriceBtn.Click += new System.EventHandler(this.ChangePriceBtn_Click);
            // 
            // AccessoriesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(817, 473);
            this.Controls.Add(this.AccessoriesflowLayoutPanel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccessoriesForm";
            this.Text = "AccessoriesForm";
            this.Load += new System.EventHandler(this.AccessoriesForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.FlowLayoutPanel AccessoriesflowLayoutPanel;
        private System.Windows.Forms.Button ChangePriceBtn;
    }
}