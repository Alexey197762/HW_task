/*Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Введите число 1:");
int namberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int namberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int namberC = Convert.ToInt32(Console.ReadLine());

int max = namberA;

if(namberA > max) max = namberA;
if(namberB > max) max = namberB;
if(namberC > max) max = namberC;

Console.WriteLine($"Максимальное число равно: {max} ");