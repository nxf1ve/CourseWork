namespace CourseWork;

public class Storage
{
    private List<HashTableCondition> _storage;
  
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

}
