using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    public class Budget
    {
        #region PROPERTIES

        public string fullName {  get; set; }
        public string shortName { get; set; }
        public double currentBalance { get; set; }
        public double dailyAmount { get; set; }
        public double totalAmount { get; set; }
        public double totalSpending {  get; set; }
        public DateTime lastUpdate { get; set; }
        public int BudgetId { get; set; } = 0;
        public double SurplusShiftPercent { get; set; } = 0;
        public Budget SurplusShiftBudget { get; set; }
        public int SurplusShiftBudgetId { get; set; }

        #endregion

        #region METHODS

        public void AddDailyAmount()
        {
            int dayDiff = (DateTime.Now.Date - lastUpdate.Date).Days;
            if (dayDiff > 0)
            {
                currentBalance += dayDiff * dailyAmount;
                totalAmount += dayDiff * dailyAmount;
                if (SurplusShiftPercent > 0 && totalAmount > 0)
                {
                    double factor = Math.Pow(1 - (SurplusShiftPercent / 100), dayDiff);
                    if(SurplusShiftBudget != null)
                    {
                        SurplusShiftBudget.currentBalance += currentBalance * (1 - factor);
                        currentBalance *= factor;
                    }
                }
            }
            lastUpdate = DateTime.Now;

        }
 
        public void SubtractSpending(double amount)
        {
            currentBalance -= amount;
            totalSpending += amount;
        }

        public void UpdateSettings(double newDailyAmount, string newFullName, string newShortName, double shiftPercentage, Budget shiftBudget)
        {
            dailyAmount = newDailyAmount;
            fullName = newFullName;
            shortName = newShortName;
            SurplusShiftPercent = shiftPercentage;
            SurplusShiftBudget = shiftBudget;
        }
        #endregion
    }
}
