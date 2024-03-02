int liczbapierwsza = 0;
int reszta = 0;
for (int i = 2; i <= 100; i++)
{

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            reszta++;
        }
        if (reszta == 2 && i == j)
        {
            liczbapierwsza++;
        }
    }
    reszta = 0;
}
Console.WriteLine($"W zakresie od 0 do 100 jest {liczbapierwsza} liczb pierwszych");