// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// Метод для генерации значений элементов массива (с диапазоном от min до max)
void RandomArrayElement(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while (i < position.Length)
    {
        position[i] = rand.Next(min, max);
        i++;
    }
}
// Метод для вывода на экран элементов массива
void PrintArray(int[] position)
{
    foreach (int element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}

Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];
RandomArrayElement(array, 0, 2);// Генерация элементов масива c 0 и 1
PrintArray(array);