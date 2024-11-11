try
{
    Console.WriteLine("Введите N:");
    int N = int.Parse(Console.ReadLine());
    for (int i = 2; i <= N; i++)
    {
        bool isPrime = true;
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.Write($"{i} ");
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}