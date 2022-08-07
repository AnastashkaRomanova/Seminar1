// Напишите программу, которая на вход принимает два числа, и выдает, какое большее, а какое меньшее.
Console.WriteLine("Введите чило 1: ");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
double number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("max = ");  Console.WriteLine(number1); 
    Console.Write("min = ");  Console.Write(number2); 
}
else
{
    Console.Write("max = ");  Console.WriteLine(number2);
    Console.Write("min = ");  Console.WriteLine(number1); 
}


