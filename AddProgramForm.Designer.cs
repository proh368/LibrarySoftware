namespace LibrarySoftware
{
    partial class AddProgramForm
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
            this.costLicenseNum = new System.Windows.Forms.NumericUpDown();
            this.costLicenseLbl = new System.Windows.Forms.Label();
            this.applicationAreaLbl = new System.Windows.Forms.Label();
            this.applicationAreaTxt = new System.Windows.Forms.TextBox();
            this.releaseLbl = new System.Windows.Forms.Label();
            this.releaseTxt = new System.Windows.Forms.TextBox();
            this.firmLbl = new System.Windows.Forms.Label();
            this.firmTxt = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.versionLbl = new System.Windows.Forms.Label();
            this.versionTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.costLicenseNum)).BeginInit();
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
            this.addBtn.TabIndex = 47;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // costLicenseNum
            // 
            this.costLicenseNum.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.costLicenseNum.Location = new System.Drawing.Point(16, 218);
            this.costLicenseNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costLicenseNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.costLicenseNum.Name = "costLicenseNum";
            this.costLicenseNum.Size = new System.Drawing.Size(197, 32);
            this.costLicenseNum.TabIndex = 46;
            this.costLicenseNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // costLicenseLbl
            // 
            this.costLicenseLbl.AutoSize = true;
            this.costLicenseLbl.BackColor = System.Drawing.Color.Transparent;
            this.costLicenseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLicenseLbl.Location = new System.Drawing.Point(12, 192);
            this.costLicenseLbl.Name = "costLicenseLbl";
            this.costLicenseLbl.Size = new System.Drawing.Size(201, 23);
            this.costLicenseLbl.TabIndex = 45;
            this.costLicenseLbl.Text = "Стоимость лицензии:";
            // 
            // applicationAreaLbl
            // 
            this.applicationAreaLbl.AutoSize = true;
            this.applicationAreaLbl.BackColor = System.Drawing.Color.Transparent;
            this.applicationAreaLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicationAreaLbl.Location = new System.Drawing.Point(228, 131);
            this.applicationAreaLbl.Name = "applicationAreaLbl";
            this.applicationAreaLbl.Size = new System.Drawing.Size(195, 23);
            this.applicationAreaLbl.TabIndex = 44;
            this.applicationAreaLbl.Text = "Прикладная область:";
            // 
            // applicationAreaTxt
            // 
            this.applicationAreaTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.applicationAreaTxt.Location = new System.Drawing.Point(232, 157);
            this.applicationAreaTxt.Name = "applicationAreaTxt";
            this.applicationAreaTxt.Size = new System.Drawing.Size(210, 32);
            this.applicationAreaTxt.TabIndex = 43;
            // 
            // releaseLbl
            // 
            this.releaseLbl.AutoSize = true;
            this.releaseLbl.BackColor = System.Drawing.Color.Transparent;
            this.releaseLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseLbl.Location = new System.Drawing.Point(12, 131);
            this.releaseLbl.Name = "releaseLbl";
            this.releaseLbl.Size = new System.Drawing.Size(133, 23);
            this.releaseLbl.TabIndex = 42;
            this.releaseLbl.Text = "Дата выпуска:";
            // 
            // releaseTxt
            // 
            this.releaseTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.releaseTxt.Location = new System.Drawing.Point(16, 157);
            this.releaseTxt.Name = "releaseTxt";
            this.releaseTxt.Size = new System.Drawing.Size(210, 32);
            this.releaseTxt.TabIndex = 41;
            // 
            // firmLbl
            // 
            this.firmLbl.AutoSize = true;
            this.firmLbl.BackColor = System.Drawing.Color.Transparent;
            this.firmLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firmLbl.Location = new System.Drawing.Point(228, 70);
            this.firmLbl.Name = "firmLbl";
            this.firmLbl.Size = new System.Drawing.Size(76, 23);
            this.firmLbl.TabIndex = 40;
            this.firmLbl.Text = "Фирма:";
            // 
            // firmTxt
            // 
            this.firmTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.firmTxt.Location = new System.Drawing.Point(232, 96);
            this.firmTxt.Name = "firmTxt";
            this.firmTxt.Size = new System.Drawing.Size(210, 32);
            this.firmTxt.TabIndex = 39;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.BackColor = System.Drawing.Color.Transparent;
            this.typeLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLbl.Location = new System.Drawing.Point(12, 70);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(49, 23);
            this.typeLbl.TabIndex = 38;
            this.typeLbl.Text = "Тип:";
            // 
            // typeTxt
            // 
            this.typeTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.typeTxt.Location = new System.Drawing.Point(16, 96);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(210, 32);
            this.typeTxt.TabIndex = 37;
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.BackColor = System.Drawing.Color.Transparent;
            this.versionLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLbl.Location = new System.Drawing.Point(228, 9);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(79, 23);
            this.versionLbl.TabIndex = 36;
            this.versionLbl.Text = "Версия:";
            // 
            // versionTxt
            // 
            this.versionTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.versionTxt.Location = new System.Drawing.Point(232, 35);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.Size = new System.Drawing.Size(210, 32);
            this.versionTxt.TabIndex = 35;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(98, 23);
            this.nameLbl.TabIndex = 34;
            this.nameLbl.Text = "Название:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.nameTxt.Location = new System.Drawing.Point(16, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(210, 32);
            this.nameTxt.TabIndex = 33;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.exitBtn.Location = new System.Drawing.Point(12, 302);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 47);
            this.exitBtn.TabIndex = 64;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.costLicenseNum);
            this.Controls.Add(this.costLicenseLbl);
            this.Controls.Add(this.applicationAreaLbl);
            this.Controls.Add(this.applicationAreaTxt);
            this.Controls.Add(this.releaseLbl);
            this.Controls.Add(this.releaseTxt);
            this.Controls.Add(this.firmLbl);
            this.Controls.Add(this.firmTxt);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.versionTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            ((System.ComponentModel.ISupportInitialize)(this.costLicenseNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown costLicenseNum;
        private System.Windows.Forms.Label costLicenseLbl;
        private System.Windows.Forms.Label applicationAreaLbl;
        private System.Windows.Forms.TextBox applicationAreaTxt;
        private System.Windows.Forms.Label releaseLbl;
        private System.Windows.Forms.TextBox releaseTxt;
        private System.Windows.Forms.Label firmLbl;
        private System.Windows.Forms.TextBox firmTxt;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.TextBox versionTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button exitBtn;
    }
}