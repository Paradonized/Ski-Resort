using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortManagement
{
    public class SkiResortProxy : ISkiResort, IObservable
    {
        private SkiResort _skiResort = SkiResort.Instance();
        private Management _manager;
        public SkiResortProxy(Management manager)
        {
            _manager = manager;
        }

        public void Add(IObserver o)
        {
            _skiResort.Add(o);
        }

        public void AddBudgetDecrease(int amount)
        {
            if (_skiResort.GetAddBudget() == 0) 
            {
                Console.WriteLine("Your add budget is {0} and cannot be a negative amount!", _skiResort.GetAddBudget());
                return;
            }
            else
                _skiResort.AddBudgetDecrease(amount);
        }

        public void AddBudgetIncrease(int amount)
        {
            if (amount > _skiResort.GetBudget())
            {
                Console.WriteLine("The transaction is canceled due to insufficient funds.");
                return;
            }
            else
                _skiResort.AddBudgetIncrease(amount);
        }

        public void AtractPopulation()
        {
            _skiResort.AtractPopulation();
        }

        public void Build(string key)
        {
            _skiResort.Build(key);
        }

        public void DayPass()
        {
            _skiResort.DayPass();
        }

        public void DisplayManagement()
        {
            _skiResort.DisplayManagement();
        }

        public void DisplayResort()
        {
            _skiResort.DisplayResort();
        }

        public int GetBudget()
        {
            return _skiResort.GetBudget();
        }

        public int GetDaysLeft()
        {
            return _skiResort.GetDaysLeft();
        }

        public int GetMaintenanceCost()
        {
            return _skiResort.GetMaintenanceCost();
        }

        public int GetPopularity()
        {
            return _skiResort.GetPopularity();
        }
        public int GetPopulation()
        {
            return _skiResort.GetPopulation();
        }
        public int GetTracksSpace()
        {
            return _skiResort.GetTracksSpace();
        }

        public int GetBeds()
        {
            return _skiResort.GetBeds();
        }
        public int GetSeats()
        {
            return _skiResort.GetSeats();
        }
        public int GetLiftSeats()
        {
            return _skiResort.GetLiftSeats();
        }
        public int GetAddBudget()
        {
            return _skiResort.GetAddBudget();
        }
        public int GetIncome()
        {
            return _skiResort.GetIncome();
        }
        public void Notify(List<string> key)
        {
            _skiResort.Notify(key);
        }

        public void Pay(int cost)
        {
            _skiResort.Pay(cost);
            _skiResort.GetPay(cost);
        }
        public void PayAddBudget()
        {
            _skiResort.PayAddBudget();
        }

        public void PopularityDecrease(int amount)
        {
            _skiResort.PopularityDecrease(amount);
        }

        public void PopularityIncrease()
        {
            _skiResort.PopularityIncrease();
        }

        public void RecieveIncome()
        {
            _skiResort.RecieveIncome();
        }

        public void Remove(IObserver o)
        {
            _skiResort.Remove(o);
        }
    }
}
