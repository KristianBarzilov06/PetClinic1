namespace PetClinic.View
{
    partial class AddNewAccount
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
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UsernameTxt.Location = new System.Drawing.Point(17, 73);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(306, 32);
            this.UsernameTxt.TabIndex = 27;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.UsernameLbl.Location = new System.Drawing.Point(11, 25);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(150, 36);
            this.UsernameLbl.TabIndex = 28;
            this.UsernameLbl.Text = "Username";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PassLbl.Location = new System.Drawing.Point(11, 126);
            this.PassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(147, 36);
            this.PassLbl.TabIndex = 29;
            this.PassLbl.Text = "Password";
            this.PassLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PassTxt.Location = new System.Drawing.Point(17, 190);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(306, 32);
            this.PassTxt.TabIndex = 30;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DoneBtn.Location = new System.Drawing.Point(229, 256);
            this.DoneBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(94, 33);
            this.DoneBtn.TabIndex = 31;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click_1);
            // 
            // AddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 300);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Name = "AddNewAccount";
            this.Text = "AddNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button DoneBtn;
    }
}