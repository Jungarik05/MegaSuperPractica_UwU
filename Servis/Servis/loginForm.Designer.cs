
namespace Servis
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.enterButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.pasTextBox = new System.Windows.Forms.TextBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.toRegLabel = new System.Windows.Forms.Label();
            this.visibleButton = new System.Windows.Forms.Button();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.refButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Blue;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(124, 176);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(97, 36);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(78, 76);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(192, 20);
            this.logTextBox.TabIndex = 1;
            // 
            // pasTextBox
            // 
            this.pasTextBox.Location = new System.Drawing.Point(78, 139);
            this.pasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pasTextBox.Name = "pasTextBox";
            this.pasTextBox.PasswordChar = '*';
            this.pasTextBox.Size = new System.Drawing.Size(192, 20);
            this.pasTextBox.TabIndex = 2;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(115, 7);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(156, 26);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Авторизация";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(76, 46);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(60, 20);
            this.logLabel.TabIndex = 4;
            this.logLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(76, 108);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль";
            // 
            // toRegLabel
            // 
            this.toRegLabel.AutoSize = true;
            this.toRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRegLabel.ForeColor = System.Drawing.Color.Blue;
            this.toRegLabel.Location = new System.Drawing.Point(39, 214);
            this.toRegLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toRegLabel.Name = "toRegLabel";
            this.toRegLabel.Size = new System.Drawing.Size(294, 17);
            this.toRegLabel.TabIndex = 6;
            this.toRegLabel.Text = "Нет аккаунта? Давайте зарегистрируемся!";
            this.toRegLabel.Click += new System.EventHandler(this.toRegLabel_Click);
            // 
            // visibleButton
            // 
            this.visibleButton.BackColor = System.Drawing.Color.Aqua;
            this.visibleButton.FlatAppearance.BorderSize = 0;
            this.visibleButton.Location = new System.Drawing.Point(280, 136);
            this.visibleButton.Margin = new System.Windows.Forms.Padding(0);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(20, 24);
            this.visibleButton.TabIndex = 7;
            this.visibleButton.Text = "👁";
            this.visibleButton.UseVisualStyleBackColor = false;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(344, 46);
            this.pictureBoxCaptcha.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(106, 41);
            this.pictureBoxCaptcha.TabIndex = 8;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(344, 108);
            this.captchaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(107, 20);
            this.captchaTextBox.TabIndex = 9;
            // 
            // refButton
            // 
            this.refButton.BackColor = System.Drawing.Color.Blue;
            this.refButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refButton.ForeColor = System.Drawing.Color.White;
            this.refButton.Location = new System.Drawing.Point(344, 131);
            this.refButton.Margin = new System.Windows.Forms.Padding(2);
            this.refButton.Name = "refButton";
            this.refButton.Size = new System.Drawing.Size(106, 30);
            this.refButton.TabIndex = 10;
            this.refButton.Text = "Обновить";
            this.refButton.UseVisualStyleBackColor = false;
            this.refButton.Click += new System.EventHandler(this.refButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(335, 251);
            this.Controls.Add(this.refButton);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.visibleButton);
            this.Controls.Add(this.toRegLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.pasTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.enterButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.Text = "Сервис  по ремонту \"Владыка пылесосов\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox pasTextBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label toRegLabel;
        private System.Windows.Forms.Button visibleButton;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Button refButton;
    }
}

