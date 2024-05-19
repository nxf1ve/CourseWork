namespace CourseWork
{
    partial class FormHashTableInput
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
            labelInput = new Label();
            textBoxKeyToInsert = new TextBox();
            labelKeyToInsert = new Label();
            labelValueToInsert = new Label();
            labelInsert = new Label();
            labelRemove = new Label();
            textBoxKeyToRemove = new TextBox();
            labelKeyToRemove = new Label();
            buttonRemove = new Button();
            buttonInsert = new Button();
            buttonSetSize = new Button();
            maskedTextBoxInputSize = new MaskedTextBox();
            maskedTextBoxValueToInsert = new MaskedTextBox();
            label1 = new Label();
            textBoxKeyToSearch = new TextBox();
            label2 = new Label();
            buttonSearch = new Button();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 13);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(170, 15);
            labelInput.TabIndex = 1;
            labelInput.Text = "Введите размер хэш таблицы";
            // 
            // textBoxKeyToInsert
            // 
            textBoxKeyToInsert.Enabled = false;
            textBoxKeyToInsert.Location = new Point(10, 175);
            textBoxKeyToInsert.Name = "textBoxKeyToInsert";
            textBoxKeyToInsert.Size = new Size(69, 23);
            textBoxKeyToInsert.TabIndex = 2;
            // 
            // labelKeyToInsert
            // 
            labelKeyToInsert.AutoSize = true;
            labelKeyToInsert.Location = new Point(23, 157);
            labelKeyToInsert.Name = "labelKeyToInsert";
            labelKeyToInsert.Size = new Size(38, 15);
            labelKeyToInsert.TabIndex = 3;
            labelKeyToInsert.Text = "Ключ";
            // 
            // labelValueToInsert
            // 
            labelValueToInsert.AutoSize = true;
            labelValueToInsert.Location = new Point(85, 157);
            labelValueToInsert.Name = "labelValueToInsert";
            labelValueToInsert.Size = new Size(60, 15);
            labelValueToInsert.TabIndex = 5;
            labelValueToInsert.Text = "Значение";
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(23, 122);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(107, 15);
            labelInsert.TabIndex = 6;
            labelInsert.Text = "Операция вставки";
            // 
            // labelRemove
            // 
            labelRemove.AutoSize = true;
            labelRemove.Location = new Point(188, 122);
            labelRemove.Name = "labelRemove";
            labelRemove.Size = new Size(116, 15);
            labelRemove.TabIndex = 7;
            labelRemove.Text = "Операция удаления";
            // 
            // textBoxKeyToRemove
            // 
            textBoxKeyToRemove.Enabled = false;
            textBoxKeyToRemove.Location = new Point(218, 175);
            textBoxKeyToRemove.Name = "textBoxKeyToRemove";
            textBoxKeyToRemove.Size = new Size(69, 23);
            textBoxKeyToRemove.TabIndex = 8;
            // 
            // labelKeyToRemove
            // 
            labelKeyToRemove.AutoSize = true;
            labelKeyToRemove.Location = new Point(230, 157);
            labelKeyToRemove.Name = "labelKeyToRemove";
            labelKeyToRemove.Size = new Size(38, 15);
            labelKeyToRemove.TabIndex = 9;
            labelKeyToRemove.Text = "Ключ";
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(188, 222);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(116, 23);
            buttonRemove.TabIndex = 10;
            buttonRemove.Text = "Удалить элемент";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Enabled = false;
            buttonInsert.Location = new Point(23, 222);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(116, 23);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Вставить элемент";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonSetSize
            // 
            buttonSetSize.Enabled = false;
            buttonSetSize.Location = new Point(225, 31);
            buttonSetSize.Name = "buttonSetSize";
            buttonSetSize.Size = new Size(133, 23);
            buttonSetSize.TabIndex = 12;
            buttonSetSize.Text = "Задать размер";
            buttonSetSize.UseVisualStyleBackColor = true;
            buttonSetSize.Click += buttonSetSize_Click;
            // 
            // maskedTextBoxInputSize
            // 
            maskedTextBoxInputSize.Enabled = false;
            maskedTextBoxInputSize.Location = new Point(11, 32);
            maskedTextBoxInputSize.Mask = "00";
            maskedTextBoxInputSize.Name = "maskedTextBoxInputSize";
            maskedTextBoxInputSize.Size = new Size(171, 23);
            maskedTextBoxInputSize.TabIndex = 13;
            // 
            // maskedTextBoxValueToInsert
            // 
            maskedTextBoxValueToInsert.Enabled = false;
            maskedTextBoxValueToInsert.Location = new Point(85, 175);
            maskedTextBoxValueToInsert.Mask = "000";
            maskedTextBoxValueToInsert.Name = "maskedTextBoxValueToInsert";
            maskedTextBoxValueToInsert.Size = new Size(69, 23);
            maskedTextBoxValueToInsert.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 122);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 15;
            label1.Text = "Операция поиска";
            // 
            // textBoxKeyToSearch
            // 
            textBoxKeyToSearch.Enabled = false;
            textBoxKeyToSearch.Location = new Point(360, 175);
            textBoxKeyToSearch.Name = "textBoxKeyToSearch";
            textBoxKeyToSearch.Size = new Size(69, 23);
            textBoxKeyToSearch.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 157);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "Ключ";
            // 
            // buttonSearch
            // 
            buttonSearch.Enabled = false;
            buttonSearch.Location = new Point(342, 222);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(116, 23);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Найти элемент";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // FormHashTableInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(470, 266);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(textBoxKeyToSearch);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxValueToInsert);
            Controls.Add(maskedTextBoxInputSize);
            Controls.Add(buttonSetSize);
            Controls.Add(buttonInsert);
            Controls.Add(buttonRemove);
            Controls.Add(labelKeyToRemove);
            Controls.Add(textBoxKeyToRemove);
            Controls.Add(labelRemove);
            Controls.Add(labelInsert);
            Controls.Add(labelValueToInsert);
            Controls.Add(labelKeyToInsert);
            Controls.Add(textBoxKeyToInsert);
            Controls.Add(labelInput);
            Name = "FormHashTableInput";
            Text = "Форма ввода";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelInput;
        private TextBox textBoxKeyToInsert;
        private Label labelKeyToInsert;
        private Label labelValueToInsert;
        private Label labelInsert;
        private Label labelRemove;
        private TextBox textBoxKeyToRemove;
        private Label labelKeyToRemove;
        private Button buttonRemove;
        private Button buttonInsert;
        private Button buttonSetSize;
        private MaskedTextBox maskedTextBoxInputSize;
        private MaskedTextBox maskedTextBoxValueToInsert;
        private Label label1;
        private TextBox textBoxKeyToSearch;
        private Label label2;
        private Button buttonSearch;
    }
}