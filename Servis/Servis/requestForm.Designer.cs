
namespace Servis
{
    partial class requestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.problemLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.problemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.techComboBox = new System.Windows.Forms.ComboBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.typeLabel.Location = new System.Drawing.Point(77, 71);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(138, 25);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Тип техники";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modelLabel.Location = new System.Drawing.Point(77, 152);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(90, 25);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Модель";
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.problemLabel.Location = new System.Drawing.Point(79, 252);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(222, 25);
            this.problemLabel.TabIndex = 2;
            this.problemLabel.Text = "Описание проблемы";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(83, 191);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(281, 22);
            this.modelTextBox.TabIndex = 3;
            // 
            // problemRichTextBox
            // 
            this.problemRichTextBox.Location = new System.Drawing.Point(85, 296);
            this.problemRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemRichTextBox.Name = "problemRichTextBox";
            this.problemRichTextBox.Size = new System.Drawing.Size(281, 96);
            this.problemRichTextBox.TabIndex = 4;
            this.problemRichTextBox.Text = "";
            // 
            // techComboBox
            // 
            this.techComboBox.FormattingEnabled = true;
            this.techComboBox.Location = new System.Drawing.Point(85, 109);
            this.techComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.techComboBox.Name = "techComboBox";
            this.techComboBox.Size = new System.Drawing.Size(280, 24);
            this.techComboBox.TabIndex = 5;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.requestLabel.Location = new System.Drawing.Point(40, 11);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(24, 32);
            this.requestLabel.TabIndex = 6;
            this.requestLabel.Text = "/";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(148, 414);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 39);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // requestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(443, 477);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.techComboBox);
            this.Controls.Add(this.problemRichTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.typeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "requestForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.RichTextBox problemRichTextBox;
        private System.Windows.Forms.ComboBox techComboBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Button saveButton;
    }
}