namespace TestApp1
{
    public class Budget
    {
        #region CONSTRUCTORS

        /// <summary>
        /// Creates an empty instance of a budget (default constructor).
        /// </summary>
        public Budget ()
        {

        }

        /// <summary>
        /// Creates a budget without a surplus shift.
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="sn"></param>
        /// <param name="da"></param>
        public Budget (string fn, string sn, double da)
        {
            fullName = fn;
            shortName = sn;
            dailyAmount = da;
            currentBalance = da;
            totalAmount = da;
            totalSpending = 0;
            lastUpdate = DateTime.Now;
            BudgetId = 0;
            SurplusShiftPercent = 0;
            SurplusShiftBudget = null;
            SurplusShiftBudgetId = 0;
        }

        /// <summary>
        /// Creates a new budget with a surplus shift budget.
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="sn"></param>
        /// <param name="da"></param>
        /// <param name="ssp"></param>
        /// <param name="ssb"></param>
        public Budget (string fn, string sn, double da, double ssp, Budget ssb) 
        {
            fullName = fn;
            shortName = sn;
            dailyAmount = da;
            currentBalance = da;
            totalAmount = da;
            totalSpending = 0;
            lastUpdate = DateTime.Now;
            BudgetId = 0;
            SurplusShiftPercent = ssp;
            SurplusShiftBudget = ssb;
            SurplusShiftBudgetId = ssb.BudgetId;
        }

        /// <summary>
        /// Creates a budget from line of parameters.
        /// </summary>
        /// <param name="fn">Budget full name</param>
        /// <param name="sn">Budget code</param>
        /// <param name="cb">Current balance</param>
        /// <param name="da">Daily amount</param>
        /// <param name="ta">Total amount</param>
        /// <param name="ts">Total spending</param>
        /// <param name="lu">Last update time</param>
        /// <param name="bid">Budget ID</param>
        /// <param name="ssp">Surplus percentage to shift</param>
        /// <param name="ssb">Destination budget for surplus shift</param>
        public Budget(string[] str)
        { 
            fullName = str[0];
            shortName = str[1];
            dailyAmount = double.Parse(str[3]);
            currentBalance = double.Parse(str[2]);
            totalAmount = double.Parse(str[4]);
            totalSpending = double.Parse(str[5]);
            lastUpdate = DateTime.Parse(str[6]);
            BudgetId = int.Parse(str[7]);
            SurplusShiftPercent = int.Parse(str[8]);
            SurplusShiftBudgetId = int.Parse(str[9]);
        }
        #endregion


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
        
        /// <summary>
        /// Deducts spent amount from the budget.
        /// </summary>
        /// <param name="amount"></param>
        public void SubtractSpending(double amount)
        {
            currentBalance -= amount;
            totalSpending += amount;
        }

        /// <summary>
        /// Updates all parameters of the budget.
        /// </summary>
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
