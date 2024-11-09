
namespace Servis
{
    partial class techAskPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(techAskPartsForm));
            this.partComboBox = new System.Windows.Forms.ComboBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.reqComboBox = new System.Windows.Forms.ComboBox();
            this.partLabel = new System.Windows.Forms.Label();
            this.reqLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partComboBox
            // 
            this.partComboBox.FormattingEnabled = true;
            this.partComboBox.Location = new System.Drawing.Point(109, 212);
            this.partComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partComboBox.Name = "partComboBox";
            this.partComboBox.Size = new System.Drawing.Size(280, 24);
            this.partComboBox.TabIndex = 24;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.requestLabel.Location = new System.Drawing.Point(133, 30);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(224, 32);
            this.requestLabel.TabIndex = 23;
            this.requestLabel.Text = "Запрос детали";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Blue;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(169, 263);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(153, 39);
            this.sendButton.TabIndex = 22;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // reqComboBox
            // 
            this.reqComboBox.FormattingEnabled = true;
            this.reqComboBox.Location = new System.Drawing.Point(109, 130);
            this.reqComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reqComboBox.Name = "reqComboBox";
            this.reqComboBox.Size = new System.Drawing.Size(280, 24);
            this.reqComboBox.TabIndex = 21;
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.partLabel.Location = new System.Drawing.Point(101, 174);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(90, 25);
            this.partLabel.TabIndex = 18;
            this.partLabel.Text = "Деталь";
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reqLabel.Location = new System.Drawing.Point(101, 94);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(155, 25);
            this.reqLabel.TabIndex = 17;
            this.reqLabel.Text = "Номер заявки";
            // 
            // techAskPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(509, 359);
            this.Controls.Add(this.partComboBox);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.reqComboBox);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.reqLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "techAskPartsForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox partComboBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox reqComboBox;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label reqLabel;
    }
}