
namespace Servis
{
    partial class clientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.pictureBoxClientPhoto = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.QRpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClientPhoto
            // 
            this.pictureBoxClientPhoto.Location = new System.Drawing.Point(698, 10);
            this.pictureBoxClientPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxClientPhoto.Name = "pictureBoxClientPhoto";
            this.pictureBoxClientPhoto.Size = new System.Drawing.Size(75, 79);
            this.pictureBoxClientPhoto.TabIndex = 0;
            this.pictureBoxClientPhoto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 314);
            this.dataGridView1.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Blue;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(698, 329);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 27);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(697, 249);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Blue;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(697, 279);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(101, 28);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.mainLabel.Location = new System.Drawing.Point(252, 1);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(140, 26);
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "Мои заявки";
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel1.Location = new System.Drawing.Point(693, 218);
            this.idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(91, 20);
            this.idLabel1.TabIndex = 6;
            this.idLabel1.Text = "ID заявки";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Blue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(53, 41);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // QRpictureBox
            // 
            this.QRpictureBox.Location = new System.Drawing.Point(697, 128);
            this.QRpictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.QRpictureBox.Name = "QRpictureBox";
            this.QRpictureBox.Size = new System.Drawing.Size(75, 79);
            this.QRpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRpictureBox.TabIndex = 25;
            this.QRpictureBox.TabStop = false;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(810, 366);
            this.Controls.Add(this.QRpictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxClientPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clientForm";
            this.Text = "Сервис  по ремонту \"Владыка пылесосов\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClientPhoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox QRpictureBox;
    }
}