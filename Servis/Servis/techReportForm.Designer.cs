
namespace Servis
{
    partial class techReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(techReportForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.reqComboBox = new System.Windows.Forms.ComboBox();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.workLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.reqLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.partComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(130, 256);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 32);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // reqComboBox
            // 
            this.reqComboBox.FormattingEnabled = true;
            this.reqComboBox.Location = new System.Drawing.Point(73, 89);
            this.reqComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reqComboBox.Name = "reqComboBox";
            this.reqComboBox.Size = new System.Drawing.Size(211, 21);
            this.reqComboBox.TabIndex = 13;
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Location = new System.Drawing.Point(73, 161);
            this.noteRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(212, 79);
            this.noteRichTextBox.TabIndex = 12;
            this.noteRichTextBox.Text = "";
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.workLabel.Location = new System.Drawing.Point(69, 130);
            this.workLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(158, 20);
            this.workLabel.TabIndex = 10;
            this.workLabel.Text = "Описание работы";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modelLabel.Location = new System.Drawing.Point(252, 311);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(73, 20);
            this.modelLabel.TabIndex = 9;
            this.modelLabel.Text = "Деталь";
            this.modelLabel.Visible = false;
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reqLabel.Location = new System.Drawing.Point(67, 58);
            this.reqLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(127, 20);
            this.reqLabel.TabIndex = 8;
            this.reqLabel.Text = "Номер заявки";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.requestLabel.Location = new System.Drawing.Point(147, 22);
            this.requestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(78, 26);
            this.requestLabel.TabIndex = 15;
            this.requestLabel.Text = "Отчет";
            // 
            // partComboBox
            // 
            this.partComboBox.FormattingEnabled = true;
            this.partComboBox.Location = new System.Drawing.Point(256, 351);
            this.partComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partComboBox.Name = "partComboBox";
            this.partComboBox.Size = new System.Drawing.Size(211, 21);
            this.partComboBox.TabIndex = 16;
            this.partComboBox.Visible = false;
            // 
            // techReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(363, 307);
            this.Controls.Add(this.partComboBox);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reqComboBox);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.reqLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "techReportForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox reqComboBox;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label reqLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.ComboBox partComboBox;
    }
}