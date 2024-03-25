namespace PetClinic.View
{
    partial class AdministratorDashboard
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
            this.AdminHeader = new System.Windows.Forms.Label();
            this.ComboBoxAdmin = new System.Windows.Forms.ComboBox();
            this.RoleLb = new System.Windows.Forms.Label();
            this.AdminUsrLb = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminHeader
            // 
            this.AdminHeader.AutoSize = true;
            this.AdminHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.AdminHeader.Location = new System.Drawing.Point(181, 9);
            this.AdminHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHeader.Name = "AdminHeader";
            this.AdminHeader.Size = new System.Drawing.Size(275, 36);
            this.AdminHeader.TabIndex = 1;
            this.AdminHeader.Text = "Administrator Panel";
            this.AdminHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComboBoxAdmin
            // 
            this.ComboBoxAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAdmin.FormattingEnabled = true;
            this.ComboBoxAdmin.Items.AddRange(new object[] {
            "Doctor",
            "Client"});
            this.ComboBoxAdmin.Location = new System.Drawing.Point(260, 77);
            this.ComboBoxAdmin.Name = "ComboBoxAdmin";
            this.ComboBoxAdmin.Size = new System.Drawing.Size(269, 21);
            this.ComboBoxAdmin.TabIndex = 13;
            // 
            // RoleLb
            // 
            this.RoleLb.AutoSize = true;
            this.RoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.RoleLb.Location = new System.Drawing.Point(93, 64);
            this.RoleLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleLb.Name = "RoleLb";
            this.RoleLb.Size = new System.Drawing.Size(77, 36);
            this.RoleLb.TabIndex = 12;
            this.RoleLb.Text = "Role";
            this.RoleLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminUsrLb
            // 
            this.AdminUsrLb.AutoSize = true;
            this.AdminUsrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.AdminUsrLb.Location = new System.Drawing.Point(92, 115);
            this.AdminUsrLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminUsrLb.Name = "AdminUsrLb";
            this.AdminUsrLb.Size = new System.Drawing.Size(150, 36);
            this.AdminUsrLb.TabIndex = 11;
            this.AdminUsrLb.Text = "Username";
            this.AdminUsrLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameLb
            // 
            this.UsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UsernameLb.Location = new System.Drawing.Point(260, 122);
            this.UsernameLb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(269, 32);
            this.UsernameLb.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AddBtn.Location = new System.Drawing.Point(98, 164);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 33);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Insert";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateBtn.Location = new System.Drawing.Point(210, 164);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 33);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DeleteBtn.Location = new System.Drawing.Point(322, 164);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 33);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SearchBtn.Location = new System.Drawing.Point(435, 164);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 33);
            this.SearchBtn.TabIndex = 17;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(98, 224);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(431, 163);
            this.dataGridViewAdmin.TabIndex = 18;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ComboBoxAdmin);
            this.Controls.Add(this.RoleLb);
            this.Controls.Add(this.AdminUsrLb);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.AdminHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdministratorDashboard";
            this.Text = "AdministratorDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminHeader;
        private System.Windows.Forms.ComboBox ComboBoxAdmin;
        private System.Windows.Forms.Label RoleLb;
        private System.Windows.Forms.Label AdminUsrLb;
        private System.Windows.Forms.TextBox UsernameLb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
    }
}