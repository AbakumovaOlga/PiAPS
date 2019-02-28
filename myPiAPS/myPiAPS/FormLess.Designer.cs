namespace myPiAPS
{
    partial class FormLess
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
            this.F_Products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Products
            // 
            this.F_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_Products.Location = new System.Drawing.Point(12, 12);
            this.F_Products.Name = "F_Products";
            this.F_Products.ReadOnly = true;
            this.F_Products.RowTemplate.Height = 28;
            this.F_Products.Size = new System.Drawing.Size(776, 426);
            this.F_Products.TabIndex = 0;
            // 
            // FormLess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Products);
            this.Name = "FormLess";
            this.Text = "FormLess";
            this.Load += new System.EventHandler(this.FormLess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView F_Products;
    }
}