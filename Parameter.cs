namespace OOPWorkshop
{
    public class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number += 10;
        }

        public void GetFullName(out string fullname)
        {
            fullname = "Sachin Tichkule";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers) sum += n;
            return sum;
        }
    }
}
