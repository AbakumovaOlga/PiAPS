namespace myPiAPS
{
    partial class FormMainM
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
            this.F_CrUser = new System.Windows.Forms.Button();
            this.F_CrProduct = new System.Windows.Forms.Button();
            this.F_CrProdGr = new System.Windows.Forms.Button();
            this.F_CrType = new System.Windows.Forms.Button();
            this.F_CrStock = new System.Windows.Forms.Button();
            this.F_CrSH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_CrUser
            // 
            this.F_CrUser.Location = new System.Drawing.Point(86, 61);
            this.F_CrUser.Name = "F_CrUser";
            this.F_CrUser.Size = new System.Drawing.Size(122, 40);
            this.F_CrUser.TabIndex = 44;
            this.F_CrUser.Text = "CreateUser";
            this.F_CrUser.UseVisualStyleBackColor = true;
            this.F_CrUser.Click += new System.EventHandler(this.F_CrUser_Click);
            // 
            // F_CrProduct
            // 
            this.F_CrProduct.Location = new System.Drawing.Point(339, 205);
            this.F_CrProduct.Name = "F_CrProduct";
            this.F_CrProduct.Size = new System.Drawing.Size(122, 40);
            this.F_CrProduct.TabIndex = 45;
            this.F_CrProduct.Text = "CreateProduct";
            this.F_CrProduct.UseVisualStyleBackColor = true;
            this.F_CrProduct.Click += new System.EventHandler(this.F_CrProduct_Click);
            // 
            // F_CrProdGr
            // 
            this.F_CrProdGr.Location = new System.Drawing.Point(575, 138);
            this.F_CrProdGr.Name = "F_CrProdGr";
            this.F_CrProdGr.Size = new System.Drawing.Size(122, 40);
            this.F_CrProdGr.TabIndex = 46;
            this.F_CrProdGr.Text = "CreateProdGroup";
            this.F_CrProdGr.UseVisualStyleBackColor = true;
            this.F_CrProdGr.Click += new System.EventHandler(this.F_CrProdGr_Click);
            // 
            // F_CrType
            // 
            this.F_CrType.Location = new System.Drawing.Point(236, 306);
            this.F_CrType.Name = "F_CrType";
            this.F_CrType.Size = new System.Drawing.Size(122, 40);
            this.F_CrType.TabIndex = 47;
            this.F_CrType.Text = "CreateType";
            this.F_CrType.UseVisualStyleBackColor = true;
            this.F_CrType.Click += new System.EventHandler(this.F_CrType_Click);
            // 
            // F_CrStock
            // 
            this.F_CrStock.Location = new System.Drawing.Point(395, 277);
            this.F_CrStock.Name = "F_CrStock";
            this.F_CrStock.Size = new System.Drawing.Size(122, 40);
            this.F_CrStock.TabIndex = 48;
            this.F_CrStock.Text = "CreateStock";
            this.F_CrStock.UseVisualStyleBackColor = true;
            this.F_CrStock.Click += new System.EventHandler(this.F_CrStock_Click);
            // 
            // F_CrSH
            // 
            this.F_CrSH.Location = new System.Drawing.Point(535, 218);
            this.F_CrSH.Name = "F_CrSH";
            this.F_CrSH.Size = new System.Drawing.Size(122, 40);
            this.F_CrSH.TabIndex = 49;
            this.F_CrSH.Text = "CreateSH";
            this.F_CrSH.UseVisualStyleBackColor = true;
            this.F_CrSH.Click += new System.EventHandler(this.F_CrSH_Click);
            // 
            // FormMainM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_CrSH);
            this.Controls.Add(this.F_CrStock);
            this.Controls.Add(this.F_CrType);
            this.Controls.Add(this.F_CrProdGr);
            this.Controls.Add(this.F_CrProduct);
            this.Controls.Add(this.F_CrUser);
            this.Name = "FormMainM";
            this.Text = "FormMainM";
            this.Load += new System.EventHandler(this.FormMainM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button F_CrUser;
        private System.Windows.Forms.Button F_CrProduct;
        private System.Windows.Forms.Button F_CrProdGr;
        private System.Windows.Forms.Button F_CrType;
        private System.Windows.Forms.Button F_CrStock;
        private System.Windows.Forms.Button F_CrSH;
    }
}