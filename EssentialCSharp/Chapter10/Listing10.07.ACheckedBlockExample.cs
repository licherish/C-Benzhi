namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_07
{
    public class Program
    {
        public static void Main()
        {
            checked
            {
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                System.Console.WriteLine(n);
            }
        }
    }
}