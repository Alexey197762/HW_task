/* Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число ");
int namber = Convert.ToInt32(Console.ReadLine());
int caunt = 1;
while(caunt <= namber)
{
    if( caunt % 2 == 0)
    {
        Console.Write($"{caunt} ");
    }
    caunt = caunt + 1;
}