namespace RemontV2.Views
{
    partial class WorkAddEditForm
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
            System.Windows.Forms.Label iD_заявкиLabel;
            System.Windows.Forms.Label iD_комплектующегоLabel;
            System.Windows.Forms.Label iD_работыLabel;
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label iD_статусаLabel;
            System.Windows.Forms.Label iD_услугиLabel;
            System.Windows.Forms.Label датаЗавершLabel;
            System.Windows.Forms.Label датаНачLabel;
            System.Windows.Forms.Label характер_ремонтаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkAddEditForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_заявкиComboBox = new System.Windows.Forms.ComboBox();
            this.iD_комплектующегоComboBox = new System.Windows.Forms.ComboBox();
            this.iD_работыTextBox = new System.Windows.Forms.TextBox();
            this.iD_сотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_статусаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_услугиComboBox = new System.Windows.Forms.ComboBox();
            this.датаЗавершDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаНачDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.характер_ремонтаTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveWorkBtn = new System.Windows.Forms.Button();
            this.DeleteWorkBtn = new System.Windows.Forms.Button();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комплектующееBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_заявкиLabel = new System.Windows.Forms.Label();
            iD_комплектующегоLabel = new System.Windows.Forms.Label();
            iD_работыLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            iD_статусаLabel = new System.Windows.Forms.Label();
            iD_услугиLabel = new System.Windows.Forms.Label();
            датаЗавершLabel = new System.Windows.Forms.Label();
            датаНачLabel = new System.Windows.Forms.Label();
            характер_ремонтаLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(833, 66);
            this.panel2.TabIndex = 2;
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
            this.EMPHeaderLbl.Location = new System.Drawing.Point(153, 19);
            this.EMPHeaderLbl.Name = "EMPHeaderLbl";
            this.EMPHeaderLbl.Size = new System.Drawing.Size(511, 23);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Добавление и редактирование данных по ремонтным работам";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.DeleteWorkBtn);
            this.panel1.Controls.Add(this.SaveWorkBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 66);
            this.panel1.TabIndex = 3;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataSource = typeof(RemontV2.Models.Ремонт);
            // 
            // iD_заявкиLabel
            // 
            iD_заявкиLabel.AutoSize = true;
            iD_заявкиLabel.Location = new System.Drawing.Point(67, 88);
            iD_заявкиLabel.Name = "iD_заявкиLabel";
            iD_заявкиLabel.Size = new System.Drawing.Size(90, 23);
            iD_заявкиLabel.TabIndex = 4;
            iD_заявкиLabel.Text = "ID заявки:";
            // 
            // iD_заявкиComboBox
            // 
            this.iD_заявкиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_заявки", true));
            this.iD_заявкиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_заявки", true));
            this.iD_заявкиComboBox.DataSource = this.заявкаBindingSource;
            this.iD_заявкиComboBox.DisplayMember = "ID_заявки";
            this.iD_заявкиComboBox.FormattingEnabled = true;
            this.iD_заявкиComboBox.Location = new System.Drawing.Point(248, 85);
            this.iD_заявкиComboBox.Name = "iD_заявкиComboBox";
            this.iD_заявкиComboBox.Size = new System.Drawing.Size(385, 31);
            this.iD_заявкиComboBox.TabIndex = 5;
            this.iD_заявкиComboBox.ValueMember = "ID_заявки";
            // 
            // iD_комплектующегоLabel
            // 
            iD_комплектующегоLabel.AutoSize = true;
            iD_комплектующегоLabel.Location = new System.Drawing.Point(67, 216);
            iD_комплектующегоLabel.Name = "iD_комплектующегоLabel";
            iD_комплектующегоLabel.Size = new System.Drawing.Size(175, 23);
            iD_комплектующегоLabel.TabIndex = 6;
            iD_комплектующегоLabel.Text = "ID комплектующего:";
            // 
            // iD_комплектующегоComboBox
            // 
            this.iD_комплектующегоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоComboBox.DataSource = this.комплектующееBindingSource;
            this.iD_комплектующегоComboBox.DisplayMember = "Наименование";
            this.iD_комплектующегоComboBox.FormattingEnabled = true;
            this.iD_комплектующегоComboBox.Location = new System.Drawing.Point(248, 213);
            this.iD_комплектующегоComboBox.Name = "iD_комплектующегоComboBox";
            this.iD_комплектующегоComboBox.Size = new System.Drawing.Size(385, 31);
            this.iD_комплектующегоComboBox.TabIndex = 7;
            this.iD_комплектующегоComboBox.ValueMember = "ID_комплектующего";
            // 
            // iD_работыLabel
            // 
            iD_работыLabel.AutoSize = true;
            iD_работыLabel.Location = new System.Drawing.Point(67, 46);
            iD_работыLabel.Name = "iD_работыLabel";
            iD_работыLabel.Size = new System.Drawing.Size(96, 23);
            iD_работыLabel.TabIndex = 8;
            iD_работыLabel.Text = "ID работы:";
            // 
            // iD_работыTextBox
            // 
            this.iD_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_работы", true));
            this.iD_работыTextBox.Location = new System.Drawing.Point(248, 43);
            this.iD_работыTextBox.Name = "iD_работыTextBox";
            this.iD_работыTextBox.ReadOnly = true;
            this.iD_работыTextBox.Size = new System.Drawing.Size(120, 30);
            this.iD_работыTextBox.TabIndex = 9;
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(67, 173);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(128, 23);
            iD_сотрудникаLabel.TabIndex = 10;
            iD_сотрудникаLabel.Text = "ID сотрудника:";
            // 
            // iD_сотрудникаComboBox
            // 
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаComboBox.DataSource = this.сотрудникBindingSource;
            this.iD_сотрудникаComboBox.DisplayMember = "ФИО";
            this.iD_сотрудникаComboBox.FormattingEnabled = true;
            this.iD_сотрудникаComboBox.Location = new System.Drawing.Point(248, 170);
            this.iD_сотрудникаComboBox.Name = "iD_сотрудникаComboBox";
            this.iD_сотрудникаComboBox.Size = new System.Drawing.Size(385, 31);
            this.iD_сотрудникаComboBox.TabIndex = 11;
            this.iD_сотрудникаComboBox.ValueMember = "ID_сотрудника";
            // 
            // iD_статусаLabel
            // 
            iD_статусаLabel.AutoSize = true;
            iD_статусаLabel.Location = new System.Drawing.Point(67, 260);
            iD_статусаLabel.Name = "iD_статусаLabel";
            iD_статусаLabel.Size = new System.Drawing.Size(98, 23);
            iD_статусаLabel.TabIndex = 12;
            iD_статусаLabel.Text = "ID статуса:";
            // 
            // iD_статусаComboBox
            // 
            this.iD_статусаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_статуса", true));
            this.iD_статусаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_статуса", true));
            this.iD_статусаComboBox.DataSource = this.статусРаботBindingSource;
            this.iD_статусаComboBox.DisplayMember = "Наименование";
            this.iD_статусаComboBox.FormattingEnabled = true;
            this.iD_статусаComboBox.Location = new System.Drawing.Point(248, 257);
            this.iD_статусаComboBox.Name = "iD_статусаComboBox";
            this.iD_статусаComboBox.Size = new System.Drawing.Size(385, 31);
            this.iD_статусаComboBox.TabIndex = 13;
            this.iD_статусаComboBox.ValueMember = "ID_статуса";
            // 
            // iD_услугиLabel
            // 
            iD_услугиLabel.AutoSize = true;
            iD_услугиLabel.Location = new System.Drawing.Point(67, 305);
            iD_услугиLabel.Name = "iD_услугиLabel";
            iD_услугиLabel.Size = new System.Drawing.Size(95, 23);
            iD_услугиLabel.TabIndex = 14;
            iD_услугиLabel.Text = "ID услуги:";
            // 
            // iD_услугиComboBox
            // 
            this.iD_услугиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "ID_услуги", true));
            this.iD_услугиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ремонтBindingSource, "ID_услуги", true));
            this.iD_услугиComboBox.DataSource = this.услугаBindingSource;
            this.iD_услугиComboBox.DisplayMember = "Наименование";
            this.iD_услугиComboBox.FormattingEnabled = true;
            this.iD_услугиComboBox.Location = new System.Drawing.Point(248, 302);
            this.iD_услугиComboBox.Name = "iD_услугиComboBox";
            this.iD_услугиComboBox.Size = new System.Drawing.Size(385, 31);
            this.iD_услугиComboBox.TabIndex = 15;
            this.iD_услугиComboBox.ValueMember = "ID_услуги";
            // 
            // датаЗавершLabel
            // 
            датаЗавершLabel.AutoSize = true;
            датаЗавершLabel.Location = new System.Drawing.Point(67, 349);
            датаЗавершLabel.Name = "датаЗавершLabel";
            датаЗавершLabel.Size = new System.Drawing.Size(111, 23);
            датаЗавершLabel.TabIndex = 16;
            датаЗавершLabel.Text = "Дата Заверш:";
            // 
            // датаЗавершDateTimePicker
            // 
            this.датаЗавершDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ремонтBindingSource, "ДатаЗаверш", true));
            this.датаЗавершDateTimePicker.Location = new System.Drawing.Point(248, 345);
            this.датаЗавершDateTimePicker.Name = "датаЗавершDateTimePicker";
            this.датаЗавершDateTimePicker.Size = new System.Drawing.Size(385, 30);
            this.датаЗавершDateTimePicker.TabIndex = 17;
            // 
            // датаНачLabel
            // 
            датаНачLabel.AutoSize = true;
            датаНачLabel.Location = new System.Drawing.Point(67, 391);
            датаНачLabel.Name = "датаНачLabel";
            датаНачLabel.Size = new System.Drawing.Size(85, 23);
            датаНачLabel.TabIndex = 18;
            датаНачLabel.Text = "Дата Нач:";
            // 
            // датаНачDateTimePicker
            // 
            this.датаНачDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ремонтBindingSource, "ДатаНач", true));
            this.датаНачDateTimePicker.Location = new System.Drawing.Point(248, 387);
            this.датаНачDateTimePicker.Name = "датаНачDateTimePicker";
            this.датаНачDateTimePicker.Size = new System.Drawing.Size(385, 30);
            this.датаНачDateTimePicker.TabIndex = 19;
            // 
            // характер_ремонтаLabel
            // 
            характер_ремонтаLabel.AutoSize = true;
            характер_ремонтаLabel.Location = new System.Drawing.Point(67, 131);
            характер_ремонтаLabel.Name = "характер_ремонтаLabel";
            характер_ремонтаLabel.Size = new System.Drawing.Size(153, 23);
            характер_ремонтаLabel.TabIndex = 20;
            характер_ремонтаLabel.Text = "Характер ремонта:";
            // 
            // характер_ремонтаTextBox
            // 
            this.характер_ремонтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтBindingSource, "Характер_ремонта", true));
            this.характер_ремонтаTextBox.Location = new System.Drawing.Point(248, 128);
            this.характер_ремонтаTextBox.Name = "характер_ремонтаTextBox";
            this.характер_ремонтаTextBox.Size = new System.Drawing.Size(385, 30);
            this.характер_ремонтаTextBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iD_статусаComboBox);
            this.groupBox1.Controls.Add(iD_заявкиLabel);
            this.groupBox1.Controls.Add(this.характер_ремонтаTextBox);
            this.groupBox1.Controls.Add(this.iD_заявкиComboBox);
            this.groupBox1.Controls.Add(характер_ремонтаLabel);
            this.groupBox1.Controls.Add(iD_комплектующегоLabel);
            this.groupBox1.Controls.Add(this.датаНачDateTimePicker);
            this.groupBox1.Controls.Add(this.iD_комплектующегоComboBox);
            this.groupBox1.Controls.Add(датаНачLabel);
            this.groupBox1.Controls.Add(iD_работыLabel);
            this.groupBox1.Controls.Add(this.датаЗавершDateTimePicker);
            this.groupBox1.Controls.Add(this.iD_работыTextBox);
            this.groupBox1.Controls.Add(датаЗавершLabel);
            this.groupBox1.Controls.Add(iD_сотрудникаLabel);
            this.groupBox1.Controls.Add(this.iD_услугиComboBox);
            this.groupBox1.Controls.Add(this.iD_сотрудникаComboBox);
            this.groupBox1.Controls.Add(iD_услугиLabel);
            this.groupBox1.Controls.Add(iD_статусаLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 458);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните все поля формы";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveWorkBtn
            // 
            this.SaveWorkBtn.Location = new System.Drawing.Point(15, 18);
            this.SaveWorkBtn.Name = "SaveWorkBtn";
            this.SaveWorkBtn.Size = new System.Drawing.Size(183, 36);
            this.SaveWorkBtn.TabIndex = 0;
            this.SaveWorkBtn.Text = "Сохранить";
            this.SaveWorkBtn.UseVisualStyleBackColor = true;
            this.SaveWorkBtn.Click += new System.EventHandler(this.SaveWorkBtn_Click);
            // 
            // DeleteWorkBtn
            // 
            this.DeleteWorkBtn.Location = new System.Drawing.Point(638, 18);
            this.DeleteWorkBtn.Name = "DeleteWorkBtn";
            this.DeleteWorkBtn.Size = new System.Drawing.Size(183, 36);
            this.DeleteWorkBtn.TabIndex = 0;
            this.DeleteWorkBtn.Text = "Удалить";
            this.DeleteWorkBtn.UseVisualStyleBackColor = true;
            this.DeleteWorkBtn.Click += new System.EventHandler(this.DeleteWorkBtn_Click);
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataSource = typeof(RemontV2.Models.Заявка);
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataSource = typeof(RemontV2.Models.Сотрудник);
            // 
            // комплектующееBindingSource
            // 
            this.комплектующееBindingSource.DataSource = typeof(RemontV2.Models.Комплектующее);
            // 
            // статусРаботBindingSource
            // 
            this.статусРаботBindingSource.DataSource = typeof(RemontV2.Models.СтатусРабот);
            // 
            // услугаBindingSource
            // 
            this.услугаBindingSource.DataSource = typeof(RemontV2.Models.Услуга);
            // 
            // WorkAddEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(833, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkAddEditForm";
            this.Text = "WorkAddEditForm";
            this.Load += new System.EventHandler(this.WorkAddEditForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private System.Windows.Forms.ComboBox iD_заявкиComboBox;
        private System.Windows.Forms.ComboBox iD_комплектующегоComboBox;
        private System.Windows.Forms.TextBox iD_работыTextBox;
        private System.Windows.Forms.ComboBox iD_сотрудникаComboBox;
        private System.Windows.Forms.ComboBox iD_статусаComboBox;
        private System.Windows.Forms.ComboBox iD_услугиComboBox;
        private System.Windows.Forms.DateTimePicker датаЗавершDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаНачDateTimePicker;
        private System.Windows.Forms.TextBox характер_ремонтаTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteWorkBtn;
        private System.Windows.Forms.Button SaveWorkBtn;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private System.Windows.Forms.BindingSource комплектующееBindingSource;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.BindingSource статусРаботBindingSource;
        private System.Windows.Forms.BindingSource услугаBindingSource;
    }
}