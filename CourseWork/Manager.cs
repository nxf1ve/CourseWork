using System.Collections;
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
    public bool Search(string key)
    {
        int value = hashTable.Get(key);
        HashItem selectedItem;
        if (value != -1)
        {
            selectedItem = new HashItem(key, value);            
            HashTableCondition condition = hashTable.SaveHashTableCondition(EnumOperations.Search, selectedItem);
            storage.AddState(condition);
            return true;
        }
        else
        {
            MessageBox.Show("Элемент не найден.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
       
        
    }

    public void SetHashTableCondition(HashTableCondition condition)
    {
        hashTable.SetHashTableCondition(condition);
      
    }
   
}
