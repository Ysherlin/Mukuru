namespace Mukuru
{
    public class Greeter
    {
        public string SayHello()
        {
            return "Hello, World!";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            Console.WriteLine(greeter.SayHello());
        }
    }
}
