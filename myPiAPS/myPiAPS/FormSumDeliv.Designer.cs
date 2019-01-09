namespace myPiAPS
{
    partial class FormSumDeliv
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
            this.F_GoodsSales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Sales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Summa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.F_GoodsSales)).BeginInit();
            this.SuspendLayout();
            // 
            // F_GoodsSales
            // 
            this.F_GoodsSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_GoodsSales.Location = new System.Drawing.Point(12, 63);
            this.F_GoodsSales.Name = "F_GoodsSales";
            this.F_GoodsSales.RowTemplate.Height = 28;
            this.F_GoodsSales.Size = new System.Drawing.Size(776, 375);
            this.F_GoodsSales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales invoice";
            // 
            // F_Sales
            // 
            this.F_Sales.FormattingEnabled = true;
            this.F_Sales.Location = new System.Drawing.Point(119, 15);
            this.F_Sales.Name = "F_Sales";
            this.F_Sales.Size = new System.Drawing.Size(270, 28);
            this.F_Sales.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(554, 12);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.Size = new System.Drawing.Size(234, 26);
            this.F_Summa.TabIndex = 3;
            // 
            // FormSumDeliv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.F_Sales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_GoodsSales);
            this.Name = "FormSumDeliv";
            this.Text = "FormSumDeliv";
            ((System.ComponentModel.ISupportInitialize)(this.F_GoodsSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_GoodsSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox F_Sales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox F_Summa;
    }
}