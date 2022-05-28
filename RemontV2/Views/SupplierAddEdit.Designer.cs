namespace RemontV2.Views
{
    partial class SupplierAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_поставщикаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierAddEdit));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_поставщикаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.SaveSupplierBtn = new System.Windows.Forms.Button();
            this.DeleteSupplierBtn = new System.Windows.Forms.Button();
            iD_поставщикаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.ShutDownEMPBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.EMPHeaderLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 66);
            this.panel2.TabIndex = 3;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(547, 3);
            this.ShutDownEMPBtn.Name = "ShutDownEMPBtn";
            this.ShutDownEMPBtn.Size = new System.Drawing.Size(42, 48);
            this.ShutDownEMPBtn.TabIndex = 21;
            this.ShutDownEMPBtn.Text = "X";
            this.ShutDownEMPBtn.UseVisualStyleBackColor = true;
            this.ShutDownEMPBtn.Click += new System.EventHandler(this.ShutDownEMPBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EMPHeaderLbl
            // 
            this.EMPHeaderLbl.AutoSize = true;
            this.EMPHeaderLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMPHeaderLbl.Location = new System.Drawing.Point(109, 12);
            this.EMPHeaderLbl.Name = "EMPHeaderLbl";
            this.EMPHeaderLbl.Size = new System.Drawing.Size(419, 23);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Добавление и редактирование списка поставщиков";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.DeleteSupplierBtn);
            this.panel1.Controls.Add(this.SaveSupplierBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 66);
            this.panel1.TabIndex = 4;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataSource = typeof(RemontV2.Models.Поставщик);
            // 
            // iD_поставщикаLabel
            // 
            iD_поставщикаLabel.AutoSize = true;
            iD_поставщикаLabel.Location = new System.Drawing.Point(58, 92);
            iD_поставщикаLabel.Name = "iD_поставщикаLabel";
            iD_поставщикаLabel.Size = new System.Drawing.Size(131, 23);
            iD_поставщикаLabel.TabIndex = 5;
            iD_поставщикаLabel.Text = "ID поставщика:";
            // 
            // iD_поставщикаTextBox
            // 
            this.iD_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "ID_поставщика", true));
            this.iD_поставщикаTextBox.Location = new System.Drawing.Point(200, 89);
            this.iD_поставщикаTextBox.Name = "iD_поставщикаTextBox";
            this.iD_поставщикаTextBox.ReadOnly = true;
            this.iD_поставщикаTextBox.Size = new System.Drawing.Size(64, 30);
            this.iD_поставщикаTextBox.TabIndex = 6;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(58, 147);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(61, 23);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(200, 144);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(289, 30);
            this.адресTextBox.TabIndex = 8;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(58, 197);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 23);
            наименованиеLabel.TabIndex = 9;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(200, 194);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(289, 30);
            this.наименованиеTextBox.TabIndex = 10;
            // 
            // SaveSupplierBtn
            // 
            this.SaveSupplierBtn.Location = new System.Drawing.Point(12, 17);
            this.SaveSupplierBtn.Name = "SaveSupplierBtn";
            this.SaveSupplierBtn.Size = new System.Drawing.Size(145, 33);
            this.SaveSupplierBtn.TabIndex = 0;
            this.SaveSupplierBtn.Text = "Сохранить";
            this.SaveSupplierBtn.UseVisualStyleBackColor = true;
            this.SaveSupplierBtn.Click += new System.EventHandler(this.SaveSupplierBtn_Click);
            // 
            // DeleteSupplierBtn
            // 
            this.DeleteSupplierBtn.Location = new System.Drawing.Point(433, 17);
            this.DeleteSupplierBtn.Name = "DeleteSupplierBtn";
            this.DeleteSupplierBtn.Size = new System.Drawing.Size(145, 33);
            this.DeleteSupplierBtn.TabIndex = 0;
            this.DeleteSupplierBtn.Text = "Удалить";
            this.DeleteSupplierBtn.UseVisualStyleBackColor = true;
            this.DeleteSupplierBtn.Click += new System.EventHandler(this.DeleteSupplierBtn_Click);
            // 
            // SupplierAddEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(590, 326);
            this.Controls.Add(iD_поставщикаLabel);
            this.Controls.Add(this.iD_поставщикаTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierAddEdit";
            this.Text = "SupplierAddEdit";
            this.Load += new System.EventHandler(this.SupplierAddEdit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteSupplierBtn;
        private System.Windows.Forms.Button SaveSupplierBtn;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.TextBox iD_поставщикаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
    }
}