﻿namespace ATM_Machine
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
            this.SavingsBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WithdrawAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.CheckingBalance = new System.Windows.Forms.TextBox();
            this.checkBoxChecking = new System.Windows.Forms.CheckBox();
            this.checkBoxSavings = new System.Windows.Forms.CheckBox();
            this.TransferAmount = new System.Windows.Forms.TextBox();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.TransferToChecking = new System.Windows.Forms.CheckBox();
            this.TransferToSavings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SavingsBalance
            // 
            this.SavingsBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavingsBalance.Location = new System.Drawing.Point(212, 172);
            this.SavingsBalance.Name = "SavingsBalance";
            this.SavingsBalance.PlaceholderText = "0.00";
            this.SavingsBalance.ReadOnly = true;
            this.SavingsBalance.Size = new System.Drawing.Size(210, 32);
            this.SavingsBalance.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Savings Balance:  $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Checking Balance:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(337, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "from Account ";
            // 
            // WithdrawAmount
            // 
            this.WithdrawAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawAmount.Location = new System.Drawing.Point(153, 264);
            this.WithdrawAmount.Name = "WithdrawAmount";
            this.WithdrawAmount.PlaceholderText = "0.00";
            this.WithdrawAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WithdrawAmount.Size = new System.Drawing.Size(178, 32);
            this.WithdrawAmount.TabIndex = 17;
            this.WithdrawAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Withdraw  $";
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerID.Location = new System.Drawing.Point(212, 28);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PlaceholderText = "12345678";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Size = new System.Drawing.Size(210, 32);
            this.CustomerID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer Number:";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(650, 366);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 35);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw.Location = new System.Drawing.Point(271, 325);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(260, 76);
            this.Withdraw.TabIndex = 24;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // CheckingBalance
            // 
            this.CheckingBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckingBalance.Location = new System.Drawing.Point(212, 105);
            this.CheckingBalance.Name = "CheckingBalance";
            this.CheckingBalance.PlaceholderText = "0.00";
            this.CheckingBalance.ReadOnly = true;
            this.CheckingBalance.Size = new System.Drawing.Size(210, 32);
            this.CheckingBalance.TabIndex = 25;
            // 
            // checkBoxChecking
            // 
            this.checkBoxChecking.AutoSize = true;
            this.checkBoxChecking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxChecking.Location = new System.Drawing.Point(476, 257);
            this.checkBoxChecking.Name = "checkBoxChecking";
            this.checkBoxChecking.Size = new System.Drawing.Size(109, 29);
            this.checkBoxChecking.TabIndex = 26;
            this.checkBoxChecking.Text = "Checking";
            this.checkBoxChecking.UseVisualStyleBackColor = true;
            // 
            // checkBoxSavings
            // 
            this.checkBoxSavings.AutoSize = true;
            this.checkBoxSavings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSavings.Location = new System.Drawing.Point(476, 286);
            this.checkBoxSavings.Name = "checkBoxSavings";
            this.checkBoxSavings.Size = new System.Drawing.Size(95, 29);
            this.checkBoxSavings.TabIndex = 27;
            this.checkBoxSavings.Text = "Savings";
            this.checkBoxSavings.UseVisualStyleBackColor = true;
            // 
            // TransferAmount
            // 
            this.TransferAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferAmount.Location = new System.Drawing.Point(523, 109);
            this.TransferAmount.Name = "TransferAmount";
            this.TransferAmount.Size = new System.Drawing.Size(177, 32);
            this.TransferAmount.TabIndex = 29;
            this.TransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransferBtn
            // 
            this.TransferBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransferBtn.Location = new System.Drawing.Point(545, 147);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(128, 41);
            this.TransferBtn.TabIndex = 31;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // TransferToChecking
            // 
            this.TransferToChecking.AutoSize = true;
            this.TransferToChecking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferToChecking.Location = new System.Drawing.Point(470, 38);
            this.TransferToChecking.Name = "TransferToChecking";
            this.TransferToChecking.Size = new System.Drawing.Size(288, 27);
            this.TransferToChecking.TabIndex = 32;
            this.TransferToChecking.Text = "Transfer from Savings to Checking";
            this.TransferToChecking.UseVisualStyleBackColor = true;
            // 
            // TransferToSavings
            // 
            this.TransferToSavings.AutoSize = true;
            this.TransferToSavings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferToSavings.Location = new System.Drawing.Point(470, 71);
            this.TransferToSavings.Name = "TransferToSavings";
            this.TransferToSavings.Size = new System.Drawing.Size(288, 27);
            this.TransferToSavings.TabIndex = 33;
            this.TransferToSavings.Text = "Transfer from Checking to Savings";
            this.TransferToSavings.UseVisualStyleBackColor = true;
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.TransferToSavings);
            this.Controls.Add(this.TransferToChecking);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.TransferAmount);
            this.Controls.Add(this.checkBoxSavings);
            this.Controls.Add(this.checkBoxChecking);
            this.Controls.Add(this.CheckingBalance);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.SavingsBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WithdrawAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Name = "BankingForm";
            this.Text = "Banking Form";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CheckBox checkBoxChecking;
        private CheckBox checkBoxSavings;
        private TextBox TransferAmount;
        private Button TransferBtn;
        private CheckBox TransferToChecking;
        private CheckBox TransferToSavings;
    }
}