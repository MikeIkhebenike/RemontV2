namespace RemontV2.Views
{
    partial class ChangePlaceForm
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
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePlaceForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.рольTextBox = new System.Windows.Forms.TextBox();
            this.SavePlaceBtn = new System.Windows.Forms.Button();
            должностьLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(477, 66);
            this.panel2.TabIndex = 3;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(438, 1);
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
            this.EMPHeaderLbl.Location = new System.Drawing.Point(125, 23);
            this.EMPHeaderLbl.Name = "EMPHeaderLbl";
            this.EMPHeaderLbl.Size = new System.Drawing.Size(281, 23);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Изменение должности сотрудника";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SavePlaceBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 50);
            this.panel1.TabIndex = 6;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataSource = typeof(RemontV2.Models.Сотрудник);
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(41, 188);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(99, 23);
            должностьLabel.TabIndex = 7;
            должностьLabel.Text = "Должность:";
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(152, 185);
            this.должностьTextBox.MaxLength = 100;
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(254, 30);
            this.должностьTextBox.TabIndex = 8;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(41, 88);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(50, 23);
            фИОLabel.TabIndex = 8;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(152, 88);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.ReadOnly = true;
            this.фИОTextBox.Size = new System.Drawing.Size(254, 30);
            this.фИОTextBox.TabIndex = 9;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(41, 139);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(55, 23);
            наименованиеLabel.TabIndex = 9;
            наименованиеLabel.Text = "Роль: ";
            // 
            // рольTextBox
            // 
            this.рольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Роль.Наименование", true));
            this.рольTextBox.Location = new System.Drawing.Point(152, 139);
            this.рольTextBox.Name = "рольTextBox";
            this.рольTextBox.ReadOnly = true;
            this.рольTextBox.Size = new System.Drawing.Size(254, 30);
            this.рольTextBox.TabIndex = 11;
            // 
            // SavePlaceBtn
            // 
            this.SavePlaceBtn.Location = new System.Drawing.Point(172, 8);
            this.SavePlaceBtn.Name = "SavePlaceBtn";
            this.SavePlaceBtn.Size = new System.Drawing.Size(133, 34);
            this.SavePlaceBtn.TabIndex = 1;
            this.SavePlaceBtn.Text = "Сохранить";
            this.SavePlaceBtn.UseVisualStyleBackColor = true;
            this.SavePlaceBtn.Click += new System.EventHandler(this.SavePlaceBtn_Click);
            // 
            // ChangePlaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(477, 289);
            this.Controls.Add(this.рольTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePlaceForm";
            this.Text = "ChangePlaceForm";
            this.Load += new System.EventHandler(this.ChangePlaceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox рольTextBox;
        private System.Windows.Forms.Button SavePlaceBtn;
    }
}