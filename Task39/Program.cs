/* 
Задача 39. Напишите программу, которая перевернет одномерный массив
[1 2 3 4 5] -> [5 4 3 2 1]
*/

int[] GenerateArray (int length, int maxValue)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(0, maxValue + 1);
    }
    return returningArray;
}

int[] rotateArray(int[] inputArray)
{
    int[] returningArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        returningArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return returningArray;
}

void PrintArray(int[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i]);
        if (i != inputArray.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] arrayToRotate = GenerateArray(11, 10);
int[] rotatedArray = rotateArray(arrayToRotate);
int[] rotatedRotatedArray = rotateArray(rotatedArray);

Console.WriteLine("Сгенерированный массив");
PrintArray(arrayToRotate);
Console.WriteLine("Перевернутый массив");
PrintArray(rotatedArray);
Console.WriteLine("Перевернутый еще раз массив");
PrintArray(rotatedRotatedArray);