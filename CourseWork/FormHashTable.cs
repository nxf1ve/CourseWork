using System.Collections;
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
            hashTableVisualization.DrawHashTable(graphics, hashTabelManager.GetStorage().GetCondition(currentConditionIndex));
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

        private void buttonSetSize_Click(object sender, EventArgs e)
        {
            FormHashTableInput form = new FormHashTableInput(EnumOperations.SetSize);
            form.Show();
            form.AddEvent(CreateHashTableManager);
            
        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {
            if (currentConditionStep+1 <= hashTabelManager.GetStorage().Count )
            {
                
                RepaintCurrentCondition(EnumOperations.StepForward);
                buttonStepBack.Enabled=true;

            }
            
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {
            if (currentConditionStep-1 >= 0)
            {
                RepaintCurrentCondition(EnumOperations.StepBack);
                buttonStepForward.Enabled = true;

                //hashTabelManager.SetHashTableCondition(hashTabelManager.GetStorage().GetCondition(currentConditionStep));
               
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
                    break;
                default:
                    currentConditionStep++;
                    break;
            }
            if (currentConditionStep > 0)
            {
                UpdateTextBoxes(currentConditionStep);

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
            }
            textBoxStep.Text = currentConditionStep.ToString();
            textBoxTotalSteps.Text = (hashTabelManager.GetStorage().Count - 1).ToString();
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
    }


}
