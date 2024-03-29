﻿namespace RemontV2.Views
{
    partial class AccessoriesCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CostLbl = new System.Windows.Forms.Label();
            this.qtyStockLbl = new System.Windows.Forms.Label();
            this.supplierNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(211, 93);
            this.CostLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(145, 22);
            this.CostLbl.TabIndex = 8;
            this.CostLbl.Text = "Стоимость: 10";
            // 
            // qtyStockLbl
            // 
            this.qtyStockLbl.AutoSize = true;
            this.qtyStockLbl.Location = new System.Drawing.Point(211, 51);
            this.qtyStockLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qtyStockLbl.Name = "qtyStockLbl";
            this.qtyStockLbl.Size = new System.Drawing.Size(130, 22);
            this.qtyStockLbl.TabIndex = 6;
            this.qtyStockLbl.Text = "10 в наличии";
            // 
            // supplierNameLbl
            // 
            this.supplierNameLbl.AutoSize = true;
            this.supplierNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierNameLbl.Location = new System.Drawing.Point(210, 5);
            this.supplierNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supplierNameLbl.Name = "supplierNameLbl";
            this.supplierNameLbl.Size = new System.Drawing.Size(458, 22);
            this.supplierNameLbl.TabIndex = 5;
            this.supplierNameLbl.Text = "Поставщик | Наименование комплектующего";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RemontV2.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AccessoriesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.qtyStockLbl);
            this.Controls.Add(this.supplierNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AccessoriesCard";
            this.Size = new System.Drawing.Size(765, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label qtyStockLbl;
        private System.Windows.Forms.Label supplierNameLbl;
    }
}
