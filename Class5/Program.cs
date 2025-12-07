namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////deligate, action, func, predicate
            //args.ToList().ForEach(arg => Console.WriteLine(arg));
            //Program program = new Program();
            //program.MyMethod();


            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
            };
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine($"Stack Pop: {stack.Pop()}");
            Console.WriteLine($"Stack Pop: {stack.Pop()}");

            Console.WriteLine("---------------------------------");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(20);
            queue.Enqueue(50);

            Console.WriteLine($"Queue Dequeue: {queue.Dequeue()}");

            Console.WriteLine($"Queue Dequeue: {queue.Dequeue()}");




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
