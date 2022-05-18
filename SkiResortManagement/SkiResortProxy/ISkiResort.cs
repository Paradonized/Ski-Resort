namespace SkiResortManagement
{
    public interface ISkiResort
    {
        void AddBudgetDecrease(int amount);
        void AddBudgetIncrease(int amount);
        void AtractPopulation();
        void Build(string key);
        void DayPass();
        void DisplayManagement();
        void DisplayResort();
        int GetBudget();
        int GetDaysLeft();
        int GetMaintenanceCost();
        int GetPopularity();
        void Pay(int cost);
        void PayAddBudget();
        void PopularityDecrease(int amount);
        void PopularityIncrease();
        void RecieveIncome();
    }
}