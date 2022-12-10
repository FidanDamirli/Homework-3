namespace Homework_3;
class Program
{
    static void Main(string[] args)
    {
        int Birthday, BirthMonth, BirthYear, today, ThisMonth, ThisYear;
        Console.WriteLine("Dogum gununuzun gunun daxil edin");
        Birthday = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dogum ayinizi daxil edin");
        BirthMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dogum ilin daxil edin");
        BirthYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bugunu daxil edin");
        today = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bu ayi daxil edin");
        ThisMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bu ili daxil edin");
        ThisYear = Convert.ToInt32(Console.ReadLine());
        int yas = ThisYear - BirthYear;
        if (BirthMonth > ThisMonth)
            yas -= 1;
        else if (BirthMonth == ThisMonth)
        {
            if (Birthday > today)
                yas -= 1;
        }
        if (yas >= 1)
            Console.WriteLine(yas);
        else
            Console.WriteLine("yashi tamam deyil");


        Console.ReadKey();

    }
}

