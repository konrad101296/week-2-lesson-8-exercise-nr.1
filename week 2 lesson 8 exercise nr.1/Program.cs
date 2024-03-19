int primeNumbersCount= 0;
int dividersCount= 0;
for (int i = 2; i <= 100; i++)
{

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            dividersCount++;
        }
        if (dividersCount == 2 && i == j)
        {
            primeNumbersCount++;
        }
    }
    dividersCount = 0;
}
Console.WriteLine($"In the range of 1 to 100 is {primeNumbersCount} prime numbers");
