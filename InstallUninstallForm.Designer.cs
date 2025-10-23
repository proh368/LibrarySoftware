namespace LibrarySoftware
{
    partial class InstallUninstallForm
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
            this.installUninstallDGV = new System.Windows.Forms.DataGridView();
            this.idInstallUninstallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costInstallationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInstallationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUninstallationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLicensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installUninstallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LibrarySoftware.databaseDataSet();
            this.titleLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.install_UninstallTableAdapter = new LibrarySoftware.databaseDataSetTableAdapters.Install_UninstallTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.installUninstallDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installUninstallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // installUninstallDGV
            // 
            this.installUninstallDGV.AutoGenerateColumns = false;
            this.installUninstallDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installUninstallDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInstallUninstallDataGridViewTextBoxColumn,
            this.costInstallationDataGridViewTextBoxColumn,
            this.dateInstallationDataGridViewTextBoxColumn,
            this.dateUninstallationDataGridViewTextBoxColumn,
            this.countLicensesDataGridViewTextBoxColumn,
            this.idProgramDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn});
            this.installUninstallDGV.DataSource = this.installUninstallBindingSource;
            this.installUninstallDGV.Location = new System.Drawing.Point(12, 67);
            this.installUninstallDGV.Name = "installUninstallDGV";
            this.installUninstallDGV.Size = new System.Drawing.Size(760, 429);
            this.installUninstallDGV.TabIndex = 0;
            this.installUninstallDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.installUninstallDGV_UserDeletingRow);
            // 
            // idInstallUninstallDataGridViewTextBoxColumn
            // 
            this.idInstallUninstallDataGridViewTextBoxColumn.DataPropertyName = "idInstallUninstall";
            this.idInstallUninstallDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idInstallUninstallDataGridViewTextBoxColumn.Name = "idInstallUninstallDataGridViewTextBoxColumn";
            this.idInstallUninstallDataGridViewTextBoxColumn.Width = 50;
            // 
            // costInstallationDataGridViewTextBoxColumn
            // 
            this.costInstallationDataGridViewTextBoxColumn.DataPropertyName = "costInstallation";
            this.costInstallationDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costInstallationDataGridViewTextBoxColumn.Name = "costInstallationDataGridViewTextBoxColumn";
            this.costInstallationDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateInstallationDataGridViewTextBoxColumn
            // 
            this.dateInstallationDataGridViewTextBoxColumn.DataPropertyName = "dateInstallation";
            this.dateInstallationDataGridViewTextBoxColumn.HeaderText = "Дата инсталляции";
            this.dateInstallationDataGridViewTextBoxColumn.Name = "dateInstallationDataGridViewTextBoxColumn";
            this.dateInstallationDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateUninstallationDataGridViewTextBoxColumn
            // 
            this.dateUninstallationDataGridViewTextBoxColumn.DataPropertyName = "dateUninstallation";
            this.dateUninstallationDataGridViewTextBoxColumn.HeaderText = "Дата деинсталляции";
            this.dateUninstallationDataGridViewTextBoxColumn.Name = "dateUninstallationDataGridViewTextBoxColumn";
            this.dateUninstallationDataGridViewTextBoxColumn.Width = 130;
            // 
            // countLicensesDataGridViewTextBoxColumn
            // 
            this.countLicensesDataGridViewTextBoxColumn.DataPropertyName = "countLicenses";
            this.countLicensesDataGridViewTextBoxColumn.HeaderText = "Количество лицензий";
            this.countLicensesDataGridViewTextBoxColumn.Name = "countLicensesDataGridViewTextBoxColumn";
            this.countLicensesDataGridViewTextBoxColumn.Width = 130;
            // 
            // idProgramDataGridViewTextBoxColumn
            // 
            this.idProgramDataGridViewTextBoxColumn.DataPropertyName = "idProgram";
            this.idProgramDataGridViewTextBoxColumn.HeaderText = "Код программы";
            this.idProgramDataGridViewTextBoxColumn.Name = "idProgramDataGridViewTextBoxColumn";
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "idUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "Код пользователя";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            // 
            // installUninstallBindingSource
            // 
            this.installUninstallBindingSource.DataMember = "Install_Uninstall";
            this.installUninstallBindingSource.DataSource = this.databaseDataSet;
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
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(62, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(675, 55);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Инсталляция/Деинсталляция";
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
            // install_UninstallTableAdapter
            // 
            this.install_UninstallTableAdapter.ClearBeforeFill = true;
            // 
            // InstallUninstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.installUninstallDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InstallUninstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.InstallUninstallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.installUninstallDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installUninstallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView installUninstallDGV;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        public databaseDataSet databaseDataSet;
        public System.Windows.Forms.BindingSource installUninstallBindingSource;
        public databaseDataSetTableAdapters.Install_UninstallTableAdapter install_UninstallTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstallUninstallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costInstallationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInstallationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUninstallationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countLicensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
    }
}