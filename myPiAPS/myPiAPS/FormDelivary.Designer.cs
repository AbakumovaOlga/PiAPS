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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F_Count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_Cancel = new System.Windows.Forms.Button();
            this.F_SavePrint = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(271, 136);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(305, 26);
            this.F_Number.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nomenclature number";
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(271, 288);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.Size = new System.Drawing.Size(305, 26);
            this.F_Summa.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Summa";
            // 
            // F_Count
            // 
            this.F_Count.Location = new System.Drawing.Point(271, 213);
            this.F_Count.Name = "F_Count";
            this.F_Count.Size = new System.Drawing.Size(305, 26);
            this.F_Count.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product group";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(173, 378);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(109, 34);
            this.F_Save.TabIndex = 27;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_Cancel
            // 
            this.F_Cancel.Location = new System.Drawing.Point(335, 378);
            this.F_Cancel.Name = "F_Cancel";
            this.F_Cancel.Size = new System.Drawing.Size(109, 34);
            this.F_Cancel.TabIndex = 28;
            this.F_Cancel.Text = "Cancel";
            this.F_Cancel.UseVisualStyleBackColor = true;
            this.F_Cancel.Click += new System.EventHandler(this.F_Cancel_Click);
            // 
            // F_SavePrint
            // 
            this.F_SavePrint.Location = new System.Drawing.Point(494, 378);
            this.F_SavePrint.Name = "F_SavePrint";
            this.F_SavePrint.Size = new System.Drawing.Size(142, 34);
            this.F_SavePrint.TabIndex = 29;
            this.F_SavePrint.Text = "Save and print";
            this.F_SavePrint.UseVisualStyleBackColor = true;
            this.F_SavePrint.Click += new System.EventHandler(this.F_SavePrint_Click);
            // 
            // FormDelivary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_SavePrint);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormDelivary";
            this.Text = "FormDelivary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.Button F_Cancel;
        private System.Windows.Forms.Button F_SavePrint;
    }
}