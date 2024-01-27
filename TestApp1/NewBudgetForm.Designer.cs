namespace TestApp1
{
    partial class NewBudgetForm
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
            label3 = new Label();
            txtBoxFullName = new TextBox();
            txtBoxShortName = new TextBox();
            txtBoxAmount = new TextBox();
            BtnConfirm = new Button();
            BtnCancel = new Button();
            txtBoxSurplusPercent = new TextBox();
            comBoxSurplusBudget = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 1;
            label1.Text = "Full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Short name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 3;
            label3.Text = "Daily amount";
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxFullName.Location = new Point(178, 11);
            txtBoxFullName.Margin = new Padding(2);
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.Size = new Size(234, 29);
            txtBoxFullName.TabIndex = 4;
            // 
            // txtBoxShortName
            // 
            txtBoxShortName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxShortName.Location = new Point(178, 48);
            txtBoxShortName.Margin = new Padding(2);
            txtBoxShortName.MaxLength = 32766;
            txtBoxShortName.Name = "txtBoxShortName";
            txtBoxShortName.Size = new Size(234, 29);
            txtBoxShortName.TabIndex = 5;
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAmount.Location = new Point(178, 87);
            txtBoxAmount.Margin = new Padding(2);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(234, 29);
            txtBoxAmount.TabIndex = 6;
            txtBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirm.Location = new Point(314, 207);
            BtnConfirm.Margin = new Padding(2);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(96, 32);
            BtnConfirm.TabIndex = 7;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(214, 207);
            BtnCancel.Margin = new Padding(2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(96, 32);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // txtBoxSurplusPercent
            // 
            txtBoxSurplusPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSurplusPercent.Location = new Point(178, 126);
            txtBoxSurplusPercent.Margin = new Padding(2);
            txtBoxSurplusPercent.Name = "txtBoxSurplusPercent";
            txtBoxSurplusPercent.Size = new Size(205, 29);
            txtBoxSurplusPercent.TabIndex = 9;
            txtBoxSurplusPercent.TextAlign = HorizontalAlignment.Right;
            // 
            // comBoxSurplusBudget
            // 
            comBoxSurplusBudget.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSurplusBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comBoxSurplusBudget.FormattingEnabled = true;
            comBoxSurplusBudget.Location = new Point(178, 165);
            comBoxSurplusBudget.Name = "comBoxSurplusBudget";
            comBoxSurplusBudget.Size = new Size(232, 29);
            comBoxSurplusBudget.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 129);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 11;
            label4.Text = "Surplus shift percent";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 168);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 12;
            label5.Text = "Surplus shift to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(387, 129);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 13;
            label6.Text = "%";
            // 
            // NewBudgetForm
            // 
            AcceptButton = BtnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(427, 252);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comBoxSurplusBudget);
            Controls.Add(txtBoxSurplusPercent);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(txtBoxAmount);
            Controls.Add(txtBoxShortName);
            Controls.Add(txtBoxFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "NewBudgetForm";
            Text = "NewBudgetForm";
            Load += NewBudgetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxFullName;
        private TextBox txtBoxShortName;
        private TextBox txtBoxAmount;
        private Button BtnConfirm;
        private Button BtnCancel;
        private TextBox txtBoxSurplusPercent;
        private ComboBox comBoxSurplusBudget;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}