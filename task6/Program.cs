﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Ведите число");
int numberA = Convert.ToInt32(Console.ReadLine());

int ost = numberA % 2;

if (ost == 0)
{
    Console.WriteLine ("да");
}
else
{
   Console.WriteLine ("нет");
} 
