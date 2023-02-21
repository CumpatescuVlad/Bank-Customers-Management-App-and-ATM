namespace EmployeePortal
{
    partial class MainWindow
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
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.employeename = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.manageCustomerDataBtn = new System.Windows.Forms.Button();
            this.manageAccountsBtn = new System.Windows.Forms.Button();
            this.createCreditCardBtn = new System.Windows.Forms.Button();
            this.addACompanyBtn = new System.Windows.Forms.Button();
            this.manageAccountsTab1 = new EmployeePortal.ManageAccountsTab();
            this.deleteCustomerTab1 = new EmployeePortal.DeleteCustomerTab();
            this.addCustomerTab1 = new EmployeePortal.AddCustomerTab();
            this.manageCustomerData1 = new EmployeePortal.ManageCustomerData();
            this.createCreditCardTab1 = new EmployeePortal.UIComponents.CreditCardUI.CreateCreditCardTab();
            this.addCompanyTab1 = new EmployeePortal.AddCompanyTab();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.backBtn.Location = new System.Drawing.Point(12, 442);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(124, 34);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "HOME";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitBtn.Location = new System.Drawing.Point(932, 442);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 34);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // employeename
            // 
            this.employeename.AutoSize = true;
            this.employeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.employeename.Location = new System.Drawing.Point(368, 183);
            this.employeename.Name = "employeename";
            this.employeename.Size = new System.Drawing.Size(152, 26);
            this.employeename.TabIndex = 2;
            this.employeename.Text = "Loggend In As";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.time.Location = new System.Drawing.Point(7, 383);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(70, 26);
            this.time.TabIndex = 3;
            this.time.Text = "label1";
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addCustomer.Location = new System.Drawing.Point(12, 12);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(124, 34);
            this.addCustomer.TabIndex = 4;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteCustomer.Location = new System.Drawing.Point(163, 12);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(143, 34);
            this.deleteCustomer.TabIndex = 7;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // manageCustomerDataBtn
            // 
            this.manageCustomerDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manageCustomerDataBtn.Location = new System.Drawing.Point(331, 12);
            this.manageCustomerDataBtn.Name = "manageCustomerDataBtn";
            this.manageCustomerDataBtn.Size = new System.Drawing.Size(189, 34);
            this.manageCustomerDataBtn.TabIndex = 12;
            this.manageCustomerDataBtn.Text = "Manage Customer Data";
            this.manageCustomerDataBtn.UseVisualStyleBackColor = true;
            this.manageCustomerDataBtn.Click += new System.EventHandler(this.manageCustomerDataBtn_Click);
            // 
            // manageAccountsBtn
            // 
            this.manageAccountsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manageAccountsBtn.Location = new System.Drawing.Point(548, 12);
            this.manageAccountsBtn.Name = "manageAccountsBtn";
            this.manageAccountsBtn.Size = new System.Drawing.Size(147, 34);
            this.manageAccountsBtn.TabIndex = 14;
            this.manageAccountsBtn.Text = "Manage Accounts";
            this.manageAccountsBtn.UseVisualStyleBackColor = true;
            this.manageAccountsBtn.Click += new System.EventHandler(this.manageAccountsBtn_Click);
            // 
            // createCreditCardBtn
            // 
            this.createCreditCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createCreditCardBtn.Location = new System.Drawing.Point(720, 12);
            this.createCreditCardBtn.Name = "createCreditCardBtn";
            this.createCreditCardBtn.Size = new System.Drawing.Size(155, 34);
            this.createCreditCardBtn.TabIndex = 16;
            this.createCreditCardBtn.Text = "Create Credit Card";
            this.createCreditCardBtn.UseVisualStyleBackColor = true;
            this.createCreditCardBtn.Click += new System.EventHandler(this.createCreditCardBtn_Click);
            // 
            // addACompanyBtn
            // 
            this.addACompanyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addACompanyBtn.Location = new System.Drawing.Point(892, 12);
            this.addACompanyBtn.Name = "addACompanyBtn";
            this.addACompanyBtn.Size = new System.Drawing.Size(143, 34);
            this.addACompanyBtn.TabIndex = 18;
            this.addACompanyBtn.Text = "Add  Company";
            this.addACompanyBtn.UseVisualStyleBackColor = true;
            this.addACompanyBtn.Click += new System.EventHandler(this.addACompanyBtn_Click);
            // 
            // manageAccountsTab1
            // 
            this.manageAccountsTab1.Location = new System.Drawing.Point(1, 2);
            this.manageAccountsTab1.Name = "manageAccountsTab1";
            this.manageAccountsTab1.Size = new System.Drawing.Size(1048, 441);
            this.manageAccountsTab1.TabIndex = 15;
            // 
            // deleteCustomerTab1
            // 
            this.deleteCustomerTab1.Location = new System.Drawing.Point(1, 3);
            this.deleteCustomerTab1.Name = "deleteCustomerTab1";
            this.deleteCustomerTab1.Size = new System.Drawing.Size(1048, 433);
            this.deleteCustomerTab1.TabIndex = 11;
            // 
            // addCustomerTab1
            // 
            this.addCustomerTab1.Location = new System.Drawing.Point(-5, 3);
            this.addCustomerTab1.Name = "addCustomerTab1";
            this.addCustomerTab1.Size = new System.Drawing.Size(1048, 433);
            this.addCustomerTab1.TabIndex = 8;
            // 
            // manageCustomerData1
            // 
            this.manageCustomerData1.Location = new System.Drawing.Point(-5, 2);
            this.manageCustomerData1.Name = "manageCustomerData1";
            this.manageCustomerData1.Size = new System.Drawing.Size(1054, 434);
            this.manageCustomerData1.TabIndex = 13;
            // 
            // createCreditCardTab1
            // 
            this.createCreditCardTab1.Location = new System.Drawing.Point(1, 2);
            this.createCreditCardTab1.Name = "createCreditCardTab1";
            this.createCreditCardTab1.Size = new System.Drawing.Size(1054, 441);
            this.createCreditCardTab1.TabIndex = 17;
            // 
            // addCompanyTab1
            // 
            this.addCompanyTab1.Location = new System.Drawing.Point(-5, 3);
            this.addCompanyTab1.Name = "addCompanyTab1";
            this.addCompanyTab1.Size = new System.Drawing.Size(1056, 433);
            this.addCompanyTab1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 488);
            this.ControlBox = false;
            this.Controls.Add(this.addACompanyBtn);
            this.Controls.Add(this.createCreditCardBtn);
            this.Controls.Add(this.manageAccountsBtn);
            this.Controls.Add(this.manageCustomerDataBtn);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.time);
            this.Controls.Add(this.employeename);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.manageAccountsTab1);
            this.Controls.Add(this.deleteCustomerTab1);
            this.Controls.Add(this.addCustomerTab1);
            this.Controls.Add(this.manageCustomerData1);
            this.Controls.Add(this.createCreditCardTab1);
            this.Controls.Add(this.addCompanyTab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label employeename;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private AddCustomerTab addCustomerTab1;
        private DeleteCustomerTab deleteCustomerTab1;
        private System.Windows.Forms.Button manageCustomerDataBtn;
        private ManageCustomerData manageCustomerData1;
        private System.Windows.Forms.Button manageAccountsBtn;
        private ManageAccountsTab manageAccountsTab1;
        private System.Windows.Forms.Button createCreditCardBtn;
        private UIComponents.CreditCardUI.CreateCreditCardTab createCreditCardTab1;
        private System.Windows.Forms.Button addACompanyBtn;
        private AddCompanyTab addCompanyTab1;
    }
}

