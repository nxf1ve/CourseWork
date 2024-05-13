using System.Collections;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormHashTable : Form
    {
        private HashTableCondition hashTable;
        public FormHashTable()
        {
            InitializeComponent();
            hashTable = hashTable.GetHashTableState();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (inputKeyTextBox.Text != null && int.TryParse(inputValueTextBox.Text, out int value))
            {
                string key = inputKeyTextBox.Text;
                hashTable.Insert(key, value);
                UpdateHashTableVisualization();
            }
            else
            {
                MessageBox.Show("����������, ������� ������������� �������� ��� ����� � ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (inputKeyTextBox.Text != null)
            {
                string key = inputKeyTextBox.Text;
                hashTable.Delete(key);
                UpdateHashTableVisualization();
            }
            else
            {
                MessageBox.Show("����������, ������� ������������� �������� ��� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateHashTableVisualization()
        {
            // �������� ������� ���������� ��� ������������ ���-�������
            dataGridView.Rows.Clear();

            // �������� ������������ ���-������� �� ������ �������� ���������
            foreach (var pair in hashTable.Items)
            {
                // ���������, ��� �������� pair.Value �� ����� null, ������ ��� ���������� � �������� ���������
                if (pair.Value != null)
                {
                    foreach (var item in pair.Value)
                    {
                        dataGridView.Rows.Add(pair.Key, item.Key, item.Value);
                    }
                }
            }
        }

    }


}
