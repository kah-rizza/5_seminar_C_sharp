using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine()); // Вводим размер массива с клавиатуры

        // Создаем и заполняем массив случайными числами
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10); // Генерируем случайное число от 1 до 10 и сохраняем в массив
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Создаем новый массив для хранения произведений пар чисел
        int[] productArray = new int[size / 2];

        // Вычисляем произведения пар чисел и записываем в новый массив
        for (int i = 0; i < size / 2; i++)
        {
            productArray[i] = array[i] * array[size - 1 - i]; // Произведение пары чисел сохраняем в новый массив
        }

        // Выводим новый массив с произведениями пар чисел
        Console.WriteLine("Массив с произведениями пар чисел:");
        PrintArray(productArray);
    }

    // Вспомогательный метод для вывода массива
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " "); // Выводим каждый элемент массива
        }
        Console.WriteLine();
    }
}
