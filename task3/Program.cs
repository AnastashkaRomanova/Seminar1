//Напишите программу,  которая на вход принимает число и выдает, является ли число чётным
int Usernumber = new int();
Console.WriteLine("Введите чиcло: ");
Usernumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введенное число чётное?");

if (Usernumber%2 == 0)
    {
        Console.WriteLine("да");
    }

else 
{
    Console.WriteLine("нет");
}



