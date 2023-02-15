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
