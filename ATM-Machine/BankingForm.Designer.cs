namespace ATM_Machine
{
    partial class BankingForm
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
            SavingsBalance = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            WithdrawAmount = new TextBox();
            label2 = new Label();
            CustomerID = new TextBox();
            label1 = new Label();
            Exit = new Button();
            Withdraw = new Button();
            CheckingBalance = new TextBox();
            AccountNumber = new ComboBox();
            SuspendLayout();
            // 
            // SavingsBalance
            // 
            SavingsBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SavingsBalance.Location = new Point(212, 181);
            SavingsBalance.Name = "SavingsBalance";
            SavingsBalance.PlaceholderText = "0.00";
            SavingsBalance.ReadOnly = true;
            SavingsBalance.Size = new Size(210, 34);
            SavingsBalance.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 184);
            label5.Name = "label5";
            label5.Size = new Size(175, 28);
            label5.TabIndex = 21;
            label5.Text = "Savings Balance:  $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 114);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 20;
            label4.Text = "Checking Balance:  $";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(337, 284);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 18;
            label3.Text = "from Account #";
            // 
            // WithdrawAmount
            // 
            WithdrawAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawAmount.Location = new Point(153, 278);
            WithdrawAmount.Name = "WithdrawAmount";
            WithdrawAmount.PlaceholderText = "0.00";
            WithdrawAmount.RightToLeft = RightToLeft.Yes;
            WithdrawAmount.Size = new Size(178, 34);
            WithdrawAmount.TabIndex = 17;
            WithdrawAmount.TextChanged += WithdrawAmount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 281);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 16;
            label2.Text = "Withdraw  $";
            // 
            // CustomerID
            // 
            CustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerID.Location = new Point(212, 29);
            CustomerID.Name = "CustomerID";
            CustomerID.PlaceholderText = "12345678";
            CustomerID.ReadOnly = true;
            CustomerID.Size = new Size(210, 34);
            CustomerID.TabIndex = 15;
            CustomerID.TextChanged += CustomerID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 14;
            label1.Text = "Customer Number:";
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Location = new Point(650, 385);
            Exit.Name = "Exit";
            Exit.Size = new Size(122, 37);
            Exit.TabIndex = 13;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Withdraw
            // 
            Withdraw.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Withdraw.Location = new Point(271, 342);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(260, 80);
            Withdraw.TabIndex = 24;
            Withdraw.Text = "Withdraw";
            Withdraw.TextImageRelation = TextImageRelation.ImageBeforeText;
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += Withdraw_Click;
            // 
            // CheckingBalance
            // 
            CheckingBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckingBalance.Location = new Point(212, 111);
            CheckingBalance.Name = "CheckingBalance";
            CheckingBalance.PlaceholderText = "0.00";
            CheckingBalance.ReadOnly = true;
            CheckingBalance.Size = new Size(210, 34);
            CheckingBalance.TabIndex = 25;
            // 
            // AccountNumber
            // 
            AccountNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountNumber.FormattingEnabled = true;
            AccountNumber.Location = new Point(491, 284);
            AccountNumber.Name = "AccountNumber";
            AccountNumber.Size = new Size(236, 36);
            AccountNumber.TabIndex = 26;
            AccountNumber.SelectedIndexChanged += AccountNumber_SelectedIndexChanged;
            // 
            // BankingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AccountNumber);
            Controls.Add(CheckingBalance);
            Controls.Add(Withdraw);
            Controls.Add(SavingsBalance);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(WithdrawAmount);
            Controls.Add(label2);
            Controls.Add(CustomerID);
            Controls.Add(label1);
            Controls.Add(Exit);
            Name = "BankingForm";
            Text = "Banking Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox SavingsBalance;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox WithdrawAmount;
        private Label label2;
        private TextBox CustomerID;
        private Label label1;
        private Button Exit;
        private Button Withdraw;
        private TextBox CheckingBalance;
        private ComboBox AccountNumber;
    }
}