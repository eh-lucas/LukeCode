namespace LukeCode.ArraysAndHashing;
public static class GroupAnagrams
{
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
	    var map = new Dictionary<string, List<string>>();
	    foreach (var s in strs){
	    	var count = new int[26];
	    	for (int i = 0; i < s.Length; i++){
			count[s[i] - 'a']++;
		}
		var key = string.Join(',', count);
		if (!map.ContainsKey(key))
			map.Add(key, new List<string>());
		map[key].Add(s);
	    }
	    return map.Values.ToList<List<string>>();
    }
}
