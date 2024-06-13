namespace PetClinic.View
{
    partial class ClientDashboard
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
            this.PetLb = new System.Windows.Forms.Label();
            this.PetTextBox = new System.Windows.Forms.TextBox();
            this.DescLb = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PickDateLb = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PetLb
            // 
            this.PetLb.AutoSize = true;
            this.PetLb.BackColor = System.Drawing.Color.Transparent;
            this.PetLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PetLb.Location = new System.Drawing.Point(36, 118);
            this.PetLb.Name = "PetLb";
            this.PetLb.Size = new System.Drawing.Size(99, 52);
            this.PetLb.TabIndex = 3;
            this.PetLb.Text = "Pet:";
            this.PetLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PetTextBox
            // 
            this.PetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PetTextBox.Location = new System.Drawing.Point(141, 128);
            this.PetTextBox.Name = "PetTextBox";
            this.PetTextBox.Size = new System.Drawing.Size(148, 44);
            this.PetTextBox.TabIndex = 4;
            // 
            // DescLb
            // 
            this.DescLb.AutoSize = true;
            this.DescLb.BackColor = System.Drawing.Color.Transparent;
            this.DescLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.DescLb.Location = new System.Drawing.Point(36, 195);
            this.DescLb.Name = "DescLb";
            this.DescLb.Size = new System.Drawing.Size(253, 52);
            this.DescLb.TabIndex = 5;
            this.DescLb.Text = "Description:";
            this.DescLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescBox
            // 
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DescBox.Location = new System.Drawing.Point(45, 260);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(714, 221);
            this.DescBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // PickDateLb
            // 
            this.PickDateLb.AutoSize = true;
            this.PickDateLb.BackColor = System.Drawing.Color.Transparent;
            this.PickDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PickDateLb.Location = new System.Drawing.Point(296, 118);
            this.PickDateLb.Name = "PickDateLb";
            this.PickDateLb.Size = new System.Drawing.Size(249, 52);
            this.PickDateLb.TabIndex = 8;
            this.PickDateLb.Text = "Pick a date:";
            this.PickDateLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubmitBtn.Location = new System.Drawing.Point(550, 195);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(200, 52);
            this.SubmitBtn.TabIndex = 9;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(705, 18);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(76, 74);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.Image = global::PetClinic.Properties.Resources.return4;
            this.ReturnBtn.Location = new System.Drawing.Point(18, 18);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(74, 74);
            this.ReturnBtn.TabIndex = 12;
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetClinic.Properties.Resources._751099bbbf3521a7318776a55a78cc76;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PickDateLb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.DescLb);
            this.Controls.Add(this.PetTextBox);
            this.Controls.Add(this.PetLb);
            this.Name = "ClientDashboard";
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PetLb;
        private System.Windows.Forms.TextBox PetTextBox;
        private System.Windows.Forms.Label DescLb;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label PickDateLb;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}