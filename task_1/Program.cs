/* Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1:");
int namber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int namber_2 = Convert.ToInt32(Console.ReadLine());
int max = namber;
if(namber > max) max = namber;
if(namber_2 > max) max = namber_2;
 
Console.WriteLine($"Максимальное число равно: {max} ");