namespace TestApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAddSpending = new Button();
            label1 = new Label();
            BudgetsTable = new DataGridView();
            BtnSettings = new Button();
            versionLabel = new Label();
            NameColumn = new DataGridViewTextBoxColumn();
            CodeColumn = new DataGridViewTextBoxColumn();
            DailyAmountColumn = new DataGridViewTextBoxColumn();
            BalanceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)BudgetsTable).BeginInit();
            SuspendLayout();
            // 
            // BtnAddSpending
            // 
            BtnAddSpending.Location = new Point(519, 8);
            BtnAddSpending.Name = "BtnAddSpending";
            BtnAddSpending.Size = new Size(144, 45);
            BtnAddSpending.TabIndex = 0;
            BtnAddSpending.Text = "Add Spending";
            BtnAddSpending.UseVisualStyleBackColor = true;
            BtnAddSpending.Click += BtnAddSpending_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(473, 48);
            label1.TabIndex = 1;
            label1.Text = "CURRENT BUDGET STATUS";
            // 
            // BudgetsTable
            // 
            BudgetsTable.AllowUserToAddRows = false;
            BudgetsTable.AllowUserToDeleteRows = false;
            BudgetsTable.AllowUserToResizeColumns = false;
            BudgetsTable.AllowUserToResizeRows = false;
            BudgetsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BudgetsTable.ColumnHeadersHeight = 34;
            BudgetsTable.Columns.AddRange(new DataGridViewColumn[] { NameColumn, CodeColumn, DailyAmountColumn, BalanceColumn });
            BudgetsTable.Location = new Point(11, 60);
            BudgetsTable.MaximumSize = new Size(774, 1000);
            BudgetsTable.MinimumSize = new Size(774, 167);
            BudgetsTable.Name = "BudgetsTable";
            BudgetsTable.RowHeadersVisible = false;
            BudgetsTable.RowHeadersWidth = 62;
            BudgetsTable.Size = new Size(774, 367);
            BudgetsTable.TabIndex = 2;
            // 
            // BtnSettings
            // 
            BtnSettings.Location = new Point(669, 8);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(119, 45);
            BtnSettings.TabIndex = 3;
            BtnSettings.Text = "Settings";
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // versionLabel
            // 
            versionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(11, 432);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(146, 25);
            versionLabel.TabIndex = 4;
            versionLabel.Text = "(version number)";
            versionLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Budget name";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 315;
            // 
            // CodeColumn
            // 
            CodeColumn.HeaderText = "Code";
            CodeColumn.MinimumWidth = 8;
            CodeColumn.Name = "CodeColumn";
            CodeColumn.ReadOnly = true;
            CodeColumn.Width = 75;
            // 
            // DailyAmountColumn
            // 
            DailyAmountColumn.HeaderText = "Daily amount";
            DailyAmountColumn.MinimumWidth = 8;
            DailyAmountColumn.Name = "DailyAmountColumn";
            DailyAmountColumn.ReadOnly = true;
            DailyAmountColumn.Width = 150;
            // 
            // BalanceColumn
            // 
            BalanceColumn.HeaderText = "Balance";
            BalanceColumn.MinimumWidth = 8;
            BalanceColumn.Name = "BalanceColumn";
            BalanceColumn.ReadOnly = true;
            BalanceColumn.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 468);
            Controls.Add(versionLabel);
            Controls.Add(BtnSettings);
            Controls.Add(BudgetsTable);
            Controls.Add(label1);
            Controls.Add(BtnAddSpending);
            MaximumSize = new Size(812, 1129);
            MinimumSize = new Size(812, 296);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BudgetsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddSpending;
        private Label label1;
        private DataGridView BudgetsTable;
        private Button BtnSettings;
        private Label versionLabel;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CodeColumn;
        private DataGridViewTextBoxColumn DailyAmountColumn;
        private DataGridViewTextBoxColumn BalanceColumn;
    }
}
