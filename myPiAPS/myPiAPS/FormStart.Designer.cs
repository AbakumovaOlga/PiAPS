namespace myPiAPS
{
    partial class FormStart
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Password = new System.Windows.Forms.TextBox();
            this.F_Login = new System.Windows.Forms.TextBox();
            this.F_Choose = new System.Windows.Forms.Button();
            this.F_CrUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // F_Password
            // 
            this.F_Password.Location = new System.Drawing.Point(211, 149);
            this.F_Password.Name = "F_Password";
            this.F_Password.PasswordChar = '*';
            this.F_Password.Size = new System.Drawing.Size(405, 26);
            this.F_Password.TabIndex = 7;
            // 
            // F_Login
            // 
            this.F_Login.Location = new System.Drawing.Point(211, 103);
            this.F_Login.Name = "F_Login";
            this.F_Login.Size = new System.Drawing.Size(405, 26);
            this.F_Login.TabIndex = 6;
            // 
            // F_Choose
            // 
            this.F_Choose.Location = new System.Drawing.Point(346, 207);
            this.F_Choose.Name = "F_Choose";
            this.F_Choose.Size = new System.Drawing.Size(98, 44);
            this.F_Choose.TabIndex = 43;
            this.F_Choose.Text = "Enter";
            this.F_Choose.UseVisualStyleBackColor = true;
            this.F_Choose.Click += new System.EventHandler(this.F_Choose_Click);
            // 
            // F_CrUser
            // 
            this.F_CrUser.Location = new System.Drawing.Point(666, 398);
            this.F_CrUser.Name = "F_CrUser";
            this.F_CrUser.Size = new System.Drawing.Size(122, 40);
            this.F_CrUser.TabIndex = 45;
            this.F_CrUser.Text = "CreateUser";
            this.F_CrUser.UseVisualStyleBackColor = true;
            this.F_CrUser.Click += new System.EventHandler(this.F_CrUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "система учета наличия и движения товаров в торговой организации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Абакумова Ольга";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_CrUser);
            this.Controls.Add(this.F_Choose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Password);
            this.Controls.Add(this.F_Login);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Password;
        private System.Windows.Forms.TextBox F_Login;
        private System.Windows.Forms.Button F_Choose;
        private System.Windows.Forms.Button F_CrUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}