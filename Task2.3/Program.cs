// Задача 3: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
int Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    string strValue = System.Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;

}
int valueA = Math.Abs(Prompt("Введите целое число : "));
if (valueA > 99)
{
    while (valueA > 1000)
    {
        valueA = (valueA - valueA % 10) / 10;
    }
    valueA = valueA % 10;
    System.Console.WriteLine($"Третья цифра заданного числа : {valueA}");
}
else
{
    System.Console.WriteLine("Третья цифра заданного числа отсутствует");
}
