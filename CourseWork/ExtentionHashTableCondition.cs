﻿namespace CourseWork;

public static class ExtentionHashTableCondition
{
    private static readonly string _separatorForObject = "|";
    public static string GetDataForSave(this HashTableCondition condition)
    {
        string[]? array = condition.GetConditionStringRepresentation();

        if (array == null)
        {
            return string.Empty;
        }

        return string.Join(_separatorForObject, array);
    }

    public static HashTableCondition? CreateHashTableCondition(this string info)
    {
        string[] strs = info.Split(_separatorForObject);
        HashTableCondition? condition = HashTableCondition.CreateCondition(strs);
        if (condition != null)
        {
            return condition;
        }

        return null;
    }
}
