using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManagement
{
    public class Management
    {
        public SkiResortProxy proxy;
        private Management manager;
 
        public Management Instance()
        {
            return manager;
        }
        public static void ShowPossibleActions()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Possible Actions");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Build a hotel (cost: 110,000cr. | 60 beds).");
            Console.WriteLine("2. Build a restaurant  (cost: 80,000cr. | 45 seats).");

            Console.WriteLine("3. Build a lift with chairs (cost: 40,000cr. | 30 lift seats).");
            Console.WriteLine("4. Build a lift with cabins (cost: 60,000cr. | 50 lift seats).");

            Console.WriteLine("5. Build a track (cost: 30,000cr. | 20 track space | maintain: 5,000 cr).");

            Console.WriteLine("6. Increase advertizemet cost (5,000 cr.).");
            Console.WriteLine("7. Decrease advertizemet cost (5,000 cr.).");

            Console.WriteLine("8. End the day.");
            Console.WriteLine("-----------------------------");
        }
        public static void MakeAction(int choice, SkiResortProxy proxy)
        {
            switch (choice)
            {
                case 1:
                    BuildHotel(proxy);
                    break;
                case 2:
                    BuildRestaurant(proxy);
                    break;
                case 3:
                    BuildLiftWithChairs(proxy);
                    break;
                case 4:
                    BuildLiftWithCabins(proxy);
                    break;
                case 5:
                    BuildTrack(proxy);
                    break;
                case 6:
                    IncreaseAdvertizemetCost(proxy);
                    break;
                case 7:
                    DecreaseAdvertizemetCost(proxy);
                    break;
                case 8:
                    EndDay(proxy);
                    break;
                default:
                    Console.WriteLine("Please enter a valid command (form 1 to 8).");
                    break;
            }

        }

        public static void BuildHotel(SkiResortProxy proxy)
        {
            string key = "hotel";
            Console.WriteLine("You have built a hotel.");
            proxy.Pay(110000);
            proxy.Build(key);
        }
        public static void BuildRestaurant(SkiResortProxy proxy)
        {
            string key = "restaurant";
            Console.WriteLine("You have built a restaurant.");
            proxy.Pay(80000);
            proxy.Build(key);
        }
        public static void BuildLiftWithChairs(SkiResortProxy proxy)
        {
            string key = "liftsWithChairs";
            Console.WriteLine("You have built a lift with chairs.");
            proxy.Pay(40000);
            proxy.Build(key);
        }
        public static void BuildLiftWithCabins(SkiResortProxy proxy)
        {
            string key = "liftsWithCabins";
            Console.WriteLine("You have built a lift with cabins.");
            proxy.Pay(60000);
            proxy.Build(key);
        }
        public static void BuildTrack(SkiResortProxy proxy)
        {
            string key = "tracks";
            Console.WriteLine("You have built a track.");
            proxy.Pay(30000);
            proxy.Build(key);
        }
        public static void IncreaseAdvertizemetCost(SkiResortProxy proxy)
        {
            int amount = 5000;
            proxy.AddBudgetIncrease(amount);
        }
        public static void DecreaseAdvertizemetCost(SkiResortProxy proxy)
        {
            int amount = 5000;
            proxy.AddBudgetDecrease(amount);
        }
        public static void StartDay(SkiResortProxy proxy)
        {
            Console.Clear();
            Console.WriteLine("New Day.");
            proxy.PopularityDecrease(5);
            proxy.RecieveIncome();
            proxy.AtractPopulation();
            proxy.PopularityIncrease();
            proxy.Pay(proxy.GetMaintenanceCost());
            proxy.PayAddBudget();
            proxy.DisplayResort();
            proxy.DisplayManagement();
            ShowPossibleActions();
            EndGame(proxy);
        }
        public static void EndDay(SkiResortProxy proxy)
        {
            EndGame(proxy);
            proxy.DayPass();
        }
        public static void EndGame(SkiResortProxy proxy)
        {
            if (proxy.GetPopularity() <= 0 || proxy.GetDaysLeft() == 0 || proxy.GetBudget() <= 0)
            {
                Console.Clear();
                Console.WriteLine("You Lost!");
                Console.WriteLine("Days Left: {0} days.", proxy.GetDaysLeft());
                Console.WriteLine("Budget: {0}cr.", proxy.GetBudget());
                Environment.Exit(0);
            }
            if (proxy.GetBudget() >= 1000000)
            {
                Console.Clear();
                Console.WriteLine("You Win!");
                Console.WriteLine("Days Left: {0} days.", proxy.GetDaysLeft());
                Console.WriteLine("Budget: {0}cr.", proxy.GetBudget());
                Environment.Exit(0);
            }
        }
    }
}