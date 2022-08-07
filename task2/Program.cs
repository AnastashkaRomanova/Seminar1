// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите чило 1: ");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
double number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чило 3: ");
double number3 = Convert.ToInt32(Console.ReadLine());

double max = number1;

if (number2 > number1) max = number2;
if (number3 > number2) max = number3;


Console.Write("Максимальное число = "); Console.WriteLine(max);

