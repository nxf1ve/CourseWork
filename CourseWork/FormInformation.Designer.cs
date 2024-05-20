namespace CourseWork
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            richTextBoxDescription = new RichTextBox();
            label1 = new Label();
            richTextBoxUsing = new RichTextBox();
            labelUsing = new Label();
            labelHeading = new Label();
            richTextBoxProgramWorking = new RichTextBox();
            labelProgramWorking = new Label();
            SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(23, 70);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(507, 172);
            richTextBoxDescription.TabIndex = 0;
            richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Описание";
            // 
            // richTextBoxUsing
            // 
            richTextBoxUsing.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxUsing.Location = new Point(23, 272);
            richTextBoxUsing.Name = "richTextBoxUsing";
            richTextBoxUsing.ReadOnly = true;
            richTextBoxUsing.Size = new Size(507, 154);
            richTextBoxUsing.TabIndex = 2;
            richTextBoxUsing.Text = resources.GetString("richTextBoxUsing.Text");
            // 
            // labelUsing
            // 
            labelUsing.AutoSize = true;
            labelUsing.Location = new Point(23, 254);
            labelUsing.Name = "labelUsing";
            labelUsing.Size = new Size(146, 15);
            labelUsing.TabIndex = 3;
            labelUsing.Text = "Применение хэш таблиц";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.BackColor = Color.FromArgb(255, 192, 128);
            labelHeading.BorderStyle = BorderStyle.FixedSingle;
            labelHeading.Font = new Font("Times New Roman", 14.28F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeading.Location = new Point(210, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(449, 24);
            labelHeading.TabIndex = 4;
            labelHeading.Text = "Хеш-таблица: метод цепочек хэша является массив";
            // 
            // richTextBoxProgramWorking
            // 
            richTextBoxProgramWorking.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxProgramWorking.Location = new Point(588, 70);
            richTextBoxProgramWorking.Name = "richTextBoxProgramWorking";
            richTextBoxProgramWorking.Size = new Size(288, 356);
            richTextBoxProgramWorking.TabIndex = 5;
            richTextBoxProgramWorking.Text = resources.GetString("richTextBoxProgramWorking.Text");
            // 
            // labelProgramWorking
            // 
            labelProgramWorking.AutoSize = true;
            labelProgramWorking.Location = new Point(597, 52);
            labelProgramWorking.Name = "labelProgramWorking";
            labelProgramWorking.Size = new Size(175, 15);
            labelProgramWorking.TabIndex = 6;
            labelProgramWorking.Text = "Описание работы программы";
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(901, 450);
            Controls.Add(labelProgramWorking);
            Controls.Add(richTextBoxProgramWorking);
            Controls.Add(labelHeading);
            Controls.Add(labelUsing);
            Controls.Add(richTextBoxUsing);
            Controls.Add(label1);
            Controls.Add(richTextBoxDescription);
            Name = "FormInformation";
            Text = "Информация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxDescription;
        private Label label1;
        private RichTextBox richTextBoxUsing;
        private Label labelUsing;
        private Label labelHeading;
        private RichTextBox richTextBoxProgramWorking;
        private Label labelProgramWorking;
    }
}