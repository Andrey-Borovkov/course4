// See https://aka.ms/new-console-template for more information
Console.Write("Выберете четверть: ");
int Chetvert = Convert.ToInt32(Console.ReadLine());
if (Chetvert == 1)
{
    Console.WriteLine("Координаты X и Y могут принимать значения больше 0");
}
else
{
    if (Chetvert == 2)
    {
       Console.WriteLine("Координаты X  могут принимать отрицательные значения, а координаты Y  больше 0");
    } 
    else
    {
      if (Chetvert == 3)
    {
       Console.WriteLine("Координаты X и Y  могут принимать отрицательные значения");
    }  
    else
    {
       Console.WriteLine("Координаты X  могут принимать положительные значения, а координаты Y  отрицательные"); 
    } 
    }   
    
}
