namespace GetNames1
{
    public class GetNames
    {
        public static void Names1()
        {
            Console.WriteLine("Hello Please Enter Name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Hello There " + name);
        }
    }

    public class Tasks
    {
        public static void GetTasks()
        {
            Console.WriteLine("Enter Task 1: ");
            var taskOne = Console.ReadLine();
            Console.WriteLine("Enter Task 2: ");
            var taskTwo = Console.ReadLine();

            Console.WriteLine("TASK ONE: " + taskOne);
            Console.WriteLine("TASK TWO: " + taskTwo);
        }
    }

    public class Names
    {
        public static bool isActive = false;

        public static void Main(string[] args)
        {
            var names = new GetNames();
            GetNames.Names1();
            var t = new Tasks();
            Tasks.GetTasks();
            Console.ReadLine();
        }
    }
}
