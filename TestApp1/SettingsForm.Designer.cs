namespace TestApp1
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comBoxBudgets = new ComboBox();
            txtBoxAmount = new TextBox();
            label3 = new Label();
            txtBoxBalance = new TextBox();
            label4 = new Label();
            txtBoxSpending = new TextBox();
            BtnConfirm = new Button();
            BtnCancel = new Button();
            BtnNewBudget = new Button();
            txtBoxSurplusPercent = new TextBox();
            label5 = new Label();
            comBoxSurplusBudget = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 0;
            label1.Text = "Budget";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 80);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 1;
            label2.Text = "Daily quota";
            // 
            // comBoxBudgets
            // 
            comBoxBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxBudgets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comBoxBudgets.FormattingEnabled = true;
            comBoxBudgets.Location = new Point(254, 18);
            comBoxBudgets.Name = "comBoxBudgets";
            comBoxBudgets.Size = new Size(330, 40);
            comBoxBudgets.TabIndex = 2;
            comBoxBudgets.SelectedIndexChanged += comBoxBudgets_SelectedIndexChanged;
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAmount.Location = new Point(254, 80);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(330, 39);
            txtBoxAmount.TabIndex = 3;
            txtBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 148);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 4;
            label3.Text = "Current balance";
            // 
            // txtBoxBalance
            // 
            txtBoxBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBalance.Location = new Point(254, 145);
            txtBoxBalance.Name = "txtBoxBalance";
            txtBoxBalance.ReadOnly = true;
            txtBoxBalance.Size = new Size(330, 39);
            txtBoxBalance.TabIndex = 5;
            txtBoxBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 217);
            label4.Name = "label4";
            label4.Size = new Size(171, 32);
            label4.TabIndex = 6;
            label4.Text = "Total spending";
            // 
            // txtBoxSpending
            // 
            txtBoxSpending.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSpending.Location = new Point(254, 213);
            txtBoxSpending.Name = "txtBoxSpending";
            txtBoxSpending.ReadOnly = true;
            txtBoxSpending.Size = new Size(330, 39);
            txtBoxSpending.TabIndex = 7;
            txtBoxSpending.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirm.Location = new Point(451, 428);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(134, 53);
            BtnConfirm.TabIndex = 8;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(310, 428);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(134, 53);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnNewBudget
            // 
            BtnNewBudget.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNewBudget.ForeColor = SystemColors.Highlight;
            BtnNewBudget.Location = new Point(26, 428);
            BtnNewBudget.Name = "BtnNewBudget";
            BtnNewBudget.Size = new Size(134, 53);
            BtnNewBudget.TabIndex = 10;
            BtnNewBudget.Text = "New Budget";
            BtnNewBudget.UseVisualStyleBackColor = true;
            BtnNewBudget.Click += BtnNewBudget_Click;
            // 
            // txtBoxSurplusPercent
            // 
            txtBoxSurplusPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSurplusPercent.Location = new Point(254, 278);
            txtBoxSurplusPercent.Name = "txtBoxSurplusPercent";
            txtBoxSurplusPercent.Size = new Size(291, 39);
            txtBoxSurplusPercent.TabIndex = 11;
            txtBoxSurplusPercent.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(553, 283);
            label5.Name = "label5";
            label5.Size = new Size(34, 32);
            label5.TabIndex = 12;
            label5.Text = "%";
            // 
            // comBoxSurplusBudget
            // 
            comBoxSurplusBudget.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSurplusBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comBoxSurplusBudget.FormattingEnabled = true;
            comBoxSurplusBudget.Location = new Point(254, 343);
            comBoxSurplusBudget.Margin = new Padding(4, 5, 4, 5);
            comBoxSurplusBudget.Name = "comBoxSurplusBudget";
            comBoxSurplusBudget.Size = new Size(330, 40);
            comBoxSurplusBudget.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 283);
            label7.Name = "label7";
            label7.Size = new Size(234, 32);
            label7.TabIndex = 15;
            label7.Text = "Surplus shift percent";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 348);
            label6.Name = "label6";
            label6.Size = new Size(180, 32);
            label6.TabIndex = 16;
            label6.Text = "Surplus shift to:";
            // 
            // SettingsForm
            // 
            AcceptButton = BtnConfirm;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(610, 505);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(comBoxSurplusBudget);
            Controls.Add(label5);
            Controls.Add(txtBoxSurplusPercent);
            Controls.Add(BtnNewBudget);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(txtBoxSpending);
            Controls.Add(label4);
            Controls.Add(txtBoxBalance);
            Controls.Add(label3);
            Controls.Add(txtBoxAmount);
            Controls.Add(comBoxBudgets);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(632, 561);
            MinimumSize = new Size(632, 561);
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comBoxBudgets;
        private TextBox txtBoxAmount;
        private Label label3;
        private TextBox txtBoxBalance;
        private Label label4;
        private TextBox txtBoxSpending;
        private Button BtnConfirm;
        private Button BtnCancel;
        private Button BtnNewBudget;
        private TextBox txtBoxSurplusPercent;
        private Label label5;
        private ComboBox comBoxSurplusBudget;
        private Label label7;
        private Label label6;
    }
}