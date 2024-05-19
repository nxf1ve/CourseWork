using System.Text;
using System.Text.Json;

namespace CourseWork;

public class Storage
{
    private List<HashTableCondition> _storage;
    private readonly string _separatorItems = ";";
    private readonly string _separatorConditionItems = "|";


    public Storage()
    {
        _storage = new List<HashTableCondition>(); 
    }
    public int Count => _storage.Count;
    public void AddState(HashTableCondition condition)
    {
        if (condition == null)
        {
            return;
        }
        if (_storage.Count > 0 && _storage.Last().Equals(condition))
        {
            _storage.RemoveAt(_storage.Count - 1);
        }
        _storage.Add(condition);
    }
    public HashTableCondition GetCondition(int index)
    {
        if (_storage[index] == null || index < 0 ) 
        {
            throw new IndexOutOfRangeException();
        }
        return _storage[index];
    }
    public void SaveData(string filename)
    {
        if (_storage.Count <= 0)
        {
            throw new Exception("В хранилище отсутствуют коллекции для сохранения");
        }
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        StringBuilder sb = new();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var condition in _storage)
            {
                string data = condition?.GetDataForSave() ?? string.Empty;
                if (string.IsNullOrEmpty(data))
                    continue;
                sb.Append(data);
                sb.Append(_separatorItems);
                sw.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }

    // Загрузка данных из текстового файла
    public void LoadData(string filename)
    {
        if (!File.Exists(filename))
        {
            File.Delete(filename);
        }
        using (StreamReader sr = new StreamReader(filename))
        {
            string? line;
            _storage.Clear();
            while ((line = sr.ReadLine()) != null)
            {
                string[] record = line.TrimEnd(_separatorItems.ToCharArray()).Split(_separatorConditionItems);
                if (record.Length != 5)
                {
                    continue;
                }
                HashTableCondition condition = HashTableCondition.CreateCondition(record);
                if (condition != null)
                {
                    _storage.Add(condition);
                }
            }
        }
    }


}
