namespace LibrarySoftware
{
    partial class MainForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.listProgramBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.instUninstBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.editLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet1 = new LibrarySoftware.databaseDataSet1();
            this.checkLastMonthBeforeLastMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.check_lastMonth_BeforeLastMonthTableAdapter = new LibrarySoftware.databaseDataSet1TableAdapters.Check_lastMonth_BeforeLastMonthTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInstallationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLastMonthBeforeLastMonthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(173, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(440, 73);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Главное меню";
            // 
            // listProgramBtn
            // 
            this.listProgramBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.listProgramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listProgramBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.listProgramBtn.Location = new System.Drawing.Point(12, 144);
            this.listProgramBtn.Name = "listProgramBtn";
            this.listProgramBtn.Size = new System.Drawing.Size(222, 47);
            this.listProgramBtn.TabIndex = 7;
            this.listProgramBtn.Text = "Список программ";
            this.listProgramBtn.UseVisualStyleBackColor = false;
            this.listProgramBtn.Click += new System.EventHandler(this.listProgramBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.userBtn.Location = new System.Drawing.Point(12, 197);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(222, 47);
            this.userBtn.TabIndex = 8;
            this.userBtn.Text = "Пользователи";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // instUninstBtn
            // 
            this.instUninstBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.instUninstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instUninstBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.instUninstBtn.Location = new System.Drawing.Point(12, 250);
            this.instUninstBtn.Name = "instUninstBtn";
            this.instUninstBtn.Size = new System.Drawing.Size(222, 57);
            this.instUninstBtn.TabIndex = 9;
            this.instUninstBtn.Text = "Инсталляция/Деинсталляция";
            this.instUninstBtn.UseVisualStyleBackColor = false;
            this.instUninstBtn.Click += new System.EventHandler(this.instUninstBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 502);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.Tomato;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.accountBtn.Location = new System.Drawing.Point(12, 313);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(222, 47);
            this.accountBtn.TabIndex = 13;
            this.accountBtn.Text = "Аккаунты";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Visible = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // editLbl
            // 
            this.editLbl.AutoSize = true;
            this.editLbl.BackColor = System.Drawing.Color.Transparent;
            this.editLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLbl.Location = new System.Drawing.Point(12, 118);
            this.editLbl.Name = "editLbl";
            this.editLbl.Size = new System.Drawing.Size(145, 23);
            this.editLbl.TabIndex = 16;
            this.editLbl.Text = "Редактировать:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dateInstallationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkLastMonthBeforeLastMonthBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(328, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 464);
            this.dataGridView1.TabIndex = 18;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkLastMonthBeforeLastMonthBindingSource
            // 
            this.checkLastMonthBeforeLastMonthBindingSource.DataMember = "Check lastMonth BeforeLastMonth";
            this.checkLastMonthBeforeLastMonthBindingSource.DataSource = this.databaseDataSet1;
            // 
            // check_lastMonth_BeforeLastMonthTableAdapter
            // 
            this.check_lastMonth_BeforeLastMonthTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nameProgram";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название программы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dateInstallationDataGridViewTextBoxColumn
            // 
            this.dateInstallationDataGridViewTextBoxColumn.DataPropertyName = "dateInstallation";
            this.dateInstallationDataGridViewTextBoxColumn.HeaderText = "Дата инсталляции";
            this.dateInstallationDataGridViewTextBoxColumn.Name = "dateInstallationDataGridViewTextBoxColumn";
            this.dateInstallationDataGridViewTextBoxColumn.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editLbl);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.instUninstBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.listProgramBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLastMonthBeforeLastMonthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button listProgramBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button instUninstBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label editLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource checkLastMonthBeforeLastMonthBindingSource;
        private databaseDataSet1TableAdapters.Check_lastMonth_BeforeLastMonthTableAdapter check_lastMonth_BeforeLastMonthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInstallationDataGridViewTextBoxColumn;
    }
}