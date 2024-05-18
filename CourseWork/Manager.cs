using System.Reflection.Metadata;
using System.Windows.Forms;

namespace CourseWork;

public class Manager
{
    private HashTable hashTable;
    private List<HashItem>[] hashTableItems;
    private Storage storage;
    public Storage GetStorage() { return storage; }

    public Manager(HashTableParameters parameters)
    {
        hashTable = new HashTable(parameters.Size);
        hashTableItems = hashTable.GetItems();
        storage = new();
        HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.SetSize, null);
        //storage.AddState(new HashTableCondition(hashTableItems, EnumOperations.SetSize, null, parameters.Size, 0));
        storage.AddState(condition);
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

    public void SetHashTableCondition(HashTableCondition condition)
    {
        hashTable.SetHashTableCondition(condition);
      
    }
   
}
