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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Budget";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Daily quota";
            // 
            // comBoxBudgets
            // 
            comBoxBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxBudgets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comBoxBudgets.FormattingEnabled = true;
            comBoxBudgets.Location = new Point(178, 11);
            comBoxBudgets.Margin = new Padding(2);
            comBoxBudgets.Name = "comBoxBudgets";
            comBoxBudgets.Size = new Size(234, 29);
            comBoxBudgets.TabIndex = 2;
            comBoxBudgets.SelectedIndexChanged += comBoxBudgets_SelectedIndexChanged;
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAmount.Location = new Point(178, 48);
            txtBoxAmount.Margin = new Padding(2);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(234, 29);
            txtBoxAmount.TabIndex = 3;
            txtBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 4;
            label3.Text = "Current balance";
            // 
            // txtBoxBalance
            // 
            txtBoxBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBalance.Location = new Point(178, 87);
            txtBoxBalance.Margin = new Padding(2);
            txtBoxBalance.Name = "txtBoxBalance";
            txtBoxBalance.ReadOnly = true;
            txtBoxBalance.Size = new Size(234, 29);
            txtBoxBalance.TabIndex = 5;
            txtBoxBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 130);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 6;
            label4.Text = "Total spending";
            // 
            // txtBoxSpending
            // 
            txtBoxSpending.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSpending.Location = new Point(178, 128);
            txtBoxSpending.Margin = new Padding(2);
            txtBoxSpending.Name = "txtBoxSpending";
            txtBoxSpending.ReadOnly = true;
            txtBoxSpending.Size = new Size(234, 29);
            txtBoxSpending.TabIndex = 7;
            txtBoxSpending.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirm.Location = new Point(316, 179);
            BtnConfirm.Margin = new Padding(2);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 32);
            BtnConfirm.TabIndex = 8;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(217, 179);
            BtnCancel.Margin = new Padding(2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 32);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnNewBudget
            // 
            BtnNewBudget.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNewBudget.ForeColor = SystemColors.Highlight;
            BtnNewBudget.Location = new Point(18, 179);
            BtnNewBudget.Margin = new Padding(2);
            BtnNewBudget.Name = "BtnNewBudget";
            BtnNewBudget.Size = new Size(94, 32);
            BtnNewBudget.TabIndex = 10;
            BtnNewBudget.Text = "New Budget";
            BtnNewBudget.UseVisualStyleBackColor = true;
            BtnNewBudget.Click += BtnNewBudget_Click;
            // 
            // SettingsForm
            // 
            AcceptButton = BtnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(427, 225);
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
            Margin = new Padding(2);
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
    }
}