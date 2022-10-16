// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = num % 2;
if (x == 0) Console.WriteLine($"Число {num} четное");
else Console.WriteLine($"Число {num} нечетное");
