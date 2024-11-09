
namespace Servis
{
    partial class adminRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminRequestForm));
            this.IDTechComboBox = new System.Windows.Forms.ComboBox();
            this.IDTechLabel = new System.Windows.Forms.Label();
            this.IDClientComboBox = new System.Windows.Forms.ComboBox();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.techComboBox = new System.Windows.Forms.ComboBox();
            this.problemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.problemLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDTechComboBox
            // 
            this.IDTechComboBox.FormattingEnabled = true;
            this.IDTechComboBox.Location = new System.Drawing.Point(43, 130);
            this.IDTechComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDTechComboBox.Name = "IDTechComboBox";
            this.IDTechComboBox.Size = new System.Drawing.Size(211, 21);
            this.IDTechComboBox.TabIndex = 22;
            // 
            // IDTechLabel
            // 
            this.IDTechLabel.AutoSize = true;
            this.IDTechLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.IDTechLabel.Location = new System.Drawing.Point(43, 98);
            this.IDTechLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDTechLabel.Name = "IDTechLabel";
            this.IDTechLabel.Size = new System.Drawing.Size(100, 20);
            this.IDTechLabel.TabIndex = 21;
            this.IDTechLabel.Text = "ID техника";
            // 
            // IDClientComboBox
            // 
            this.IDClientComboBox.FormattingEnabled = true;
            this.IDClientComboBox.Location = new System.Drawing.Point(45, 68);
            this.IDClientComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDClientComboBox.Name = "IDClientComboBox";
            this.IDClientComboBox.Size = new System.Drawing.Size(211, 21);
            this.IDClientComboBox.TabIndex = 20;
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.idClientLabel.Location = new System.Drawing.Point(39, 37);
            this.idClientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(103, 20);
            this.idClientLabel.TabIndex = 19;
            this.idClientLabel.Text = "ID клиента";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(19, 462);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 32);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // techComboBox
            // 
            this.techComboBox.FormattingEnabled = true;
            this.techComboBox.Location = new System.Drawing.Point(45, 201);
            this.techComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.techComboBox.Name = "techComboBox";
            this.techComboBox.Size = new System.Drawing.Size(211, 21);
            this.techComboBox.TabIndex = 17;
            // 
            // problemRichTextBox
            // 
            this.problemRichTextBox.Location = new System.Drawing.Point(45, 353);
            this.problemRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.problemRichTextBox.Name = "problemRichTextBox";
            this.problemRichTextBox.Size = new System.Drawing.Size(212, 79);
            this.problemRichTextBox.TabIndex = 16;
            this.problemRichTextBox.Text = "";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(44, 267);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(212, 20);
            this.modelTextBox.TabIndex = 15;
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.problemLabel.Location = new System.Drawing.Point(40, 317);
            this.problemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(181, 20);
            this.problemLabel.TabIndex = 14;
            this.problemLabel.Text = "Описание проблемы";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modelLabel.Location = new System.Drawing.Point(39, 236);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(76, 20);
            this.modelLabel.TabIndex = 13;
            this.modelLabel.Text = "Модель";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.typeLabel.Location = new System.Drawing.Point(39, 170);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(111, 20);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "Тип техники";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.requestLabel.Location = new System.Drawing.Point(27, 7);
            this.requestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(278, 26);
            this.requestLabel.TabIndex = 23;
            this.requestLabel.Text = "Редактирование заявки";
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.Blue;
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(178, 462);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(115, 32);
            this.finishButton.TabIndex = 24;
            this.finishButton.Text = "Закрыть";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // adminRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(312, 518);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.IDTechComboBox);
            this.Controls.Add(this.IDTechLabel);
            this.Controls.Add(this.IDClientComboBox);
            this.Controls.Add(this.idClientLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.techComboBox);
            this.Controls.Add(this.problemRichTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.typeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminRequestForm";
            this.Text = "Сервис по ремонту \"Владыка пылесосов\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDTechComboBox;
        private System.Windows.Forms.Label IDTechLabel;
        private System.Windows.Forms.ComboBox IDClientComboBox;
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox techComboBox;
        private System.Windows.Forms.RichTextBox problemRichTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Button finishButton;
    }
}