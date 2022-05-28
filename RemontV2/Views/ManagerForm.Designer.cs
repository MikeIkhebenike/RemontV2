namespace RemontV2.Views
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuppRequestBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.WorksBtn = new System.Windows.Forms.Button();
            this.RequestsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewFormPanelLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.SuppRequestBtn);
            this.panel1.Controls.Add(this.SuppliersBtn);
            this.panel1.Controls.Add(this.WorksBtn);
            this.panel1.Controls.Add(this.RequestsBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.Navy;
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Image = global::RemontV2.Properties.Resources.logoutuser;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.Location = new System.Drawing.Point(0, 517);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(186, 60);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Выйти из учетной записи";
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.Leave += new System.EventHandler(this.ExitBtn_Leave);
            // 
            // SuppRequestBtn
            // 
            this.SuppRequestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuppRequestBtn.FlatAppearance.BorderSize = 0;
            this.SuppRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppRequestBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuppRequestBtn.Image = global::RemontV2.Properties.Resources.supplrequest;
            this.SuppRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuppRequestBtn.Location = new System.Drawing.Point(0, 333);
            this.SuppRequestBtn.Name = "SuppRequestBtn";
            this.SuppRequestBtn.Size = new System.Drawing.Size(186, 60);
            this.SuppRequestBtn.TabIndex = 1;
            this.SuppRequestBtn.Text = "Список заявок на поставку";
            this.SuppRequestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SuppRequestBtn.UseVisualStyleBackColor = true;
            this.SuppRequestBtn.Click += new System.EventHandler(this.SuppRequestBtn_Click);
            this.SuppRequestBtn.Leave += new System.EventHandler(this.SuppRequestBtn_Leave);
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuppliersBtn.FlatAppearance.BorderSize = 0;
            this.SuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuppliersBtn.Image = global::RemontV2.Properties.Resources.couriericon;
            this.SuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuppliersBtn.Location = new System.Drawing.Point(0, 273);
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(186, 60);
            this.SuppliersBtn.TabIndex = 1;
            this.SuppliersBtn.Text = "Список Поставщиков";
            this.SuppliersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SuppliersBtn.UseVisualStyleBackColor = true;
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            this.SuppliersBtn.Leave += new System.EventHandler(this.SuppliersBtn_Leave);
            // 
            // WorksBtn
            // 
            this.WorksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorksBtn.FlatAppearance.BorderSize = 0;
            this.WorksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorksBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorksBtn.Image = global::RemontV2.Properties.Resources.work;
            this.WorksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorksBtn.Location = new System.Drawing.Point(0, 213);
            this.WorksBtn.Name = "WorksBtn";
            this.WorksBtn.Size = new System.Drawing.Size(186, 60);
            this.WorksBtn.TabIndex = 1;
            this.WorksBtn.Text = "Список Работ";
            this.WorksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorksBtn.UseVisualStyleBackColor = true;
            this.WorksBtn.Click += new System.EventHandler(this.WorksBtn_Click);
            this.WorksBtn.Leave += new System.EventHandler(this.WorksBtn_Leave);
            // 
            // RequestsBtn
            // 
            this.RequestsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestsBtn.FlatAppearance.BorderSize = 0;
            this.RequestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RequestsBtn.Image = global::RemontV2.Properties.Resources.request;
            this.RequestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RequestsBtn.Location = new System.Drawing.Point(0, 153);
            this.RequestsBtn.Name = "RequestsBtn";
            this.RequestsBtn.Size = new System.Drawing.Size(186, 60);
            this.RequestsBtn.TabIndex = 1;
            this.RequestsBtn.Text = "Список Заявок";
            this.RequestsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RequestsBtn.UseVisualStyleBackColor = true;
            this.RequestsBtn.Click += new System.EventHandler(this.RequestsBtn_Click);
            this.RequestsBtn.Leave += new System.EventHandler(this.RequestsBtn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 153);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some User Text Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NewFormPanelLoader
            // 
            this.NewFormPanelLoader.AutoScroll = true;
            this.NewFormPanelLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewFormPanelLoader.Location = new System.Drawing.Point(186, 70);
            this.NewFormPanelLoader.Name = "NewFormPanelLoader";
            this.NewFormPanelLoader.Size = new System.Drawing.Size(833, 507);
            this.NewFormPanelLoader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(469, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Список сотрудников";
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownBtn.Location = new System.Drawing.Point(977, 0);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(42, 48);
            this.ShutDownBtn.TabIndex = 21;
            this.ShutDownBtn.Text = "X";
            this.ShutDownBtn.UseVisualStyleBackColor = true;
            this.ShutDownBtn.Click += new System.EventHandler(this.ShutDownBtn_Click_1);
            // 
            // ManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1019, 577);
            this.Controls.Add(this.ShutDownBtn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.NewFormPanelLoader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SuppRequestBtn;
        private System.Windows.Forms.Button SuppliersBtn;
        private System.Windows.Forms.Button WorksBtn;
        private System.Windows.Forms.Button RequestsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NewFormPanelLoader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button ShutDownBtn;
    }
}