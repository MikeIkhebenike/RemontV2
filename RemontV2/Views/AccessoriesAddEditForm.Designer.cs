namespace RemontV2.Views
{
    partial class AccessoriesAddEditForm
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
            System.Windows.Forms.Label iD_комплектующегоLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.Windows.Forms.Label количествоВналичLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьШтLabel;
            System.Windows.Forms.Label наименованиеLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoriesAddEditForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveAccBtn2 = new System.Windows.Forms.Button();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.SaveAccBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChoosePicBtn = new System.Windows.Forms.Button();
            this.наименованиеComboBox = new System.Windows.Forms.ComboBox();
            this.комплектующееBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_комплектующегоTextBox = new System.Windows.Forms.TextBox();
            this.изображениеPictureBox = new System.Windows.Forms.PictureBox();
            this.количествоВналичTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьШтTextBox = new System.Windows.Forms.TextBox();
            iD_комплектующегоLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            количествоВналичLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьШтLabel = new System.Windows.Forms.Label();
            наименованиеLabel1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_комплектующегоLabel
            // 
            iD_комплектующегоLabel.AutoSize = true;
            iD_комплектующегоLabel.Location = new System.Drawing.Point(22, 49);
            iD_комплектующегоLabel.Name = "iD_комплектующегоLabel";
            iD_комплектующегоLabel.Size = new System.Drawing.Size(175, 23);
            iD_комплектующегоLabel.TabIndex = 0;
            iD_комплектующегоLabel.Text = "ID комплектующего:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Location = new System.Drawing.Point(650, 46);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(114, 23);
            изображениеLabel.TabIndex = 4;
            изображениеLabel.Text = "Изображение:";
            // 
            // количествоВналичLabel
            // 
            количествоВналичLabel.AutoSize = true;
            количествоВналичLabel.Location = new System.Drawing.Point(22, 156);
            количествоВналичLabel.Name = "количествоВналичLabel";
            количествоВналичLabel.Size = new System.Drawing.Size(188, 23);
            количествоВналичLabel.TabIndex = 6;
            количествоВналичLabel.Text = "Количество в наличии:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(22, 206);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 23);
            наименованиеLabel.TabIndex = 8;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьШтLabel
            // 
            стоимостьШтLabel.AutoSize = true;
            стоимостьШтLabel.Location = new System.Drawing.Point(22, 257);
            стоимостьШтLabel.Name = "стоимостьШтLabel";
            стоимостьШтLabel.Size = new System.Drawing.Size(125, 23);
            стоимостьШтLabel.TabIndex = 10;
            стоимостьШтLabel.Text = "Стоимость Шт:";
            // 
            // наименованиеLabel1
            // 
            наименованиеLabel1.AutoSize = true;
            наименованиеLabel1.Location = new System.Drawing.Point(22, 102);
            наименованиеLabel1.Name = "наименованиеLabel1";
            наименованиеLabel1.Size = new System.Drawing.Size(102, 23);
            наименованиеLabel1.TabIndex = 12;
            наименованиеLabel1.Text = "Поставщик:";
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
            this.panel2.Size = new System.Drawing.Size(822, 66);
            this.panel2.TabIndex = 3;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(779, 3);
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
            this.EMPHeaderLbl.Location = new System.Drawing.Point(153, 19);
            this.EMPHeaderLbl.Name = "EMPHeaderLbl";
            this.EMPHeaderLbl.Size = new System.Drawing.Size(576, 27);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Добавление и редактирование данных по комплектующим";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SaveAccBtn2);
            this.panel1.Controls.Add(this.DeleteAccBtn);
            this.panel1.Controls.Add(this.SaveAccBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 66);
            this.panel1.TabIndex = 4;
            // 
            // SaveAccBtn2
            // 
            this.SaveAccBtn2.Location = new System.Drawing.Point(307, 18);
            this.SaveAccBtn2.Name = "SaveAccBtn2";
            this.SaveAccBtn2.Size = new System.Drawing.Size(183, 36);
            this.SaveAccBtn2.TabIndex = 1;
            this.SaveAccBtn2.Text = "Сохранить";
            this.SaveAccBtn2.UseVisualStyleBackColor = true;
            this.SaveAccBtn2.Click += new System.EventHandler(this.SaveAccBtn2_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Location = new System.Drawing.Point(627, 18);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(183, 36);
            this.DeleteAccBtn.TabIndex = 0;
            this.DeleteAccBtn.Text = "Удалить";
            this.DeleteAccBtn.UseVisualStyleBackColor = true;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            // 
            // SaveAccBtn
            // 
            this.SaveAccBtn.Location = new System.Drawing.Point(15, 18);
            this.SaveAccBtn.Name = "SaveAccBtn";
            this.SaveAccBtn.Size = new System.Drawing.Size(183, 36);
            this.SaveAccBtn.TabIndex = 0;
            this.SaveAccBtn.Text = "Изменить";
            this.SaveAccBtn.UseVisualStyleBackColor = true;
            this.SaveAccBtn.Click += new System.EventHandler(this.SaveAccBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChoosePicBtn);
            this.groupBox1.Controls.Add(наименованиеLabel1);
            this.groupBox1.Controls.Add(this.наименованиеComboBox);
            this.groupBox1.Controls.Add(iD_комплектующегоLabel);
            this.groupBox1.Controls.Add(this.iD_комплектующегоTextBox);
            this.groupBox1.Controls.Add(изображениеLabel);
            this.groupBox1.Controls.Add(this.изображениеPictureBox);
            this.groupBox1.Controls.Add(количествоВналичLabel);
            this.groupBox1.Controls.Add(this.количествоВналичTextBox);
            this.groupBox1.Controls.Add(наименованиеLabel);
            this.groupBox1.Controls.Add(this.наименованиеTextBox);
            this.groupBox1.Controls.Add(стоимостьШтLabel);
            this.groupBox1.Controls.Add(this.стоимостьШтTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните все поля формы";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ChoosePicBtn
            // 
            this.ChoosePicBtn.Location = new System.Drawing.Point(615, 244);
            this.ChoosePicBtn.Name = "ChoosePicBtn";
            this.ChoosePicBtn.Size = new System.Drawing.Size(183, 36);
            this.ChoosePicBtn.TabIndex = 14;
            this.ChoosePicBtn.Text = "Выбрать";
            this.ChoosePicBtn.UseVisualStyleBackColor = true;
            this.ChoosePicBtn.Click += new System.EventHandler(this.ChoosePicBtn_Click);
            // 
            // наименованиеComboBox
            // 
            this.наименованиеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "Поставщик.Наименование", true));
            this.наименованиеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.комплектующееBindingSource, "ID_поставщика", true));
            this.наименованиеComboBox.DataSource = this.поставщикBindingSource;
            this.наименованиеComboBox.DisplayMember = "Наименование";
            this.наименованиеComboBox.FormattingEnabled = true;
            this.наименованиеComboBox.Location = new System.Drawing.Point(224, 99);
            this.наименованиеComboBox.Name = "наименованиеComboBox";
            this.наименованиеComboBox.Size = new System.Drawing.Size(318, 31);
            this.наименованиеComboBox.TabIndex = 13;
            this.наименованиеComboBox.ValueMember = "ID_поставщика";
            // 
            // комплектующееBindingSource
            // 
            this.комплектующееBindingSource.DataSource = typeof(RemontV2.Models.Комплектующее);
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataSource = typeof(RemontV2.Models.Поставщик);
            // 
            // iD_комплектующегоTextBox
            // 
            this.iD_комплектующегоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "ID_комплектующего", true));
            this.iD_комплектующегоTextBox.Location = new System.Drawing.Point(224, 46);
            this.iD_комплектующегоTextBox.Name = "iD_комплектующегоTextBox";
            this.iD_комплектующегоTextBox.ReadOnly = true;
            this.iD_комплектующегоTextBox.Size = new System.Drawing.Size(81, 30);
            this.iD_комплектующегоTextBox.TabIndex = 1;
            // 
            // изображениеPictureBox
            // 
            this.изображениеPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.изображениеPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.комплектующееBindingSource, "Изображение", true));
            this.изображениеPictureBox.Location = new System.Drawing.Point(624, 72);
            this.изображениеPictureBox.Name = "изображениеPictureBox";
            this.изображениеPictureBox.Size = new System.Drawing.Size(167, 161);
            this.изображениеPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.изображениеPictureBox.TabIndex = 5;
            this.изображениеPictureBox.TabStop = false;
            // 
            // количествоВналичTextBox
            // 
            this.количествоВналичTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "КоличествоВналич", true));
            this.количествоВналичTextBox.Location = new System.Drawing.Point(224, 153);
            this.количествоВналичTextBox.MaxLength = 10;
            this.количествоВналичTextBox.Name = "количествоВналичTextBox";
            this.количествоВналичTextBox.Size = new System.Drawing.Size(121, 30);
            this.количествоВналичTextBox.TabIndex = 7;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(224, 203);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(318, 30);
            this.наименованиеTextBox.TabIndex = 9;
            // 
            // стоимостьШтTextBox
            // 
            this.стоимостьШтTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "СтоимостьШт", true));
            this.стоимостьШтTextBox.Location = new System.Drawing.Point(224, 254);
            this.стоимостьШтTextBox.Name = "стоимостьШтTextBox";
            this.стоимостьШтTextBox.Size = new System.Drawing.Size(318, 30);
            this.стоимостьШтTextBox.TabIndex = 11;
            // 
            // AccessoriesAddEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessoriesAddEditForm";
            this.Text = "AccessoriesAddEditForm";
            this.Load += new System.EventHandler(this.AccessoriesAddEditForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteAccBtn;
        private System.Windows.Forms.Button SaveAccBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox наименованиеComboBox;
        private System.Windows.Forms.BindingSource комплектующееBindingSource;
        private System.Windows.Forms.TextBox iD_комплектующегоTextBox;
        private System.Windows.Forms.PictureBox изображениеPictureBox;
        private System.Windows.Forms.TextBox количествоВналичTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox стоимостьШтTextBox;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.Button ChoosePicBtn;
        private System.Windows.Forms.Button SaveAccBtn2;
    }
}