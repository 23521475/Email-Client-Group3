﻿
namespace LoginForm
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDontHave = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linklblRegister = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.10909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Teal;
            this.lblLogin.Location = new System.Drawing.Point(592, 65);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(330, 53);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login Account";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblUsername.Location = new System.Drawing.Point(499, 167);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblDontHave
            // 
            this.lblDontHave.AutoSize = true;
            this.lblDontHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDontHave.Location = new System.Drawing.Point(542, 547);
            this.lblDontHave.Name = "lblDontHave";
            this.lblDontHave.Size = new System.Drawing.Size(244, 25);
            this.lblDontHave.TabIndex = 3;
            this.lblDontHave.Text = "Don\'t have an account ?";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Teal;
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(375, 42);
            this.txtUsername.TabIndex = 4;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Teal;
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.ForeColor = System.Drawing.Color.White;
            this.pnlUsername.Location = new System.Drawing.Point(546, 213);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlUsername.Size = new System.Drawing.Size(375, 45);
            this.pnlUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(505, 297);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 29);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Teal;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.ForeColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(546, 347);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlPassword.Size = new System.Drawing.Size(375, 45);
            this.pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Teal;
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(375, 42);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(600, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(287, 54);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linklblRegister
            // 
            this.linklblRegister.AutoSize = true;
            this.linklblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRegister.ForeColor = System.Drawing.Color.Teal;
            this.linklblRegister.LinkColor = System.Drawing.Color.Teal;
            this.linklblRegister.Location = new System.Drawing.Point(795, 547);
            this.linklblRegister.Name = "linklblRegister";
            this.linklblRegister.Size = new System.Drawing.Size(92, 25);
            this.linklblRegister.TabIndex = 10;
            this.linklblRegister.TabStop = true;
            this.linklblRegister.Text = "Register";
            this.linklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegister_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(910, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picPassword
            // 
            this.picPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picPassword.BackColor = System.Drawing.SystemColors.Control;
            this.picPassword.Image = global::LoginForm.Properties.Resources.key;
            this.picPassword.Location = new System.Drawing.Point(504, 347);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(41, 45);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 8;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picUsername.BackColor = System.Drawing.SystemColors.Control;
            this.picUsername.Image = global::LoginForm.Properties.Resources.user;
            this.picUsername.Location = new System.Drawing.Point(504, 213);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(41, 45);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 5;
            this.picUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.Wallpaper_03;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linklblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.lblDontHave);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDontHave;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linklblRegister;
        private System.Windows.Forms.Button btnClose;
    }
}

