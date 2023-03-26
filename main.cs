string[] InitiallArray(int length)
{
    char[] alphabetEng = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    string[] result = new string[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        int wordLength = rand.Next(0, 8);
        for (int l = 0; l < wordLength; l++)
        {
            result[i] += alphabetEng[rand.Next(0,26)];
        }
        
    }
    return result;
}

System.Console.WriteLine($"[{string.Join(", ", InitiallArray(3))}]");