// Показать кубы чисел, заканчивающихся на четную цифру

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
// Метод проверки четности числа
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
int i = 1;
RandomArrayElement(array, 1, 8);// Генерация элементов масива в заданном диапазоне
PrintArray(array);
foreach (int element in array)
{
    if (ElementEven(element) == true)
    {
        Console.Write($"элемент массива №{i} или элемент массива с индексом {i - 1} , в третьей степени = ");
        ElementCube(element);
    }
    i++;
}
