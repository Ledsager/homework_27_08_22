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
bool ElementPositiv(int num)
{
    bool result = false;
    if (num >= 0)
        result = true;
    return result;
}
// Метод считает сумму положительных и отрицательных элементов и выводит результат
void SumPositivAndNegativElement(int[] mas)
{
    int sumpositiv = 0;
    int yespositiv = 0, nopositiv = 0;

    int sumnegativ = 0;
    foreach (int element in mas)
        if (ElementPositiv(element) == true)
        {
            yespositiv++;
            sumpositiv = sumpositiv + element;
        }
        else
        {
            nopositiv++;
            sumnegativ = sumnegativ + element;
        }
    if(yespositiv > 0)
        Console.WriteLine($"Сумма положительных элементов массива = {sumpositiv}");
    else
        Console.WriteLine($"положительных элементов в массиве нет");
    if(nopositiv > 0)
        Console.WriteLine($"Сумма отрицательных элементов массива = {sumnegativ}");
    else
        Console.WriteLine($"отрицательных элементов в массиве нет");
}
Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];
RandomArrayElement(array, 0, 10);// Генерация элементов масива в заданном диапазоне
PrintArray(array);
SumPositivAndNegativElement(array);
