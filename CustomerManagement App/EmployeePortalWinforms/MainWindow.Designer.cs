namespace EmployeePortalWinforms
{
    partial class MainWindow
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
            this.customersBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.functionsBTN = new System.Windows.Forms.Button();
            this.accountsManagement = new System.Windows.Forms.Button();
            this.customersIndex1 = new EmployeePortalWinforms.CustomersUI.CustomersIndex();
            this.mainWindowBTN = new System.Windows.Forms.Button();
            this.functionsIndex1 = new EmployeePortalWinforms.FunctionsUI.FunctionsIndex();
            this.accountsIndex1 = new EmployeePortalWinforms.AccountsUI.AccountsIndex();
            this.SuspendLayout();
            // 
            // customersBTN
            // 
            this.customersBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersBTN.Location = new System.Drawing.Point(57, 201);
            this.customersBTN.Name = "customersBTN";
            this.customersBTN.Size = new System.Drawing.Size(216, 41);
            this.customersBTN.TabIndex = 0;
            this.customersBTN.Text = "Customers Management";
            this.customersBTN.UseVisualStyleBackColor = true;
            this.customersBTN.Click += new System.EventHandler(this.customersBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Titillium Web", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Romanian Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // functionsBTN
            // 
            this.functionsBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.functionsBTN.Location = new System.Drawing.Point(279, 201);
            this.functionsBTN.Name = "functionsBTN";
            this.functionsBTN.Size = new System.Drawing.Size(216, 41);
            this.functionsBTN.TabIndex = 2;
            this.functionsBTN.Text = "Functions";
            this.functionsBTN.UseVisualStyleBackColor = true;
            this.functionsBTN.Click += new System.EventHandler(this.functionsBTN_Click);
            // 
            // accountsManagement
            // 
            this.accountsManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountsManagement.Location = new System.Drawing.Point(501, 201);
            this.accountsManagement.Name = "accountsManagement";
            this.accountsManagement.Size = new System.Drawing.Size(216, 41);
            this.accountsManagement.TabIndex = 3;
            this.accountsManagement.Text = "Accounts Management";
            this.accountsManagement.UseVisualStyleBackColor = true;
            this.accountsManagement.Click += new System.EventHandler(this.accountsManagement_Click);
            // 
            // customersIndex1
            // 
            this.customersIndex1.Location = new System.Drawing.Point(12, 60);
            this.customersIndex1.Name = "customersIndex1";
            this.customersIndex1.Size = new System.Drawing.Size(802, 480);
            this.customersIndex1.TabIndex = 4;
            // 
            // mainWindowBTN
            // 
            this.mainWindowBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainWindowBTN.Location = new System.Drawing.Point(673, 546);
            this.mainWindowBTN.Name = "mainWindowBTN";
            this.mainWindowBTN.Size = new System.Drawing.Size(141, 39);
            this.mainWindowBTN.TabIndex = 5;
            this.mainWindowBTN.Text = "Main Window";
            this.mainWindowBTN.UseVisualStyleBackColor = true;
            this.mainWindowBTN.Click += new System.EventHandler(this.mainWindowBTN_Click);
            // 
            // functionsIndex1
            // 
            this.functionsIndex1.Location = new System.Drawing.Point(12, 60);
            this.functionsIndex1.Name = "functionsIndex1";
            this.functionsIndex1.Size = new System.Drawing.Size(802, 480);
            this.functionsIndex1.TabIndex = 6;
            // 
            // accountsIndex1
            // 
            this.accountsIndex1.Location = new System.Drawing.Point(12, 60);
            this.accountsIndex1.Name = "accountsIndex1";
            this.accountsIndex1.Size = new System.Drawing.Size(802, 480);
            this.accountsIndex1.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 613);
            this.Controls.Add(this.mainWindowBTN);
            this.Controls.Add(this.accountsManagement);
            this.Controls.Add(this.functionsBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersBTN);
            this.Controls.Add(this.customersIndex1);
            this.Controls.Add(this.functionsIndex1);
            this.Controls.Add(this.accountsIndex1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button customersBTN;
        private Label label1;
        private Button functionsBTN;
        private Button accountsManagement;
        private CustomersUI.CustomersIndex customersIndex1;
        private Button mainWindowBTN;
        private FunctionsUI.FunctionsIndex functionsIndex1;
        private AccountsUI.AccountsIndex accountsIndex1;
    }
}