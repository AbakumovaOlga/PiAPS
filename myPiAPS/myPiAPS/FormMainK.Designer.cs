namespace myPiAPS
{
    partial class FormMainK
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
            this.F_Receipt = new System.Windows.Forms.Button();
            this.F_Delivary = new System.Windows.Forms.Button();
            this.F_GoodsList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.F_Number = new System.Windows.Forms.TextBox();
            this.F_Find = new System.Windows.Forms.Button();
            this.F_Less = new System.Windows.Forms.Button();
            this.F_Write = new System.Windows.Forms.Button();
            this.F_Rev = new System.Windows.Forms.Button();
            this.F_Archive = new System.Windows.Forms.Button();
            this.F_Sum = new System.Windows.Forms.Button();
            this.F_SumDeliv = new System.Windows.Forms.Button();
            this.F_Diagram = new System.Windows.Forms.Button();
            this.F_ChooseGrop = new System.Windows.Forms.ComboBox();
            this.F_Print = new System.Windows.Forms.Button();
            this.F_Load = new System.Windows.Forms.Button();
            this.F_GropFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F_GoodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Receipt
            // 
            this.F_Receipt.Location = new System.Drawing.Point(12, 379);
            this.F_Receipt.Name = "F_Receipt";
            this.F_Receipt.Size = new System.Drawing.Size(113, 59);
            this.F_Receipt.TabIndex = 0;
            this.F_Receipt.Text = "Receipt of goods";
            this.F_Receipt.UseVisualStyleBackColor = true;
            this.F_Receipt.Click += new System.EventHandler(this.F_Receipt_Click);
            // 
            // F_Delivary
            // 
            this.F_Delivary.Location = new System.Drawing.Point(131, 379);
            this.F_Delivary.Name = "F_Delivary";
            this.F_Delivary.Size = new System.Drawing.Size(113, 59);
            this.F_Delivary.TabIndex = 1;
            this.F_Delivary.Text = "Delivary of goods";
            this.F_Delivary.UseVisualStyleBackColor = true;
            this.F_Delivary.Click += new System.EventHandler(this.F_Delivary_Click);
            // 
            // F_GoodsList
            // 
            this.F_GoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_GoodsList.Location = new System.Drawing.Point(12, 58);
            this.F_GoodsList.Name = "F_GoodsList";
            this.F_GoodsList.ReadOnly = true;
            this.F_GoodsList.RowTemplate.Height = 28;
            this.F_GoodsList.Size = new System.Drawing.Size(776, 315);
            this.F_GoodsList.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nomenclature number";
            // 
            // F_Number
            // 
            this.F_Number.Location = new System.Drawing.Point(215, 19);
            this.F_Number.Name = "F_Number";
            this.F_Number.Size = new System.Drawing.Size(305, 26);
            this.F_Number.TabIndex = 13;
            // 
            // F_Find
            // 
            this.F_Find.Location = new System.Drawing.Point(526, 17);
            this.F_Find.Name = "F_Find";
            this.F_Find.Size = new System.Drawing.Size(77, 30);
            this.F_Find.TabIndex = 14;
            this.F_Find.Text = "Find";
            this.F_Find.UseVisualStyleBackColor = true;
            this.F_Find.Click += new System.EventHandler(this.F_Find_Click);
            // 
            // F_Less
            // 
            this.F_Less.Location = new System.Drawing.Point(672, 379);
            this.F_Less.Name = "F_Less";
            this.F_Less.Size = new System.Drawing.Size(116, 59);
            this.F_Less.TabIndex = 15;
            this.F_Less.Text = "Less than the norm";
            this.F_Less.UseVisualStyleBackColor = true;
            this.F_Less.Click += new System.EventHandler(this.F_Less_Click);
            // 
            // F_Write
            // 
            this.F_Write.Location = new System.Drawing.Point(250, 379);
            this.F_Write.Name = "F_Write";
            this.F_Write.Size = new System.Drawing.Size(113, 59);
            this.F_Write.TabIndex = 16;
            this.F_Write.Text = "Write-off of goods";
            this.F_Write.UseVisualStyleBackColor = true;
            this.F_Write.Click += new System.EventHandler(this.F_Write_Click);
            // 
            // F_Rev
            // 
            this.F_Rev.Location = new System.Drawing.Point(369, 379);
            this.F_Rev.Name = "F_Rev";
            this.F_Rev.Size = new System.Drawing.Size(113, 59);
            this.F_Rev.TabIndex = 17;
            this.F_Rev.Text = "Revaluation of goods";
            this.F_Rev.UseVisualStyleBackColor = true;
            this.F_Rev.Click += new System.EventHandler(this.F_Rev_Click);
            // 
            // F_Archive
            // 
            this.F_Archive.Location = new System.Drawing.Point(553, 379);
            this.F_Archive.Name = "F_Archive";
            this.F_Archive.Size = new System.Drawing.Size(113, 59);
            this.F_Archive.TabIndex = 18;
            this.F_Archive.Text = "Archive";
            this.F_Archive.UseVisualStyleBackColor = true;
            this.F_Archive.Click += new System.EventHandler(this.F_Archive_Click);
            // 
            // F_Sum
            // 
            this.F_Sum.Location = new System.Drawing.Point(861, 58);
            this.F_Sum.Name = "F_Sum";
            this.F_Sum.Size = new System.Drawing.Size(109, 54);
            this.F_Sum.TabIndex = 19;
            this.F_Sum.Text = "Summa today";
            this.F_Sum.UseVisualStyleBackColor = true;
            this.F_Sum.Click += new System.EventHandler(this.F_Sum_Click);
            // 
            // F_SumDeliv
            // 
            this.F_SumDeliv.Location = new System.Drawing.Point(861, 144);
            this.F_SumDeliv.Name = "F_SumDeliv";
            this.F_SumDeliv.Size = new System.Drawing.Size(109, 54);
            this.F_SumDeliv.TabIndex = 20;
            this.F_SumDeliv.Text = "Summa of dlivary";
            this.F_SumDeliv.UseVisualStyleBackColor = true;
            this.F_SumDeliv.Click += new System.EventHandler(this.F_SumDeliv_Click);
            // 
            // F_Diagram
            // 
            this.F_Diagram.Location = new System.Drawing.Point(861, 227);
            this.F_Diagram.Name = "F_Diagram";
            this.F_Diagram.Size = new System.Drawing.Size(109, 54);
            this.F_Diagram.TabIndex = 21;
            this.F_Diagram.Text = "Diagram";
            this.F_Diagram.UseVisualStyleBackColor = true;
            this.F_Diagram.Click += new System.EventHandler(this.F_Diagram_Click);
            // 
            // F_ChooseGrop
            // 
            this.F_ChooseGrop.FormattingEnabled = true;
            this.F_ChooseGrop.Location = new System.Drawing.Point(609, 19);
            this.F_ChooseGrop.Name = "F_ChooseGrop";
            this.F_ChooseGrop.Size = new System.Drawing.Size(266, 28);
            this.F_ChooseGrop.TabIndex = 22;
            // 
            // F_Print
            // 
            this.F_Print.Location = new System.Drawing.Point(861, 379);
            this.F_Print.Name = "F_Print";
            this.F_Print.Size = new System.Drawing.Size(109, 54);
            this.F_Print.TabIndex = 23;
            this.F_Print.Text = "Print doc";
            this.F_Print.UseVisualStyleBackColor = true;
            this.F_Print.Click += new System.EventHandler(this.F_Print_Click);
            // 
            // F_Load
            // 
            this.F_Load.Location = new System.Drawing.Point(968, 19);
            this.F_Load.Name = "F_Load";
            this.F_Load.Size = new System.Drawing.Size(27, 25);
            this.F_Load.TabIndex = 24;
            this.F_Load.Text = "-";
            this.F_Load.UseVisualStyleBackColor = true;
            this.F_Load.Click += new System.EventHandler(this.F_Load_Click);
            // 
            // F_GropFind
            // 
            this.F_GropFind.Location = new System.Drawing.Point(881, 17);
            this.F_GropFind.Name = "F_GropFind";
            this.F_GropFind.Size = new System.Drawing.Size(77, 30);
            this.F_GropFind.TabIndex = 25;
            this.F_GropFind.Text = "Group";
            this.F_GropFind.UseVisualStyleBackColor = true;
            this.F_GropFind.Click += new System.EventHandler(this.F_GropFind_Click);
            // 
            // FormMainK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.F_GropFind);
            this.Controls.Add(this.F_Load);
            this.Controls.Add(this.F_Print);
            this.Controls.Add(this.F_ChooseGrop);
            this.Controls.Add(this.F_Diagram);
            this.Controls.Add(this.F_SumDeliv);
            this.Controls.Add(this.F_Sum);
            this.Controls.Add(this.F_Archive);
            this.Controls.Add(this.F_Rev);
            this.Controls.Add(this.F_Write);
            this.Controls.Add(this.F_Less);
            this.Controls.Add(this.F_Find);
            this.Controls.Add(this.F_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F_GoodsList);
            this.Controls.Add(this.F_Delivary);
            this.Controls.Add(this.F_Receipt);
            this.Name = "FormMainK";
            this.Text = "FormMainK";
            this.Load += new System.EventHandler(this.FormMainK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_GoodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F_Receipt;
        private System.Windows.Forms.Button F_Delivary;
        private System.Windows.Forms.DataGridView F_GoodsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F_Number;
        private System.Windows.Forms.Button F_Find;
        private System.Windows.Forms.Button F_Less;
        private System.Windows.Forms.Button F_Write;
        private System.Windows.Forms.Button F_Rev;
        private System.Windows.Forms.Button F_Archive;
        private System.Windows.Forms.Button F_Sum;
        private System.Windows.Forms.Button F_SumDeliv;
        private System.Windows.Forms.Button F_Diagram;
        private System.Windows.Forms.ComboBox F_ChooseGrop;
        private System.Windows.Forms.Button F_Print;
        private System.Windows.Forms.Button F_Load;
        private System.Windows.Forms.Button F_GropFind;
    }
}