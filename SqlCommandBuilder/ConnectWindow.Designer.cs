namespace SqlCommandBuilder
{
    partial class ConnectWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConenct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(75, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(222, 20);
            this.txtServer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(75, 34);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(222, 20);
            this.txtDatabase.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConenct
            // 
            this.btnConenct.Location = new System.Drawing.Point(184, 127);
            this.btnConenct.Name = "btnConenct";
            this.btnConenct.Size = new System.Drawing.Size(113, 23);
            this.btnConenct.TabIndex = 8;
            this.btnConenct.Text = "Connect";
            this.btnConenct.UseVisualStyleBackColor = true;
            this.btnConenct.Click += new System.EventHandler(this.btnConenct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(103, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(15, 186);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(282, 20);
            this.txtConnString.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Connection String";
            // 
            // btnConnString
            // 
            this.btnConnString.Location = new System.Drawing.Point(184, 213);
            this.btnConnString.Name = "btnConnString";
            this.btnConnString.Size = new System.Drawing.Size(113, 23);
            this.btnConnString.TabIndex = 12;
            this.btnConnString.Text = "Connect";
            this.btnConnString.UseVisualStyleBackColor = true;
            this.btnConnString.Click += new System.EventHandler(this.btnConnString_Click);
            // 
            // ConnectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 254);
            this.Controls.Add(this.btnConnString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConenct);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConnectWindow";
            this.RightToLeftLayout = true;
            this.Text = "Connect To Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConenct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnString;
    }
}