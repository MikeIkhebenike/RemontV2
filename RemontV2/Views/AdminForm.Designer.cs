﻿namespace RemontV2.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuppRequestBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.WorksBtn = new System.Windows.Forms.Button();
            this.AccessoriesBtn = new System.Windows.Forms.Button();
            this.RequestsBtn = new System.Windows.Forms.Button();
            this.EmployeeListBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFormLoad = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.AccessoriesBtn);
            this.panel1.Controls.Add(this.RequestsBtn);
            this.panel1.Controls.Add(this.EmployeeListBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
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
            this.SuppRequestBtn.Location = new System.Drawing.Point(0, 453);
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
            this.SuppliersBtn.Location = new System.Drawing.Point(0, 393);
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
            this.WorksBtn.Location = new System.Drawing.Point(0, 333);
            this.WorksBtn.Name = "WorksBtn";
            this.WorksBtn.Size = new System.Drawing.Size(186, 60);
            this.WorksBtn.TabIndex = 1;
            this.WorksBtn.Text = "Список Работ";
            this.WorksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorksBtn.UseVisualStyleBackColor = true;
            this.WorksBtn.Click += new System.EventHandler(this.WorksBtn_Click);
            this.WorksBtn.Leave += new System.EventHandler(this.WorksBtn_Leave);
            // 
            // AccessoriesBtn
            // 
            this.AccessoriesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccessoriesBtn.FlatAppearance.BorderSize = 0;
            this.AccessoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessoriesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessoriesBtn.Image = global::RemontV2.Properties.Resources.accessories;
            this.AccessoriesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccessoriesBtn.Location = new System.Drawing.Point(0, 273);
            this.AccessoriesBtn.Name = "AccessoriesBtn";
            this.AccessoriesBtn.Size = new System.Drawing.Size(186, 60);
            this.AccessoriesBtn.TabIndex = 1;
            this.AccessoriesBtn.Text = "Список Комплектующих";
            this.AccessoriesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AccessoriesBtn.UseVisualStyleBackColor = true;
            this.AccessoriesBtn.Click += new System.EventHandler(this.AccessoriesBtn_Click);
            this.AccessoriesBtn.Leave += new System.EventHandler(this.AccessoriesBtn_Leave);
            // 
            // RequestsBtn
            // 
            this.RequestsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestsBtn.FlatAppearance.BorderSize = 0;
            this.RequestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsBtn.Image = global::RemontV2.Properties.Resources.request;
            this.RequestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RequestsBtn.Location = new System.Drawing.Point(0, 213);
            this.RequestsBtn.Name = "RequestsBtn";
            this.RequestsBtn.Size = new System.Drawing.Size(186, 60);
            this.RequestsBtn.TabIndex = 1;
            this.RequestsBtn.Text = "Список Заявок";
            this.RequestsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RequestsBtn.UseVisualStyleBackColor = true;
            this.RequestsBtn.Click += new System.EventHandler(this.RequestsBtn_Click);
            this.RequestsBtn.Leave += new System.EventHandler(this.RequestsBtn_Leave);
            // 
            // EmployeeListBtn
            // 
            this.EmployeeListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeListBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeListBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeListBtn.Image = global::RemontV2.Properties.Resources.employe;
            this.EmployeeListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeListBtn.Location = new System.Drawing.Point(0, 153);
            this.EmployeeListBtn.Name = "EmployeeListBtn";
            this.EmployeeListBtn.Size = new System.Drawing.Size(186, 60);
            this.EmployeeListBtn.TabIndex = 1;
            this.EmployeeListBtn.Text = "Список Сотрудников";
            this.EmployeeListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EmployeeListBtn.UseVisualStyleBackColor = true;
            this.EmployeeListBtn.Click += new System.EventHandler(this.EmployeeListBtn_Click);
            this.EmployeeListBtn.Leave += new System.EventHandler(this.EmployeeListBtn_Leave);
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
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(232, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Список сотрудников";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(914, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PnlFormLoad
            // 
            this.PnlFormLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoad.Location = new System.Drawing.Point(186, 88);
            this.PnlFormLoad.Name = "PnlFormLoad";
            this.PnlFormLoad.Size = new System.Drawing.Size(765, 489);
            this.PnlFormLoad.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlFormLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EmployeeListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AccessoriesBtn;
        private System.Windows.Forms.Button RequestsBtn;
        private System.Windows.Forms.Button SuppRequestBtn;
        private System.Windows.Forms.Button SuppliersBtn;
        private System.Windows.Forms.Button WorksBtn;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlFormLoad;
    }
}