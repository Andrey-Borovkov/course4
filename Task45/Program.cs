/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
int[] CreateFirstArray(int arrayLength)
{
    int[] FirstArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        FirstArray[i] = new Random().Next(-100, 100);
    }
    return FirstArray;
}
int[] CopingArray(int[] FirstArray)
{
    int[] CopiedArray = new int[FirstArray.Length];
    for (int i = 0; i < CopiedArray.Length; i++)
    {
        CopiedArray[i] = FirstArray[i];
    }
    return CopiedArray;
}
void PrintArray(int[] PrintingArray)
{
    Console.Write("[");
    for (int i = 0; i < PrintingArray.Length; i++)
    {
        Console.Write(PrintingArray[i]);
        if (i<PrintingArray.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
Console.Write("Введите количество элементов первого массива: ");
int NumbersElementsOfFirstArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] FirstArray = CreateFirstArray(NumbersElementsOfFirstArray);
Console.WriteLine("Первый сгенерированный массив:");
PrintArray(FirstArray);
int[] CopiedArray = CopingArray(FirstArray);
Console.WriteLine("");
Console.WriteLine("Копия первого массива:");
PrintArray(CopiedArray);
