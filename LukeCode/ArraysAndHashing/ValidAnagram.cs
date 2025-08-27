namespace LukeCode.ArraysAndHashing;
public static class ValidAnagram 
{
    public static bool RunValidAnagram(string s, string t)
    {
	 if (s.Length != t.Length) return false;
	 var count = new int[26];
	 for (int i = 0; i < s.Length; i++)
	 {
		 count[s[i] - 'a']++;
		 count[t[i] - 'a']--;
	 }
	 foreach (int val in count)
		 if (val != 0) return false;

	 return true;
    }
}
