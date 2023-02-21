namespace EmployeePortal
{
    partial class TransactionsLog
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
            this.searchTransactionsLog = new System.Windows.Forms.Button();
            this.customerFullNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.generateStatementBtn = new System.Windows.Forms.Button();
            this.generateStatementTab1 = new EmployeePortal.GenerateStatementTab();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(65, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // searchTransactionsLog
            // 
            this.searchTransactionsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTransactionsLog.Location = new System.Drawing.Point(270, 211);
            this.searchTransactionsLog.Name = "searchTransactionsLog";
            this.searchTransactionsLog.Size = new System.Drawing.Size(103, 37);
            this.searchTransactionsLog.TabIndex = 1;
            this.searchTransactionsLog.Text = "Search";
            this.searchTransactionsLog.UseVisualStyleBackColor = true;
            this.searchTransactionsLog.Click += new System.EventHandler(this.searchTransactionsLog_Click);
            // 
            // customerFullNameBox
            // 
            this.customerFullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerFullNameBox.Location = new System.Drawing.Point(231, 86);
            this.customerFullNameBox.Name = "customerFullNameBox";
            this.customerFullNameBox.Size = new System.Drawing.Size(211, 26);
            this.customerFullNameBox.TabIndex = 2;
            this.customerFullNameBox.TextChanged += new System.EventHandler(this.customerFullNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(65, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Number";
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountNumberBox.Location = new System.Drawing.Point(231, 150);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(211, 26);
            this.accountNumberBox.TabIndex = 4;
            this.accountNumberBox.TextChanged += new System.EventHandler(this.accountNumberBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(163, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "<<<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(447, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(572, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(293, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Account Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(141, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(4, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Account Owner";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(-3, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(666, 312);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // generateStatementBtn
            // 
            this.generateStatementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generateStatementBtn.Location = new System.Drawing.Point(351, 380);
            this.generateStatementBtn.Name = "generateStatementBtn";
            this.generateStatementBtn.Size = new System.Drawing.Size(182, 40);
            this.generateStatementBtn.TabIndex = 15;
            this.generateStatementBtn.Text = "Generate Statement";
            this.generateStatementBtn.UseVisualStyleBackColor = true;
            this.generateStatementBtn.Click += new System.EventHandler(this.generateStatementBtn_Click);
            // 
            // generateStatementTab1
            // 
            this.generateStatementTab1.Location = new System.Drawing.Point(0, 0);
            this.generateStatementTab1.Name = "generateStatementTab1";
            this.generateStatementTab1.Size = new System.Drawing.Size(666, 502);
            this.generateStatementTab1.TabIndex = 16;
            // 
            // TransactionsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generateStatementBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.accountNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerFullNameBox);
            this.Controls.Add(this.searchTransactionsLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateStatementTab1);
            this.Name = "TransactionsLog";
            this.Size = new System.Drawing.Size(666, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchTransactionsLog;
        private System.Windows.Forms.TextBox customerFullNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button generateStatementBtn;
        private GenerateStatementTab generateStatementTab1;
    }
}
