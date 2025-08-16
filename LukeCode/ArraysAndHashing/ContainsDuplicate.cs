namespace LukeCode.ArraysAndHashing;
public static class ContainsDuplicate
{
    private static int[] _sample1 = new[] { 1, 2, 3, 4, 4, 5 };
    private static int[] _sample2 = new[] { 1, 2, 3, 4, 5 };
    public static bool RunReturningIfCodeIsCorrect()
    {
        Dictionary<int[], bool> samples = new()
        {
            { _sample1, true },
            { _sample2, false }
        };

        foreach (var sample in samples)
        {
            if (HasDuplicate(sample.Key) != sample.Value)
                return false;
        }
        return true;
    }

    public static bool HasDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
                return true;
            set.Add(num);
        }
        return false;
    }
}
