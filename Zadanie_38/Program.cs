using System;

class Program
{
    static void Main()
    {
        // Создаем массив вещественных чисел
        double[] array = { 2.5, 1.3, 4.7, 3.1, 2.8 };
        
        // Инициализируем переменные для максимального и минимального элементов
        double max = array[0];
        double min = array[0];
        
        // Находим максимальный и минимальный элементы
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        
        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;
        
        // Выводим результат на экран
        Console.WriteLine("Массив: " + string.Join(", ", array));
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}
