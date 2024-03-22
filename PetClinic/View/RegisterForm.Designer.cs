﻿namespace PetClinic.View
{
    partial class RegisterForm
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
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSignUp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordRegisterTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameRegisterTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Location = new System.Drawing.Point(224, 563);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(246, 20);
            this.LoginLink.TabIndex = 13;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Already have an account? Sign In";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.RegisterBtn.Location = new System.Drawing.Point(590, 537);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(158, 65);
            this.RegisterBtn.TabIndex = 12;
            this.RegisterBtn.Text = "Sign Up";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(460, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSignUp
            // 
            this.comboBoxSignUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignUp.FormattingEnabled = true;
            this.comboBoxSignUp.Items.AddRange(new object[] {
            "Doctor",
            "Client"});
            this.comboBoxSignUp.Location = new System.Drawing.Point(470, 266);
            this.comboBoxSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSignUp.Name = "comboBoxSignUp";
            this.comboBoxSignUp.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSignUp.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label4.Location = new System.Drawing.Point(219, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 52);
            this.label4.TabIndex = 18;
            this.label4.Text = "Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label3.Location = new System.Drawing.Point(218, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 52);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordRegisterTxt
            // 
            this.passwordRegisterTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordRegisterTxt.Location = new System.Drawing.Point(470, 426);
            this.passwordRegisterTxt.Name = "passwordRegisterTxt";
            this.passwordRegisterTxt.Size = new System.Drawing.Size(277, 44);
            this.passwordRegisterTxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(218, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 52);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameRegisterTxt
            // 
            this.usernameRegisterTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameRegisterTxt.Location = new System.Drawing.Point(470, 334);
            this.usernameRegisterTxt.Name = "usernameRegisterTxt";
            this.usernameRegisterTxt.Size = new System.Drawing.Size(277, 44);
            this.usernameRegisterTxt.TabIndex = 14;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 805);
            this.Controls.Add(this.comboBoxSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordRegisterTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameRegisterTxt);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordRegisterTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameRegisterTxt;
    }
}