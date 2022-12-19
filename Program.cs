Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите A:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите B:");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("A больше B");
}
else
{
    
}
if (number1 < number2)
{
    Console.WriteLine("B больше A");
}
else
{
    Console.WriteLine("A равно B");

}

Console.WriteLine("Задача 2: Найти максимальное из трёх чисел.");
Console.Write("Введите певрое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int num3 =int.Parse(Console.ReadLine()!);

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3);
{
    max = num3;
}
Console.WriteLine($"максимальное число = {max}");

Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).");
Console.Write("Введите число:");
int number=int.Parse(Console.ReadLine()!);

if(number%2==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}

Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите N:");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
{
    Console.Write($"{i}");
}
i++;
}

