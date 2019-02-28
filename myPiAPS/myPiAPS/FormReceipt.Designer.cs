namespace myPiAPS
{
    partial class FormReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.F_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.F_Stock = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.F_Products = new System.Windows.Forms.DataGridView();
            this.FCakeDel = new System.Windows.Forms.Button();
            this.F_AddProd = new System.Windows.Forms.Button();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.F_Print = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод данных приходной накладной";
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(219, 367);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(107, 52);
            this.F_Save.TabIndex = 1;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summa";
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(204, 143);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.ReadOnly = true;
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Stock";
            // 
            // F_Stock
            // 
            this.F_Stock.FormattingEnabled = true;
            this.F_Stock.Location = new System.Drawing.Point(204, 181);
            this.F_Stock.Name = "F_Stock";
            this.F_Stock.Size = new System.Drawing.Size(305, 28);
            this.F_Stock.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F_Products);
            this.groupBox1.Controls.Add(this.FCakeDel);
            this.groupBox1.Controls.Add(this.F_AddProd);
            this.groupBox1.Location = new System.Drawing.Point(786, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 414);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // F_Products
            // 
            this.F_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_Products.Location = new System.Drawing.Point(21, 36);
            this.F_Products.Name = "F_Products";
            this.F_Products.ReadOnly = true;
            this.F_Products.RowTemplate.Height = 28;
            this.F_Products.Size = new System.Drawing.Size(527, 342);
            this.F_Products.TabIndex = 8;
            // 
            // FCakeDel
            // 
            this.FCakeDel.Location = new System.Drawing.Point(570, 113);
            this.FCakeDel.Name = "FCakeDel";
            this.FCakeDel.Size = new System.Drawing.Size(90, 38);
            this.FCakeDel.TabIndex = 6;
            this.FCakeDel.Text = "Delete";
            this.FCakeDel.UseVisualStyleBackColor = true;
            this.FCakeDel.Click += new System.EventHandler(this.FCakeDel_Click);
            // 
            // F_AddProd
            // 
            this.F_AddProd.Location = new System.Drawing.Point(570, 25);
            this.F_AddProd.Name = "F_AddProd";
            this.F_AddProd.Size = new System.Drawing.Size(90, 38);
            this.F_AddProd.TabIndex = 4;
            this.F_AddProd.Text = "Add";
            this.F_AddProd.UseVisualStyleBackColor = true;
            this.F_AddProd.Click += new System.EventHandler(this.F_AddProd_Click);
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(204, 99);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Date";
            // 
            // F_Print
            // 
            this.F_Print.Location = new System.Drawing.Point(421, 367);
            this.F_Print.Name = "F_Print";
            this.F_Print.Size = new System.Drawing.Size(109, 54);
            this.F_Print.TabIndex = 38;
            this.F_Print.Text = "Print doc";
            this.F_Print.UseVisualStyleBackColor = true;
            this.F_Print.Click += new System.EventHandler(this.F_Print_Click);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 476);
            this.Controls.Add(this.F_Print);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.F_Stock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.label1);
            this.Name = "FormReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox F_Stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView F_Products;
        private System.Windows.Forms.Button FCakeDel;
        private System.Windows.Forms.Button F_AddProd;
        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button F_Print;
    }
}