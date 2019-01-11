namespace myPiAPS
{
    partial class newUser
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
            this.F_Login = new System.Windows.Forms.TextBox();
            this.F_Rassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.F_FIO = new System.Windows.Forms.TextBox();
            this.F_Role = new System.Windows.Forms.TextBox();
            this.F_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_Login
            // 
            this.F_Login.Location = new System.Drawing.Point(153, 83);
            this.F_Login.Name = "F_Login";
            this.F_Login.Size = new System.Drawing.Size(282, 26);
            this.F_Login.TabIndex = 0;
            // 
            // F_Rassword
            // 
            this.F_Rassword.Location = new System.Drawing.Point(153, 140);
            this.F_Rassword.Name = "F_Rassword";
            this.F_Rassword.Size = new System.Drawing.Size(282, 26);
            this.F_Rassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role";
            // 
            // F_FIO
            // 
            this.F_FIO.Location = new System.Drawing.Point(153, 204);
            this.F_FIO.Name = "F_FIO";
            this.F_FIO.Size = new System.Drawing.Size(282, 26);
            this.F_FIO.TabIndex = 6;
            // 
            // F_Role
            // 
            this.F_Role.Location = new System.Drawing.Point(153, 264);
            this.F_Role.Name = "F_Role";
            this.F_Role.Size = new System.Drawing.Size(282, 26);
            this.F_Role.TabIndex = 7;
            // 
            // F_OK
            // 
            this.F_OK.Location = new System.Drawing.Point(417, 376);
            this.F_OK.Name = "F_OK";
            this.F_OK.Size = new System.Drawing.Size(75, 32);
            this.F_OK.TabIndex = 8;
            this.F_OK.Text = "OK";
            this.F_OK.UseVisualStyleBackColor = true;
            this.F_OK.Click += new System.EventHandler(this.F_OK_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_OK);
            this.Controls.Add(this.F_Role);
            this.Controls.Add(this.F_FIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Rassword);
            this.Controls.Add(this.F_Login);
            this.Name = "newUser";
            this.Text = "newUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F_Login;
        private System.Windows.Forms.TextBox F_Rassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox F_FIO;
        private System.Windows.Forms.TextBox F_Role;
        private System.Windows.Forms.Button F_OK;
    }
}