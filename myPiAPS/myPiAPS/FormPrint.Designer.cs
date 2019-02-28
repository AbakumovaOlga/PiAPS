namespace myPiAPS
{
    partial class FormPrint
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
            this.F_DocList = new System.Windows.Forms.DataGridView();
            this.F_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Find = new System.Windows.Forms.Button();
            this.F_Sort = new System.Windows.Forms.Button();
            this.F_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F_DocList)).BeginInit();
            this.SuspendLayout();
            // 
            // F_DocList
            // 
            this.F_DocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_DocList.Location = new System.Drawing.Point(12, 69);
            this.F_DocList.Name = "F_DocList";
            this.F_DocList.ReadOnly = true;
            this.F_DocList.RowTemplate.Height = 28;
            this.F_DocList.Size = new System.Drawing.Size(878, 369);
            this.F_DocList.TabIndex = 0;
            this.F_DocList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.F_DocList_RowHeaderMouseDoubleClick);
            // 
            // F_Type
            // 
            this.F_Type.FormattingEnabled = true;
            this.F_Type.Location = new System.Drawing.Point(106, 17);
            this.F_Type.Name = "F_Type";
            this.F_Type.Size = new System.Drawing.Size(263, 28);
            this.F_Type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kind of doc";
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(524, 16);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(185, 26);
            this.F_Number.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // F_Find
            // 
            this.F_Find.Location = new System.Drawing.Point(715, 12);
            this.F_Find.Name = "F_Find";
            this.F_Find.Size = new System.Drawing.Size(75, 36);
            this.F_Find.TabIndex = 5;
            this.F_Find.Text = "Find";
            this.F_Find.UseVisualStyleBackColor = true;
            this.F_Find.Click += new System.EventHandler(this.F_Find_Click);
            // 
            // F_Sort
            // 
            this.F_Sort.Location = new System.Drawing.Point(375, 15);
            this.F_Sort.Name = "F_Sort";
            this.F_Sort.Size = new System.Drawing.Size(61, 34);
            this.F_Sort.TabIndex = 6;
            this.F_Sort.Text = "OK";
            this.F_Sort.UseVisualStyleBackColor = true;
            this.F_Sort.Click += new System.EventHandler(this.F_Sort_Click);
            // 
            // F_All
            // 
            this.F_All.Location = new System.Drawing.Point(837, 20);
            this.F_All.Name = "F_All";
            this.F_All.Size = new System.Drawing.Size(30, 22);
            this.F_All.TabIndex = 7;
            this.F_All.Text = "-";
            this.F_All.UseVisualStyleBackColor = true;
            this.F_All.Click += new System.EventHandler(this.F_All_Click);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.F_All);
            this.Controls.Add(this.F_Sort);
            this.Controls.Add(this.F_Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Type);
            this.Controls.Add(this.F_DocList);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_DocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_DocList;
        private System.Windows.Forms.ComboBox F_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button F_Find;
        private System.Windows.Forms.Button F_Sort;
        private System.Windows.Forms.Button F_All;
    }
}