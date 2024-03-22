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
            this.SuspendLayout();
            // 
            // PetLb
            // 
            this.PetLb.AutoSize = true;
            this.PetLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PetLb.Location = new System.Drawing.Point(25, 38);
            this.PetLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PetLb.Name = "PetLb";
            this.PetLb.Size = new System.Drawing.Size(67, 36);
            this.PetLb.TabIndex = 3;
            this.PetLb.Text = "Pet:";
            this.PetLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PetTextBox
            // 
            this.PetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PetTextBox.Location = new System.Drawing.Point(95, 44);
            this.PetTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PetTextBox.Name = "PetTextBox";
            this.PetTextBox.Size = new System.Drawing.Size(100, 32);
            this.PetTextBox.TabIndex = 4;
            // 
            // DescLb
            // 
            this.DescLb.AutoSize = true;
            this.DescLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.DescLb.Location = new System.Drawing.Point(25, 88);
            this.DescLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescLb.Name = "DescLb";
            this.DescLb.Size = new System.Drawing.Size(173, 36);
            this.DescLb.TabIndex = 5;
            this.DescLb.Text = "Description:";
            this.DescLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescBox
            // 
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DescBox.Location = new System.Drawing.Point(31, 130);
            this.DescBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(477, 145);
            this.DescBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 52);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // PickDateLb
            // 
            this.PickDateLb.AutoSize = true;
            this.PickDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PickDateLb.Location = new System.Drawing.Point(198, 38);
            this.PickDateLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PickDateLb.Name = "PickDateLb";
            this.PickDateLb.Size = new System.Drawing.Size(169, 36);
            this.PickDateLb.TabIndex = 8;
            this.PickDateLb.Text = "Pick a date:";
            this.PickDateLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubmitBtn.Location = new System.Drawing.Point(368, 88);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(133, 34);
            this.SubmitBtn.TabIndex = 9;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(499, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 21);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PickDateLb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.DescLb);
            this.Controls.Add(this.PetTextBox);
            this.Controls.Add(this.PetLb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientDashboard";
            this.Text = "ClientDashboard";
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
    }
}