string[] array = ["Hello", "2", "world", ":-)", "456", "tor", "753"];

string[] shortArray = new string[array.Length];

void SecondArray()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortArray[count] = array[i];
            count ++;
        }
    }
}
void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
SecondArray();
Console.WriteLine("Массив коротких строк: ");
PrintArray(shortArray);