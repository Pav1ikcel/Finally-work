/*
using System;
class Program {
    static void Main(string[] args) {
        // Объявление и заполнение первоначального массива строк
        string[] initialArray = { "hello", "2", "world", ":-)"};

        // Создание нового массива строк
        string[] newArray = new string[initialArray.Length];
        int count = 0;

        // Проверка каждой строки на длину
        foreach (string s in initialArray) {
            if (s.Length <= 3) {
                newArray[count] = s;
                count++;
            }
        }

        // Вывод нового массива строк
        for (int i = 0; i < count; i++) {
            Console.WriteLine(newArray[i]);
        }
    }
}
*/


//Вот пример решения на языке C#, считывающий количество строк и сами строки с помощью консольного ввод.

using System;
class Program {
    static void Main(string[] args) {
        // Ввод количества строк
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        // Объявление и заполнение первоначального массива строк
        string[] initialArray = new string[n];
        Console.WriteLine("Введите строки:");
        for (int i = 0; i < n; i++) {
            initialArray[i] = Console.ReadLine();
        }
        // Создание нового массива строк
        string[] newArray = new string[initialArray.Length];
        int count = 0;

        // Проверка каждой строки на длину
        foreach (string s in initialArray) {
            if (s.Length <= 3) {
                newArray[count] = s;
                count++;
            }
        }
        // Вывод нового массива строк
        for (int i = 0; i < count; i++) {
            Console.WriteLine(newArray[i]);
        }
    }
}
