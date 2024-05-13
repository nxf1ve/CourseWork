using System.Reflection.Metadata;

namespace CourseWork;

public class Manager
{
    private HashTable hashTable;
    private Storage storage;

    public Manager(HashTableParameters parameters)
    {
        hashTable = new HashTable(parameters.Size);
        storage = new Storage();       
    }

    public Storage Insert(string key, int value)
    {
        hashTable.Insert(key, value);
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Insert);
        storage.AddState(condition);
        return storage;
    }
    public Storage Remove(string key)
    {
        hashTable.Delete(key);
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Delete);
        storage.AddState(condition);
        return storage;
    }
}
