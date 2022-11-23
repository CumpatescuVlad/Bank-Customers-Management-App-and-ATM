namespace EmployeePortal
{
    partial class AddCustomerTab
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.succesName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(464, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(216, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(216, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(216, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Phone Number";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameBox.Location = new System.Drawing.Point(425, 76);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(301, 23);
            this.nameBox.TabIndex = 5;
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneNumBox.Location = new System.Drawing.Point(424, 166);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(302, 23);
            this.phoneNumBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailBox.Location = new System.Drawing.Point(425, 121);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(301, 23);
            this.emailBox.TabIndex = 7;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addCustomerBtn.Location = new System.Drawing.Point(496, 258);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(152, 40);
            this.addCustomerBtn.TabIndex = 9;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // succesName
            // 
            this.succesName.AutoSize = true;
            this.succesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.succesName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.succesName.Location = new System.Drawing.Point(541, 212);
            this.succesName.Name = "succesName";
            this.succesName.Size = new System.Drawing.Size(0, 17);
            this.succesName.TabIndex = 10;
            // 
            // AddCustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.succesName);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneNumBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerTab";
            this.Size = new System.Drawing.Size(1065, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Label succesName;
    }
}
