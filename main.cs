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
            result[i] += alphabetEng[rand.Next(0, 26)];
        }

    }
    return result;
}

string[] ProccensingArray(string[] array)
{
    string[] result = new string[array.Length];
    int i = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            result[i++] = item;      
        }
    }
    return result;
}

//debug
string[] myArray = InitiallArray(5);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");
myArray = ProccensingArray(myArray);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");