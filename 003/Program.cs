﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]
// 6, 1, 3 -> [6, 1, 3]


// Функция для печати массива
void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
}

// Функция, которая убирает пробелы, в том случае, если пользователь вводил их, указывая массив
string StrWithoutSpace(string series)
{
    string newStr = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            newStr += series[i];
        }
    }
    return newStr;
}

// Функция, которая проверить правильно ли введён массив
void CheckArray(char series)
{
    char[] standart = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ',' };

    if (standart.Contains(series))
    { }
    else
    {
        Console.WriteLine($"Произошла ошибка при вводе");
    }
}

// Фукнция для заполнения массива
int[] ArrOfNumb(string newStr)
{
    int[] array = new int[1];
    int[] except_arr = { };

    for (int i = 0, j = 0; i < newStr.Length; i++, j++)
    {
        string figure = "";

        while (newStr[i] != ',' && i < newStr.Length)  //Достаём по цифре из строки
        {
            figure += newStr[i];
            CheckArray(newStr[i]);
            i++;

            if ((figure.Length > 1 && figure[0] != '-') || figure.Length > 2) // Обработчик случая, если в ряде содержатся двузначные числа и более
            {
                Console.WriteLine("Разрешается вводить числа из промежутка (-10;10)");
                return except_arr;
            }
        }

        array[j] = Convert.ToInt32(figure);    // заполняет массив значениями из строки

        if (i < newStr.Length - 1)
        {
            array = array.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
    }
    return array;
}
Console.WriteLine("Данная программа преобразует ряд чисел в массив и выведет его на экран, разрешается вводить числа от -9 до 9.");
Console.Write("Введите ряд чисел, через запятую: ");
string StrArray = Console.ReadLine();

StrArray += ',';                   // запятая для обозначение конца строки

string newStr = StrWithoutSpace(StrArray);
int[] array = ArrOfNumb(newStr);
PrintArray(array);

