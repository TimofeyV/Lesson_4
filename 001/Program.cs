// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Если я правильно понял задание, то надо было сделать именно цикл, если же нет, то есть решение короче
//                               |
//                               |
//                              \ /
// Console.WriteLine($"Число {number} в степени {degree} = {Math.Pow(number,degree)}");


Console.WriteLine("Программа возводит число в натуральную степень");
Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
Console.Write($"Введите степень в которую надо возвести число {number}: ");
string text1 = Console.ReadLine();
int degree = Convert.ToInt32(text1);
int result = 1;

for (int i = 0; i < degree; i++)
{
    result *= number;
}

Console.WriteLine($"Число {text} в степени {degree} = {result}");
