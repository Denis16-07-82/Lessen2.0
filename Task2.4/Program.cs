// Задача 5 *: Напишите программу, которая генерирует 
// несколько случайных чисел, и в цикле проверяет,
//  кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да
int Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    string strValue = System.Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;

}
int valueA = Prompt("Введите желаемое число : ");
while(1 == 1)
{
    int value = new Random().Next();
    if(value % valueA == 0)
    {
        System.Console.WriteLine($" Случайное число: {value} кратно числу ,введённому пользователем: {valueA}");
        break;
    }
    else
    {
        System.Console.WriteLine($" Случайное число: {value} не кратно числу ,введённому пользователем: {valueA}");
    }
}
