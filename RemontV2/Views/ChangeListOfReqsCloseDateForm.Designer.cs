namespace RemontV2.Views
{
    partial class ChangeListOfReqsCloseDateForm
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
            System.Windows.Forms.Label дата_созданияLabel;
            System.Windows.Forms.Label дата_закрытияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeListOfReqsCloseDateForm));
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.заявкаНаПоставкуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_закрытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShutDownEMPBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            дата_закрытияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаНаПоставкуBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(35, 82);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(124, 23);
            дата_созданияLabel.TabIndex = 1;
            дата_созданияLabel.Text = "Дата создания:";
            // 
            // дата_закрытияLabel
            // 
            дата_закрытияLabel.AutoSize = true;
            дата_закрытияLabel.Location = new System.Drawing.Point(32, 151);
            дата_закрытияLabel.Name = "дата_закрытияLabel";
            дата_закрытияLabel.Size = new System.Drawing.Size(127, 23);
            дата_закрытияLabel.TabIndex = 3;
            дата_закрытияLabel.Text = "Дата закрытия:";
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаНаПоставкуBindingSource, "Дата_создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(165, 78);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(236, 30);
            this.дата_созданияDateTimePicker.TabIndex = 2;
            // 
            // заявкаНаПоставкуBindingSource
            // 
            this.заявкаНаПоставкуBindingSource.DataSource = typeof(RemontV2.Models.ЗаявкаНаПоставку);
            // 
            // дата_закрытияDateTimePicker
            // 
            this.дата_закрытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаНаПоставкуBindingSource, "Дата_закрытия", true));
            this.дата_закрытияDateTimePicker.Location = new System.Drawing.Point(165, 147);
            this.дата_закрытияDateTimePicker.Name = "дата_закрытияDateTimePicker";
            this.дата_закрытияDateTimePicker.Size = new System.Drawing.Size(236, 30);
            this.дата_закрытияDateTimePicker.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 50);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.ShutDownEMPBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 50);
            this.panel2.TabIndex = 6;
            // 
            // ShutDownEMPBtn
            // 
            this.ShutDownEMPBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownEMPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownEMPBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownEMPBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownEMPBtn.Location = new System.Drawing.Point(507, 1);
            this.ShutDownEMPBtn.Name = "ShutDownEMPBtn";
            this.ShutDownEMPBtn.Size = new System.Drawing.Size(42, 48);
            this.ShutDownEMPBtn.TabIndex = 22;
            this.ShutDownEMPBtn.Text = "X";
            this.ShutDownEMPBtn.UseVisualStyleBackColor = true;
            this.ShutDownEMPBtn.Click += new System.EventHandler(this.ShutDownEMPBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование даты закрытия";
            // 
            // ChangeListOfReqsCloseDateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(550, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(дата_закрытияLabel);
            this.Controls.Add(this.дата_закрытияDateTimePicker);
            this.Controls.Add(дата_созданияLabel);
            this.Controls.Add(this.дата_созданияDateTimePicker);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeListOfReqsCloseDateForm";
            this.Text = "ChangeListOfReqsCloseDateForm";
            this.Load += new System.EventHandler(this.ChangeListOfReqsCloseDateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заявкаНаПоставкуBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource заявкаНаПоставкуBindingSource;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_закрытияDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShutDownEMPBtn;
    }
}