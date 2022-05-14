// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
bool n1 = (number < 1) | (number > 7);
bool n2 = (n1 == false) & (number < 6);
bool n3 = (n1 == false) & (number > 5);


if (n2 == true)
{
    Console.WriteLine("это рабочий день");
}
else if (n3 == true)
{
    Console.WriteLine("это выходной");
}

else if (n1 == true)
{
    Console.WriteLine("число введено неверно");
}
else
{
    Console.WriteLine("логический абсурд");
}
