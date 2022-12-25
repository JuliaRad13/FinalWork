// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] ArrayTask(string[] a)
{
    int count = 0;
    string[] result = new string[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            result[count] = a[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string[] result)
{
    for (int i = 0; i < result.Length; i++)
        System.Console.Write($"{result[i],5}");
}

void PrintTask(string[] array)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Исходный массив:");
    PrintArray(array);
    string[] shortArray = ArrayTask(array);
    System.Console.WriteLine();
    System.Console.WriteLine($"Результат массива: ");
    PrintArray(shortArray);
    System.Console.WriteLine();
}

PrintTask(array1);
PrintTask(array2);
PrintTask(array3);