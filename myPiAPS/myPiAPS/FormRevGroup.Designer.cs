namespace myPiAPS
{
    partial class FormRevGroup
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
            this.F_ListProd = new System.Windows.Forms.DataGridView();
            this.F_Coeff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Group = new System.Windows.Forms.ComboBox();
            this.F_RevAll = new System.Windows.Forms.Button();
            this.F_Show = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_Calc = new System.Windows.Forms.Button();
            this.F_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F_ListProd)).BeginInit();
            this.SuspendLayout();
            // 
            // F_ListProd
            // 
            this.F_ListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_ListProd.Location = new System.Drawing.Point(12, 12);
            this.F_ListProd.Name = "F_ListProd";
            this.F_ListProd.ReadOnly = true;
            this.F_ListProd.RowTemplate.Height = 28;
            this.F_ListProd.Size = new System.Drawing.Size(776, 307);
            this.F_ListProd.TabIndex = 0;
            // 
            // F_Coeff
            // 
            this.F_Coeff.Location = new System.Drawing.Point(139, 404);
            this.F_Coeff.Name = "F_Coeff";
            this.F_Coeff.Size = new System.Drawing.Size(185, 26);
            this.F_Coeff.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coeff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product group";
            // 
            // F_Group
            // 
            this.F_Group.FormattingEnabled = true;
            this.F_Group.Location = new System.Drawing.Point(139, 352);
            this.F_Group.Name = "F_Group";
            this.F_Group.Size = new System.Drawing.Size(305, 28);
            this.F_Group.TabIndex = 5;
            // 
            // F_RevAll
            // 
            this.F_RevAll.Location = new System.Drawing.Point(640, 355);
            this.F_RevAll.Name = "F_RevAll";
            this.F_RevAll.Size = new System.Drawing.Size(136, 50);
            this.F_RevAll.TabIndex = 30;
            this.F_RevAll.Text = "Revaluation all";
            this.F_RevAll.UseVisualStyleBackColor = true;
            this.F_RevAll.Click += new System.EventHandler(this.F_RevAll_Click);
            // 
            // F_Show
            // 
            this.F_Show.Location = new System.Drawing.Point(477, 382);
            this.F_Show.Name = "F_Show";
            this.F_Show.Size = new System.Drawing.Size(75, 23);
            this.F_Show.TabIndex = 31;
            this.F_Show.Text = "Show";
            this.F_Show.UseVisualStyleBackColor = true;
            this.F_Show.Click += new System.EventHandler(this.F_Show_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Date";
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(139, 452);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 45;
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(139, 504);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.ReadOnly = true;
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Summa";
            // 
            // F_Calc
            // 
            this.F_Calc.Location = new System.Drawing.Point(477, 495);
            this.F_Calc.Name = "F_Calc";
            this.F_Calc.Size = new System.Drawing.Size(93, 35);
            this.F_Calc.TabIndex = 52;
            this.F_Calc.Text = "Рассчитать";
            this.F_Calc.UseVisualStyleBackColor = true;
            this.F_Calc.Click += new System.EventHandler(this.F_Calc_Click);
            // 
            // F_Print
            // 
            this.F_Print.Location = new System.Drawing.Point(640, 476);
            this.F_Print.Name = "F_Print";
            this.F_Print.Size = new System.Drawing.Size(109, 54);
            this.F_Print.TabIndex = 53;
            this.F_Print.Text = "Print doc";
            this.F_Print.UseVisualStyleBackColor = true;
            this.F_Print.Click += new System.EventHandler(this.F_Print_Click);
            // 
            // FormRevGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.F_Print);
            this.Controls.Add(this.F_Calc);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.F_Show);
            this.Controls.Add(this.F_RevAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Coeff);
            this.Controls.Add(this.F_ListProd);
            this.Name = "FormRevGroup";
            this.Text = "FormRevGroup";
            this.Load += new System.EventHandler(this.FormRevGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_ListProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_ListProd;
        private System.Windows.Forms.TextBox F_Coeff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox F_Group;
        private System.Windows.Forms.Button F_RevAll;
        private System.Windows.Forms.Button F_Show;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button F_Calc;
        private System.Windows.Forms.Button F_Print;
    }
}