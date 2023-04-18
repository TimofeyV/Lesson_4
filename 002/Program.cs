// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int result = 0;


for (int i = 0; i < text.Length; i++)
{
    int last_figure = number % 10;
    number /= 10;
    result += last_figure;
}

Console.WriteLine($"Сумма всех цифр в числе = {result}");