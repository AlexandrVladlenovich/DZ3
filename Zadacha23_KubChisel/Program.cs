Console.Clear();
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
    for (int i = 0; i <= n; i++)
        Console.WriteLine("{0}^3 = {1}", i, i*i*i);
Console.ReadKey(true);