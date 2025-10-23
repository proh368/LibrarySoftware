namespace LibrarySoftware
{
    partial class LogForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.logBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(107, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(164, 73);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Вход";
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.loginTxt.Location = new System.Drawing.Point(86, 139);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(210, 32);
            this.loginTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.passwordTxt.Location = new System.Drawing.Point(86, 200);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(210, 32);
            this.passwordTxt.TabIndex = 2;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(82, 113);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(71, 23);
            this.loginLbl.TabIndex = 3;
            this.loginLbl.Text = "Логин:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLbl.Location = new System.Drawing.Point(82, 174);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(81, 23);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Пароль:";
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBtn.Location = new System.Drawing.Point(103, 238);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(182, 47);
            this.logBtn.TabIndex = 5;
            this.logBtn.Text = "Войти";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.LightGreen;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBtn.Location = new System.Drawing.Point(103, 291);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(182, 47);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Регистрация";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Crimson;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(336, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 31);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Х";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarySoftware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

