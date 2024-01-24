using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestApp1
{
    public partial class SettingsForm : Form
    {
        public Form1 mainForm {  get; set; }
        private Budget selectedBudget {  get; set; }
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewBudget_Click(object sender, EventArgs e)
        {
            NewBudgetForm nbf = new NewBudgetForm();
            nbf.mainForm = mainForm;
            nbf.settingsForm = this;
            nbf.ShowDialog();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (Budget b in Form1.Budgets)
            {
                string s = b.fullName + " [" + b.shortName + "]";
                comBoxBudgets.Items.Add(s);
            }
        }

        private void comBoxBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comBoxBudgets.Text.Split(" [")[0];
            selectedBudget = Form1.Budgets.Where(b => b.fullName == name).First();
            double roundedCurrentBalance = Math.Round(selectedBudget.currentBalance, 2);
            double roundedTotalSpending = Math.Round(selectedBudget.totalSpending, 2);
            txtBoxBalance.Text = roundedCurrentBalance.ToString("0.00");
            txtBoxSpending.Text = roundedTotalSpending.ToString("0.00");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBudget.dailyAmount = double.Parse(txtBoxAmount.Text);
                mainForm.BudgetsTableUpdate();
                Close();
            }
            catch(Exception ex)
            {
                txtBoxAmount.BackColor = Color.LightSalmon;
            }
        }
    }
}
