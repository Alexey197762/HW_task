﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("Введите число ");
int namber = Convert.ToInt32(Console.ReadLine());

if( namber % 2 == 0)
{
    Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число не четное");
}