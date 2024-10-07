int counter = 2;
int primeCounter = 1;
int primeNumberCount = 0;


primeNumberCount = Input();
if (primeNumberCount <= 0) 
{
    Console.WriteLine("Введите число больше 0");
    primeNumberCount = Input();
}
while (primeCounter < primeNumberCount)
{
    counter++;
    if (isPrime(counter) == true)
    {
        primeCounter++;
    }
}
Console.WriteLine($"Ваше простое число: {counter}");

int Input()
{
    try
    {
        Console.Write("Введите порядковый номер: ");
        return int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Неправильный ввод данных");
        return Input();
    }
}
bool isPrime(int number)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}