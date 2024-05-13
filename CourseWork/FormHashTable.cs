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
                MessageBox.Show("Пожалуйста, введите целочисленные значения для ключа и значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Пожалуйста, введите целочисленное значение для ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateHashTableVisualization()
        {
            // Очистить элемент управления для визуализации хэш-таблицы
            dataGridView.Rows.Clear();

            // Обновить визуализацию хэш-таблицы на основе текущего состояния
            foreach (var pair in hashTable.Items)
            {
                // Проверяем, что значение pair.Value не равно null, прежде чем переходить к перебору элементов
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
