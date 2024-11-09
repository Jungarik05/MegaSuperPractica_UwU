
namespace Servis
{
    partial class techMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(techMainForm));
            this.mainLabel = new System.Windows.Forms.Label();
            this.askPartsButton = new System.Windows.Forms.Button();
            this.createRepButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxClientPhoto = new System.Windows.Forms.PictureBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.mainLabel.Location = new System.Drawing.Point(384, 7);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(177, 32);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Мои заявки";
            // 
            // askPartsButton
            // 
            this.askPartsButton.BackColor = System.Drawing.Color.Blue;
            this.askPartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.askPartsButton.ForeColor = System.Drawing.Color.White;
            this.askPartsButton.Location = new System.Drawing.Point(944, 233);
            this.askPartsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.askPartsButton.Name = "askPartsButton";
            this.askPartsButton.Size = new System.Drawing.Size(148, 63);
            this.askPartsButton.TabIndex = 11;
            this.askPartsButton.Text = "Заказать запчасти";
            this.askPartsButton.UseVisualStyleBackColor = false;
            this.askPartsButton.Click += new System.EventHandler(this.askPartsButton_Click);
            // 
            // createRepButton
            // 
            this.createRepButton.BackColor = System.Drawing.Color.Blue;
            this.createRepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.createRepButton.ForeColor = System.Drawing.Color.White;
            this.createRepButton.Location = new System.Drawing.Point(944, 162);
            this.createRepButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createRepButton.Name = "createRepButton";
            this.createRepButton.Size = new System.Drawing.Size(148, 64);
            this.createRepButton.TabIndex = 9;
            this.createRepButton.Text = "Составить отчет";
            this.createRepButton.UseVisualStyleBackColor = false;
            this.createRepButton.Click += new System.EventHandler(this.createRepButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 386);
            this.dataGridView1.TabIndex = 8;
            // 
            // pictureBoxClientPhoto
            // 
            this.pictureBoxClientPhoto.Location = new System.Drawing.Point(945, 18);
            this.pictureBoxClientPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClientPhoto.Name = "pictureBoxClientPhoto";
            this.pictureBoxClientPhoto.Size = new System.Drawing.Size(133, 97);
            this.pictureBoxClientPhoto.TabIndex = 7;
            this.pictureBoxClientPhoto.TabStop = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Blue;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(945, 385);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(148, 63);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Изменить стадию заявки";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Blue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(4, 7);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 50);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // techMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1107, 498);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.askPartsButton);
            this.Controls.Add(this.createRepButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxClientPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "techMainForm";
            this.Text = "Сервис по ремонту \"Вадыка пылесосов\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button askPartsButton;
        private System.Windows.Forms.Button createRepButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxClientPhoto;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button backButton;
    }
}