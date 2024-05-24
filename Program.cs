namespace TodoListApplication;

class Program
{
    static void Main(string[] args)
    {
        List<string>todos=new List<string>();
        bool exitProgram = false;
        Console.WriteLine("Hello");
        while(!exitProgram)
        {

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all Todos");
            Console.WriteLine("[A]dd all todos");
            Console.WriteLine("[R]emove toods");
            Console.WriteLine("[E]xit Program");
            string userInput=Console.ReadLine().ToLower();
            if(userInput=="a")
            {
                Console.WriteLine("Add a description");
                string description=Console.ReadLine();
                todos.Add(description);
            }
            else if(userInput=="s")
            {
                for(int i=0;i<todos.Count;i++)
                {
                    Console.WriteLine($"{i}: {todos[i]}");

                }
                
            }
            else if(userInput=="r")
            {
                Console.WriteLine("Current Todos");
                for(int i=0;i<todos.Count;i++)
                {
                    Console.WriteLine($"{i}: {todos[i]}");

                }
                Console.WriteLine("Enter the index you want to be removed");
                int indexRemoval=Convert.ToInt32(Console.ReadLine());
                if(indexRemoval>=0&&indexRemoval<todos.Count)
                {
                    todos.RemoveAt(indexRemoval);
                    Console.WriteLine("TODO has been removed successfully");
                }
                else
                {
                    Console.WriteLine("Innvalid Index");
                }
            }
            else if(userInput=="e")
            {
                exitProgram=true;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }    

        }
    }
}

