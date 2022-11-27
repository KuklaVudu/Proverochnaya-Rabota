// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равно 3 символа.
void StringArray(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            arrayNew[count] = array[i];
        count++;
    }
}
Console.Clear();
string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] arrayNew = new string[array.Length];
StringArray(array, arrayNew);
Console.WriteLine($"[{string.Join("  ", array)}] -> [{string.Join(" ", arrayNew)}]");