
namespace Servis
{
    partial class adminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMainForm));
            this.regButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.workLogButton = new System.Windows.Forms.Button();
            this.notifButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxClientPhoto = new System.Windows.Forms.PictureBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Blue;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(670, 321);
            this.regButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(155, 45);
            this.regButton.TabIndex = 19;
            this.regButton.Text = "Зарегистрировать";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.mainLabel.Location = new System.Drawing.Point(295, 9);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(91, 26);
            this.mainLabel.TabIndex = 18;
            this.mainLabel.Text = "Заявки";
            // 
            // workLogButton
            // 
            this.workLogButton.BackColor = System.Drawing.Color.Blue;
            this.workLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workLogButton.ForeColor = System.Drawing.Color.White;
            this.workLogButton.Location = new System.Drawing.Point(672, 191);
            this.workLogButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workLogButton.Name = "workLogButton";
            this.workLogButton.Size = new System.Drawing.Size(153, 51);
            this.workLogButton.TabIndex = 17;
            this.workLogButton.Text = "Посмотреть отчеты";
            this.workLogButton.UseVisualStyleBackColor = false;
            this.workLogButton.Click += new System.EventHandler(this.workLogButton_Click);
            // 
            // notifButton
            // 
            this.notifButton.BackColor = System.Drawing.Color.Blue;
            this.notifButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifButton.ForeColor = System.Drawing.Color.White;
            this.notifButton.Location = new System.Drawing.Point(672, 115);
            this.notifButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notifButton.Name = "notifButton";
            this.notifButton.Size = new System.Drawing.Size(153, 55);
            this.notifButton.TabIndex = 16;
            this.notifButton.Text = "Отправить уведомление клиенту";
            this.notifButton.UseVisualStyleBackColor = false;
            this.notifButton.Click += new System.EventHandler(this.notifButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 314);
            this.dataGridView1.TabIndex = 15;
            // 
            // pictureBoxClientPhoto
            // 
            this.pictureBoxClientPhoto.Location = new System.Drawing.Point(696, 9);
            this.pictureBoxClientPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxClientPhoto.Name = "pictureBoxClientPhoto";
            this.pictureBoxClientPhoto.Size = new System.Drawing.Size(110, 79);
            this.pictureBoxClientPhoto.TabIndex = 14;
            this.pictureBoxClientPhoto.TabStop = false;
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel1.Location = new System.Drawing.Point(668, 275);
            this.idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(91, 20);
            this.idLabel1.TabIndex = 22;
            this.idLabel1.Text = "ID заявки";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(672, 297);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Blue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(4, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 41);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(62, 31);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 26);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "label";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(589, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "📋";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(844, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.workLogButton);
            this.Controls.Add(this.notifButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxClientPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminMainForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button workLogButton;
        private System.Windows.Forms.Button notifButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxClientPhoto;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button1;
    }
}