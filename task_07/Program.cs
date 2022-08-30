// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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
// возведение в куб элемента и вывод его на экран
void ElementCube(int cube)
{
    Console.WriteLine($"{Math.Pow(cube, 3)}");
}
// Метод проверки знака числа
bool ElementEven(int num)
{
    bool result = false;
    if (num % 2 == 0)
        result = true;
    return result;
}
Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];
RandomArrayElement(array, 0, 10);// Генерация элементов масива в заданном диапазоне

