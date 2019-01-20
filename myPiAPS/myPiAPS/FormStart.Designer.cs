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
            this.F_AsManager = new System.Windows.Forms.Button();
            this.F_AsStorekeeper = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Password = new System.Windows.Forms.TextBox();
            this.F_Login = new System.Windows.Forms.TextBox();
            this.F_Cancel = new System.Windows.Forms.Button();
            this.F_Choose = new System.Windows.Forms.Button();
            this.F_CrUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_AsManager
            // 
            this.F_AsManager.Location = new System.Drawing.Point(429, 295);
            this.F_AsManager.Name = "F_AsManager";
            this.F_AsManager.Size = new System.Drawing.Size(187, 57);
            this.F_AsManager.TabIndex = 11;
            this.F_AsManager.Text = "Enter as a MANAGER";
            this.F_AsManager.UseVisualStyleBackColor = true;
            this.F_AsManager.Click += new System.EventHandler(this.F_AsManager_Click);
            // 
            // F_AsStorekeeper
            // 
            this.F_AsStorekeeper.Location = new System.Drawing.Point(211, 295);
            this.F_AsStorekeeper.Name = "F_AsStorekeeper";
            this.F_AsStorekeeper.Size = new System.Drawing.Size(187, 57);
            this.F_AsStorekeeper.TabIndex = 10;
            this.F_AsStorekeeper.Text = "Enter as a STOREKEEPER";
            this.F_AsStorekeeper.UseVisualStyleBackColor = true;
            this.F_AsStorekeeper.Click += new System.EventHandler(this.F_AsStorekeeper_Click);
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
            // F_Cancel
            // 
            this.F_Cancel.Location = new System.Drawing.Point(350, 385);
            this.F_Cancel.Name = "F_Cancel";
            this.F_Cancel.Size = new System.Drawing.Size(109, 34);
            this.F_Cancel.TabIndex = 42;
            this.F_Cancel.Text = "Cancel";
            this.F_Cancel.UseVisualStyleBackColor = true;
            this.F_Cancel.Click += new System.EventHandler(this.F_Cancel_Click);
            // 
            // F_Choose
            // 
            this.F_Choose.Location = new System.Drawing.Point(373, 228);
            this.F_Choose.Name = "F_Choose";
            this.F_Choose.Size = new System.Drawing.Size(75, 44);
            this.F_Choose.TabIndex = 43;
            this.F_Choose.Text = "Choose";
            this.F_Choose.UseVisualStyleBackColor = true;
            this.F_Choose.Click += new System.EventHandler(this.F_Choose_Click);
            // 
            // F_CrUser
            // 
            this.F_CrUser.Location = new System.Drawing.Point(635, 142);
            this.F_CrUser.Name = "F_CrUser";
            this.F_CrUser.Size = new System.Drawing.Size(122, 40);
            this.F_CrUser.TabIndex = 45;
            this.F_CrUser.Text = "CreateUser";
            this.F_CrUser.UseVisualStyleBackColor = true;
            this.F_CrUser.Click += new System.EventHandler(this.F_CrUser_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_CrUser);
            this.Controls.Add(this.F_Choose);
            this.Controls.Add(this.F_Cancel);
            this.Controls.Add(this.F_AsManager);
            this.Controls.Add(this.F_AsStorekeeper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Password);
            this.Controls.Add(this.F_Login);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F_AsManager;
        private System.Windows.Forms.Button F_AsStorekeeper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Password;
        private System.Windows.Forms.TextBox F_Login;
        private System.Windows.Forms.Button F_Cancel;
        private System.Windows.Forms.Button F_Choose;
        private System.Windows.Forms.Button F_CrUser;
    }
}