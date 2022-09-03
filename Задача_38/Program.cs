// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

void DiffBetweenMaxMin()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble()), 3);   // array[i] = Math.Round (array[i], 3);
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

    double Max = array.Max();
    double Min = array.Min();
    double Diff = Max - Min;
    
    Console.WriteLine($"Максимальный элемент = {Max:f3}"); 
    Console.WriteLine($"Минимальный элемент = {Min:f3}"); 
    Console.WriteLine($"Разница между Max и Min = {Diff:f3}");
}
DiffBetweenMaxMin();

