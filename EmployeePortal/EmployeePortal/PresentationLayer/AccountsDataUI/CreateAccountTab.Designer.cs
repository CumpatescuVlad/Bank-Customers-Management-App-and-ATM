namespace EmployeePortal
{
    partial class CreateAccountTab
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
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accountNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountInitialAmountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountCreatedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(58, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customer Name";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameBox.Location = new System.Drawing.Point(250, 75);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(234, 26);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(278, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountNameBox
            // 
            this.accountNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountNameBox.Location = new System.Drawing.Point(250, 132);
            this.accountNameBox.Name = "accountNameBox";
            this.accountNameBox.Size = new System.Drawing.Size(234, 26);
            this.accountNameBox.TabIndex = 6;
            this.accountNameBox.TextChanged += new System.EventHandler(this.accountNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Account Name";
            // 
            // accountInitialAmountBox
            // 
            this.accountInitialAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountInitialAmountBox.Location = new System.Drawing.Point(250, 185);
            this.accountInitialAmountBox.Name = "accountInitialAmountBox";
            this.accountInitialAmountBox.Size = new System.Drawing.Size(234, 26);
            this.accountInitialAmountBox.TabIndex = 8;
            this.accountInitialAmountBox.TextChanged += new System.EventHandler(this.accountInitialAmountBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(58, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Initial Amount";
            // 
            // accountCreatedLbl
            // 
            this.accountCreatedLbl.AutoSize = true;
            this.accountCreatedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.accountCreatedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accountCreatedLbl.Location = new System.Drawing.Point(260, 228);
            this.accountCreatedLbl.Name = "accountCreatedLbl";
            this.accountCreatedLbl.Size = new System.Drawing.Size(0, 17);
            this.accountCreatedLbl.TabIndex = 9;
            // 
            // CreateAccountTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountCreatedLbl);
            this.Controls.Add(this.accountInitialAmountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountTab";
            this.Size = new System.Drawing.Size(666, 437);
            this.Load += new System.EventHandler(this.CreateAccountTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox accountNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountInitialAmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountCreatedLbl;
    }
}
