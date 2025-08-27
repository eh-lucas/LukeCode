namespace LukeCode.ArraysAndHashing;
public static class TwoSum
{
    public static int[] RunTwoSum(int[] nums, int target)
    {
	    var map = new Dictionary<int, int>();
	    for (int i = 0; i < nums.Length; i++)
	    {
		    var diff = target - nums[i];
		    if (map.ContainsKey(diff))
			   return new int[] { map[diff], i }; 
		    else map.Add(nums[i], i);
	    }
	    return null;
    }
}

