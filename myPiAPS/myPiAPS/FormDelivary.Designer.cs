namespace myPiAPS
{
    partial class FormDelivary
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
            this.label9 = new System.Windows.Forms.Label();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.F_Products = new System.Windows.Forms.DataGridView();
            this.FCakeDel = new System.Windows.Forms.Button();
            this.F_AddProd = new System.Windows.Forms.Button();
            this.F_Stock = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_ShopHall = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.F_Print = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод данных о расходе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Date";
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(123, 118);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F_Products);
            this.groupBox1.Controls.Add(this.FCakeDel);
            this.groupBox1.Controls.Add(this.F_AddProd);
            this.groupBox1.Location = new System.Drawing.Point(705, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 414);
            this.groupBox1.TabIndex = 61;
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
            // F_Stock
            // 
            this.F_Stock.FormattingEnabled = true;
            this.F_Stock.Location = new System.Drawing.Point(123, 156);
            this.F_Stock.Name = "F_Stock";
            this.F_Stock.Size = new System.Drawing.Size(305, 28);
            this.F_Stock.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Stock";
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(123, 248);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.ReadOnly = true;
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Summa";
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(138, 386);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(107, 52);
            this.F_Save.TabIndex = 55;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click_1);
            // 
            // F_ShopHall
            // 
            this.F_ShopHall.FormattingEnabled = true;
            this.F_ShopHall.Location = new System.Drawing.Point(123, 200);
            this.F_ShopHall.Name = "F_ShopHall";
            this.F_ShopHall.Size = new System.Drawing.Size(305, 28);
            this.F_ShopHall.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "ShopHall";
            // 
            // F_Print
            // 
            this.F_Print.Location = new System.Drawing.Point(387, 384);
            this.F_Print.Name = "F_Print";
            this.F_Print.Size = new System.Drawing.Size(109, 54);
            this.F_Print.TabIndex = 68;
            this.F_Print.Text = "Print doc";
            this.F_Print.UseVisualStyleBackColor = true;
            this.F_Print.Click += new System.EventHandler(this.F_Print_Click);
            // 
            // FormDelivary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 525);
            this.Controls.Add(this.F_Print);
            this.Controls.Add(this.F_ShopHall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.F_Stock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.label1);
            this.Name = "FormDelivary";
            this.Text = "FormDelivary";
            this.Load += new System.EventHandler(this.FormDelivary_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView F_Products;
        private System.Windows.Forms.Button FCakeDel;
        private System.Windows.Forms.Button F_AddProd;
        private System.Windows.Forms.ComboBox F_Stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.ComboBox F_ShopHall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button F_Print;
    }
}