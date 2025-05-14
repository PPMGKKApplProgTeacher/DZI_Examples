// Примерни задачи за работа с потоци. Анализирайте ги и предвидете резултатът от изпълнение на програмата. Анализирайте спршмо различни варианти на съдържанието и локацията на  входните файлове

Пример 1

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("data.txt");
        string line = reader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line.ToUpper());
            line = reader.ReadLine();
        }
        reader.Close();
    }
}

Пример 2

using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            writer.WriteLine("Hello");
            writer.Write("World");
        }
    }
}

Пример 3

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("missing");
        string content = reader.ReadToEnd();
        Console.WriteLine(content);
    }
}

Пример 4

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        File.WriteAllLines("names.txt", names);
    }
}

Пример 5

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numbers.txt");
        int total = 0;
        foreach (string line in lines)
            total += int.Parse(line);
        Console.WriteLine(total);
    }
}

Пример 6

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("data.txt");
        writer.WriteLine("Line 1");
    }
}

Пример 7

using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("log.txt"))
        {
            Console.WriteLine(reader.ReadLine());
            reader.Close();
            Console.WriteLine(reader.ReadLine()); 
        }
    }
}

Пример 8

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";
        if (File.Exists(path))
        {
            string[] content = File.ReadAllLines(path);
            Console.WriteLine(content.Length);
        }
        else
        {
            Console.WriteLine("Файлът не съществува");
        }
    }
}

Пример 9

using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
            for (int i = 1; i <= 5; i++)
                writer.Write(i + " ");
        }
    }
}

Пример 10

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("data.txt");
        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        }
        reader.Dispose();
    }
}

Пример 11

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "notes.txt";
        File.AppendAllText(path, "New note\n");
        Console.WriteLine(File.ReadAllText(path));
    }
}

Пример 12

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("data.txt");
        writer.WriteLine("Missing semicolon")
        writer.Close();
    }
}

Пример 13

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] data = File.ReadAllLines("numbers.txt");
        int sum = 0;
        foreach (string s in data)
            sum += int.Parse(s.Trim());
        Console.WriteLine("Sum: " + sum);
    }
}

Пример 14

using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("greeting.txt", "Здравей, свят!");
        Console.WriteLine("Файлът беше създаден");
    }
}

Пример 15

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("data.txt");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            int num = Convert.ToInt32(line);
            Console.WriteLine(num * 2);
        }
        reader.Close();
    }
}

Пример 16

using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllLines("list.txt", new string[] { "one", "two", "three" });
        string[] result = File.ReadAllLines("list.txt");
        foreach (string s in result)
            Console.WriteLine(s.ToUpper());
    }
}

Пример 17

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("log.txt");
        writer.WriteLine("Start");
        int x = 5 / int.Parse("0"); 
        writer.WriteLine("End");
        writer.Close();
    }
}

Пример 18

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("test.txt");
        writer.Write("No newline");
        writer.Write(" Still same line");
        writer.Close();
    }
}

Пример 19

using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("text.txt", "Line1\nLine2\nLine3");
        string line = File.ReadLines("text.txt").Skip(1).First();
        Console.WriteLine(line);
    }
}

Пример 20

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string content = File.ReadAllText("nonexistent.txt");
        Console.WriteLine(content);
    }
}
