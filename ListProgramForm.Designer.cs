namespace LibrarySoftware
{
    partial class ListProgramForm
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
            this.listProgramDGV = new System.Windows.Forms.DataGridView();
            this.idProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LibrarySoftware.databaseDataSet();
            this.titleLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.listProgramTableAdapter = new LibrarySoftware.databaseDataSetTableAdapters.ListProgramTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listProgramDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listProgramDGV
            // 
            this.listProgramDGV.AutoGenerateColumns = false;
            this.listProgramDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProgramDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProgramDataGridViewTextBoxColumn,
            this.nameProgramDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.firmDataGridViewTextBoxColumn,
            this.releaseDataGridViewTextBoxColumn,
            this.applicationAreaDataGridViewTextBoxColumn,
            this.costLicenseDataGridViewTextBoxColumn});
            this.listProgramDGV.DataSource = this.listProgramBindingSource;
            this.listProgramDGV.Location = new System.Drawing.Point(12, 85);
            this.listProgramDGV.Name = "listProgramDGV";
            this.listProgramDGV.Size = new System.Drawing.Size(760, 411);
            this.listProgramDGV.TabIndex = 0;
            this.listProgramDGV.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.listProgramDGV_UserDeletingRow);
            // 
            // idProgramDataGridViewTextBoxColumn
            // 
            this.idProgramDataGridViewTextBoxColumn.DataPropertyName = "id_Program";
            this.idProgramDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idProgramDataGridViewTextBoxColumn.Name = "idProgramDataGridViewTextBoxColumn";
            this.idProgramDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameProgramDataGridViewTextBoxColumn
            // 
            this.nameProgramDataGridViewTextBoxColumn.DataPropertyName = "nameProgram";
            this.nameProgramDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameProgramDataGridViewTextBoxColumn.Name = "nameProgramDataGridViewTextBoxColumn";
            this.nameProgramDataGridViewTextBoxColumn.Width = 125;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Версия";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 50;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // firmDataGridViewTextBoxColumn
            // 
            this.firmDataGridViewTextBoxColumn.DataPropertyName = "firm";
            this.firmDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.firmDataGridViewTextBoxColumn.Name = "firmDataGridViewTextBoxColumn";
            // 
            // releaseDataGridViewTextBoxColumn
            // 
            this.releaseDataGridViewTextBoxColumn.DataPropertyName = "release";
            this.releaseDataGridViewTextBoxColumn.HeaderText = "Дата выпуска";
            this.releaseDataGridViewTextBoxColumn.Name = "releaseDataGridViewTextBoxColumn";
            this.releaseDataGridViewTextBoxColumn.Width = 90;
            // 
            // applicationAreaDataGridViewTextBoxColumn
            // 
            this.applicationAreaDataGridViewTextBoxColumn.DataPropertyName = "applicationArea";
            this.applicationAreaDataGridViewTextBoxColumn.HeaderText = "Пркладная область";
            this.applicationAreaDataGridViewTextBoxColumn.Name = "applicationAreaDataGridViewTextBoxColumn";
            this.applicationAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // costLicenseDataGridViewTextBoxColumn
            // 
            this.costLicenseDataGridViewTextBoxColumn.DataPropertyName = "costLicense";
            this.costLicenseDataGridViewTextBoxColumn.HeaderText = "Стоимость лицензии";
            this.costLicenseDataGridViewTextBoxColumn.Name = "costLicenseDataGridViewTextBoxColumn";
            this.costLicenseDataGridViewTextBoxColumn.Width = 75;
            // 
            // listProgramBindingSource
            // 
            this.listProgramBindingSource.DataMember = "ListProgram";
            this.listProgramBindingSource.DataSource = this.databaseDataSet;
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
            this.titleLbl.Location = new System.Drawing.Point(133, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(555, 73);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Список программ";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.saveBtn.Location = new System.Drawing.Point(550, 502);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(222, 47);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 502);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Khaki;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addBtn.Location = new System.Drawing.Point(322, 502);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 47);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listProgramTableAdapter
            // 
            this.listProgramTableAdapter.ClearBeforeFill = true;
            // 
            // ListProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.listProgramDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ListProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.AddProgramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProgramDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView listProgramDGV;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        public databaseDataSet databaseDataSet;
        public System.Windows.Forms.BindingSource listProgramBindingSource;
        public databaseDataSetTableAdapters.ListProgramTableAdapter listProgramTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costLicenseDataGridViewTextBoxColumn;
    }
}