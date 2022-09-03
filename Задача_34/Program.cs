// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void CountEvenNumbers()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);   // [100; 999] - положит.трехзнач.числа
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

    int evenNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenNumbers++;
    }
    Console.WriteLine($"Количество четных чисел в массиве = {evenNumbers}"); 
}

CountEvenNumbers();

