namespace myPiAPS
{
    partial class FormSumToday
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
            this.F_TodayList = new System.Windows.Forms.DataGridView();
            this.F_Summa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.F_TodayList)).BeginInit();
            this.SuspendLayout();
            // 
            // F_TodayList
            // 
            this.F_TodayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_TodayList.Location = new System.Drawing.Point(12, 12);
            this.F_TodayList.Name = "F_TodayList";
            this.F_TodayList.ReadOnly = true;
            this.F_TodayList.RowTemplate.Height = 28;
            this.F_TodayList.Size = new System.Drawing.Size(776, 380);
            this.F_TodayList.TabIndex = 0;
            // 
            // F_Summa
            // 
            this.F_Summa.Location = new System.Drawing.Point(620, 412);
            this.F_Summa.Name = "F_Summa";
            this.F_Summa.ReadOnly = true;
            this.F_Summa.Size = new System.Drawing.Size(168, 26);
            this.F_Summa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total for today";
            // 
            // FormSumToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Summa);
            this.Controls.Add(this.F_TodayList);
            this.Name = "FormSumToday";
            this.Text = "FormSumToday";
            this.Load += new System.EventHandler(this.FormSumToday_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.F_TodayList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_TodayList;
        private System.Windows.Forms.TextBox F_Summa;
        private System.Windows.Forms.Label label1;
    }
}