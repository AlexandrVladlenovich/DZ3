Console.Clear();
int i, remainder = 0, newnum = 0;
    Console.WriteLine("Введите число: ");
    int uinput = Convert.ToInt32((Console.ReadLine()));
        for (i = uinput; i > 0; i = (i / 10))
        {
            remainder = i % 10;
            newnum = (newnum*10) + remainder;
        }
        if (newnum == uinput)
        {
            Console.WriteLine(" - число является полиндромом");
        }
        else
        {
            Console.WriteLine(" - число не является полиндромом");
        }
Console.ReadKey();