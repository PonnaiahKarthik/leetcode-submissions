public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var freq = new int[26];

        var s1 = s.ToCharArray();
        var t1 = t.ToCharArray();

        foreach(var c in s1)
            freq[c-97]++;
        foreach(var c in t1)
            freq[c-97]--;
        
    foreach(var c in freq){
        Console.Write($"{c},");
        if(c!=0) return false;
    }
    return true;
    }
}