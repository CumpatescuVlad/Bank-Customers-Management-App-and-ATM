namespace EmployeePortalWinforms.AccountsUI
{
    partial class SearchTransactions
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchTransactionsBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Customer Name";
            // 
            // searchTransactionsBTN
            // 
            this.searchTransactionsBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTransactionsBTN.ForeColor = System.Drawing.Color.Black;
            this.searchTransactionsBTN.Location = new System.Drawing.Point(298, 162);
            this.searchTransactionsBTN.Name = "searchTransactionsBTN";
            this.searchTransactionsBTN.Size = new System.Drawing.Size(164, 31);
            this.searchTransactionsBTN.TabIndex = 14;
            this.searchTransactionsBTN.Text = "Search Transactions";
            this.searchTransactionsBTN.UseVisualStyleBackColor = true;
            this.searchTransactionsBTN.Click += new System.EventHandler(this.searchTransactionsBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(248, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 29);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Transactions";
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(516, 83);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 19);
            this.nullNameLbl.TabIndex = 16;
            // 
            // SearchTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTransactionsBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchTransactions";
            this.Size = new System.Drawing.Size(733, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button searchTransactionsBTN;
        private TextBox textBox1;
        private Label label1;
        private Label nullNameLbl;
    }
}
