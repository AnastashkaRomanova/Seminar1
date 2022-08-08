// Напишите программу, которая на вход принимает число (N)а на выходе показывает все четные числа от 1 до N.
int Usernumber = new int();
Console.WriteLine("Введите чиcло: ");
Usernumber = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i<= Usernumber)
{
    Console.WriteLine(i);
    i += 2;
}
    

