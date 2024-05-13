namespace CourseWork;

public class HashItem
{
    public string Key { get; private set; }

    public int Value { get; private set; }

    public HashItem(string key, int value)
    {

        Key = key;
        Value = value;

    }
}