namespace LibrarySoftware
{
    partial class AddInstallUninstallForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.countLicensesLbl = new System.Windows.Forms.Label();
            this.dateUninstallationLbl = new System.Windows.Forms.Label();
            this.dateUninstallationTxt = new System.Windows.Forms.TextBox();
            this.dateInstallationLbl = new System.Windows.Forms.Label();
            this.dateInstallationTxt = new System.Windows.Forms.TextBox();
            this.costLbl = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.countLicensesNum = new System.Windows.Forms.NumericUpDown();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countLicensesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Khaki;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.addBtn.Location = new System.Drawing.Point(220, 303);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 47);
            this.addBtn.TabIndex = 62;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // countLicensesLbl
            // 
            this.countLicensesLbl.AutoSize = true;
            this.countLicensesLbl.BackColor = System.Drawing.Color.Transparent;
            this.countLicensesLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLicensesLbl.Location = new System.Drawing.Point(130, 192);
            this.countLicensesLbl.Name = "countLicensesLbl";
            this.countLicensesLbl.Size = new System.Drawing.Size(165, 23);
            this.countLicensesLbl.TabIndex = 55;
            this.countLicensesLbl.Text = "Кол-во лицензий:";
            // 
            // dateUninstallationLbl
            // 
            this.dateUninstallationLbl.AutoSize = true;
            this.dateUninstallationLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateUninstallationLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateUninstallationLbl.Location = new System.Drawing.Point(126, 131);
            this.dateUninstallationLbl.Name = "dateUninstallationLbl";
            this.dateUninstallationLbl.Size = new System.Drawing.Size(193, 23);
            this.dateUninstallationLbl.TabIndex = 53;
            this.dateUninstallationLbl.Text = "Дата деинсталляции:";
            // 
            // dateUninstallationTxt
            // 
            this.dateUninstallationTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.dateUninstallationTxt.Location = new System.Drawing.Point(130, 157);
            this.dateUninstallationTxt.Name = "dateUninstallationTxt";
            this.dateUninstallationTxt.Size = new System.Drawing.Size(210, 32);
            this.dateUninstallationTxt.TabIndex = 52;
            // 
            // dateInstallationLbl
            // 
            this.dateInstallationLbl.AutoSize = true;
            this.dateInstallationLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateInstallationLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateInstallationLbl.Location = new System.Drawing.Point(130, 70);
            this.dateInstallationLbl.Name = "dateInstallationLbl";
            this.dateInstallationLbl.Size = new System.Drawing.Size(173, 23);
            this.dateInstallationLbl.TabIndex = 51;
            this.dateInstallationLbl.Text = "Дата инсталляции:";
            // 
            // dateInstallationTxt
            // 
            this.dateInstallationTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.dateInstallationTxt.Location = new System.Drawing.Point(134, 96);
            this.dateInstallationTxt.Name = "dateInstallationTxt";
            this.dateInstallationTxt.Size = new System.Drawing.Size(210, 32);
            this.dateInstallationTxt.TabIndex = 50;
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.BackColor = System.Drawing.Color.Transparent;
            this.costLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLbl.Location = new System.Drawing.Point(130, 9);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(114, 23);
            this.costLbl.TabIndex = 49;
            this.costLbl.Text = "Стоимость:";
            // 
            // costTxt
            // 
            this.costTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.costTxt.Location = new System.Drawing.Point(134, 35);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(210, 32);
            this.costTxt.TabIndex = 48;
            // 
            // countLicensesNum
            // 
            this.countLicensesNum.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.countLicensesNum.Location = new System.Drawing.Point(134, 219);
            this.countLicensesNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countLicensesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countLicensesNum.Name = "countLicensesNum";
            this.countLicensesNum.Size = new System.Drawing.Size(210, 32);
            this.countLicensesNum.TabIndex = 61;
            this.countLicensesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 302);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 63;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddInstallUninstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.countLicensesNum);
            this.Controls.Add(this.countLicensesLbl);
            this.Controls.Add(this.dateUninstallationLbl);
            this.Controls.Add(this.dateUninstallationTxt);
            this.Controls.Add(this.dateInstallationLbl);
            this.Controls.Add(this.dateInstallationTxt);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.costTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddInstallUninstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            ((System.ComponentModel.ISupportInitialize)(this.countLicensesNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label countLicensesLbl;
        private System.Windows.Forms.Label dateUninstallationLbl;
        private System.Windows.Forms.TextBox dateUninstallationTxt;
        private System.Windows.Forms.Label dateInstallationLbl;
        private System.Windows.Forms.TextBox dateInstallationTxt;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.NumericUpDown countLicensesNum;
        private System.Windows.Forms.Button exitBtn;
    }
}