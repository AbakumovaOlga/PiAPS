namespace myPiAPS
{
    partial class FormUpdGood
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.F_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.F_Cancel = new System.Windows.Forms.Button();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_NewGroup = new System.Windows.Forms.TextBox();
            this.F_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(192, 174);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(305, 26);
            this.F_Number.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nomenclature number";
            // 
            // F_Price
            // 
            this.F_Price.Location = new System.Drawing.Point(192, 260);
            this.F_Price.Name = "F_Price";
            this.F_Price.Size = new System.Drawing.Size(305, 26);
            this.F_Price.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product group";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // F_Cancel
            // 
            this.F_Cancel.Location = new System.Drawing.Point(510, 314);
            this.F_Cancel.Name = "F_Cancel";
            this.F_Cancel.Size = new System.Drawing.Size(107, 52);
            this.F_Cancel.TabIndex = 28;
            this.F_Cancel.Text = "Cancel";
            this.F_Cancel.UseVisualStyleBackColor = true;
            this.F_Cancel.Click += new System.EventHandler(this.F_Cancel_Click);
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(192, 314);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(107, 52);
            this.F_Save.TabIndex = 27;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_NewGroup
            // 
            this.F_NewGroup.Location = new System.Drawing.Point(525, 45);
            this.F_NewGroup.Name = "F_NewGroup";
            this.F_NewGroup.Size = new System.Drawing.Size(243, 26);
            this.F_NewGroup.TabIndex = 29;
            // 
            // F_Add
            // 
            this.F_Add.Location = new System.Drawing.Point(646, 77);
            this.F_Add.Name = "F_Add";
            this.F_Add.Size = new System.Drawing.Size(75, 32);
            this.F_Add.TabIndex = 30;
            this.F_Add.Text = "Add";
            this.F_Add.UseVisualStyleBackColor = true;
            this.F_Add.Click += new System.EventHandler(this.F_Add_Click);
            // 
            // FormUpdGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Add);
            this.Controls.Add(this.F_NewGroup);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormUpdGood";
            this.Text = "FormUpdGood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button F_Cancel;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.TextBox F_NewGroup;
        private System.Windows.Forms.Button F_Add;
    }
}