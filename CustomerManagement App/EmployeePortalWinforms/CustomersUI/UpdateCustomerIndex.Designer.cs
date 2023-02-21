namespace EmployeePortalWinforms.CustomersUI
{
    partial class UpdateCustomerIndex
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
            this.button1 = new System.Windows.Forms.Button();
            this.updateLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updateCustomerEmail1 = new EmployeePortalWinforms.CustomersUI.UpdateCustomerEmail();
            this.updateIndex = new System.Windows.Forms.Button();
            this.updateCustomerName1 = new EmployeePortalWinforms.CustomersUI.UpdateCustomerName();
            this.updateCustomerPhoneNumber1 = new EmployeePortalWinforms.CustomersUI.UpdateCustomerPhoneNumber();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(54, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Customer Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateLbl
            // 
            this.updateLbl.AutoSize = true;
            this.updateLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateLbl.ForeColor = System.Drawing.Color.Red;
            this.updateLbl.Location = new System.Drawing.Point(271, 11);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(234, 30);
            this.updateLbl.TabIndex = 1;
            this.updateLbl.Text = "Update Customer Data";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(246, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Customer Phone Number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(511, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Customer Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateCustomerEmail1
            // 
            this.updateCustomerEmail1.Location = new System.Drawing.Point(3, 0);
            this.updateCustomerEmail1.Name = "updateCustomerEmail1";
            this.updateCustomerEmail1.Size = new System.Drawing.Size(761, 244);
            this.updateCustomerEmail1.TabIndex = 4;
            // 
            // updateIndex
            // 
            this.updateIndex.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateIndex.Location = new System.Drawing.Point(3, 250);
            this.updateIndex.Name = "updateIndex";
            this.updateIndex.Size = new System.Drawing.Size(125, 27);
            this.updateIndex.TabIndex = 5;
            this.updateIndex.Text = "Update Index";
            this.updateIndex.UseVisualStyleBackColor = true;
            this.updateIndex.Click += new System.EventHandler(this.updateIndex_Click);
            // 
            // updateCustomerName1
            // 
            this.updateCustomerName1.Location = new System.Drawing.Point(0, 0);
            this.updateCustomerName1.Name = "updateCustomerName1";
            this.updateCustomerName1.Size = new System.Drawing.Size(761, 244);
            this.updateCustomerName1.TabIndex = 6;
            // 
            // updateCustomerPhoneNumber1
            // 
            this.updateCustomerPhoneNumber1.Location = new System.Drawing.Point(0, -3);
            this.updateCustomerPhoneNumber1.Name = "updateCustomerPhoneNumber1";
            this.updateCustomerPhoneNumber1.Size = new System.Drawing.Size(761, 247);
            this.updateCustomerPhoneNumber1.TabIndex = 7;
            // 
            // UpdateCustomerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateIndex);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateCustomerPhoneNumber1);
            this.Controls.Add(this.updateCustomerName1);
            this.Controls.Add(this.updateCustomerEmail1);
            this.Name = "UpdateCustomerIndex";
            this.Size = new System.Drawing.Size(761, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label updateLbl;
        private Button button2;
        private Button button3;
        private UpdateCustomerEmail updateCustomerEmail1;
        private Button updateIndex;
        private UpdateCustomerName updateCustomerName1;
        private UpdateCustomerPhoneNumber updateCustomerPhoneNumber1;
    }
}
