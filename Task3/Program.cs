void Zadacha42()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Raschet(number));
}

int Raschet(int numb = 0)
{
    int result = 0;
    int bias = 1;
    while( numb > 0)
    {
        result += numb %2 * bias;
        bias *=10;
        numb /=2;
    }
    return result;
}

Zadacha42();