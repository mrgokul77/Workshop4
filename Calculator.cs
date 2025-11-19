namespace OOPWorkshop
{
    public class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
