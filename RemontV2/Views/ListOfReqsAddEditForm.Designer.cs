namespace RemontV2.Views
{
    partial class ListOfReqsAddEditForm
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
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label дата_закрытияLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfReqsAddEditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteListReqBtn = new System.Windows.Forms.Button();
            this.SaveListReqBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_поставщикаComboBox = new System.Windows.Forms.ComboBox();
            this.заявкаНаПоставкуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_сотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_закрытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            iD_поставщикаLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            дата_закрытияLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаНаПоставкуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_поставщикаLabel
            // 
            iD_поставщикаLabel.AutoSize = true;
            iD_поставщикаLabel.Location = new System.Drawing.Point(107, 142);
            iD_поставщикаLabel.Name = "iD_поставщикаLabel";
            iD_поставщикаLabel.Size = new System.Drawing.Size(102, 23);
            iD_поставщикаLabel.TabIndex = 0;
            iD_поставщикаLabel.Text = "Поставщик:";
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(107, 193);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(96, 23);
            iD_сотрудникаLabel.TabIndex = 2;
            iD_сотрудникаLabel.Text = "Сотрудник:";
            // 
            // дата_закрытияLabel
            // 
            дата_закрытияLabel.AutoSize = true;
            дата_закрытияLabel.Location = new System.Drawing.Point(107, 244);
            дата_закрытияLabel.Name = "дата_закрытияLabel";
            дата_закрытияLabel.Size = new System.Drawing.Size(127, 23);
            дата_закрытияLabel.TabIndex = 4;
            дата_закрытияLabel.Text = "Дата закрытия:";
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(107, 293);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(124, 23);
            дата_созданияLabel.TabIndex = 6;
            дата_созданияLabel.Text = "Дата создания:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(107, 92);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(104, 23);
            количествоLabel.TabIndex = 8;
            количествоLabel.Text = "Количество:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(107, 41);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 23);
            наименованиеLabel.TabIndex = 10;
            наименованиеLabel.Text = "Наименование:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ShutDownEMPBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 77);
            this.panel1.TabIndex = 0;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(788, 3);
            this.ShutDownEMPBtn.Name = "ShutDownEMPBtn";
            this.ShutDownEMPBtn.Size = new System.Drawing.Size(42, 48);
            this.ShutDownEMPBtn.TabIndex = 22;
            this.ShutDownEMPBtn.Text = "X";
            this.ShutDownEMPBtn.UseVisualStyleBackColor = true;
            this.ShutDownEMPBtn.Click += new System.EventHandler(this.ShutDownEMPBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заявки на поставку";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.DeleteListReqBtn);
            this.panel2.Controls.Add(this.SaveListReqBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 57);
            this.panel2.TabIndex = 0;
            // 
            // DeleteListReqBtn
            // 
            this.DeleteListReqBtn.Location = new System.Drawing.Point(666, 12);
            this.DeleteListReqBtn.Name = "DeleteListReqBtn";
            this.DeleteListReqBtn.Size = new System.Drawing.Size(155, 36);
            this.DeleteListReqBtn.TabIndex = 0;
            this.DeleteListReqBtn.Text = "Удалить";
            this.DeleteListReqBtn.UseVisualStyleBackColor = true;
            this.DeleteListReqBtn.Click += new System.EventHandler(this.DeleteListReqBtn_Click);
            // 
            // SaveListReqBtn
            // 
            this.SaveListReqBtn.Location = new System.Drawing.Point(12, 12);
            this.SaveListReqBtn.Name = "SaveListReqBtn";
            this.SaveListReqBtn.Size = new System.Drawing.Size(155, 36);
            this.SaveListReqBtn.TabIndex = 0;
            this.SaveListReqBtn.Text = "Сохранить";
            this.SaveListReqBtn.UseVisualStyleBackColor = true;
            this.SaveListReqBtn.Click += new System.EventHandler(this.SaveListReqBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iD_поставщикаLabel);
            this.groupBox1.Controls.Add(this.iD_поставщикаComboBox);
            this.groupBox1.Controls.Add(iD_сотрудникаLabel);
            this.groupBox1.Controls.Add(this.iD_сотрудникаComboBox);
            this.groupBox1.Controls.Add(дата_закрытияLabel);
            this.groupBox1.Controls.Add(this.дата_закрытияDateTimePicker);
            this.groupBox1.Controls.Add(дата_созданияLabel);
            this.groupBox1.Controls.Add(this.дата_созданияDateTimePicker);
            this.groupBox1.Controls.Add(количествоLabel);
            this.groupBox1.Controls.Add(this.количествоTextBox);
            this.groupBox1.Controls.Add(наименованиеLabel);
            this.groupBox1.Controls.Add(this.наименованиеTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // iD_поставщикаComboBox
            // 
            this.iD_поставщикаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаНаПоставкуBindingSource, "ID_поставщика", true));
            this.iD_поставщикаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заявкаНаПоставкуBindingSource, "ID_поставщика", true));
            this.iD_поставщикаComboBox.DataSource = this.поставщикBindingSource;
            this.iD_поставщикаComboBox.DisplayMember = "Наименование";
            this.iD_поставщикаComboBox.FormattingEnabled = true;
            this.iD_поставщикаComboBox.Location = new System.Drawing.Point(286, 139);
            this.iD_поставщикаComboBox.Name = "iD_поставщикаComboBox";
            this.iD_поставщикаComboBox.Size = new System.Drawing.Size(295, 31);
            this.iD_поставщикаComboBox.TabIndex = 1;
            this.iD_поставщикаComboBox.ValueMember = "ID_поставщика";
            // 
            // заявкаНаПоставкуBindingSource
            // 
            this.заявкаНаПоставкуBindingSource.DataSource = typeof(RemontV2.Models.ЗаявкаНаПоставку);
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataSource = typeof(RemontV2.Models.Поставщик);
            // 
            // iD_сотрудникаComboBox
            // 
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаНаПоставкуBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заявкаНаПоставкуBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataSource = this.сотрудникBindingSource;
            this.iD_сотрудникаComboBox.DisplayMember = "ФИО";
            this.iD_сотрудникаComboBox.FormattingEnabled = true;
            this.iD_сотрудникаComboBox.Location = new System.Drawing.Point(286, 190);
            this.iD_сотрудникаComboBox.Name = "iD_сотрудникаComboBox";
            this.iD_сотрудникаComboBox.Size = new System.Drawing.Size(295, 31);
            this.iD_сотрудникаComboBox.TabIndex = 3;
            this.iD_сотрудникаComboBox.ValueMember = "ID_сотрудника";
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataSource = typeof(RemontV2.Models.Сотрудник);
            // 
            // дата_закрытияDateTimePicker
            // 
            this.дата_закрытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаНаПоставкуBindingSource, "Дата_закрытия", true));
            this.дата_закрытияDateTimePicker.Location = new System.Drawing.Point(286, 240);
            this.дата_закрытияDateTimePicker.Name = "дата_закрытияDateTimePicker";
            this.дата_закрытияDateTimePicker.Size = new System.Drawing.Size(295, 30);
            this.дата_закрытияDateTimePicker.TabIndex = 5;
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаНаПоставкуBindingSource, "Дата_создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(286, 289);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(295, 30);
            this.дата_созданияDateTimePicker.TabIndex = 7;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаНаПоставкуBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(286, 89);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(295, 30);
            this.количествоTextBox.TabIndex = 9;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаНаПоставкуBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(286, 38);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(295, 30);
            this.наименованиеTextBox.TabIndex = 11;
            // 
            // ListOfReqsAddEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListOfReqsAddEditForm";
            this.Text = "ListOfReqsAddEditForm";
            this.Load += new System.EventHandler(this.ListOfReqsAddEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаНаПоставкуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteListReqBtn;
        private System.Windows.Forms.Button SaveListReqBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox iD_поставщикаComboBox;
        private System.Windows.Forms.BindingSource заявкаНаПоставкуBindingSource;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.ComboBox iD_сотрудникаComboBox;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.DateTimePicker дата_закрытияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.Button ShutDownEMPBtn;
    }
}