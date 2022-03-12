namespace Quotiend_remainder
{
    class Program
    {
        public void Calculation()
        {
            int DIVIDENT;
            int DIVISOR;
            int REMAINDER;
            int QUOTIENT;
            Console.WriteLine("enter the divident :");
            DIVIDENT =int.Parse(Console.ReadLine());
            Console.WriteLine("enter the divisor :");
            DIVISOR = int.Parse(Console.ReadLine());
            QUOTIENT = DIVIDENT / DIVISOR;
            REMAINDER = DIVIDENT % DIVISOR;
            Console.WriteLine("Quotient value : " + QUOTIENT);
            Console.WriteLine("Remainder value : " + REMAINDER);
        }
    }
    class Result
    {
        public static void Main(string[]args)
        {
            Program program = new Program();
            program.Calculation();
        }
    }
}