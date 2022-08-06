namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Areola areola = new Areola();

            Console.WriteLine (areola.Father());
            Console.WriteLine(areola.Mother());
            Console.WriteLine(areola.Child());
        }
    }
}