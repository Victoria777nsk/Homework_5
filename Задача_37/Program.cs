// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] EnterArray()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
    return array;
}

int[] ProductPairsNumbers(int[] array)
{
    int size = array.Length / 2;
    
    if (array.Length % 2 == 1) size++;
    
    int[] productNumbers = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array.Length % 2 == 1) 
        {
            productNumbers[size-1] = array[array.Length / 2];
        }
        productNumbers[i] = array[i] * array[array.Length - 1 - i];
    }
    Console.WriteLine($"Массив произведений пар чисел: [{String.Join(", ", productNumbers)}]");
    return productNumbers;
}

ProductPairsNumbers(EnterArray());
