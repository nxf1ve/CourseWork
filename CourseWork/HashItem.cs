namespace CourseWork;

public class HashItem
{
    public int Key { get; private set; }

    public int Value { get; private set; }

    public HashItem(int key, int value)
    {

        Key = key;
        Value = value;

    }
}