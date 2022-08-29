// Подсчитать сумму цифр в числе

int DigitsSum(int n)// Сумма цифр в числе
{
    int result = 0;
    do
    {
        result = result + n % 10;// выделяем последнюю цифру от числа и плюсуем ее значение к rуsult(остаток от деления на 10)
        n = n / 10;//уменьшаем число на 10 (целочисленное деление)
    }
    while(n !=0);
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
Console.WriteLine($"Сумма цифр в числе {n} : = {DigitsSum(n)}");
