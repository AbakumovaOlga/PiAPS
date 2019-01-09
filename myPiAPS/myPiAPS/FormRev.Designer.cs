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
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.F_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Group = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Rev = new System.Windows.Forms.Button();
            this.F_RevGroup = new System.Windows.Forms.Button();
            this.F_Name = new System.Windows.Forms.ComboBox();
            this.F_Cancel = new System.Windows.Forms.Button();
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
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(185, 136);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(283, 26);
            this.F_Number.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nomenclature number";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product group";
            // 
            // F_Group
            // 
            this.F_Group.FormattingEnabled = true;
            this.F_Group.Location = new System.Drawing.Point(185, 93);
            this.F_Group.Name = "F_Group";
            this.F_Group.Size = new System.Drawing.Size(283, 28);
            this.F_Group.TabIndex = 15;
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
            // FormRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.F_RevGroup);
            this.Controls.Add(this.F_Rev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Group);
            this.Name = "FormRev";
            this.Text = "FormRev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox F_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_Rev;
        private System.Windows.Forms.Button F_RevGroup;
        private System.Windows.Forms.ComboBox F_Name;
        private System.Windows.Forms.Button F_Cancel;
    }
}