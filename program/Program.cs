Main();

void Main()
{
    string[] stringArray = {"Hello", "World", "I'm", "in", "IT", "The End"};
    Console.WriteLine("Исходный массив строк:");
    PrintArray(stringArray);
    Console.WriteLine();
    string[] resultArray = GetResultArray(stringArray);
    Console.WriteLine("Результирующий массив строк:");
    PrintArray(resultArray);
    Console.WriteLine();
}

string[] GetResultArray(string[] array)
{
    int resultArraySize = 0;
    int[] resultStringIndexes = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i].Length <=3)
        {
            resultStringIndexes[resultArraySize] = i;
            resultArraySize++;
        }
    }
    string[] resultArray = new string[resultArraySize];
    for(int i = 0; i < resultArraySize; i++)
    {
        resultArray[i] = array[resultStringIndexes[i]];
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    foreach(string currentString in array)
    {
        Console.WriteLine(currentString);
    }
}
