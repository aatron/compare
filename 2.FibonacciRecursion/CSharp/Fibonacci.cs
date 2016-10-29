namespace CSharp
{
    public class Fibonacci
    {
        public int Calculate(int sequenceIndex)
        {
            if (sequenceIndex <= 1)
                return 1;
            else
            {
                return Calculate(sequenceIndex - 2) + Calculate(sequenceIndex - 1);
            }
        }
    }
}