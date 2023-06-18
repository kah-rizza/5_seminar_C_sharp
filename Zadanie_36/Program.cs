using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int size = 10;
        
        // Создаем генератор случайных чисел
        Random random = new Random();
        
        // Создаем массив и заполняем случайными числами
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 100
        }
        
        // Выводим массив на экран
        Console.WriteLine("Массив: " + string.Join(", ", array));
        
        // Вычисляем сумму элементов на нечетных позициях
        int sum = 0;
        for (int i = 1; i < size; i += 2)
        {
            sum += array[i];
        }
        
        // Выводим сумму на экран
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}
