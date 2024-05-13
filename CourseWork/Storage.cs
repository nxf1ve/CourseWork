namespace CourseWork;

public class Storage
{
    private List<HashTableCondition> _storage;
    public List<HashTableCondition> GetStorage()
    {
        return _storage;
    }

    public Storage()
    {
        _storage = new List<HashTableCondition>(); 
    }
    public void AddState(HashTableCondition state)
    {
        if (state == null)
        {
            return;
        }
        _storage.Add(state);
    }
    public void IterateStates(List<HashTableCondition> states)
    {
        foreach (var state in states)
        {
            throw new NotImplementedException();
        }
    }

}
