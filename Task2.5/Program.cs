// Задача 4: Напишите программу, которая принимает
//  на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
int Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    string strValue = System.Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;

}
int valueA = Prompt("Введите число , обозначающее день недели : ");
string[]arrayDay = {"пн.","вт.","ср.","чт.","пт.","сб.","вс."};
if(valueA > 0)
{
    valueA = valueA % 7 - 1;
    if(valueA > 4)
    {
        System.Console.WriteLine($"Ура!!!Сегодня выходной день {arrayDay[valueA]}");
    }
    else
    {
        System.Console.WriteLine($"Сегодня будний день {arrayDay[valueA]}");
    }
}
else
{
    System.Console.WriteLine("Вы ввели некорректное число");
}
