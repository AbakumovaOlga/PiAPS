namespace myPiAPS
{
    partial class newShopHall
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
            this.F_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // F_OK
            // 
            this.F_OK.Location = new System.Drawing.Point(457, 256);
            this.F_OK.Name = "F_OK";
            this.F_OK.Size = new System.Drawing.Size(75, 23);
            this.F_OK.TabIndex = 0;
            this.F_OK.Text = "OK";
            this.F_OK.UseVisualStyleBackColor = true;
            this.F_OK.Click += new System.EventHandler(this.F_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(225, 97);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(100, 26);
            this.F_Name.TabIndex = 2;
            // 
            // newShopHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_OK);
            this.Name = "newShopHall";
            this.Text = "newShopHall";
            this.Load += new System.EventHandler(this.newShopHall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Name;
    }
}