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
            buttonInsert = new Button();
            buttonRemove = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            Инструменты = new GroupBox();
            menuStrip1.SuspendLayout();
            Инструменты.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsert.Location = new Point(18, 59);
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
            buttonRemove.Location = new Point(18, 21);
            buttonRemove.Margin = new Padding(2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(78, 23);
            buttonRemove.TabIndex = 32;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, InfoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(180, 22);
            LoadToolStripMenuItem.Text = "Загрузить";
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new Size(93, 20);
            InfoToolStripMenuItem.Text = "Информация";
            // 
            // Инструменты
            // 
            Инструменты.Controls.Add(buttonInsert);
            Инструменты.Controls.Add(buttonRemove);
            Инструменты.Dock = DockStyle.Right;
            Инструменты.Location = new Point(600, 24);
            Инструменты.Name = "Инструменты";
            Инструменты.Size = new Size(200, 426);
            Инструменты.TabIndex = 34;
            Инструменты.TabStop = false;
            Инструменты.Text = "Инструменты";
            // 
            // FormHashTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(Инструменты);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormHashTable";
            Text = "HashTable";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Инструменты.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonInsert;
        private Button buttonRemove;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private GroupBox Инструменты;
    }
}
