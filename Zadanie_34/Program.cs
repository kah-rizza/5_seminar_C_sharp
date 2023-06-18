using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int arraySize = 10;

        // Создаем массив
        int[] numbers = new int[arraySize];

        // Заполняем массив случайными положительными трехзначными числами
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив чисел:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Подсчитываем количество четных чисел
        int evenCount = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим количество четных чисел
        Console.WriteLine("Количество четных чисел: " + evenCount);

        // Ждем, пока пользователь нажмет клавишу Enter, чтобы закрыть консольное окно
        Console.ReadLine();
    }
}
