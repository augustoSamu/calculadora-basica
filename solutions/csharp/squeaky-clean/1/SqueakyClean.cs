public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = "";
        bool makeUpper = false;
        
        foreach (char c in identifier)
        {
            if (char.IsLower(c) && c >= 'α' && c <= 'ω')
            {
                continue;
            }
            else if (char.IsWhiteSpace(c)) 
            {
                result += "_"; 
            }
            else if (char.IsControl(c)) 
            {
                result += "CTRL";   
            }
            else if (c == '-') 
            {
                makeUpper = true;
            }
            else if (makeUpper) 
            {
                result += char.ToUpper(c);
                makeUpper = false;
            } 
            else if (char.IsLetter(c)) 
            {
                result += c;   
            }
        }
        
        return result; 
    }
}
