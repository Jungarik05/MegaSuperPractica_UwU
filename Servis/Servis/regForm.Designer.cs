
namespace Servis
{
    partial class regForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regForm));
            this.toLogLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.pasTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.pasTextBox2 = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toLogLabel
            // 
            this.toLogLabel.AutoSize = true;
            this.toLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLogLabel.ForeColor = System.Drawing.Color.Blue;
            this.toLogLabel.Location = new System.Drawing.Point(79, 342);
            this.toLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toLogLabel.Name = "toLogLabel";
            this.toLogLabel.Size = new System.Drawing.Size(212, 17);
            this.toLogLabel.TabIndex = 13;
            this.toLogLabel.Text = "У вас уже есть аккаунт? Войти";
            this.toLogLabel.Click += new System.EventHandler(this.toLogLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(80, 119);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Пароль";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(80, 58);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(60, 20);
            this.logLabel.TabIndex = 11;
            this.logLabel.Text = "Логин";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(112, 19);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(152, 26);
            this.mainLabel.TabIndex = 10;
            this.mainLabel.Text = "Регистрация";
            // 
            // pasTextBox
            // 
            this.pasTextBox.Location = new System.Drawing.Point(82, 150);
            this.pasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pasTextBox.Name = "pasTextBox";
            this.pasTextBox.Size = new System.Drawing.Size(192, 20);
            this.pasTextBox.TabIndex = 9;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(82, 88);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(192, 20);
            this.logTextBox.TabIndex = 8;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Blue;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(82, 304);
            this.regButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(198, 36);
            this.regButton.TabIndex = 7;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel2.Location = new System.Drawing.Point(80, 177);
            this.passwordLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(192, 20);
            this.passwordLabel2.TabIndex = 15;
            this.passwordLabel2.Text = "Подтвердите пароль";
            // 
            // pasTextBox2
            // 
            this.pasTextBox2.Location = new System.Drawing.Point(82, 208);
            this.pasTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pasTextBox2.Name = "pasTextBox2";
            this.pasTextBox2.Size = new System.Drawing.Size(192, 20);
            this.pasTextBox2.TabIndex = 14;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(80, 233);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(156, 20);
            this.phoneLabel.TabIndex = 17;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(82, 264);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(192, 20);
            this.phoneTextBox.TabIndex = 16;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(341, 379);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.pasTextBox2);
            this.Controls.Add(this.toLogLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.pasTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.regButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toLogLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox pasTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox pasTextBox2;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}