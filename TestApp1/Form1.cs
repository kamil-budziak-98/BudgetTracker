using System.Reflection;

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
            versionLabel.Text = "v" + v.Major + "." + v.Minor;
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
                        Budget b = new Budget();
                        b.fullName = details[0];
                        b.shortName = details[1];
                        b.currentBalance = double.Parse(details[2]);
                        b.dailyAmount = double.Parse(details[3]);
                        b.totalAmount = double.Parse(details[4]);
                        b.totalSpending = double.Parse(details[5]);
                        b.lastUpdate = DateTime.Parse(details[6]);
                        Budgets.Add(b);
                    }
                }
                foreach (Budget b in Budgets) {
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
                    b.lastUpdate;
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
    }
}
