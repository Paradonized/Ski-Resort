using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManagement
{
    public class SkiResort : IObservable, ISkiResort
    //singleton
    {
        int hotels, beds, restaurants, seats, liftsWithChairs, liftsWithCabins, liftSeats, tracks, tracksSpace, maintenance;
        int popularity, budget, population, daysLeft, addBudget;
        List<string> key = new List<string>();
        private static SkiResort skiResort;
        private List<IObserver> observers = new List<IObserver>();
        private SkiResort()
        {
            hotels = 1;
            beds = 60;

            restaurants = 1;
            seats = 60;

            liftsWithChairs = 1;
            liftsWithCabins = 0;
            liftSeats = 30;

            tracks = 1;
            tracksSpace = 20;

            maintenance = 5000;

            popularity = 50;
            budget = 100000;
            population = 20;
            daysLeft = 20;
            addBudget = 0;
        }
        public static SkiResort Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (skiResort == null)
            {
                skiResort = new SkiResort();
            }
            return skiResort;
        }

        public void Build(string key)
        {
            switch (key)
            {
                case "hotel":
                    hotels += 1;
                    beds += 60;
                    break;
                case "restaurant":
                    restaurants += 1;
                    seats += 60;
                    break;
                case "liftsWithChairs":
                    liftsWithChairs += 1;
                    liftSeats += 30;
                    break;
                case "liftsWithCabins":
                    liftsWithCabins += 1;
                    liftSeats += 50;
                    break;
                case "tracks":
                    tracks += 1;
                    tracksSpace += 20;
                    maintenance += 5000;
                    break;
                default:
                    Console.WriteLine("Please enter a valid value.");
                    break;
            }
        }


        public void Pay(int cost)
        {
            budget -= cost;
            Console.WriteLine("Payed: {0}cr.", cost);
            GetPay(cost);
        }

        public int GetPay(int cost)
        {
            return cost;
        }

        public void RecieveIncome()
        {
            int income = GetIncome();
            budget += income;
        }
        public int GetIncome()
        {
            return population * 2000;
        }

        public void DayPass()
        {
            daysLeft -= 1;
        }

        public int GetDaysLeft()
        {
            return daysLeft;
        }
        public int GetBudget()
        {
            return budget;
        }
        public int GetPopularity()
        {
            return popularity;
        }
        public int GetPopulation()
        {
            return population;
        }
        public int GetTracksSpace()
        {
            return tracksSpace;
        }
        public int GetBeds()
        {
            return beds;
        }
        public int GetSeats()
        {
            return seats;
        }
        public int GetLiftSeats()
        {
            return liftSeats;
        }
        public int GetAddBudget()
        {
            return addBudget;
        }
        public void PopularityDecrease(int amount)
        {
            popularity -= amount;

            if (population > tracksSpace)
            {
                popularity -= (population - tracksSpace) / 2;
                population -= (population - tracksSpace) / 2;
                key.Add("tracks");
            }
            if (population > beds)
            {
                popularity -= (population - beds) / 2;
                population -= (population - beds) / 2;
                key.Add("hotels");
            }
            if (population > seats)
            {
                popularity -= (population - seats) / 2;
                population -= (population - seats) / 2;
                key.Add("restaurants");
            }
            if (population > liftSeats)
            {
                popularity -= (population - liftSeats) / 2;
                population -= (population - liftSeats) / 2;
                key.Add("lifts");
            }
        }

        public void PopularityIncrease()
        {
            popularity += addBudget / 2500;
        }

        public void AtractPopulation()
        {
            population += popularity / 4;
        }

        public void AddBudgetIncrease(int amount)
        {
            addBudget += amount;
            Console.WriteLine("Increased add budget: {0}cr.", amount);
        }

        public void AddBudgetDecrease(int amount)
        {
            addBudget -= amount;
            Console.WriteLine("Decreased add budget: {0}cr.", amount);
        }

        public void PayAddBudget()
        {
            budget -= addBudget;
        }

        public int GetMaintenanceCost()
        {
            return maintenance;
        }

        public void DisplayResort()
        {
            Notify(key);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Ski Resort Status");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Hotels: {0} ({1} beds)", hotels, beds);
            Console.WriteLine("Restaurants: {0} ({1} seats)", restaurants, seats);

            Console.WriteLine("Lifts With Chairs: {0}", liftsWithChairs);
            Console.WriteLine("Lifts With Cabins: {0}", liftsWithCabins);
            Console.WriteLine("Lift Seats: {0}", liftSeats);

            Console.WriteLine("Tracks: {0}", tracks);
            Console.WriteLine("Tracks Space: {0}", tracksSpace);

            Console.WriteLine("Daily Maintenance Cost: {0}cr.", maintenance);
            Console.WriteLine("-----------------------------");
        }
        public void DisplayManagement()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Management Status");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Popularity: {0}%", popularity);
            Console.WriteLine("Budget: {0} cr.", budget);
            Console.WriteLine("Add Budget: {0}cr.", addBudget);

            Console.WriteLine("Days Remaining: {0} days.", daysLeft);

            Console.WriteLine("Population: {0}", population);

            Console.WriteLine("-----------------------------");
        }
        public void Notify(List<string> key)
        {
            key = this.key;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Log");
            Console.WriteLine("-----------------------------");
            foreach (IObserver o in this.observers)
            {
                o.Update(key);
                
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            this.key.Clear();
        }

        public void Add(IObserver o)
        {
            this.observers.Add(o);
        }

        public void Remove(IObserver o)
        {
            this.observers.Remove(o);
        }
    }
}