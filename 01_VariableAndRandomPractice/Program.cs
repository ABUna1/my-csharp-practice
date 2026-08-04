class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Generate equations for addition and subtraction:");
        for (int i = 0; i < 5; i++)
        {
            int position1 = new Random().Next(1, 100);
            int num2 = new Random().Next(1, 100);
          Console.WriteLine($"{position1} + {num2} = {position1 + num2}");
          Console.WriteLine($"{position1} - {num2} = {position1 - num2}");
        }
    }
}