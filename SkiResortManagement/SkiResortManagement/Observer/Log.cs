using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManagement
{
    class Log : IObserver
    {
        public SkiResortProxy proxy;
        List<string> key;
        string role, username;

        public Log(SkiResortProxy proxy, string role, string username)
        {
            this.proxy = proxy;
            this.role = role;
            this.username = username;
            proxy.Notify(key);
        }
        public void Update(List<string> key)
        {
            if (role == "Economist")
            {
                Console.WriteLine("Notify [{0}] {1}: Income {2}cr.", role, username, proxy.GetIncome());
                Console.WriteLine("Notify [{0}] {1}: Payed amount for advertisement {2}cr.", role, username, proxy.GetAddBudget());
                Console.WriteLine("Notify [{0}] {1}: Payed amount for maintenance {2}cr.", role, username, proxy.GetMaintenanceCost());
                Console.WriteLine("Notify [{0}] {1}: {2} people came because of advertisement.", role, username, (proxy.GetPopularity() / 4));
            }

            if (key.Contains("hotels"))
            {
                Console.WriteLine("Secret note from [{0}] {1}: Hotels are lacking!", role, username);
                Console.WriteLine("Secret note from [{0}] {1}: {2} people left.", role, username, (proxy.GetPopulation() - proxy.GetBeds()) / 2);
            }
            if (key.Contains("restaurants"))
            {
                Console.WriteLine("Secret note from [{0}] {1}: Restaurants are lacking!", role, username);
                Console.WriteLine("Secret note from [{0}] {1}: {2} people left.", role, username, (proxy.GetPopulation() - proxy.GetSeats()) / 2);
            }
            if (key.Contains("lifts"))
            {
                Console.WriteLine("Secret note from [{0}] {1}: Lifts are lacking!", role, username);
                Console.WriteLine("Secret note from [{0}] {1}: {2} people left.", role, username, (proxy.GetPopulation() - proxy.GetLiftSeats()) / 2);
            }
            if (key.Contains("tracks"))
            {
                Console.WriteLine("Secret note from [{0}] {1}: Tracks are lacking!", role, username);
                Console.WriteLine("Secret note from [{0}] {1}: {2} people left.", role, username, (proxy.GetPopulation() - proxy.GetTracksSpace()) / 2);
            }
        }
    }
}
