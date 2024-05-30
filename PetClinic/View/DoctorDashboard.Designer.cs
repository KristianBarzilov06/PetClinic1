namespace PetClinic.View
{
    partial class DoctorDashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.petClinicDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petClinicDBDataSet = new PetClinic.PetClinicDBDataSet();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.petClinicDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petClinicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 83);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // petClinicDBDataSetBindingSource
            // 
            this.petClinicDBDataSetBindingSource.DataSource = this.petClinicDBDataSet;
            this.petClinicDBDataSetBindingSource.Position = 0;
            // 
            // petClinicDBDataSet
            // 
            this.petClinicDBDataSet.DataSetName = "PetClinicDBDataSet";
            this.petClinicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(12, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 21);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.petClinicDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 280);
            this.dataGridView1.TabIndex = 9;
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DoctorDashboard";
            this.Text = "DoctorDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.petClinicDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petClinicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource petClinicDBDataSetBindingSource;
        private PetClinicDBDataSet petClinicDBDataSet;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}