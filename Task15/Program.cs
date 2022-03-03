// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

int GetToDay(int value)
{
    switch(value)
    {
        case 1:
            Console.WriteLine("Сегодня понедельник. БУДНИЙ день.");
            break;
        case 2:
            Console.WriteLine("Сегодня вторник. БУДНИЙ день.");
            break;
        case 3:
            Console.WriteLine("Сегодня среда. БУДНИЙ день.");
            break;
        case 4:
            Console.WriteLine("Сегодня четверг. БУДНИЙ день.");
            break;
        case 5:
            Console.WriteLine("Сегодня пятница. БУДНИЙ день.");
            break;
        case 6:
            Console.WriteLine("Сегодня суббота. ВЫХОДНОЙ день.");
            break;
        case 7:
            Console.WriteLine("Сегодня воскресенье. ВЫХОДНОЙ день.");
            break;
        default:
            Console.WriteLine("Вы ввели число не из заданного диапазона.");
            break;
    }
    return value;
}
GetToDay(day);