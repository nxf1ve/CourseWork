namespace CourseWork;

public class HashTableCondition
{
    public List<HashItem>[] _hashTableCondition;
    private EnumOperations operationType;

    public HashTableCondition(List<HashItem>[] hashTableCondition, EnumOperations operationType)
    {
        this._hashTableCondition = hashTableCondition;
        this.operationType = operationType;
    }
}
