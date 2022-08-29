// Найти кубы чисел от 1 до N

void Cube(int q)
{
    int i;
    for (i = 0; i <= q; i++)
    {
        Console.WriteLine($" {i} в кубе = {i * i * i}");// Или Console.WriteLine($" {i} в кубе = {Math.Pow(i,3)}");
    }
}

Console.WriteLine("Введите число n: ");
int Number;
while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите число n: ");
Cube(Number);