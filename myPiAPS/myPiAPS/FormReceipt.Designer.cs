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
            this.F_Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.F_Count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.F_Add = new System.Windows.Forms.Button();
            this.F_NewGroup = new System.Windows.Forms.TextBox();
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
            // F_Cancel
            // 
            this.F_Cancel.Location = new System.Drawing.Point(537, 367);
            this.F_Cancel.Name = "F_Cancel";
            this.F_Cancel.Size = new System.Drawing.Size(107, 52);
            this.F_Cancel.TabIndex = 2;
            this.F_Cancel.Text = "Cancel";
            this.F_Cancel.UseVisualStyleBackColor = true;
            this.F_Cancel.Click += new System.EventHandler(this.F_Cancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // F_Price
            // 
            this.F_Price.Location = new System.Drawing.Point(204, 248);
            this.F_Price.Name = "F_Price";
            this.F_Price.Size = new System.Drawing.Size(305, 26);
            this.F_Price.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // F_Count
            // 
            this.F_Count.Location = new System.Drawing.Point(204, 211);
            this.F_Count.Name = "F_Count";
            this.F_Count.Size = new System.Drawing.Size(305, 26);
            this.F_Count.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summa";
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(204, 286);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nomenclature number";
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(204, 134);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(305, 26);
            this.F_Number.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 26);
            this.textBox1.TabIndex = 14;
            // 
            // F_Add
            // 
            this.F_Add.Location = new System.Drawing.Point(705, 123);
            this.F_Add.Name = "F_Add";
            this.F_Add.Size = new System.Drawing.Size(75, 32);
            this.F_Add.TabIndex = 32;
            this.F_Add.Text = "Add";
            this.F_Add.UseVisualStyleBackColor = true;
            this.F_Add.Click += new System.EventHandler(this.F_Add_Click);
            // 
            // F_NewGroup
            // 
            this.F_NewGroup.Location = new System.Drawing.Point(537, 91);
            this.F_NewGroup.Name = "F_NewGroup";
            this.F_NewGroup.Size = new System.Drawing.Size(243, 26);
            this.F_NewGroup.TabIndex = 31;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Add);
            this.Controls.Add(this.F_NewGroup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.F_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.label1);
            this.Name = "FormReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.Button F_Cancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox F_Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button F_Add;
        private System.Windows.Forms.TextBox F_NewGroup;
    }
}