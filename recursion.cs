// Коя от фигурите ще бъде изведена на стандартния изход след извикването на метода

1.

static void PrintNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        PrintNumbers(n - 1);
    }
}

2.

static void PrintReverse(int n)
{
    if (n > 0)
    {
        PrintReverse(n - 1);
        Console.Write(n + " ");
    }
}

3.

static void Nested(int n)
{
    if (n > 0)
    {
        Console.Write("[");
        Nested(n - 1);
        Console.Write("]");
    }
}

4.

static void Pattern(int n)
{
    if (n > 0)
    {
        Pattern(n - 1);
        for (int i = 0; i < n; i++) Console.Write("*");
        Console.WriteLine();
    }
}

5.

static void AltPrint(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        if (n % 2 == 0)
            AltPrint(n - 2);
        else
            AltPrint(n - 1);
    }
}

6.

static void Mirror(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        Mirror(n - 1);
        Console.Write(n + " ");
    }
}

7.

static void Triangle(int row, int col = 1)
{
    if (row > 0)
    {
        if (col <= row)
        {
            Console.Write("* ");
            Triangle(row, col + 1);
        }
        else
        {
            Console.WriteLine();
            Triangle(row - 1, 1);
        }
    }
}

8.

static void Letters(int n)
{
    if (n > 0)
    {
        Letters(n - 1);
        Console.Write((char)('A' + n - 1));
        Letters(n - 1);
    }
}

9.

static void BackAndForth(int n)
{
    if (n > 0)
    {
        Console.Write("<");
        BackAndForth(n - 1);
        Console.Write(">");
    }
}

10.

static void AltRow(int n)
{
    if (n > 0)
    {
        AltRow(n - 1);
        for (int i = n; i >= 1; i--) Console.Write(i + " ");
        Console.WriteLine();
    }
}

11.

static void IndirectA(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        IndirectB(n - 1);
    }
}
static void IndirectB(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        IndirectA(n - 1);
    }
}

12.

static void DoubleCall(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        DoubleCall(n - 1);
        DoubleCall(n - 2);
    }
}

13.

static void Spaces(int n)
{
    if (n > 0)
    {
        Spaces(n - 1);
        Console.WriteLine(new string(' ', n) + "*");
    }
}

14.

static void Fig(int n)
{
    if (n > 0)
    {
        Fig(n - 1);
        Row(n);
        Console.WriteLine();
    }
}
static void Row(int n)
{
    if (n > 0)
    {
        Console.Write("* ");
        Row(n - 1);
    }
}

15.

static void Pyramid(int n, int i = 1)
{
    if (i <= n)
    {
        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        Pyramid(n, i + 1);
    }
}

16.

static void Countdown(int n)
{
    if (n >= 0)
    {
        Console.Write(n + " ");
        Countdown(n - 1);
    }
}

17.

static void Palindrome(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        Palindrome(n - 1);
        Console.Write(n + " ");
    }
}

18.

static void EvenOdd(int n)
{
    if (n > 0)
    {
        if (n % 2 == 0)
            Console.Write("E ");
        else
            Console.Write("O ");
        EvenOdd(n - 1);
    }
}

19.

static void NumberGrid(int n)
{
    if (n > 0)
    {
        NumberGrid(n - 1);
        for (int i = 1; i <= n; i++) Console.Write(i + " ");
        Console.WriteLine();
    }
}

20.

static void Combo(int n)
{
    if (n > 0)
    {
        Row(n);
        Console.WriteLine();
        Combo(n - 1);
    }
}
static void Row(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        Row(n - 1);
    }
}
