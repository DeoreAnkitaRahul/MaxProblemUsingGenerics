namespace MaxProblemUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {

           // Console.WriteLine("Welcome To Max Problem Using Generics");
            int num1 = 70, num2 = 120, num3 = 100;

            int value = MaxNo.MaximumIntegerNumber(num1, num2, num3);

            Console.WriteLine(value + " is greatest");
        }
    }
}

