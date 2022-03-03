// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int razryad = number.ToString().Length;
int GetThreeLetterOfNumber (int letter)
{
    int index = 1;
        while (index <= (razryad - 3))
        {
            letter = letter / 10;
            index++;
        }
        letter = letter % 10;
        return letter;
}
if (razryad < 3)
{
    Console.WriteLine("Число не имеет третьей цифры. Введите число с разрядностью выше двух");
}
else
{
    Console.WriteLine($"Третья цифра введенного числа равна {GetThreeLetterOfNumber(number)}");
}
