namespace Genrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcom To Genrics Problems!");
            Console.WriteLine("Enter Num1");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num3");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            MaxOf3ints.MaxmumIntegerNumber(firstNumber, secondNumber, thirdNumber);
        }
    }
}