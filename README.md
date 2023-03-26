# MATCh program by a.prush

## Задачи программы

Данная программа предназначена для выборки из массива со строковым типом данных по фильтру, длинна строки меньше или равна трём символам.

# Code of MATCh program

```
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
```

## Программные решения. Методы.

Для выполнения задачи были разработаны три функции.

Далее следует описания каждого метода.

### InitialArray
```
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
```

Этот метод создает массив количеством элементов которое мы передаем в параметре вызываемой функции.

```
string[] result = new string[length];
```

 И заполняет его случайными значениями. 
```
for (int i = 0; i < length; i++)
    {
        int wordLength = rand.Next(1, 8);
        for (int l = 0; l < wordLength; l++)
        {
            result[i] += alphabetEng[rand.Next(0, 26)];
        }

    }
``` 
Для заполнения случайными значениями подготовлен массив с латиницей.
```
char[] alphabetEng = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
```
### MatchCount

 ```
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
```

Данный метод возвращает количество объектов прошедших фильтр.

```
matchCount = (item.Length <= 3) ? (++i) : i;
```

### ProcessingArray
```
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
```

Результирующая функция в программе. 

Которая создает маслив количество элементов которого является результат метода int MatchCount().

```
string[] result = new string[MatchCount(data)];
```

В ней мы заполняем новый массив элементами прошедшие фильтр. 
```
foreach (var item in data)
{
    if (item.Length <= 3)
    {
        result[i++] = item;
    }
}
```
## Обращение к методам  

Сперва создается массив с использованием метода InitialArray(). В параметрах которого указывается сколько элементов будет в массиве.

Созданный массив выводится на экран в консоли.
```
string[] myArray = InitialArray(5);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");
```

Затем производится выборка по фильтру. 
Результат выборки так-же выводится на экран  в консоли.

```
myArray = ProcessingArray(myArray);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");
```

# Conclusion

В результате работы программы получаем выборку по фильтру. длинна строки меньше или равна трём символам.
```
U:\data\lang\cs-lang\cs_study-result_test>dotnet run
[tevn, v, rtjmch, x, ho]
[v, x, ho]
```

Следовательно можно считать что программа выполняет поставленную задачу. 

# EXCELLENT!