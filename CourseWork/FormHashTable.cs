using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormHashTable : Form
    {
        private Manager hashTabelManager;
        private HashTableVisualization hashTableVisualization;
        private int currentConditionStep = 0;

        private void CreateHashTableManager(int size)
        {
            HashTableParameters parameters = new HashTableParameters();
            parameters.Size = size;
            hashTabelManager = new Manager(parameters);
            textBoxSize.Text = size.ToString();
            RepaintCurrentCondition(EnumOperations.SetSize);

            buttonInsert.Enabled = true;
            buttonRemove.Enabled = true;
            buttonSearch.Enabled = true;
        }

        public FormHashTable()
        {
            InitializeComponent();
            hashTableVisualization = new HashTableVisualization();
        }

        public void Show(int currentConditionIndex)
        {
            if (hashTabelManager == null || hashTableVisualization == null || pictureBox.Height == 0 || pictureBox.Width == 0)
            {
                return;
            }
            Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.FromArgb(255, 224, 192));
            // Получение текущего состояния хэш-таблицы
            var condition = hashTabelManager.GetStorage().GetCondition(currentConditionIndex);

            // Если операция - поиск, передаем ключ в метод DrawHashTable
            if (condition.operationType == EnumOperations.Search)
            {
                hashTableVisualization.DrawHashTable(graphics, condition);
            }
            else
            {
                // В противном случае передаем null
                hashTableVisualization.DrawHashTable(graphics, condition);
            }

            pictureBox.Image = bitmap;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            FormHashTableInput form = new FormHashTableInput(EnumOperations.Insert);
            form.Show();
            form.AddEvent(hashTabelManager.Insert, RepaintCurrentCondition);
            buttonStepBack.Enabled = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FormHashTableInput form = new FormHashTableInput(EnumOperations.Remove);
            form.Show();
            form.AddEvent(hashTabelManager.Remove, RepaintCurrentCondition);
            buttonStepBack.Enabled = true;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormHashTableInput form = new FormHashTableInput(EnumOperations.Search);
            form.Show();
            form.AddEvent(hashTabelManager.Search, RepaintCurrentCondition);
        }

        private void buttonSetSize_Click(object sender, EventArgs e)
        {
            FormHashTableInput form = new FormHashTableInput(EnumOperations.SetSize);
            form.Show();
            form.AddEvent(CreateHashTableManager);
        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {
            if (currentConditionStep + 1 <= hashTabelManager.GetStorage().Count)
            {
                RepaintCurrentCondition(EnumOperations.StepForward);
                buttonStepBack.Enabled = true;
            }
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {
            if (currentConditionStep - 1 >= 0)
            {
                RepaintCurrentCondition(EnumOperations.StepBack);
                buttonStepForward.Enabled = true;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInformation form = new FormInformation();
            form.Show();
        }

        private void RepaintCurrentCondition(EnumOperations typeOperation)
        {
            switch (typeOperation)
            {
                case EnumOperations.StepBack:
                    currentConditionStep--;
                    buttonInsert.Enabled = false;
                    buttonRemove.Enabled = false;
                    break;
                case EnumOperations.SetSize:
                    currentConditionStep = 0;
                    break;

                default:
                    currentConditionStep++;
                    break;
            }
            if (currentConditionStep > 0)
            {
                UpdateTextBoxes(currentConditionStep);
                buttonSearch.Enabled = true;

                if (currentConditionStep == hashTabelManager.GetStorage().Count - 1)
                {
                    buttonStepForward.Enabled = false;
                    buttonInsert.Enabled = true;
                    buttonRemove.Enabled = true;
                }
            }
            else
            {
                textBoxKeyToDivide.Text = string.Empty;
                textBoxBucket.Text = string.Empty;
                textBoxKey.Text = string.Empty;
                buttonStepBack.Enabled = false;
                if (hashTabelManager.GetStorage().Count - 1 > 0)
                {
                    buttonStepForward.Enabled = true;
                }
            }
            textBoxStep.Text = currentConditionStep.ToString();
            textBoxTotalSteps.Text = (hashTabelManager.GetStorage().Count - 1).ToString();
            hashTabelManager.SetHashTableCondition(hashTabelManager.GetStorage().GetCondition(currentConditionStep));
            Show(currentConditionStep);
        }

        private void UpdateTextBoxes(int step)
        {
            var condition = hashTabelManager.GetStorage().GetCondition(step);
            if (condition != null)
            {
                int hashCode = (int)condition.keyHash;
                int hashTableSize = condition.hashTablesize;
                textBoxKey.Text = $"key - {condition.selectedItem.Key}, HashCode = {hashCode}";
                textBoxKeyToDivide.Text = hashCode.ToString();
                textBoxBucket.Text = (hashCode % hashTableSize).ToString();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hashTabelManager.GetStorage().SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hashTabelManager = new Manager();
                    hashTabelManager.GetStorage().LoadData(openFileDialog.FileName);
                    if (hashTabelManager.GetStorage().Count > 0)
                    {
                        var firstCondition = hashTabelManager.GetStorage().GetCondition(0);
                        hashTabelManager.InitializeHashTable(firstCondition.hashTablesize);
                        hashTabelManager.SetHashTableCondition(firstCondition);
                    }
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentConditionStep = 0;
                    int size = hashTabelManager.GetStorage().GetCondition(currentConditionStep).hashTablesize;
                    textBoxSize.Text = size.ToString();
                    RepaintCurrentCondition(EnumOperations.SetSize);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не загрузилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     
    }
}
