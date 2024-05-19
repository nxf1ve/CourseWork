using System.Reflection.Metadata;
using System.Windows.Forms;

namespace CourseWork;

public class Manager
{
    private HashTable hashTable;
    public void InitializeHashTable(int size)
    {
        hashTable = new HashTable(size);
    }
    private Storage storage;
    public Storage GetStorage() { return storage; }

    public Manager(HashTableParameters parameters)
    {
        hashTable = new HashTable(parameters.Size);
        storage = new();
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.SetSize, null);
        storage.AddState(condition);
    }
    public Manager()
    {
        storage = new Storage();
    }

    public Storage Insert(string key, int value)
    {
        hashTable.Insert(key, value);
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Insert, new HashItem(key, value));
        storage.AddState(condition);
        return storage;
    }
    public Storage Remove(string key)
    {
        hashTable.Delete(key);
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Remove, new HashItem(key, hashTable.Get(key)));
        storage.AddState(condition);
        return storage;
    }
    public Storage Search(string key)
    {
        if (hashTable.Get(key) != -1)
        {
            HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Remove, new HashItem(key, hashTable.Get(key)));
        }
    }

    public void SetHashTableCondition(HashTableCondition condition)
    {
        hashTable.SetHashTableCondition(condition);
      
    }
   
}
