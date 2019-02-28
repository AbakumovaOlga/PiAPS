namespace myPiAPS
{
    partial class FormSumDeliv
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
            this.F_Delivs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.F_OK = new System.Windows.Forms.Button();
            this.F_Number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.F_Delivs)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Delivs
            // 
            this.F_Delivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_Delivs.Location = new System.Drawing.Point(12, 63);
            this.F_Delivs.Name = "F_Delivs";
            this.F_Delivs.ReadOnly = true;
            this.F_Delivs.RowTemplate.Height = 28;
            this.F_Delivs.Size = new System.Drawing.Size(776, 375);
            this.F_Delivs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер накладной";
            // 
            // F_OK
            // 
            this.F_OK.Location = new System.Drawing.Point(548, 16);
            this.F_OK.Name = "F_OK";
            this.F_OK.Size = new System.Drawing.Size(90, 35);
            this.F_OK.TabIndex = 2;
            this.F_OK.Text = "OK";
            this.F_OK.UseVisualStyleBackColor = true;
            this.F_OK.Click += new System.EventHandler(this.F_OK_Click);
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(155, 20);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(360, 26);
            this.F_Number.TabIndex = 3;
            // 
            // FormSumDeliv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.F_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Delivs);
            this.Name = "FormSumDeliv";
            this.Text = "FormSumDeliv";
            this.Load += new System.EventHandler(this.FormSumDeliv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_Delivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_Delivs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_OK;
        private System.Windows.Forms.TextBox F_Number;
    }
}