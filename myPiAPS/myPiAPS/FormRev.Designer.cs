namespace myPiAPS
{
    partial class FormRev
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
            this.label7 = new System.Windows.Forms.Label();
            this.F_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Rev = new System.Windows.Forms.Button();
            this.F_RevGroup = new System.Windows.Forms.Button();
            this.F_Name = new System.Windows.Forms.ComboBox();
            this.F_Cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Calc = new System.Windows.Forms.Button();
            this.F_Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // F_Price
            // 
            this.F_Price.Location = new System.Drawing.Point(185, 222);
            this.F_Price.Name = "F_Price";
            this.F_Price.Size = new System.Drawing.Size(283, 26);
            this.F_Price.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Переоценка товаров";
            // 
            // F_Rev
            // 
            this.F_Rev.Location = new System.Drawing.Point(158, 342);
            this.F_Rev.Name = "F_Rev";
            this.F_Rev.Size = new System.Drawing.Size(117, 36);
            this.F_Rev.TabIndex = 28;
            this.F_Rev.Text = "Revaluation";
            this.F_Rev.UseVisualStyleBackColor = true;
            this.F_Rev.Click += new System.EventHandler(this.F_Rev_Click);
            // 
            // F_RevGroup
            // 
            this.F_RevGroup.Location = new System.Drawing.Point(632, 150);
            this.F_RevGroup.Name = "F_RevGroup";
            this.F_RevGroup.Size = new System.Drawing.Size(136, 58);
            this.F_RevGroup.TabIndex = 29;
            this.F_RevGroup.Text = "Revaluation group";
            this.F_RevGroup.UseVisualStyleBackColor = true;
            this.F_RevGroup.Click += new System.EventHandler(this.F_RevGroup_Click);
            // 
            // F_Name
            // 
            this.F_Name.FormattingEnabled = true;
            this.F_Name.Location = new System.Drawing.Point(185, 180);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(283, 28);
            this.F_Name.TabIndex = 30;
            // 
            // F_Cancel
            // 
            this.F_Cancel.Location = new System.Drawing.Point(359, 344);
            this.F_Cancel.Name = "F_Cancel";
            this.F_Cancel.Size = new System.Drawing.Size(109, 34);
            this.F_Cancel.TabIndex = 42;
            this.F_Cancel.Text = "Cancel";
            this.F_Cancel.UseVisualStyleBackColor = true;
            this.F_Cancel.Click += new System.EventHandler(this.F_Cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Date";
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(204, 88);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 43;
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(185, 270);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.ReadOnly = true;
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Summa";
            // 
            // F_Calc
            // 
            this.F_Calc.Location = new System.Drawing.Point(512, 234);
            this.F_Calc.Name = "F_Calc";
            this.F_Calc.Size = new System.Drawing.Size(93, 35);
            this.F_Calc.TabIndex = 50;
            this.F_Calc.Text = "Рассчитать";
            this.F_Calc.UseVisualStyleBackColor = true;
            this.F_Calc.Click += new System.EventHandler(this.F_Calc_Click);
            // 
            // F_Print
            // 
            this.F_Print.Location = new System.Drawing.Point(559, 334);
            this.F_Print.Name = "F_Print";
            this.F_Print.Size = new System.Drawing.Size(109, 54);
            this.F_Print.TabIndex = 51;
            this.F_Print.Text = "Print doc";
            this.F_Print.UseVisualStyleBackColor = true;
            this.F_Print.Click += new System.EventHandler(this.F_Print_Click);
            // 
            // FormRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Print);
            this.Controls.Add(this.F_Calc);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.F_RevGroup);
            this.Controls.Add(this.F_Rev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F_Price);
            this.Controls.Add(this.label3);
            this.Name = "FormRev";
            this.Text = "FormRev";
            this.Load += new System.EventHandler(this.FormRev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_Rev;
        private System.Windows.Forms.Button F_RevGroup;
        private System.Windows.Forms.ComboBox F_Name;
        private System.Windows.Forms.Button F_Cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button F_Calc;
        private System.Windows.Forms.Button F_Print;
    }
}