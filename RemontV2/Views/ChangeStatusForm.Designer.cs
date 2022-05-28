namespace RemontV2.Views
{
    partial class ChangeStatusForm
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
            System.Windows.Forms.Label iD_работыLabel;
            System.Windows.Forms.Label iD_статусаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStatusForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveChangeEMPBtn = new System.Windows.Forms.Button();
            this.статусРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_работыTextBox = new System.Windows.Forms.TextBox();
            this.iD_статусаComboBox = new System.Windows.Forms.ComboBox();
            iD_работыLabel = new System.Windows.Forms.Label();
            iD_статусаLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(485, 66);
            this.panel2.TabIndex = 5;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(442, 1);
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
            this.EMPHeaderLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMPHeaderLbl.Location = new System.Drawing.Point(176, 22);
            this.EMPHeaderLbl.Name = "EMPHeaderLbl";
            this.EMPHeaderLbl.Size = new System.Drawing.Size(194, 27);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Изменение статуса";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.saveChangeEMPBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 66);
            this.panel1.TabIndex = 6;
            // 
            // saveChangeEMPBtn
            // 
            this.saveChangeEMPBtn.Location = new System.Drawing.Point(175, 16);
            this.saveChangeEMPBtn.Name = "saveChangeEMPBtn";
            this.saveChangeEMPBtn.Size = new System.Drawing.Size(146, 38);
            this.saveChangeEMPBtn.TabIndex = 15;
            this.saveChangeEMPBtn.Text = "Сохранить";
            this.saveChangeEMPBtn.UseVisualStyleBackColor = true;
            this.saveChangeEMPBtn.Click += new System.EventHandler(this.saveChangeEMPBtn_Click);
            // 
            // статусРаботBindingSource
            // 
            this.статусРаботBindingSource.DataSource = typeof(RemontV2.Models.СтатусРабот);
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataSource = typeof(RemontV2.Models.Ремонт);
            // 
            // iD_работыLabel
            // 
            iD_работыLabel.AutoSize = true;
            iD_работыLabel.Location = new System.Drawing.Point(49, 115);
            iD_работыLabel.Name = "iD_работыLabel";
            iD_работыLabel.Size = new System.Drawing.Size(96, 23);
            iD_работыLabel.TabIndex = 8;
            iD_работыLabel.Text = "ID работы:";
            // 
            // iD_работыTextBox
            // 
            this.iD_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_работы", true));
            this.iD_работыTextBox.Location = new System.Drawing.Point(151, 112);
            this.iD_работыTextBox.Name = "iD_работыTextBox";
            this.iD_работыTextBox.Size = new System.Drawing.Size(71, 30);
            this.iD_работыTextBox.TabIndex = 9;
            // 
            // iD_статусаLabel
            // 
            iD_статусаLabel.AutoSize = true;
            iD_статусаLabel.Location = new System.Drawing.Point(47, 174);
            iD_статусаLabel.Name = "iD_статусаLabel";
            iD_статусаLabel.Size = new System.Drawing.Size(66, 23);
            iD_статусаLabel.TabIndex = 9;
            iD_статусаLabel.Text = "Статус:";
            // 
            // iD_статусаComboBox
            // 
            this.iD_статусаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_статуса", true));
            this.iD_статусаComboBox.FormattingEnabled = true;
            this.iD_статусаComboBox.Location = new System.Drawing.Point(151, 171);
            this.iD_статусаComboBox.Name = "iD_статусаComboBox";
            this.iD_статусаComboBox.Size = new System.Drawing.Size(187, 31);
            this.iD_статусаComboBox.TabIndex = 10;
            // 
            // ChangeStatusForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(485, 298);
            this.Controls.Add(iD_статусаLabel);
            this.Controls.Add(this.iD_статусаComboBox);
            this.Controls.Add(iD_работыLabel);
            this.Controls.Add(this.iD_работыTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeStatusForm";
            this.Text = "ChangeStatusForm";
            this.Load += new System.EventHandler(this.ChangeStatusForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveChangeEMPBtn;
        private System.Windows.Forms.BindingSource статусРаботBindingSource;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private System.Windows.Forms.TextBox iD_работыTextBox;
        private System.Windows.Forms.ComboBox iD_статусаComboBox;
    }
}