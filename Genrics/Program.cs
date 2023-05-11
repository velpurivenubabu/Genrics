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
            Console.WriteLine("Enter Num1");
            float firstNumber1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Float Num2");
            float secondNumber2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Float Num3");
            float thirdNumber3 = (float)Convert.ToDouble(Console.ReadLine());
            MaxFloats.MaxmumFloatNumber(firstNumber1, secondNumber2, thirdNumber3);
        }
    }
}