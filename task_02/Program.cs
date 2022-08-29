// Возведите число А в натуральную степень B используя цикл

int Degree(int n, int degree)// Возведение в степень
{
    int i;
    int result = 1;
    for (i = 1; i <= degree; i++)
    {
        result = result * n;
    }
return result;
}
int NumberEntry()// Функция ввода числа
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите число n: ");
    return Number;
}
Console.WriteLine("Введите число n: ");
int n = NumberEntry();
Console.WriteLine($"Введите степень в которую возводим число {n}: ");
int degree = NumberEntry();
Console.WriteLine($"Число {n} в степени {degree}: = {Degree(n, degree)}");