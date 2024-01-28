using System.Reflection;
using System.Xml.Linq;
// using Newtonsoft.Json;

namespace TestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // ON LAUNCH
        private void Form1_Load(object sender, EventArgs e)
        {
            var v = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
            versionLabel.Text = "v" + v.Major + "." + v.Minor + "." + v.Build + "." + v.Revision;
#else   
            if (v.Build == 0) {
                versionLabel.Text = "v" + v.Major + "." + v.Minor + "." + v.Build;
            }
            else {
                versionLabel.Text = "v" + v.Major + "." + v.Minor;
            }
            
#endif
            // READING THE BUDGETS FROM FILE
            if (File.Exists("budgets.txt"))
            {
                string[] budgets_str = File.ReadAllLines("budgets.txt");
                foreach (string budget_str in budgets_str)
                {
                    if (!string.IsNullOrEmpty(budget_str))
                    {
                        string[] details = budget_str.Split('\t');
                        Budget b = new Budget(details, Budgets);
                        //Budgets.Add(b);
                    }
                }
                foreach (Budget b in Budgets) {
                    if(b.SurplusShiftBudgetId > 0)
                    {
                        b.SurplusShiftBudget = Budgets.Where(b2 => b2.BudgetId == b.SurplusShiftBudgetId).First();
                    }
                    else
                    {
                        b.SurplusShiftBudget = null;
                    }
                    b.AddDailyAmount();
                }
                BudgetsTableUpdate();
            }
        }

        // ON EXIT
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // WRITING THE BUDGETS TO FILE
            /*
            foreach (var b in Budgets)
            {
                
                string path = b.shortName + ".txt";
                if(File.Exists(path))
                {

                }
                

            }
            */
            SyncDataToFile();
        }

        private void BtnAddSpending_Click(object sender, EventArgs e)
        {
            AddSpendingForm asf = new AddSpendingForm();
            asf.mainForm = this;
            asf.ShowDialog();
        }
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.mainForm = this;
            sf.ShowDialog();
        }

        public static List<Budget> Budgets = new List<Budget>();

        private void SyncDataToFile()
        {
            File.Delete("budgets.txt");
            List<string> lines = new List<string>();
            foreach (var b in Budgets)
            {
                string line =
                    b.fullName + "\t" +
                    b.shortName + "\t" +
                    b.currentBalance + "\t" +
                    b.dailyAmount + "\t" +
                    b.totalAmount + "\t" +
                    b.totalSpending + "\t" +
                    b.lastUpdate + "\t" +
                    b.BudgetId + "\t" +
                    b.SurplusShiftPercent + "\t";
                if (b.SurplusShiftBudget != null)
                {
                    line += b.SurplusShiftBudget.BudgetId;
                }
                else
                {
                    line += "0";
                }
                lines.Add(line);
            }
            File.AppendAllLines("budgets.txt", lines);
        }

        public void BudgetsTableUpdate()
        {
            BudgetsTable.Rows.Clear();
            foreach (Budget b in Budgets)
            {
                //DataGridViewRow r = new DataGridViewRow();
                int i = BudgetsTable.Rows.Add();
                BudgetsTable.Rows[i].Cells[0].Value = b.fullName;
                BudgetsTable.Rows[i].Cells[1].Value = b.shortName;
                BudgetsTable.Rows[i].Cells[2].Value = b.dailyAmount.ToString("0.00");
                BudgetsTable.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                BudgetsTable.Rows[i].Cells[3].Value = b.currentBalance.ToString("0.00");
                BudgetsTable.Rows[i].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        public void SetBudgetId(Budget b)
        {
            int id = 1;
            foreach(Budget b2 in Budgets)
            {
                if(b2 != b && b2.BudgetId != 0)
                {
                    id++;
                }
            }
            b.BudgetId = id;
        }
    }
}
