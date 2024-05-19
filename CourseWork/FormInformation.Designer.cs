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
            SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(23, 58);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(507, 380);
            richTextBoxDescription.TabIndex = 0;
            richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(558, 450);
            Controls.Add(richTextBoxDescription);
            Name = "FormInformation";
            Text = "Информация";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxDescription;
    }
}