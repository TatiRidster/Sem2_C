// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите любое число не более 9999999");
int number = Convert.ToInt32(Console.ReadLine());

int m = number;
int n = 3;
int i = 0;
int n2;
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (m != 0)
    {
        m /= 10;
        i++;
    }

    n2 = i - n;
    m = number;
    i = 0;

    while (i < n2)
    {
        m /= 10;
        i++;
    }
    Console.WriteLine("третья цифра числа " + m % 10);

}