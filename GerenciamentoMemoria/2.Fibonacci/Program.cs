

Console.WriteLine(GetNthFibonacci(20));

static int GetNthFibonacci(int n)
{
    if ((n == 0) || (n == 1))
    {
        return n;
    }
    return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
}


Console.ReadKey();