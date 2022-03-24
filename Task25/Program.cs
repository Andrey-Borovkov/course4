/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/
// Сперва сделал таким образом 

/* Console.Write("Введите Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

double ExpOfNumber(int number, int exp)
{
    double result = Math.Pow(number, exp);
    return result;
}
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {ExpOfNumber(A, B)}");
*/

// Потом перечитал условие и увидел, что надо использовать цикл

Console.Write("Введите Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

int ExpOfNumber(int number, int exp)
{
    int result = 1;
    for (int i = 1; i <= exp; i++)
    {
       result = result * number;
    }
    return result;
}
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {ExpOfNumber(A, B)}");