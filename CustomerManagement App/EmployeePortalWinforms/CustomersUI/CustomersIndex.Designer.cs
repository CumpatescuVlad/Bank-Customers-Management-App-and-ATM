namespace EmployeePortalWinforms.CustomersUI
{
    partial class CustomersIndex
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
            this.chooseOperation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.searchCustomer1 = new EmployeePortalWinforms.CustomersUI.SearchCustomer();
            this.addCustomer1 = new EmployeePortalWinforms.CustomersUI.AddCustomer();
            this.updateCustomerIndex1 = new EmployeePortalWinforms.CustomersUI.UpdateCustomerIndex();
            this.deleteCustomer1 = new EmployeePortalWinforms.CustomersUI.DeleteCustomer();
            this.homeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseOperation
            // 
            this.chooseOperation.AutoSize = true;
            this.chooseOperation.Font = new System.Drawing.Font("Titillium Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseOperation.Location = new System.Drawing.Point(271, 10);
            this.chooseOperation.Name = "chooseOperation";
            this.chooseOperation.Size = new System.Drawing.Size(209, 36);
            this.chooseOperation.TabIndex = 0;
            this.chooseOperation.Text = "Choose Operation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(221, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(397, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(573, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchCustomer1
            // 
            this.searchCustomer1.Location = new System.Drawing.Point(10, 3);
            this.searchCustomer1.Name = "searchCustomer1";
            this.searchCustomer1.Size = new System.Drawing.Size(733, 286);
            this.searchCustomer1.TabIndex = 5;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(10, 3);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(733, 400);
            this.addCustomer1.TabIndex = 6;
            this.addCustomer1.Load += new System.EventHandler(this.addCustomer1_Load);
            // 
            // updateCustomerIndex1
            // 
            this.updateCustomerIndex1.Location = new System.Drawing.Point(27, 10);
            this.updateCustomerIndex1.Name = "updateCustomerIndex1";
            this.updateCustomerIndex1.Size = new System.Drawing.Size(761, 385);
            this.updateCustomerIndex1.TabIndex = 7;
            // 
            // deleteCustomer1
            // 
            this.deleteCustomer1.Location = new System.Drawing.Point(36, 10);
            this.deleteCustomer1.Name = "deleteCustomer1";
            this.deleteCustomer1.Size = new System.Drawing.Size(733, 385);
            this.deleteCustomer1.TabIndex = 8;
            // 
            // homeBTN
            // 
            this.homeBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBTN.Location = new System.Drawing.Point(660, 439);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(142, 38);
            this.homeBTN.TabIndex = 9;
            this.homeBTN.Text = "Customers Index";
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // CustomersIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseOperation);
            this.Controls.Add(this.searchCustomer1);
            this.Controls.Add(this.addCustomer1);
            this.Controls.Add(this.updateCustomerIndex1);
            this.Controls.Add(this.deleteCustomer1);
            this.Name = "CustomersIndex";
            this.Size = new System.Drawing.Size(802, 480);
            this.Load += new System.EventHandler(this.CustomersIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label chooseOperation;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private SearchCustomer searchCustomer1;
        private AddCustomer addCustomer1;
        private UpdateCustomerIndex updateCustomerIndex1;
        private DeleteCustomer deleteCustomer1;
        private Button homeBTN;
    }
}
