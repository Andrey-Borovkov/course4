/*Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/
void CreateArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
        
}
void ShowArray(int[] array)
{
    int length = array.Length;
    Console.Write("[");

    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
CreateArray(arr);
ShowArray(arr);