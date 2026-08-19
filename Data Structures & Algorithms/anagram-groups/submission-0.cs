public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string sortedKey = new string(chars);

            if (!anagramGroups.ContainsKey(sortedKey))
            {
                anagramGroups[sortedKey] = new List<string>();
            }

            anagramGroups[sortedKey].Add(str);
        }

        return anagramGroups.Values.ToList();
    }
}