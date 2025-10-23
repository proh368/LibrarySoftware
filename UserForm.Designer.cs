namespace LibrarySoftware
{
    partial class UserForm
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
            this.userDGV = new System.Windows.Forms.DataGridView();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphereUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LibrarySoftware.databaseDataSet();
            this.titleLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userTableAdapter = new LibrarySoftware.databaseDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userDGV
            // 
            this.userDGV.AutoGenerateColumns = false;
            this.userDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserDataGridViewTextBoxColumn,
            this.nameUserDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.sphereUseDataGridViewTextBoxColumn,
            this.idAccountDataGridViewTextBoxColumn});
            this.userDGV.DataSource = this.userBindingSource;
            this.userDGV.Location = new System.Drawing.Point(12, 85);
            this.userDGV.Name = "userDGV";
            this.userDGV.Size = new System.Drawing.Size(760, 411);
            this.userDGV.TabIndex = 0;
            this.userDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.userDGV_UserDeletingRow);
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "id_User";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.Width = 55;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "nameUser";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.Width = 200;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.Width = 200;
            // 
            // sphereUseDataGridViewTextBoxColumn
            // 
            this.sphereUseDataGridViewTextBoxColumn.DataPropertyName = "sphereUse";
            this.sphereUseDataGridViewTextBoxColumn.HeaderText = "Сфера применения";
            this.sphereUseDataGridViewTextBoxColumn.Name = "sphereUseDataGridViewTextBoxColumn";
            this.sphereUseDataGridViewTextBoxColumn.Width = 200;
            // 
            // idAccountDataGridViewTextBoxColumn
            // 
            this.idAccountDataGridViewTextBoxColumn.DataPropertyName = "idAccount";
            this.idAccountDataGridViewTextBoxColumn.HeaderText = "Код аккаунта";
            this.idAccountDataGridViewTextBoxColumn.Name = "idAccountDataGridViewTextBoxColumn";
            this.idAccountDataGridViewTextBoxColumn.Width = 60;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(168, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(436, 73);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Пользователи";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Khaki;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addBtn.Location = new System.Drawing.Point(322, 502);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 47);
            this.addBtn.TabIndex = 35;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 502);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 34;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.saveBtn.Location = new System.Drawing.Point(550, 502);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(222, 47);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.userDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView userDGV;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        public databaseDataSet databaseDataSet;
        public System.Windows.Forms.BindingSource userBindingSource;
        public databaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereUseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccountDataGridViewTextBoxColumn;
    }
}