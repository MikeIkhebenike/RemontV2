namespace RemontV2.Views
{
    partial class RequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangeCloseDateBtn = new System.Windows.Forms.Button();
            this.RemoveRequestBtn = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.RequestsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.AddRequestBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddRequestBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangeCloseDateBtn);
            this.panel1.Controls.Add(this.RemoveRequestBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 45);
            this.panel1.TabIndex = 22;
            // 
            // ChangeCloseDateBtn
            // 
            this.ChangeCloseDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeCloseDateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCloseDateBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeCloseDateBtn.Location = new System.Drawing.Point(14, 0);
            this.ChangeCloseDateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ChangeCloseDateBtn.Name = "ChangeCloseDateBtn";
            this.ChangeCloseDateBtn.Size = new System.Drawing.Size(225, 42);
            this.ChangeCloseDateBtn.TabIndex = 3;
            this.ChangeCloseDateBtn.Text = "Изменить дату закрытия";
            this.ChangeCloseDateBtn.UseVisualStyleBackColor = false;
            this.ChangeCloseDateBtn.Visible = false;
            this.ChangeCloseDateBtn.Click += new System.EventHandler(this.ChangeCloseDateBtn_Click);
            // 
            // RemoveRequestBtn
            // 
            this.RemoveRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveRequestBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveRequestBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveRequestBtn.Location = new System.Drawing.Point(594, 0);
            this.RemoveRequestBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveRequestBtn.Name = "RemoveRequestBtn";
            this.RemoveRequestBtn.Size = new System.Drawing.Size(225, 42);
            this.RemoveRequestBtn.TabIndex = 2;
            this.RemoveRequestBtn.Text = "Удалить заявку";
            this.RemoveRequestBtn.UseVisualStyleBackColor = false;
            this.RemoveRequestBtn.Visible = false;
            this.RemoveRequestBtn.Click += new System.EventHandler(this.RemoveRequestBtn_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Дата открытия",
            "Дата закрытия"});
            this.sortComboBox.Location = new System.Drawing.Point(283, 10);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(167, 29);
            this.sortComboBox.TabIndex = 19;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 12);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 27);
            this.searchTextBox.TabIndex = 18;
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
            this.descCheckBox.TabIndex = 20;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // RequestsflowLayoutPanel
            // 
            this.RequestsflowLayoutPanel.AutoScroll = true;
            this.RequestsflowLayoutPanel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsflowLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.RequestsflowLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.RequestsflowLayoutPanel.Name = "RequestsflowLayoutPanel";
            this.RequestsflowLayoutPanel.Size = new System.Drawing.Size(833, 410);
            this.RequestsflowLayoutPanel.TabIndex = 17;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(604, 10);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(131, 29);
            this.filterComboBox.TabIndex = 21;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // AddRequestBtn
            // 
            this.AddRequestBtn.Image = global::RemontV2.Properties.Resources.add;
            this.AddRequestBtn.Location = new System.Drawing.Point(759, 1);
            this.AddRequestBtn.Name = "AddRequestBtn";
            this.AddRequestBtn.Size = new System.Drawing.Size(62, 44);
            this.AddRequestBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddRequestBtn.TabIndex = 24;
            this.AddRequestBtn.TabStop = false;
            this.AddRequestBtn.Click += new System.EventHandler(this.AddRequestBtn_Click);
            // 
            // RequestsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.AddRequestBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.RequestsflowLayoutPanel);
            this.Controls.Add(this.filterComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestsForm";
            this.Text = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddRequestBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveRequestBtn;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.FlowLayoutPanel RequestsflowLayoutPanel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button ChangeCloseDateBtn;
        private System.Windows.Forms.PictureBox AddRequestBtn;
    }
}