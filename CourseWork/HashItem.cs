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
    public override string ToString()
    {
        return $"{Key}:{Value}";
    }
    public static HashItem FromString(string str)
    {
        var parts = str.Split(':');
        return new HashItem(parts[0], int.Parse(parts[1]));
    }
}