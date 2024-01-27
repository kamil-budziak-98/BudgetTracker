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
            comBoxSurplusBudget.Items.Add("(none)");
            foreach (Budget b in Form1.Budgets)
            {
                string s = b.fullName + " [" + b.shortName + "]";
                comBoxBudgets.Items.Add(s);
                comBoxSurplusBudget.Items.Add(s);
            }
        }

        private void comBoxBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comBoxBudgets.Text.Split(" [")[0];
            selectedBudget = Form1.Budgets.Where(b => b.fullName == name).First();
            double roundedAmount = Math.Round(selectedBudget.dailyAmount, 2);
            double roundedCurrentBalance = Math.Round(selectedBudget.currentBalance, 2);
            double roundedTotalSpending = Math.Round(selectedBudget.totalSpending, 2);
            double roundedshiftPercent = Math.Round(selectedBudget.SurplusShiftPercent, 2);
            txtBoxAmount.Text = roundedAmount.ToString("0.00");
            txtBoxBalance.Text = roundedCurrentBalance.ToString("0.00"); 
            txtBoxSpending.Text = roundedTotalSpending.ToString("0.00");
            txtBoxSurplusPercent.Text = roundedshiftPercent.ToString("0.00");
            if(selectedBudget.SurplusShiftBudget != null)
            {
                comBoxSurplusBudget.Text = selectedBudget.SurplusShiftBudget.fullName + " [" + selectedBudget.SurplusShiftBudget.shortName + "]";
            }
            else
            {
                {
                    comBoxSurplusBudget.Text = "(none)";
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool ps1, ps2, ps3 = false;
                double dailyAmount;
                ps1 = double.TryParse(txtBoxAmount.Text, out dailyAmount);
                if(ps1)
                {
                    txtBoxAmount.BackColor = Color.White;
                    selectedBudget.dailyAmount = dailyAmount;
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
                    selectedBudget.SurplusShiftPercent = shiftPercent;
                }
                else
                {
                    txtBoxSurplusPercent.BackColor = Color.Orange;
                }
                if(shiftPercent != 0) {
                    if(comBoxSurplusBudget.Text != "")
                    {
                        ps3 = true;
                        comBoxSurplusBudget.BackColor = Color.White;
                        string name = comBoxSurplusBudget.Text.Split(" [")[0];
                        Budget selectedSurplusBudget = Form1.Budgets.Where(b => b.fullName == name).First();
                        if(selectedSurplusBudget.BudgetId == 0)
                        {
                            mainForm.SetBudgetId(selectedSurplusBudget);
                        }
                        selectedBudget.SurplusShiftBudget = selectedSurplusBudget;
                    }
                    else
                    {
                        comBoxSurplusBudget.BackColor = Color.Orange;
                    }
                }
                if(ps1 && ps2 && ps3) {
                    mainForm.BudgetsTableUpdate();
                    Close();
                }
            }
            catch(Exception ex)
            {
                txtBoxAmount.BackColor = Color.LightSalmon;
            }
        }
    }
}
