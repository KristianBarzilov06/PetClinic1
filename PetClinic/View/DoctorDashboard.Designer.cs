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
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RoleLb = new System.Windows.Forms.Label();
            this.AdminUsrLb = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.TextBox();
            this.ComboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(57, 8);
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
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(755, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(48, 48);
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
            this.dataGridView1.Location = new System.Drawing.Point(71, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 280);
            this.dataGridView1.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AddBtn.Location = new System.Drawing.Point(71, 511);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 33);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Insert";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateBtn.Location = new System.Drawing.Point(169, 511);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 33);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DeleteBtn.Location = new System.Drawing.Point(267, 511);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 33);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SearchBtn.Location = new System.Drawing.Point(673, 511);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 33);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // RoleLb
            // 
            this.RoleLb.AutoSize = true;
            this.RoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.RoleLb.Location = new System.Drawing.Point(73, 93);
            this.RoleLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleLb.Name = "RoleLb";
            this.RoleLb.Size = new System.Drawing.Size(77, 36);
            this.RoleLb.TabIndex = 28;
            this.RoleLb.Text = "Role";
            this.RoleLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminUsrLb
            // 
            this.AdminUsrLb.AutoSize = true;
            this.AdminUsrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.AdminUsrLb.Location = new System.Drawing.Point(72, 144);
            this.AdminUsrLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminUsrLb.Name = "AdminUsrLb";
            this.AdminUsrLb.Size = new System.Drawing.Size(150, 36);
            this.AdminUsrLb.TabIndex = 27;
            this.AdminUsrLb.Text = "Username";
            this.AdminUsrLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameLb
            // 
            this.UsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UsernameLb.Location = new System.Drawing.Point(240, 151);
            this.UsernameLb.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(269, 32);
            this.UsernameLb.TabIndex = 26;
            // 
            // ComboBoxDoctor
            // 
            this.ComboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDoctor.FormattingEnabled = true;
            this.ComboBoxDoctor.Location = new System.Drawing.Point(241, 99);
            this.ComboBoxDoctor.Name = "ComboBoxDoctor";
            this.ComboBoxDoctor.Size = new System.Drawing.Size(267, 21);
            this.ComboBoxDoctor.TabIndex = 29;
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ShowAll.Location = new System.Drawing.Point(665, 160);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(102, 33);
            this.ShowAll.TabIndex = 30;
            this.ShowAll.Text = "ShowAll";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.Image = global::PetClinic.Properties.Resources.return4;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(49, 48);
            this.ReturnBtn.TabIndex = 31;
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 571);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.ComboBoxDoctor);
            this.Controls.Add(this.RoleLb);
            this.Controls.Add(this.AdminUsrLb);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
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
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label RoleLb;
        private System.Windows.Forms.Label AdminUsrLb;
        private System.Windows.Forms.TextBox UsernameLb;
        private System.Windows.Forms.ComboBox ComboBoxDoctor;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button ReturnBtn;
    }
}