using System;

namespace SkiResortManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Management manager = new Management();
            SkiResortProxy proxy = new SkiResortProxy(manager);

            Log log = new Log(proxy, "Economist", "User1");
            Log log2 = new Log(proxy, "Worker", "User2");
            Log log3 = new Log(proxy, "Manager", "User3");

            proxy.Add(log);
            proxy.Add(log2);
            proxy.Add(log3);
            proxy.Remove(log3);

            while (proxy.GetDaysLeft() != 0)
            {
                Management.StartDay(proxy);
                Console.Write("Make a decision:");
                int choice = int.Parse(Console.ReadLine());
                Management.MakeAction(choice, proxy);
                while (choice != 8)
                {
                    Console.Write("Make a decision:");
                    choice = int.Parse(Console.ReadLine());
                    Management.MakeAction(choice, proxy);
                }
            }
        }
    }
}
