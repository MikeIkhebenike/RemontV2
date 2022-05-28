namespace RemontV2.Views
{
    partial class ChangeReqCloseDateForm
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
            System.Windows.Forms.Label датаОткрLabel;
            System.Windows.Forms.Label датаЗакрLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeReqCloseDateForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EMPHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveChangeEMPBtn = new System.Windows.Forms.Button();
            this.датаОткрDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаЗакрDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            датаОткрLabel = new System.Windows.Forms.Label();
            датаЗакрLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(513, 66);
            this.panel2.TabIndex = 2;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(468, 1);
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
            this.EMPHeaderLbl.Size = new System.Drawing.Size(278, 23);
            this.EMPHeaderLbl.TabIndex = 0;
            this.EMPHeaderLbl.Text = "Изменение даты закрытия заявки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.saveChangeEMPBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 66);
            this.panel1.TabIndex = 3;
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
            // датаОткрLabel
            // 
            датаОткрLabel.AutoSize = true;
            датаОткрLabel.Location = new System.Drawing.Point(23, 103);
            датаОткрLabel.Name = "датаОткрLabel";
            датаОткрLabel.Size = new System.Drawing.Size(129, 23);
            датаОткрLabel.TabIndex = 4;
            датаОткрLabel.Text = "Дата открытия:";
            // 
            // датаОткрDateTimePicker
            // 
            this.датаОткрDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаBindingSource, "ДатаОткр", true));
            this.датаОткрDateTimePicker.Enabled = false;
            this.датаОткрDateTimePicker.Location = new System.Drawing.Point(158, 103);
            this.датаОткрDateTimePicker.Name = "датаОткрDateTimePicker";
            this.датаОткрDateTimePicker.Size = new System.Drawing.Size(262, 30);
            this.датаОткрDateTimePicker.TabIndex = 5;
            // 
            // датаЗакрLabel
            // 
            датаЗакрLabel.AutoSize = true;
            датаЗакрLabel.Location = new System.Drawing.Point(23, 182);
            датаЗакрLabel.Name = "датаЗакрLabel";
            датаЗакрLabel.Size = new System.Drawing.Size(127, 23);
            датаЗакрLabel.TabIndex = 5;
            датаЗакрLabel.Text = "Дата закрытия:";
            // 
            // датаЗакрDateTimePicker
            // 
            this.датаЗакрDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаBindingSource, "ДатаЗакр", true));
            this.датаЗакрDateTimePicker.Location = new System.Drawing.Point(158, 177);
            this.датаЗакрDateTimePicker.Name = "датаЗакрDateTimePicker";
            this.датаЗакрDateTimePicker.Size = new System.Drawing.Size(262, 30);
            this.датаЗакрDateTimePicker.TabIndex = 6;
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataSource = typeof(RemontV2.Models.Заявка);
            // 
            // ChangeReqCloseDateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(513, 306);
            this.Controls.Add(датаЗакрLabel);
            this.Controls.Add(this.датаЗакрDateTimePicker);
            this.Controls.Add(датаОткрLabel);
            this.Controls.Add(this.датаОткрDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeReqCloseDateForm";
            this.Text = "ChangeReqCloseDateForm";
            this.Load += new System.EventHandler(this.ChangeReqCloseDateForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private System.Windows.Forms.DateTimePicker датаОткрDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаЗакрDateTimePicker;
    }
}