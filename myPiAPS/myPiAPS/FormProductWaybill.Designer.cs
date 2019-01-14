namespace myPiAPS
{
    partial class FormProductWaybill
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
            this.F_Product = new System.Windows.Forms.ComboBox();
            this.F_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // F_Product
            // 
            this.F_Product.FormattingEnabled = true;
            this.F_Product.Location = new System.Drawing.Point(160, 22);
            this.F_Product.Name = "F_Product";
            this.F_Product.Size = new System.Drawing.Size(329, 28);
            this.F_Product.TabIndex = 12;
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(260, 117);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(102, 30);
            this.F_Save.TabIndex = 10;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product";
            // 
            // F_Count
            // 
            this.F_Count.Location = new System.Drawing.Point(160, 70);
            this.F_Count.Name = "F_Count";
            this.F_Count.Size = new System.Drawing.Size(330, 26);
            this.F_Count.TabIndex = 7;
            // 
            // FormProductWaybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 182);
            this.Controls.Add(this.F_Product);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Count);
            this.Name = "FormProductWaybill";
            this.Text = "FormProductWaybill";
            this.Load += new System.EventHandler(this.FormProductWaybillBM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox F_Product;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Count;
    }
}