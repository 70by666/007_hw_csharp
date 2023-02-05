// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] Task_47(int first, int second, int from, int to)
{
    Random rnd = new Random();
    double [,] arr = new double [first, second];
    for (int i = 0; i < first; i++)
    {
        for (int j = 0; j < second; j++)
        {
            arr[i, j] = rnd.Next(from, to);

        }
    }

    return arr;
}


void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }

    Console.WriteLine();
    }
}


PrintArr(Task_47(first: 3, second: 4, from: 0, to: 10));


System.Console.WriteLine("#################################");


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// я так понимаю 17 это значение элемента, а не индекс, 
// индекс должен же был быть записан [1, 2] например
// так же как и снизу, по такому же принцупу, только два параметра для индексов
string Task_50(int value)
{
    int [,] arr = new int [3, 4] {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}};
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (arr[i, j] == value)
            {
                return $"value = {arr[i, j]}, pos = {i}, {j}";
            }
        }
    }

    return "Error";
}


System.Console.WriteLine(Task_50(17));
System.Console.WriteLine(Task_50(666));
System.Console.WriteLine(Task_50(8));


System.Console.WriteLine("#################################");


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Task_52(double[,] arr)
{
    string result = "";
    double temp = 0;
    int count = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            temp += arr[j, i];
            count ++;
        }

        result += Convert.ToString(Math.Round(temp / count, 2)) + ", ";
        temp = 0; count = 0;
    }

    PrintArr(arr);
    System.Console.WriteLine(result);
}


Task_52(Task_47(first: 3, second: 4, from: 0, to: 10));
