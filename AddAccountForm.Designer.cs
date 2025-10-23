namespace LibrarySoftware
{
    partial class AddAccountForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.roleCBox = new System.Windows.Forms.ComboBox();
            this.databaseDataSet = new LibrarySoftware.databaseDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new LibrarySoftware.databaseDataSetTableAdapters.AccountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 303);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 73;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Khaki;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addBtn.Location = new System.Drawing.Point(220, 304);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 47);
            this.addBtn.TabIndex = 72;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.BackColor = System.Drawing.Color.Transparent;
            this.roleLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLbl.Location = new System.Drawing.Point(127, 174);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(58, 23);
            this.roleLbl.TabIndex = 70;
            this.roleLbl.Text = "Роль:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLbl.Location = new System.Drawing.Point(127, 113);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(81, 23);
            this.passwordLbl.TabIndex = 67;
            this.passwordLbl.Text = "Пароль:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.passwordTxt.Location = new System.Drawing.Point(131, 139);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(210, 32);
            this.passwordTxt.TabIndex = 66;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(127, 52);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(71, 23);
            this.loginLbl.TabIndex = 65;
            this.loginLbl.Text = "Логин:";
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.loginTxt.Location = new System.Drawing.Point(131, 78);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(210, 32);
            this.loginTxt.TabIndex = 64;
            // 
            // roleCBox
            // 
            this.roleCBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.roleCBox.FormattingEnabled = true;
            this.roleCBox.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.roleCBox.Location = new System.Drawing.Point(131, 200);
            this.roleCBox.Name = "roleCBox";
            this.roleCBox.Size = new System.Drawing.Size(210, 31);
            this.roleCBox.TabIndex = 74;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.databaseDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.roleCBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.loginTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.ComboBox roleCBox;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private databaseDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
    }
}