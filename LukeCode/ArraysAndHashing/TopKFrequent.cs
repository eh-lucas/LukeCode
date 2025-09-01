namespace LukeCode.ArraysAndHashing;
public static class TopKFrequent 
{
    public static int[] RunTopKFrequent(int[] nums, int k)
    {
	    var count = new Dictionary<int, int>();
	    var freq = new List<int>[nums.Length + 1];
	    
	    for (int i = 0; i < freq.Length; i++){
		    freq[i] = new List<int>();
	    }
	   
	    foreach (var n in nums){
		    if (!count.ContainsKey(n))
			    count.Add(n, 0);
		    count[n]++;
	    }

	    foreach (var entry in count){
		    freq[entry.Value].Add(entry.Key);
	    }
	    
	    int[] res = new int[k];
	    int index = 0;
	    for (int i = freq.Length - 1; i > 0 && index < k; i--)
	    {
		    foreach (int n in freq[i]){
			   res[index] = n;
			   index++;
			   if (index == k) return res;
		    }
	    }

	    return res;
    }
}
