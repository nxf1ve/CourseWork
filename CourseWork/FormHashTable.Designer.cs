namespace CourseWork
{
    partial class FormHashTable
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEnterElement = new Label();
            inputKeyTextBox = new TextBox();
            buttonInsert = new Button();
            buttonRemove = new Button();
            dataGridView = new DataGridView();
            Hash = new DataGridViewTextBoxColumn();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            inputValueTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelEnterElement
            // 
            labelEnterElement.AutoSize = true;
            labelEnterElement.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnterElement.Location = new Point(31, 34);
            labelEnterElement.Margin = new Padding(2, 0, 2, 0);
            labelEnterElement.Name = "labelEnterElement";
            labelEnterElement.Size = new Size(124, 17);
            labelEnterElement.TabIndex = 29;
            labelEnterElement.Text = "Enter the element:";
            // 
            // inputKeyTextBox
            // 
            inputKeyTextBox.BackColor = SystemColors.Window;
            inputKeyTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputKeyTextBox.ForeColor = SystemColors.WindowText;
            inputKeyTextBox.Location = new Point(159, 34);
            inputKeyTextBox.Margin = new Padding(2);
            inputKeyTextBox.MaxLength = 3;
            inputKeyTextBox.Name = "inputKeyTextBox";
            inputKeyTextBox.Size = new Size(36, 23);
            inputKeyTextBox.TabIndex = 30;
            inputKeyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsert.Location = new Point(273, 34);
            buttonInsert.Margin = new Padding(2);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(78, 23);
            buttonInsert.TabIndex = 31;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemove.Location = new Point(402, 34);
            buttonRemove.Margin = new Padding(2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(78, 23);
            buttonRemove.TabIndex = 32;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Hash, Key, Value });
            dataGridView.Location = new Point(31, 87);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(460, 164);
            dataGridView.TabIndex = 65;
            // 
            // Hash
            // 
            Hash.HeaderText = "Hash";
            Hash.Name = "Hash";
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.Name = "Key";
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // inputValueTextBox
            // 
            inputValueTextBox.BackColor = SystemColors.Window;
            inputValueTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueTextBox.ForeColor = SystemColors.WindowText;
            inputValueTextBox.Location = new Point(211, 34);
            inputValueTextBox.Margin = new Padding(2);
            inputValueTextBox.MaxLength = 3;
            inputValueTextBox.Name = "inputValueTextBox";
            inputValueTextBox.Size = new Size(36, 23);
            inputValueTextBox.TabIndex = 66;
            inputValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FormHashTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(inputValueTextBox);
            Controls.Add(dataGridView);
            Controls.Add(buttonRemove);
            Controls.Add(buttonInsert);
            Controls.Add(inputKeyTextBox);
            Controls.Add(labelEnterElement);
            Name = "FormHashTable";
            Text = "HashTable";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnterElement;
        private TextBox inputKeyTextBox;
        private Button buttonInsert;
        private Button buttonRemove;
        private DataGridView dataGridView;
        private TextBox inputValueTextBox;
        private DataGridViewTextBoxColumn Hash;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
    }
}
