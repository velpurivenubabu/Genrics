namespace Genrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Any Below Option");
            Console.WriteLine("1.Finding Max Integer\n2.Finding Max Float\n3.Finding Max String");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Hello, Welcom To Genrics Problems!");
                    Console.WriteLine("Enter Num1");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num2");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num3");
                    int thirdNumber = Convert.ToInt32(Console.ReadLine());
                    MaxOf3ints.MaxmumIntegerNumber(firstNumber, secondNumber, thirdNumber);
                    break;

                case 2:

                    Console.WriteLine("Enter Num1");
                    float firstNumber1 = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Float Num2");
                    float secondNumber2 = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Float Num3");
                    float thirdNumber3 = (float)Convert.ToDouble(Console.ReadLine());
                    MaxFloats.MaxmumFloatNumber(firstNumber1, secondNumber2, thirdNumber3);
                    break;
                case 3:

                    Console.WriteLine("Enter Num1");
                    string st1 = Console.ReadLine();
                    Console.WriteLine("Enter Float Num2");
                    string st2 = Console.ReadLine();
                    Console.WriteLine("Enter Float Num3");
                    string st3 = Console.ReadLine();
                    FindingMaxString.FindingMaxSt(st1, st2, st3);
                    break;

            }
            
                
               
             
           
            
        }
   
    }
}