using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp1
{
    public partial class AddSpendingForm : Form
    {
        public Form1 mainForm { get; set; }
        public AddSpendingForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSpendingForm_Load(object sender, EventArgs e)
        {

            foreach (Budget b in Form1.Budgets)
            {
                string s = b.fullName + " [" + b.shortName + "]";
                comBoxBudgets.Items.Add(s);
            }

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (comBoxBudgets.Text != "")
            {
                string name = comBoxBudgets.Text.Split(" [")[0];
                Budget selectedBudget = Form1.Budgets.Where(b => b.fullName == name).First();
                selectedBudget.SubtractSpending(double.Parse(txtBoxAmount.Text));
                //selectedBudget.currentBalance -= double.Parse(txtBoxAmount.Text);
                //selectedBudget.totalSpending += double.Parse(txtBoxAmount.Text);
                mainForm.BudgetsTableUpdate();
                Close();
            }
            else
            {
                comBoxBudgets.BackColor = Color.LightSalmon;
            }
        }

        private void comBoxBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxBudgets.BackColor = Color.White;
        }
    }
}
