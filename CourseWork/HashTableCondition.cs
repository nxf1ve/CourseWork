namespace CourseWork;

public class HashTableCondition
{
    public List<HashItem>[] _hashTable;
    private EnumOperations operationType;
    public HashItem selectedItem;
    public int hashTablesize;
    public int? keyHash;


    public HashTableCondition(List<HashItem>[] hashTableCondition, EnumOperations operationType, HashItem selectedItem, int hashTablesize, int? keyHash)
    {
        this._hashTable = hashTableCondition;
        this.operationType = operationType;
        this.selectedItem = selectedItem;
        this.hashTablesize = hashTablesize;
        this.keyHash = keyHash;
    }
}
