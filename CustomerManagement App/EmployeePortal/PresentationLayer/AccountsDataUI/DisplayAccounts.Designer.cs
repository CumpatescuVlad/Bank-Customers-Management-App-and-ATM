﻿namespace EmployeePortal
{
    partial class DisplayAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchCustomersAccount = new System.Windows.Forms.Button();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayOwnerName = new System.Windows.Forms.Label();
            this.displayIBAN = new System.Windows.Forms.Label();
            this.displayAccountNumber = new System.Windows.Forms.Label();
            this.displayAccountBallance = new System.Windows.Forms.Label();
            this.displayAccountName = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchCustomersAccount
            // 
            this.searchCustomersAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchCustomersAccount.Location = new System.Drawing.Point(295, 302);
            this.searchCustomersAccount.Name = "searchCustomersAccount";
            this.searchCustomersAccount.Size = new System.Drawing.Size(139, 29);
            this.searchCustomersAccount.TabIndex = 0;
            this.searchCustomersAccount.Text = "Serach";
            this.searchCustomersAccount.UseVisualStyleBackColor = true;
            this.searchCustomersAccount.Click += new System.EventHandler(this.searchCustomersAccount_Click);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameBox.Location = new System.Drawing.Point(237, 208);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(297, 26);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(147, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(336, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(470, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(555, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account Name";
            // 
            // displayOwnerName
            // 
            this.displayOwnerName.AutoSize = true;
            this.displayOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayOwnerName.Location = new System.Drawing.Point(4, 61);
            this.displayOwnerName.Name = "displayOwnerName";
            this.displayOwnerName.Size = new System.Drawing.Size(148, 20);
            this.displayOwnerName.TabIndex = 10;
            this.displayOwnerName.Text = "DisplayOwnerName";
            // 
            // displayIBAN
            // 
            this.displayIBAN.AutoSize = true;
            this.displayIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayIBAN.Location = new System.Drawing.Point(147, 61);
            this.displayIBAN.Name = "displayIBAN";
            this.displayIBAN.Size = new System.Drawing.Size(157, 20);
            this.displayIBAN.TabIndex = 11;
            this.displayIBAN.Text = "DisplayAccountIBAN";
            // 
            // displayAccountNumber
            // 
            this.displayAccountNumber.AutoSize = true;
            this.displayAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayAccountNumber.Location = new System.Drawing.Point(336, 61);
            this.displayAccountNumber.Name = "displayAccountNumber";
            this.displayAccountNumber.Size = new System.Drawing.Size(124, 20);
            this.displayAccountNumber.TabIndex = 12;
            this.displayAccountNumber.Text = "AccountNumber";
            // 
            // displayAccountBallance
            // 
            this.displayAccountBallance.AutoSize = true;
            this.displayAccountBallance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayAccountBallance.Location = new System.Drawing.Point(470, 61);
            this.displayAccountBallance.Name = "displayAccountBallance";
            this.displayAccountBallance.Size = new System.Drawing.Size(65, 20);
            this.displayAccountBallance.TabIndex = 13;
            this.displayAccountBallance.Text = "Amount";
            // 
            // displayAccountName
            // 
            this.displayAccountName.AutoSize = true;
            this.displayAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayAccountName.Location = new System.Drawing.Point(555, 61);
            this.displayAccountName.Name = "displayAccountName";
            this.displayAccountName.Size = new System.Drawing.Size(114, 20);
            this.displayAccountName.TabIndex = 14;
            this.displayAccountName.Text = "Account Name";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(270, 131);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(65, 20);
            this.errorLabel.TabIndex = 15;
            this.errorLabel.Text = "ErrorLbl";
            // 
            // DisplayAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.displayAccountName);
            this.Controls.Add(this.displayAccountBallance);
            this.Controls.Add(this.displayAccountNumber);
            this.Controls.Add(this.displayIBAN);
            this.Controls.Add(this.displayOwnerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.searchCustomersAccount);
            this.Name = "DisplayAccounts";
            this.Size = new System.Drawing.Size(666, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCustomersAccount;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displayOwnerName;
        private System.Windows.Forms.Label displayIBAN;
        private System.Windows.Forms.Label displayAccountNumber;
        private System.Windows.Forms.Label displayAccountBallance;
        private System.Windows.Forms.Label displayAccountName;
        private System.Windows.Forms.Label errorLabel;
    }
}