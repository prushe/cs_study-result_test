string[] InitialArray(int length)
{
    char[] alphabetEng = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    string[] result = new string[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        int wordLength = rand.Next(1, 8);
        for (int l = 0; l < wordLength; l++)
        {
            result[i] += alphabetEng[rand.Next(0, 26)];
        }

    }
    return result;
}

int MatchCount(string[] data)
{
    int i = 0;
    int matchCount = 0;
    foreach (var item in data)
    {
        matchCount = (item.Length <= 3) ? (++i) : i;
    }
    return matchCount;
}

string[] ProcessingArray(string[] data)
{
    int i = 0;
    string[] result = new string[MatchCount(data)];
    foreach (var item in data)
    {
        if (item.Length <= 3)
        {
            result[i++] = item;
        }
    }
    return result;
}

string[] myArray = InitialArray(5);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");
myArray = ProcessingArray(myArray);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");