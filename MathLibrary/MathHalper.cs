namespace MathLibrary
{
    public class MathHalper
    {
        public static int Max(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }
    }
}