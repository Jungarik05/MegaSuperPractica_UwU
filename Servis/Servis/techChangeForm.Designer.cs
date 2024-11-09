namespace Servis
{
    partial class techChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(techChangeForm));
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.reqComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.reqLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(99, 184);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(211, 21);
            this.statusComboBox.TabIndex = 24;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.mainLabel.Location = new System.Drawing.Point(94, 25);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(219, 26);
            this.mainLabel.TabIndex = 23;
            this.mainLabel.Text = "Изменение стадии";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(144, 225);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 32);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // reqComboBox
            // 
            this.reqComboBox.FormattingEnabled = true;
            this.reqComboBox.Location = new System.Drawing.Point(101, 109);
            this.reqComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.reqComboBox.Name = "reqComboBox";
            this.reqComboBox.Size = new System.Drawing.Size(211, 21);
            this.reqComboBox.TabIndex = 21;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(95, 144);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 20);
            this.statusLabel.TabIndex = 18;
            this.statusLabel.Text = "Стадия";
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reqLabel.Location = new System.Drawing.Point(95, 78);
            this.reqLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(127, 20);
            this.reqLabel.TabIndex = 17;
            this.reqLabel.Text = "Номер заявки";
            // 
            // techChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(391, 311);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reqComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.reqLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "techChangeForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox reqComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label reqLabel;
    }
}