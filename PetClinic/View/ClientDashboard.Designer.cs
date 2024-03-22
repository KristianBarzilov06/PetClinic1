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
            this.SuspendLayout();
            // 
            // PetLb
            // 
            this.PetLb.AutoSize = true;
            this.PetLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PetLb.Location = new System.Drawing.Point(38, 59);
            this.PetLb.Name = "PetLb";
            this.PetLb.Size = new System.Drawing.Size(99, 52);
            this.PetLb.TabIndex = 3;
            this.PetLb.Text = "Pet:";
            this.PetLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PetTextBox
            // 
            this.PetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PetTextBox.Location = new System.Drawing.Point(143, 67);
            this.PetTextBox.Name = "PetTextBox";
            this.PetTextBox.Size = new System.Drawing.Size(148, 44);
            this.PetTextBox.TabIndex = 4;
            // 
            // DescLb
            // 
            this.DescLb.AutoSize = true;
            this.DescLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.DescLb.Location = new System.Drawing.Point(38, 135);
            this.DescLb.Name = "DescLb";
            this.DescLb.Size = new System.Drawing.Size(253, 52);
            this.DescLb.TabIndex = 5;
            this.DescLb.Text = "Description:";
            this.DescLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescBox
            // 
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DescBox.Location = new System.Drawing.Point(47, 200);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(714, 221);
            this.DescBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // PickDateLb
            // 
            this.PickDateLb.AutoSize = true;
            this.PickDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PickDateLb.Location = new System.Drawing.Point(297, 59);
            this.PickDateLb.Name = "PickDateLb";
            this.PickDateLb.Size = new System.Drawing.Size(249, 52);
            this.PickDateLb.TabIndex = 8;
            this.PickDateLb.Text = "Pick a date:";
            this.PickDateLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubmitBtn.Location = new System.Drawing.Point(552, 135);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(200, 52);
            this.SubmitBtn.TabIndex = 9;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PickDateLb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.DescLb);
            this.Controls.Add(this.PetTextBox);
            this.Controls.Add(this.PetLb);
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
    }
}