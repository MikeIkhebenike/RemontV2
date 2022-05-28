namespace RemontV2
{
    partial class AuthFRM
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthFRM));
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButExit = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.SystemColors.Control;
            this.labelRole.ForeColor = System.Drawing.Color.Red;
            this.labelRole.Location = new System.Drawing.Point(117, 255);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 26);
            this.labelRole.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.Control;
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(117, 190);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 26);
            this.labelPassword.TabIndex = 25;
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.labelLogIn.ForeColor = System.Drawing.Color.Red;
            this.labelLogIn.Location = new System.Drawing.Point(117, 120);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(0, 26);
            this.labelLogIn.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ShutDownBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 88);
            this.panel1.TabIndex = 22;
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.FlatAppearance.BorderSize = 0;
            this.ShutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownBtn.ForeColor = System.Drawing.Color.Red;
            this.ShutDownBtn.Location = new System.Drawing.Point(435, 1);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(42, 48);
            this.ShutDownBtn.TabIndex = 21;
            this.ShutDownBtn.Text = "X";
            this.ShutDownBtn.UseVisualStyleBackColor = true;
            this.ShutDownBtn.Click += new System.EventHandler(this.ShutDownBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RemontV2.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(13, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(196, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Авторизация";
            // 
            // ButExit
            // 
            this.ButExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButExit.FlatAppearance.BorderSize = 0;
            this.ButExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButExit.ForeColor = System.Drawing.Color.White;
            this.ButExit.Location = new System.Drawing.Point(278, 293);
            this.ButExit.Margin = new System.Windows.Forms.Padding(6);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(127, 47);
            this.ButExit.TabIndex = 20;
            this.ButExit.Text = "Закрыть";
            this.ButExit.UseVisualStyleBackColor = false;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(49, 293);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(6);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(127, 47);
            this.LoginBtn.TabIndex = 21;
            this.LoginBtn.Text = " Войти";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(113, 151);
            this.LoginTxt.Margin = new System.Windows.Forms.Padding(6);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(292, 34);
            this.LoginTxt.TabIndex = 18;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(113, 216);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(6);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(292, 34);
            this.PassTxt.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин:";
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Image = global::RemontV2.Properties.Resources.hide;
            this.pictureBoxEye.Location = new System.Drawing.Point(417, 209);
            this.pictureBoxEye.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(50, 44);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 23;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBoxEye_Click);
            // 
            // AuthFRM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(480, 363);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AuthFRM";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShutDownBtn;
    }
}

