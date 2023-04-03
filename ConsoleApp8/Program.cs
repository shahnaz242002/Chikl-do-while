Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Напишите свой пароль");
int parol1 = Convert.ToInt32(Console.ReadLine());
int parol2 = Convert.ToInt32(Console.ReadLine());
if (parol1 == parol2) 
{
    Console.WriteLine("Пароли совпадают");
}
else
{
    do
    {
        Console.WriteLine("Пароли не совпадают");
        parol1 = Convert.ToInt32(Console.ReadLine());
        parol2 = Convert.ToInt32(Console.ReadLine());

    }
    while (parol1 != parol2);

}


