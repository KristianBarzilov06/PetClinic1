namespace PetClinic.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(400, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameLb
            // 
            this.UsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UsernameLb.Location = new System.Drawing.Point(400, 172);
            this.UsernameLb.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(186, 32);
            this.UsernameLb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 48F);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(179, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 83);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordLb
            // 
            this.PasswordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordLb.Location = new System.Drawing.Point(400, 232);
            this.PasswordLb.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.PasswordChar = '*';
            this.PasswordLb.Size = new System.Drawing.Size(186, 32);
            this.PasswordLb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 48F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(194, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 83);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(633, 529);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(105, 42);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Sign In";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLink.Location = new System.Drawing.Point(601, 572);
            this.SignUpLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(137, 13);
            this.SignUpLink.TabIndex = 6;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Are you new here? Sign Up";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 48F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(280, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 83);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "Doctor",
            "Client"});
            this.comboBoxLogin.Location = new System.Drawing.Point(400, 128);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(184, 21);
            this.comboBoxLogin.TabIndex = 8;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(692, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(46, 48);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PetClinic.Properties.Resources.waving_puppies;
            this.pictureBox1.Location = new System.Drawing.Point(208, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 311);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.Image = global::PetClinic.Properties.Resources.return4;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(49, 48);
            this.ReturnBtn.TabIndex = 11;
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 592);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReturnBtn;
    }
}