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
            Инструменты = new GroupBox();
            textBoxTotalSteps = new TextBox();
            textBoxStep = new TextBox();
            panelHash = new Panel();
            labelBucket = new Label();
            textBoxBucket = new TextBox();
            labelEqually = new Label();
            labelDivide = new Label();
            labelSize = new Label();
            labelKeyHash = new Label();
            labelHash = new Label();
            textBoxSize = new TextBox();
            textBoxKeyToDivide = new TextBox();
            textBoxKey = new TextBox();
            buttonInfo = new Button();
            buttonSetSize = new Button();
            buttonStepBack = new Button();
            buttonStepForward = new Button();
            pictureBox = new PictureBox();
            labelCurrentStep = new Label();
            labelTotalSteps = new Label();
            menuStrip1.SuspendLayout();
            Инструменты.SuspendLayout();
            panelHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Enabled = false;
            buttonInsert.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsert.Location = new Point(5, 74);
            buttonInsert.Margin = new Padding(2);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(190, 23);
            buttonInsert.TabIndex = 31;
            buttonInsert.Text = "Вставить элемент";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemove.Location = new Point(5, 101);
            buttonRemove.Margin = new Padding(2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(190, 23);
            buttonRemove.TabIndex = 32;
            buttonRemove.Text = "Удалить элемент";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 24);
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
            SaveToolStripMenuItem.Size = new Size(133, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(133, 22);
            LoadToolStripMenuItem.Text = "Загрузить";
            // 
            // Инструменты
            // 
            Инструменты.BackColor = SystemColors.ButtonFace;
            Инструменты.Controls.Add(labelTotalSteps);
            Инструменты.Controls.Add(labelCurrentStep);
            Инструменты.Controls.Add(textBoxTotalSteps);
            Инструменты.Controls.Add(textBoxStep);
            Инструменты.Controls.Add(panelHash);
            Инструменты.Controls.Add(buttonInfo);
            Инструменты.Controls.Add(buttonSetSize);
            Инструменты.Controls.Add(buttonStepBack);
            Инструменты.Controls.Add(buttonStepForward);
            Инструменты.Controls.Add(buttonInsert);
            Инструменты.Controls.Add(buttonRemove);
            Инструменты.Dock = DockStyle.Right;
            Инструменты.Location = new Point(769, 24);
            Инструменты.Name = "Инструменты";
            Инструменты.Size = new Size(200, 559);
            Инструменты.TabIndex = 34;
            Инструменты.TabStop = false;
            Инструменты.Text = "Инструменты";
            // 
            // textBoxTotalSteps
            // 
            textBoxTotalSteps.BackColor = SystemColors.ButtonHighlight;
            textBoxTotalSteps.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotalSteps.ImeMode = ImeMode.NoControl;
            textBoxTotalSteps.Location = new Point(106, 198);
            textBoxTotalSteps.Name = "textBoxTotalSteps";
            textBoxTotalSteps.ReadOnly = true;
            textBoxTotalSteps.Size = new Size(75, 23);
            textBoxTotalSteps.TabIndex = 38;
            // 
            // textBoxStep
            // 
            textBoxStep.BackColor = SystemColors.ButtonHighlight;
            textBoxStep.BorderStyle = BorderStyle.FixedSingle;
            textBoxStep.ImeMode = ImeMode.NoControl;
            textBoxStep.Location = new Point(20, 198);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.ReadOnly = true;
            textBoxStep.Size = new Size(75, 23);
            textBoxStep.TabIndex = 10;
            // 
            // panelHash
            // 
            panelHash.BackColor = SystemColors.ControlDark;
            panelHash.Controls.Add(labelBucket);
            panelHash.Controls.Add(textBoxBucket);
            panelHash.Controls.Add(labelEqually);
            panelHash.Controls.Add(labelDivide);
            panelHash.Controls.Add(labelSize);
            panelHash.Controls.Add(labelKeyHash);
            panelHash.Controls.Add(labelHash);
            panelHash.Controls.Add(textBoxSize);
            panelHash.Controls.Add(textBoxKeyToDivide);
            panelHash.Controls.Add(textBoxKey);
            panelHash.Location = new Point(5, 393);
            panelHash.Name = "panelHash";
            panelHash.Size = new Size(190, 160);
            panelHash.TabIndex = 37;
            // 
            // labelBucket
            // 
            labelBucket.AutoSize = true;
            labelBucket.Location = new Point(57, 104);
            labelBucket.Name = "labelBucket";
            labelBucket.Size = new Size(71, 15);
            labelBucket.TabIndex = 9;
            labelBucket.Text = "№ корзины";
            // 
            // textBoxBucket
            // 
            textBoxBucket.ImeMode = ImeMode.NoControl;
            textBoxBucket.Location = new Point(53, 122);
            textBoxBucket.Name = "textBoxBucket";
            textBoxBucket.ReadOnly = true;
            textBoxBucket.Size = new Size(75, 23);
            textBoxBucket.TabIndex = 8;
            // 
            // labelEqually
            // 
            labelEqually.AutoSize = true;
            labelEqually.Location = new Point(15, 125);
            labelEqually.Name = "labelEqually";
            labelEqually.Size = new Size(15, 15);
            labelEqually.TabIndex = 7;
            labelEqually.Text = "=";
            // 
            // labelDivide
            // 
            labelDivide.AutoSize = true;
            labelDivide.Location = new Point(85, 72);
            labelDivide.Name = "labelDivide";
            labelDivide.Size = new Size(17, 15);
            labelDivide.TabIndex = 6;
            labelDivide.Text = "%";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(120, 52);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(47, 15);
            labelSize.TabIndex = 5;
            labelSize.Text = "Размер";
            // 
            // labelKeyHash
            // 
            labelKeyHash.AutoSize = true;
            labelKeyHash.Location = new Point(15, 52);
            labelKeyHash.Name = "labelKeyHash";
            labelKeyHash.Size = new Size(53, 15);
            labelKeyHash.TabIndex = 4;
            labelKeyHash.Text = "Хеш код";
            // 
            // labelHash
            // 
            labelHash.AutoSize = true;
            labelHash.Location = new Point(5, 8);
            labelHash.Name = "labelHash";
            labelHash.Size = new Size(171, 15);
            labelHash.TabIndex = 3;
            labelHash.Text = "Высчитываем хеш код ключа";
            // 
            // textBoxSize
            // 
            textBoxSize.ImeMode = ImeMode.NoControl;
            textBoxSize.Location = new Point(108, 69);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.ReadOnly = true;
            textBoxSize.Size = new Size(75, 23);
            textBoxSize.TabIndex = 2;
            // 
            // textBoxKeyToDivide
            // 
            textBoxKeyToDivide.ImeMode = ImeMode.NoControl;
            textBoxKeyToDivide.Location = new Point(5, 69);
            textBoxKeyToDivide.Name = "textBoxKeyToDivide";
            textBoxKeyToDivide.ReadOnly = true;
            textBoxKeyToDivide.Size = new Size(75, 23);
            textBoxKeyToDivide.TabIndex = 1;
            // 
            // textBoxKey
            // 
            textBoxKey.ImeMode = ImeMode.NoControl;
            textBoxKey.Location = new Point(3, 26);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.ReadOnly = true;
            textBoxKey.Size = new Size(180, 23);
            textBoxKey.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInfo.Location = new Point(5, 327);
            buttonInfo.Margin = new Padding(2);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(190, 39);
            buttonInfo.TabIndex = 36;
            buttonInfo.Text = "Информация";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSetSize
            // 
            buttonSetSize.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetSize.Location = new Point(5, 31);
            buttonSetSize.Margin = new Padding(2);
            buttonSetSize.Name = "buttonSetSize";
            buttonSetSize.Size = new Size(190, 23);
            buttonSetSize.TabIndex = 35;
            buttonSetSize.Text = "Задать размер таблицы";
            buttonSetSize.UseVisualStyleBackColor = true;
            buttonSetSize.Click += buttonSetSize_Click;
            // 
            // buttonStepBack
            // 
            buttonStepBack.Enabled = false;
            buttonStepBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStepBack.Location = new Point(5, 240);
            buttonStepBack.Margin = new Padding(2);
            buttonStepBack.Name = "buttonStepBack";
            buttonStepBack.Size = new Size(190, 23);
            buttonStepBack.TabIndex = 34;
            buttonStepBack.Text = "Предыдущий шаг";
            buttonStepBack.UseVisualStyleBackColor = true;
            buttonStepBack.Click += buttonStepBack_Click;
            // 
            // buttonStepForward
            // 
            buttonStepForward.Enabled = false;
            buttonStepForward.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStepForward.Location = new Point(5, 139);
            buttonStepForward.Margin = new Padding(2);
            buttonStepForward.Name = "buttonStepForward";
            buttonStepForward.Size = new Size(190, 23);
            buttonStepForward.TabIndex = 33;
            buttonStepForward.Text = "Следующий шаг";
            buttonStepForward.UseVisualStyleBackColor = true;
            buttonStepForward.Click += buttonStepForward_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(769, 559);
            pictureBox.TabIndex = 35;
            pictureBox.TabStop = false;
            // 
            // labelCurrentStep
            // 
            labelCurrentStep.AutoSize = true;
            labelCurrentStep.Location = new Point(20, 180);
            labelCurrentStep.Name = "labelCurrentStep";
            labelCurrentStep.Size = new Size(81, 15);
            labelCurrentStep.TabIndex = 10;
            labelCurrentStep.Text = "Текущий шаг";
            // 
            // labelTotalSteps
            // 
            labelTotalSteps.AutoSize = true;
            labelTotalSteps.Location = new Point(106, 180);
            labelTotalSteps.Name = "labelTotalSteps";
            labelTotalSteps.Size = new Size(76, 15);
            labelTotalSteps.TabIndex = 39;
            labelTotalSteps.Text = "Всего шагов";
            // 
            // FormHashTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(969, 583);
            Controls.Add(pictureBox);
            Controls.Add(Инструменты);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormHashTable";
            Text = "Хэш таблица";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Инструменты.ResumeLayout(false);
            Инструменты.PerformLayout();
            panelHash.ResumeLayout(false);
            panelHash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private GroupBox Инструменты;
        private Button buttonStepBack;
        private Button buttonStepForward;
        private Button buttonSetSize;
        private PictureBox pictureBox;
        private Button buttonInfo;
        private Panel panelHash;
        private TextBox textBoxKey;
        private TextBox textBoxKeyToDivide;
        private TextBox textBoxSize;
        private Label labelSize;
        private Label labelKeyHash;
        private Label labelHash;
        private Label labelDivide;
        private Label labelEqually;
        private Label labelBucket;
        private TextBox textBoxBucket;
        private TextBox textBoxStep;
        private TextBox textBoxTotalSteps;
        private Label labelTotalSteps;
        private Label labelCurrentStep;
    }
}
