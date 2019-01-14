namespace myPiAPS
{
    partial class newProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.F_Price = new System.Windows.Forms.TextBox();
            this.F_Group = new System.Windows.Forms.ComboBox();
            this.F_OK = new System.Windows.Forms.Button();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group";
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(546, 50);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(100, 26);
            this.F_Name.TabIndex = 7;
            // 
            // F_Price
            // 
            this.F_Price.Location = new System.Drawing.Point(546, 129);
            this.F_Price.Name = "F_Price";
            this.F_Price.Size = new System.Drawing.Size(158, 26);
            this.F_Price.TabIndex = 8;
            // 
            // F_Group
            // 
            this.F_Group.FormattingEnabled = true;
            this.F_Group.Location = new System.Drawing.Point(546, 195);
            this.F_Group.Name = "F_Group";
            this.F_Group.Size = new System.Drawing.Size(121, 28);
            this.F_Group.TabIndex = 9;
            // 
            // F_OK
            // 
            this.F_OK.Location = new System.Drawing.Point(571, 311);
            this.F_OK.Name = "F_OK";
            this.F_OK.Size = new System.Drawing.Size(107, 36);
            this.F_OK.TabIndex = 10;
            this.F_OK.Text = "OK";
            this.F_OK.UseVisualStyleBackColor = true;
            this.F_OK.Click += new System.EventHandler(this.F_OK_Click);
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(546, 249);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(158, 26);
            this.F_Number.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number";
            // 
            // newProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.F_OK);
            this.Controls.Add(this.F_Group);
            this.Controls.Add(this.F_Price);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "newProduct";
            this.Text = "newProduct";
            this.Load += new System.EventHandler(this.newProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.ComboBox F_Group;
        private System.Windows.Forms.Button F_OK;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label1;
    }
}