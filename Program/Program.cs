// программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] firstArray = new string[7] { "Hello", "world", ":)", "123", "test", "hi", "54321" };
string[] secondArray = new string[firstArray.Length];
void FirstArrayToSecond(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FirstArrayToSecond(firstArray, secondArray);
PrintArray(secondArray);
