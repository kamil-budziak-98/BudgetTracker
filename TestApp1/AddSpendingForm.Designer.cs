namespace TestApp1
{
    partial class AddSpendingForm
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
            BtnConfirm = new Button();
            BtnCancel = new Button();
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
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Amount spent";
            // 
            // comBoxBudgets
            // 
            comBoxBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxBudgets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // BtnConfirm
            // 
            BtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirm.Location = new Point(316, 87);
            BtnConfirm.Margin = new Padding(2);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 29);
            BtnConfirm.TabIndex = 5;
            BtnConfirm.Tag = "";
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(218, 87);
            BtnCancel.Margin = new Padding(2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 4;
            BtnCancel.Tag = "";
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // AddSpendingForm
            // 
            AcceptButton = BtnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(427, 130);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(txtBoxAmount);
            Controls.Add(comBoxBudgets);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSpendingForm";
            Text = "Add new Spending";
            Load += AddSpendingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comBoxBudgets;
        private TextBox txtBoxAmount;
        private Button BtnConfirm;
        private Button BtnCancel;
    }
}