// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void SumOddNumbers()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

    int sumNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) sumNumbers += array[i];
    }
    Console.WriteLine($"Сумма чисел нечетных позиций = {sumNumbers}"); 
}

SumOddNumbers();

