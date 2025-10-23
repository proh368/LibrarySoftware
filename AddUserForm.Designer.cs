namespace LibrarySoftware
{
    partial class AddUserForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.idAccountLbl = new System.Windows.Forms.Label();
            this.sphereUseLbl = new System.Windows.Forms.Label();
            this.sphereUseTxt = new System.Windows.Forms.TextBox();
            this.regionLbl = new System.Windows.Forms.Label();
            this.regionTxt = new System.Windows.Forms.TextBox();
            this.fioLbl = new System.Windows.Forms.Label();
            this.fioTxt = new System.Windows.Forms.TextBox();
            this.idAccountCBox = new System.Windows.Forms.ComboBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new LibrarySoftware.databaseDataSet();
            this.accountTableAdapter = new LibrarySoftware.databaseDataSetTableAdapters.AccountTableAdapter();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Khaki;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addBtn.Location = new System.Drawing.Point(220, 302);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 47);
            this.addBtn.TabIndex = 62;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // idAccountLbl
            // 
            this.idAccountLbl.AutoSize = true;
            this.idAccountLbl.BackColor = System.Drawing.Color.Transparent;
            this.idAccountLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idAccountLbl.Location = new System.Drawing.Point(120, 219);
            this.idAccountLbl.Name = "idAccountLbl";
            this.idAccountLbl.Size = new System.Drawing.Size(130, 23);
            this.idAccountLbl.TabIndex = 55;
            this.idAccountLbl.Text = "Код аккаунта:";
            // 
            // sphereUseLbl
            // 
            this.sphereUseLbl.AutoSize = true;
            this.sphereUseLbl.BackColor = System.Drawing.Color.Transparent;
            this.sphereUseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphereUseLbl.Location = new System.Drawing.Point(120, 158);
            this.sphereUseLbl.Name = "sphereUseLbl";
            this.sphereUseLbl.Size = new System.Drawing.Size(183, 23);
            this.sphereUseLbl.TabIndex = 53;
            this.sphereUseLbl.Text = "Сфера применения:";
            // 
            // sphereUseTxt
            // 
            this.sphereUseTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.sphereUseTxt.Location = new System.Drawing.Point(124, 184);
            this.sphereUseTxt.Name = "sphereUseTxt";
            this.sphereUseTxt.Size = new System.Drawing.Size(210, 32);
            this.sphereUseTxt.TabIndex = 52;
            // 
            // regionLbl
            // 
            this.regionLbl.AutoSize = true;
            this.regionLbl.BackColor = System.Drawing.Color.Transparent;
            this.regionLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionLbl.Location = new System.Drawing.Point(120, 97);
            this.regionLbl.Name = "regionLbl";
            this.regionLbl.Size = new System.Drawing.Size(79, 23);
            this.regionLbl.TabIndex = 51;
            this.regionLbl.Text = "Регион:";
            // 
            // regionTxt
            // 
            this.regionTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.regionTxt.Location = new System.Drawing.Point(124, 123);
            this.regionTxt.Name = "regionTxt";
            this.regionTxt.Size = new System.Drawing.Size(210, 32);
            this.regionTxt.TabIndex = 50;
            // 
            // fioLbl
            // 
            this.fioLbl.AutoSize = true;
            this.fioLbl.BackColor = System.Drawing.Color.Transparent;
            this.fioLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLbl.Location = new System.Drawing.Point(120, 36);
            this.fioLbl.Name = "fioLbl";
            this.fioLbl.Size = new System.Drawing.Size(220, 23);
            this.fioLbl.TabIndex = 49;
            this.fioLbl.Text = "Название пользователя:";
            // 
            // fioTxt
            // 
            this.fioTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.fioTxt.Location = new System.Drawing.Point(124, 62);
            this.fioTxt.Name = "fioTxt";
            this.fioTxt.Size = new System.Drawing.Size(210, 32);
            this.fioTxt.TabIndex = 48;
            // 
            // idAccountCBox
            // 
            this.idAccountCBox.DataSource = this.accountBindingSource;
            this.idAccountCBox.DisplayMember = "idAccount";
            this.idAccountCBox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.idAccountCBox.FormattingEnabled = true;
            this.idAccountCBox.Location = new System.Drawing.Point(124, 245);
            this.idAccountCBox.Name = "idAccountCBox";
            this.idAccountCBox.Size = new System.Drawing.Size(210, 31);
            this.idAccountCBox.TabIndex = 63;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 302);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 65;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.idAccountCBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.idAccountLbl);
            this.Controls.Add(this.sphereUseLbl);
            this.Controls.Add(this.sphereUseTxt);
            this.Controls.Add(this.regionLbl);
            this.Controls.Add(this.regionTxt);
            this.Controls.Add(this.fioLbl);
            this.Controls.Add(this.fioTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label idAccountLbl;
        private System.Windows.Forms.Label sphereUseLbl;
        private System.Windows.Forms.TextBox sphereUseTxt;
        private System.Windows.Forms.Label regionLbl;
        private System.Windows.Forms.TextBox regionTxt;
        private System.Windows.Forms.Label fioLbl;
        private System.Windows.Forms.TextBox fioTxt;
        private System.Windows.Forms.ComboBox idAccountCBox;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private databaseDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.Button exitBtn;
    }
}