// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа

int Prompt(string messeg)
{
    int value = new Random().Next(100, 999);
    System.Console.WriteLine($"Случайное трёхзначное число : {value} ");
    return value;

}
int valueA = Prompt("Случайное трёхзначное число");// Просто мне так захотелось сделать ,чтоб привычка вводить функции была.
int valueB = (valueA % 10) + ((valueA - (valueA % 100)) / 10);
System.Console.WriteLine($"Полученое число после удаления второй цифры : {valueB} ");