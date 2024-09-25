// See https://aka.ms/new-console-template for more information
namespace IntroToCSharp
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, C#!");
            Console.WriteLine("Good Day!");
            Console.Write("FirstName: Ahmadraza");
            Console.Write("\nLastName: Danmole");
            Console.Write("1\n101\n1001\n");
            Console.Write(DateTime.Now);
            Console.WriteLine(Math.Sqrt(12345));
            Console.WriteLine("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age + 10);
        }
    }
}