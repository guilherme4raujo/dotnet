using System;

public class Piramide
{
    public int N { get; private set; }

    public Piramide(int n)
    {
        if (n < 1)
            throw new ArgumentException("O valor de N deve ser maior ou igual a 1.");
        N = n;
    }

    public void Desenha()
    {
        for (int i = 1; i <= N; i++)
        {
            Console.Write(new string(' ', N - i));
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            for (int j = i - 1; j >= 1; j--)
                Console.Write(j);
            Console.WriteLine();
        }
    }
}
