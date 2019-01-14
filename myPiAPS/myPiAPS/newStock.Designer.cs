namespace myPiAPS
{
    partial class newStock
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
            this.F_Name = new System.Windows.Forms.TextBox();
            this.F_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(255, 83);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(237, 26);
            this.F_Name.TabIndex = 1;
            // 
            // F_OK
            // 
            this.F_OK.Location = new System.Drawing.Point(577, 219);
            this.F_OK.Name = "F_OK";
            this.F_OK.Size = new System.Drawing.Size(75, 23);
            this.F_OK.TabIndex = 2;
            this.F_OK.Text = "OK";
            this.F_OK.UseVisualStyleBackColor = true;
            this.F_OK.Click += new System.EventHandler(this.F_OK_Click);
            // 
            // newStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_OK);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label1);
            this.Name = "newStock";
            this.Text = "newStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.Button F_OK;
    }
}