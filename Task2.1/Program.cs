// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    string strValue = System.Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;

}
int valueA = Prompt("Введите трёхзначное число : ");
int valueB = 0;
if ((1000 > valueA & 99 < valueA) || (-1000 < valueA & -99 > valueA))
{
    valueB = Math.Abs (((valueA - (valueA % 10)) / 10) % 10);
    System.Console.WriteLine($"Вторая цифра : {valueB}   ");
}
else
{
    System.Console.WriteLine("Вы ввели не трёхзначное число");
}
