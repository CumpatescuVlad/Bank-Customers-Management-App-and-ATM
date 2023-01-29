namespace EmployeePortal
{
    partial class ManageAccountsTab
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
            this.displayAccountsBtn = new System.Windows.Forms.Button();
            this.createNewAccountBtn = new System.Windows.Forms.Button();
            this.backBTn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionsLog1 = new EmployeePortal.TransactionsLog();
            this.createAccountTab3 = new EmployeePortal.CreateAccountTab();
            this.displayAccounts1 = new EmployeePortal.DisplayAccounts();
            this.d = new System.Windows.Forms.Button();
            this.deleteAccount1 = new EmployeePortal.DeleteAccount();
            this.SuspendLayout();
            // 
            // displayAccountsBtn
            // 
            this.displayAccountsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayAccountsBtn.Location = new System.Drawing.Point(16, 157);
            this.displayAccountsBtn.Name = "displayAccountsBtn";
            this.displayAccountsBtn.Size = new System.Drawing.Size(163, 38);
            this.displayAccountsBtn.TabIndex = 0;
            this.displayAccountsBtn.Text = "Display Accounts";
            this.displayAccountsBtn.UseVisualStyleBackColor = true;
            this.displayAccountsBtn.Click += new System.EventHandler(this.displayAccountsBtn_Click);
            // 
            // createNewAccountBtn
            // 
            this.createNewAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createNewAccountBtn.Location = new System.Drawing.Point(298, 157);
            this.createNewAccountBtn.Name = "createNewAccountBtn";
            this.createNewAccountBtn.Size = new System.Drawing.Size(181, 38);
            this.createNewAccountBtn.TabIndex = 1;
            this.createNewAccountBtn.Text = "Create New  Account";
            this.createNewAccountBtn.UseVisualStyleBackColor = true;
            this.createNewAccountBtn.Click += new System.EventHandler(this.createNewAccountBtn_Click);
            // 
            // backBTn
            // 
            this.backBTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.backBTn.Location = new System.Drawing.Point(16, 16);
            this.backBTn.Name = "backBTn";
            this.backBTn.Size = new System.Drawing.Size(80, 34);
            this.backBTn.TabIndex = 6;
            this.backBTn.Text = "<<<<";
            this.backBTn.UseVisualStyleBackColor = true;
            this.backBTn.Click += new System.EventHandler(this.backBTn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(857, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Transactions Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionsLog1
            // 
            this.transactionsLog1.Location = new System.Drawing.Point(185, -2);
            this.transactionsLog1.Name = "transactionsLog1";
            this.transactionsLog1.Size = new System.Drawing.Size(666, 440);
            this.transactionsLog1.TabIndex = 8;
            // 
            // createAccountTab3
            // 
            this.createAccountTab3.Location = new System.Drawing.Point(185, 47);
            this.createAccountTab3.Name = "createAccountTab3";
            this.createAccountTab3.Size = new System.Drawing.Size(666, 348);
            this.createAccountTab3.TabIndex = 5;
            // 
            // displayAccounts1
            // 
            this.displayAccounts1.Location = new System.Drawing.Point(185, -2);
            this.displayAccounts1.Name = "displayAccounts1";
            this.displayAccounts1.Size = new System.Drawing.Size(666, 440);
            this.displayAccounts1.TabIndex = 2;
            // 
            // d
            // 
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.d.Location = new System.Drawing.Point(616, 157);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(181, 38);
            this.d.TabIndex = 9;
            this.d.Text = "Delete Account";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteAccount1
            // 
            this.deleteAccount1.Location = new System.Drawing.Point(185, -2);
            this.deleteAccount1.Name = "deleteAccount1";
            this.deleteAccount1.Size = new System.Drawing.Size(666, 442);
            this.deleteAccount1.TabIndex = 10;
            // 
            // ManageAccountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.d);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createNewAccountBtn);
            this.Controls.Add(this.displayAccountsBtn);
            this.Controls.Add(this.backBTn);
            this.Controls.Add(this.transactionsLog1);
            this.Controls.Add(this.createAccountTab3);
            this.Controls.Add(this.displayAccounts1);
            this.Controls.Add(this.deleteAccount1);
            this.Name = "ManageAccountsTab";
            this.Size = new System.Drawing.Size(1060, 438);
            this.Load += new System.EventHandler(this.ManageAccountsTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayAccountsBtn;
        private System.Windows.Forms.Button createNewAccountBtn;
        private DisplayAccounts displayAccounts1;
        private CreateAccountTab createAccountTab3;
        private System.Windows.Forms.Button backBTn;
        private System.Windows.Forms.Button button1;
        private TransactionsLog transactionsLog1;
        private System.Windows.Forms.Button d;
        private DeleteAccount deleteAccount1;
    }
}
