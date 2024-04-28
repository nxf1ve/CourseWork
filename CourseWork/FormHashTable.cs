using System.Collections;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormHashTable : Form
    {
        private HashTable hashTable;
        public FormHashTable()
        {
            InitializeComponent();
            hashTable = new HashTable();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputKeyTextBox.Text, out int key) && int.TryParse(inputValueTextBox.Text, out int value))
            {
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
            if (int.TryParse(inputKeyTextBox.Text, out int key))
            {
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
