// Написать программу вычисления произведения чисел от 1 до N

int Factorial(int q)
{
    int i;
    int result = 1;
    for (i = 1; i <= q; i++)
    {
        result = result * i;
    }
return result;
}

Console.WriteLine("Введите число n: ");
int Number;
while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите число n: ");
Console.Write($"Произведение чисел от 1 до {Number} = {Factorial(Number)}");
