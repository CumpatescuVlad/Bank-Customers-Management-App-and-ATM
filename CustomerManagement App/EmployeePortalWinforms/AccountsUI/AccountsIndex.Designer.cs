namespace EmployeePortalWinforms.AccountsUI
{
    partial class AccountsIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchAccounts = new System.Windows.Forms.Button();
            this.searchTransactions = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.searchAccount1 = new EmployeePortalWinforms.AccountsUI.SearchAccount();
            this.displayAccounts1 = new EmployeePortalWinforms.AccountsUI.DisplayAccounts();
            this.searchTransactions1 = new EmployeePortalWinforms.AccountsUI.SearchTransactions();
            this.displayTransactions1 = new EmployeePortalWinforms.AccountsUI.DisplayTransactions();
            this.createAccount1 = new EmployeePortalWinforms.AccountsUI.CreateAccount();
            this.deleteAccount1 = new EmployeePortalWinforms.AccountsUI.DeleteAccount();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Titillium Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts Operations";
            // 
            // searchAccounts
            // 
            this.searchAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchAccounts.Location = new System.Drawing.Point(40, 188);
            this.searchAccounts.Name = "searchAccounts";
            this.searchAccounts.Size = new System.Drawing.Size(165, 39);
            this.searchAccounts.TabIndex = 1;
            this.searchAccounts.Text = "Search Accounts";
            this.searchAccounts.UseVisualStyleBackColor = true;
            this.searchAccounts.Click += new System.EventHandler(this.searchAccounts_Click);
            // 
            // searchTransactions
            // 
            this.searchTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTransactions.Location = new System.Drawing.Point(227, 188);
            this.searchTransactions.Name = "searchTransactions";
            this.searchTransactions.Size = new System.Drawing.Size(165, 39);
            this.searchTransactions.TabIndex = 2;
            this.searchTransactions.Text = "Search Transactions";
            this.searchTransactions.UseVisualStyleBackColor = true;
            this.searchTransactions.Click += new System.EventHandler(this.searchTransactions_Click);
            // 
            // createAccount
            // 
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccount.Location = new System.Drawing.Point(412, 188);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(165, 39);
            this.createAccount.TabIndex = 3;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAccount.Location = new System.Drawing.Point(596, 188);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(157, 39);
            this.deleteAccount.TabIndex = 4;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBTN.Location = new System.Drawing.Point(0, 431);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(134, 43);
            this.homeBTN.TabIndex = 5;
            this.homeBTN.Text = "Accounts Index";
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // searchAccount1
            // 
            this.searchAccount1.Location = new System.Drawing.Point(40, 0);
            this.searchAccount1.Name = "searchAccount1";
            this.searchAccount1.Size = new System.Drawing.Size(733, 286);
            this.searchAccount1.TabIndex = 6;
            // 
            // displayAccounts1
            // 
            this.displayAccounts1.Location = new System.Drawing.Point(0, 0);
            this.displayAccounts1.Name = "displayAccounts1";
            this.displayAccounts1.Size = new System.Drawing.Size(802, 388);
            this.displayAccounts1.TabIndex = 7;
            // 
            // searchTransactions1
            // 
            this.searchTransactions1.Location = new System.Drawing.Point(28, 3);
            this.searchTransactions1.Name = "searchTransactions1";
            this.searchTransactions1.Size = new System.Drawing.Size(733, 286);
            this.searchTransactions1.TabIndex = 8;
            this.searchTransactions1.Load += new System.EventHandler(this.searchTransactions1_Load);
            // 
            // displayTransactions1
            // 
            this.displayTransactions1.Location = new System.Drawing.Point(-3, 0);
            this.displayTransactions1.Name = "displayTransactions1";
            this.displayTransactions1.Size = new System.Drawing.Size(802, 425);
            this.displayTransactions1.TabIndex = 9;
            // 
            // createAccount1
            // 
            this.createAccount1.Location = new System.Drawing.Point(28, 0);
            this.createAccount1.Name = "createAccount1";
            this.createAccount1.Size = new System.Drawing.Size(733, 425);
            this.createAccount1.TabIndex = 10;
            // 
            // deleteAccount1
            // 
            this.deleteAccount1.Location = new System.Drawing.Point(40, 3);
            this.deleteAccount1.Name = "deleteAccount1";
            this.deleteAccount1.Size = new System.Drawing.Size(733, 286);
            this.deleteAccount1.TabIndex = 11;
            // 
            // AccountsIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.searchTransactions);
            this.Controls.Add(this.searchAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchAccount1);
            this.Controls.Add(this.displayAccounts1);
            this.Controls.Add(this.searchTransactions1);
            this.Controls.Add(this.displayTransactions1);
            this.Controls.Add(this.createAccount1);
            this.Controls.Add(this.deleteAccount1);
            this.Name = "AccountsIndex";
            this.Size = new System.Drawing.Size(802, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button searchAccounts;
        private Button searchTransactions;
        private Button createAccount;
        private Button deleteAccount;
        private Button homeBTN;
        private SearchAccount searchAccount1;
        private DisplayAccounts displayAccounts1;
        private SearchTransactions searchTransactions1;
        private DisplayTransactions displayTransactions1;
        private CreateAccount createAccount1;
        private DeleteAccount deleteAccount1;
    }
}
