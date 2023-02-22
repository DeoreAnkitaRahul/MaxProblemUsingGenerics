namespace MaxProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {

           // Console.WriteLine("Welcome To Max Problem Using Generics");
            double num1 = 6.70, num2 = 1.20, num3 = 10.0;

            double value = MaxNo.MaximumIntegerNumber(num1, num2, num3);

            Console.WriteLine(value + " is greatest");
        }
    }
}

