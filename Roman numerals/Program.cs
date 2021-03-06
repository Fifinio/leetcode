// converts a valid roman numeral string into an integer
static int RomanToInt(string s) {
    Dictionary<char, int> roman = new Dictionary<char, int>();
    roman.Add('I', 1);
    roman.Add('V', 5);
    roman.Add('X', 10);
    roman.Add('L', 50);
    roman.Add('C', 100);
    roman.Add('D', 500);
    roman.Add('M', 1000);

    int result = 0;

    for (int i = 0; i < s.Length; i++) {
        if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]]) {
            result -= roman[s[i]];
        } else {
            result += roman[s[i]];
        }
    }
    return result;
}        
Console.WriteLine(RomanToInt("XXIV"));