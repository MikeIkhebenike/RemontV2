namespace RemontV2.Views
{
    partial class ChangePriceForm
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьШтLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePriceForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.комплектующееBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьШтTextBox = new System.Windows.Forms.TextBox();
            this.изображениеPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveAccessoriesCostBtn = new System.Windows.Forms.Button();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьШтLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(669, 66);
            this.panel2.TabIndex = 4;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(624, 1);
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
            this.EMPHeaderLbl.Size = new System.Drawing.Size(328, 23);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Изменение стоимости комплектующего";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SaveAccessoriesCostBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 50);
            this.panel1.TabIndex = 6;
            // 
            // комплектующееBindingSource
            // 
            this.комплектующееBindingSource.DataSource = typeof(RemontV2.Models.Комплектующее);
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(8, 104);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 23);
            наименованиеLabel.TabIndex = 7;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(170, 101);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.ReadOnly = true;
            this.наименованиеTextBox.Size = new System.Drawing.Size(248, 30);
            this.наименованиеTextBox.TabIndex = 8;
            // 
            // стоимостьШтLabel
            // 
            стоимостьШтLabel.AutoSize = true;
            стоимостьШтLabel.Location = new System.Drawing.Point(9, 196);
            стоимостьШтLabel.Name = "стоимостьШтLabel";
            стоимостьШтLabel.Size = new System.Drawing.Size(125, 23);
            стоимостьШтLabel.TabIndex = 8;
            стоимостьШтLabel.Text = "Стоимость Шт:";
            // 
            // стоимостьШтTextBox
            // 
            this.стоимостьШтTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.комплектующееBindingSource, "СтоимостьШт", true));
            this.стоимостьШтTextBox.Location = new System.Drawing.Point(170, 189);
            this.стоимостьШтTextBox.MaxLength = 100;
            this.стоимостьШтTextBox.Name = "стоимостьШтTextBox";
            this.стоимостьШтTextBox.Size = new System.Drawing.Size(248, 30);
            this.стоимостьШтTextBox.TabIndex = 9;
            // 
            // изображениеPictureBox
            // 
            this.изображениеPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.изображениеPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.комплектующееBindingSource, "Изображение", true));
            this.изображениеPictureBox.Location = new System.Drawing.Point(476, 101);
            this.изображениеPictureBox.Name = "изображениеPictureBox";
            this.изображениеPictureBox.Size = new System.Drawing.Size(173, 117);
            this.изображениеPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.изображениеPictureBox.TabIndex = 10;
            this.изображениеPictureBox.TabStop = false;
            // 
            // SaveAccessoriesCostBtn
            // 
            this.SaveAccessoriesCostBtn.Location = new System.Drawing.Point(268, 8);
            this.SaveAccessoriesCostBtn.Name = "SaveAccessoriesCostBtn";
            this.SaveAccessoriesCostBtn.Size = new System.Drawing.Size(133, 34);
            this.SaveAccessoriesCostBtn.TabIndex = 1;
            this.SaveAccessoriesCostBtn.Text = "Сохранить";
            this.SaveAccessoriesCostBtn.UseVisualStyleBackColor = true;
            this.SaveAccessoriesCostBtn.Click += new System.EventHandler(this.SaveAccessoriesCostBtn_Click);
            // 
            // ChangePriceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(669, 307);
            this.Controls.Add(this.изображениеPictureBox);
            this.Controls.Add(стоимостьШтLabel);
            this.Controls.Add(this.стоимостьШтTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePriceForm";
            this.Text = "ChangePriceForm";
            this.Load += new System.EventHandler(this.ChangePriceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.комплектующееBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShutDownEMPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EMPHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource комплектующееBindingSource;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox стоимостьШтTextBox;
        private System.Windows.Forms.PictureBox изображениеPictureBox;
        private System.Windows.Forms.Button SaveAccessoriesCostBtn;
    }
}