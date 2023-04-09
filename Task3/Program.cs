//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


Console.Write("Укажите число");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

if (numberA % 2 == 0)
{
    System.Console.WriteLine("Чётные");
}
else
{
    System.Console.WriteLine("нечётные");
}