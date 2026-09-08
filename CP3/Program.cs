namespace CP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Money(100m);
            var b = new Money(30m);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(-a);
        }
    }
}
