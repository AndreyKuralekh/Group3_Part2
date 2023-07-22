namespace ConsoleApp1
{
    internal class Program
    {
        delegate void PrintString(string str);

        static void Main(string[] args)
        {
            PrintString printString;
            
            IPrint _pr = new Print();
            var initialString = "This is my string!";

            printString  = new PrintString(_pr.PrintStr);
            printString += new PrintString(_pr.PrintGreenStr);
            printString += new PrintString(_pr.PrintOrangeStr);

            printString(initialString);

            Console.WriteLine("The end");
        }

    }

    public class Print :IPrint
    {
        public void PrintStr(string str)
        {
            Console.WriteLine($"String: {str}");
        }
        public void PrintGreenStr(string str)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"String: {str}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void PrintOrangeStr(string str)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"String: {str}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    public interface IPrint
    {
        void PrintStr(string str);
        void PrintGreenStr(string str);
        void PrintOrangeStr(string str);
    }
}