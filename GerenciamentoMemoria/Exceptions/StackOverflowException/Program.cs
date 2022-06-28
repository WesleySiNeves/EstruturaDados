﻿



public class Example
{
    private const int MAX_RECURSIVE_CALLS = 100000;
    static int ctr = 0;

    public static void Main()
    {
        Example ex = new Example();
        Console.WriteLine("\nThe call counter: {0}", ctr);
        ex.Execute();

    }

    private void Execute()
    {
        ctr++;
        if (ctr % 50 == 0)
            Console.WriteLine("Call number {0} to the Execute method", ctr);

        if (ctr <= MAX_RECURSIVE_CALLS)
            Execute();

        ctr--;
    }
}