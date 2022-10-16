// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = 2;
Console.Write($"Четные числа от {num}: ");
while (num > x)
{
    Console.Write($"{x} ");
    x = x+2;
}
Console.WriteLine();