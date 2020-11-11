class Program
{
    static void Main(string[] args)
    {
        int value = 100 / 2;
            //1
        if (value == 50)
        {
            //2
            Console.WriteLine(true);
        }

        //3
        Console.WriteLine("Since I'm not in the if block, I'll always display.");
    }
}