namespace TestApp1
{
    public partial class NewBudgetForm : Form
    {
        public Form1 mainForm { get; set; }
        public SettingsForm settingsForm { get; set; }
        public NewBudgetForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Budget b = new Budget();
            b.fullName = txtBoxFullName.Text;
            b.shortName = txtBoxShortName.Text;
            // b.dailyAmount = double.Parse(txtBoxAmount.Text);
            // b.currentBalance = double.Parse(txtBoxAmount.Text);
            b.totalSpending = 0;
            b.lastUpdate = DateTime.Now;
            Form1.Budgets.Add(b);
            mainForm.BudgetsTableUpdate();
            Close();
            bool ps1, ps2, ps3 = false;
            double dailyAmount;
            ps1 = double.TryParse(txtBoxAmount.Text, out dailyAmount);
            if (ps1)
            {
                txtBoxAmount.BackColor = Color.White;
                b.dailyAmount = dailyAmount;
            }
            else
            {
                txtBoxAmount.BackColor = Color.Orange;
            }
            double shiftPercent;
            ps2 = double.TryParse(txtBoxSurplusPercent.Text, out shiftPercent);
            if (ps2)
            {
                txtBoxSurplusPercent.BackColor = Color.White;
                b.SurplusShiftPercent = shiftPercent;
            }
            else
            {
                txtBoxSurplusPercent.BackColor = Color.Orange;
            }
            if (shiftPercent != 0)
            {
                if (comBoxSurplusBudget.Text != "")
                {
                    ps3 = true;
                    comBoxSurplusBudget.BackColor = Color.White;
                    string name = comBoxSurplusBudget.Text.Split(" [")[0];
                    Budget selectedSurplusBudget = Form1.Budgets.Where(b => b.fullName == name).First();
                    if (selectedSurplusBudget.BudgetId == 0)
                    {
                        mainForm.SetBudgetId(selectedSurplusBudget);
                    }
                    b.SurplusShiftBudget = selectedSurplusBudget;
                }
                else
                {
                    comBoxSurplusBudget.BackColor = Color.Orange;
                }
            }
            if (ps1 && ps2 && ps3)
            {
                mainForm.BudgetsTableUpdate();
                Close();
            }



        }

        private void NewBudgetForm_Load(object sender, EventArgs e)
        {
            foreach (Budget b in Form1.Budgets)
            {
                string s = b.fullName + " [" + b.shortName + "]";
                comBoxSurplusBudget.Items.Add(s);
            }
        }
    }
}
