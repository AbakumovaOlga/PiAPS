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
            this.F_ChooseKind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F_DocList)).BeginInit();
            this.SuspendLayout();
            // 
            // F_DocList
            // 
            this.F_DocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_DocList.Location = new System.Drawing.Point(12, 69);
            this.F_DocList.Name = "F_DocList";
            this.F_DocList.RowTemplate.Height = 28;
            this.F_DocList.Size = new System.Drawing.Size(776, 369);
            this.F_DocList.TabIndex = 0;
            // 
            // F_ChooseKind
            // 
            this.F_ChooseKind.FormattingEnabled = true;
            this.F_ChooseKind.Location = new System.Drawing.Point(106, 17);
            this.F_ChooseKind.Name = "F_ChooseKind";
            this.F_ChooseKind.Size = new System.Drawing.Size(263, 28);
            this.F_ChooseKind.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_ChooseKind);
            this.Controls.Add(this.F_DocList);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            ((System.ComponentModel.ISupportInitialize)(this.F_DocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_DocList;
        private System.Windows.Forms.ComboBox F_ChooseKind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}