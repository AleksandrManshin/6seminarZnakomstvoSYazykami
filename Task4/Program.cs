// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.


// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

void Zadacha44()
{
    int numberFirst = 0;
    int numberSecond = 1;

    int count = 60;

    for(int i = 0; i < count; i++)
    {
        Console.WriteLine(numberFirst);
        int temp = numberSecond;
        numberSecond = numberFirst + numberSecond;
        numberFirst = temp;

    }
}

Zadacha44();
