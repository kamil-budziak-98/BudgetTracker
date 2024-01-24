namespace TestApp1
{
    public partial class NewBudgetForm : Form
    {
        public Form1 mainForm {  get; set; }
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
            b.dailyAmount = double.Parse(txtBoxAmount.Text);
            b.currentBalance = double.Parse(txtBoxAmount.Text);
            b.totalSpending = 0;
            b.lastUpdate = DateTime.Now;
            Form1.Budgets.Add(b);
            mainForm.BudgetsTableUpdate();
            Close();
        }
    }
}
