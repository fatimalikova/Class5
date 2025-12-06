namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deligate, action, func, predicate
        }

        public delegate int MyDeligate(int x, int y);
        public void MyMethod()
        {
            MyDeligate del = (a, b) => a + b;
            int result = del(5, 10);
            Console.WriteLine($"Result from MyDeligate: {result}");
            Action<string> action = message => Console.WriteLine(message);
            action("Hello from Action!");

            Func<int, int, int> func = (a, b) => a * b;
            int funcResult = func(4, 5);
            Console.WriteLine($"Result from Func: {funcResult}");

            Predicate<int> predicate = number => number > 0;
            bool isPositive = predicate(-3);
            Console.WriteLine($"Is -3 positive? {isPositive}");
        }
    }
}
