using System;

namespace SkiResortManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //SkiResort skiResort = SkiResort.Instance();
            Manager manager = new Manager();
            SkiResortProxy proxy = new SkiResortProxy(manager);
            Log log = new Log(proxy, "Economist", "User1");
            Log log2 = new Log(proxy, "Worker", "User2");
            Log log3 = new Log(proxy, "Manager", "User3");
            proxy.Add(log);
            proxy.Add(log2);
            proxy.Add(log3);

            while (proxy.GetDaysLeft() != 0)
            {
                Manager.StartDay(proxy);
                Console.Write("Make a decision:");
                int choice = int.Parse(Console.ReadLine());
                Manager.MakeAction(choice, proxy);
                while (choice != 8)
                {
                    Console.Write("Make a decision:");
                    choice = int.Parse(Console.ReadLine());
                    Manager.MakeAction(choice, proxy);
                }
            }
        }

        
    }
}
