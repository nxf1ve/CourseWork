using System.Windows.Forms.Design;

namespace CourseWork;

public partial class FormHashTableInput : Form
{
    private event Func<string, int, Storage>? _insertItemDelegate;
    private event Action<int>? _setSizeDelegate;
    private event Func<string, Storage>? _deleteItemDelegate;
    private event Func<string, bool>? _searchItemDelegate;
    private Action<EnumOperations>? _afterActionCallback;
    public FormHashTableInput(EnumOperations actionType)
    {
        InitializeComponent();
        switch (actionType)
        {
            case EnumOperations.Insert:
                buttonInsert.Enabled = true;
                maskedTextBoxValueToInsert.Enabled = true;
                textBoxKeyToInsert.Enabled = true;
                break;
            case EnumOperations.Remove:
                buttonRemove.Enabled = true;
                textBoxKeyToRemove.Enabled = true;
                break;
            case EnumOperations.SetSize:
                buttonSetSize.Enabled = true;
                maskedTextBoxInputSize.Enabled = true;
                break;
            case EnumOperations.Search:
                buttonSearch.Enabled = true;
                textBoxKeyToSearch.Enabled = true;
                break;
            default:
                throw new ArgumentException();

        }
    }

    public void AddEvent(Func<string, int, Storage> insertItemDelegate, Action<EnumOperations> afterActionCallback)
    {
        _insertItemDelegate += insertItemDelegate;
        _afterActionCallback = afterActionCallback;
    }
    public void AddEvent(Action<int> setSizeDelegate)
    {
        _setSizeDelegate += setSizeDelegate;
    }
    public void AddEvent(Func<string, Storage> deleteItemDelegate, Action<EnumOperations> afterActionCallback)
    {
        _deleteItemDelegate += deleteItemDelegate;
        _afterActionCallback = afterActionCallback;
    }
    public void AddEvent(Func<string, bool>? searchItemDelegate, Action<EnumOperations> afterActionCallback)
    {
        _searchItemDelegate += searchItemDelegate;
        _afterActionCallback = afterActionCallback;
    }
    private void buttonInsert_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(maskedTextBoxValueToInsert.Text) || string.IsNullOrEmpty(textBoxKeyToInsert.Text))
            {
                throw new Exception("Входные данные отсутствуют");
            }
            int value = Convert.ToInt32(maskedTextBoxValueToInsert.Text);
            string key = textBoxKeyToInsert.Text;
            _insertItemDelegate?.Invoke(key, value);
            _afterActionCallback?.Invoke(EnumOperations.Insert);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Пожалуйста, введите целочисленное число для значения и строку для ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    private void buttonSetSize_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(maskedTextBoxInputSize.Text))
            {
                throw new Exception("Входные данные отсутствуют");
            }
            int size = Convert.ToInt32(maskedTextBoxInputSize.Text);
            _setSizeDelegate?.Invoke(size);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Пожалуйста, введите целочисленное число для размера таблицы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(textBoxKeyToRemove.Text))
            {
                throw new Exception("Входные данные отсутствуют");
            }
            string key = textBoxKeyToRemove.Text;
            _deleteItemDelegate?.Invoke(key);
            _afterActionCallback?.Invoke(EnumOperations.Remove);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Пожалуйста, введите строку для ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(textBoxKeyToSearch.Text))
            {
                throw new Exception("Входные данные отсутствуют");
            }
            string key = textBoxKeyToSearch.Text;
            bool searchResult = _searchItemDelegate.Invoke(key);

            // Проверка результата операции поиска
            if (searchResult)
            {
                _afterActionCallback?.Invoke(EnumOperations.Search);
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Пожалуйста, введите строку для ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
