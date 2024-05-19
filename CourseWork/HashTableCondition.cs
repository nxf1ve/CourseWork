using System.Text;

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

    public string[] GetConditionStringRepresentation()
    {
        return new string[]
        {
                operationType.ToString(),
                hashTablesize.ToString(),
                selectedItem?.ToString() ?? "null",
                keyHash?.ToString() ?? "null",
                GetTableStringRepresentation()
        };
    }


    public string GetTableStringRepresentation()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < _hashTable.Length; i++)
        {
            sb.Append($"Bucket {i}: ");
            if (_hashTable[i] != null && _hashTable[i].Count > 0)
            {
                sb.Append(string.Join(", ", _hashTable[i].Select(item => $"{item.Key}:{item.Value}")));
            }
            else
            {
                sb.Append("empty");
            }
            sb.Append(". ");

        }

        return sb.ToString();
    }
    public static HashTableCondition? CreateCondition(string[] strs)
    {
        if (strs.Length != 5)
        {
            return null;
        }

        EnumOperations operationType = Enum.Parse<EnumOperations>(strs[0]);
        int hashTablesize = int.Parse(strs[1]);
        HashItem selectedItem = strs[2] == "null" ? null : HashItem.FromString(strs[2]);
        int? keyHash = strs[3] == "null" ? (int?)null : int.Parse(strs[3]);
        List<HashItem>[] hashTableCondition = ParseHashTable(strs[4], hashTablesize);

        return new HashTableCondition(hashTableCondition, operationType, selectedItem, hashTablesize, keyHash);
    }

    private static List<HashItem>[] ParseHashTable(string str, int size)
    {
        List<HashItem>[] hashTable = new List<HashItem>[size];
        string[] buckets = str.Split(new[] { "Bucket " }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var bucket in buckets)
        {
            string[] bucketParts = bucket.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(bucketParts[0].Trim());
            string items = bucketParts[1].Trim();

            if (!items.StartsWith("empty"))
            {
                items = items.TrimEnd('.', ' ');
                hashTable[index] = items.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(itemStr => HashItem.FromString(itemStr))
                                         .ToList();
            }
        }

        return hashTable;
    }
}


