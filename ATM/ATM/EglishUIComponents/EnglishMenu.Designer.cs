namespace ATM
{
    partial class EnglishMenu
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.MSG = new System.Windows.Forms.Label();
            this.soldBtn = new System.Windows.Forms.Button();
            this.backWardsBtn = new System.Windows.Forms.Button();
            this.DepositOrWithdrawBox = new System.Windows.Forms.TextBox();
            this.NOBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.anotherTransactionsEnglish1 = new ATM.AnotherTransactionsEnglish();
            this.reciptMessageEnglish1 = new ATM.ReciptMessageEnglish();
            this.executeWithdrawBtn = new System.Windows.Forms.Button();
            this.executeDepositBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(557, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 39);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.Location = new System.Drawing.Point(5, 342);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(124, 39);
            this.withdrawBtn.TabIndex = 8;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.Location = new System.Drawing.Point(584, 93);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(97, 39);
            this.depositBtn.TabIndex = 7;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // MSG
            // 
            this.MSG.AutoSize = true;
            this.MSG.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MSG.Location = new System.Drawing.Point(269, 19);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(175, 30);
            this.MSG.TabIndex = 6;
            this.MSG.Text = "Select Operation";
            this.MSG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // soldBtn
            // 
            this.soldBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldBtn.Location = new System.Drawing.Point(5, 93);
            this.soldBtn.Name = "soldBtn";
            this.soldBtn.Size = new System.Drawing.Size(97, 39);
            this.soldBtn.TabIndex = 5;
            this.soldBtn.Text = "SOLD";
            this.soldBtn.UseVisualStyleBackColor = true;
            this.soldBtn.Click += new System.EventHandler(this.soldBtn_Click);
            // 
            // backWardsBtn
            // 
            this.backWardsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backWardsBtn.Location = new System.Drawing.Point(0, 199);
            this.backWardsBtn.Name = "backWardsBtn";
            this.backWardsBtn.Size = new System.Drawing.Size(183, 39);
            this.backWardsBtn.TabIndex = 10;
            this.backWardsBtn.Text = "<<<<";
            this.backWardsBtn.UseVisualStyleBackColor = true;
            this.backWardsBtn.Click += new System.EventHandler(this.backWardsBtn_Click);
            // 
            // DepositOrWithdrawBox
            // 
            this.DepositOrWithdrawBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositOrWithdrawBox.Location = new System.Drawing.Point(269, 205);
            this.DepositOrWithdrawBox.Name = "DepositOrWithdrawBox";
            this.DepositOrWithdrawBox.Size = new System.Drawing.Size(193, 29);
            this.DepositOrWithdrawBox.TabIndex = 11;
            this.DepositOrWithdrawBox.TextChanged += new System.EventHandler(this.DepositOrWithdrawBox_TextChanged);
            // 
            // NOBtn
            // 
            this.NOBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NOBtn.Location = new System.Drawing.Point(498, 387);
            this.NOBtn.Name = "NOBtn";
            this.NOBtn.Size = new System.Drawing.Size(183, 39);
            this.NOBtn.TabIndex = 13;
            this.NOBtn.Text = "NO";
            this.NOBtn.UseVisualStyleBackColor = true;
            this.NOBtn.Click += new System.EventHandler(this.NOBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.Location = new System.Drawing.Point(3, 387);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(183, 39);
            this.yesBtn.TabIndex = 12;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // anotherTransactionsEnglish1
            // 
            this.anotherTransactionsEnglish1.Location = new System.Drawing.Point(0, -3);
            this.anotherTransactionsEnglish1.Name = "anotherTransactionsEnglish1";
            this.anotherTransactionsEnglish1.Size = new System.Drawing.Size(684, 455);
            this.anotherTransactionsEnglish1.TabIndex = 15;
            // 
            // reciptMessageEnglish1
            // 
            this.reciptMessageEnglish1.Location = new System.Drawing.Point(0, 0);
            this.reciptMessageEnglish1.Name = "reciptMessageEnglish1";
            this.reciptMessageEnglish1.Size = new System.Drawing.Size(684, 455);
            this.reciptMessageEnglish1.TabIndex = 16;
            // 
            // executeWithdrawBtn
            // 
            this.executeWithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeWithdrawBtn.Location = new System.Drawing.Point(299, 259);
            this.executeWithdrawBtn.Name = "executeWithdrawBtn";
            this.executeWithdrawBtn.Size = new System.Drawing.Size(129, 39);
            this.executeWithdrawBtn.TabIndex = 17;
            this.executeWithdrawBtn.Text = "WITHDRAW";
            this.executeWithdrawBtn.UseVisualStyleBackColor = true;
            this.executeWithdrawBtn.Click += new System.EventHandler(this.executeWithdrawBtn_Click);
            // 
            // executeDepositBtn
            // 
            this.executeDepositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeDepositBtn.Location = new System.Drawing.Point(299, 259);
            this.executeDepositBtn.Name = "executeDepositBtn";
            this.executeDepositBtn.Size = new System.Drawing.Size(129, 39);
            this.executeDepositBtn.TabIndex = 18;
            this.executeDepositBtn.Text = "DEPOSIT";
            this.executeDepositBtn.UseVisualStyleBackColor = true;
            this.executeDepositBtn.Click += new System.EventHandler(this.executeDepositBtn_Click);
            // 
            // EnglishMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.executeDepositBtn);
            this.Controls.Add(this.executeWithdrawBtn);
            this.Controls.Add(this.NOBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.DepositOrWithdrawBox);
            this.Controls.Add(this.backWardsBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.soldBtn);
            this.Controls.Add(this.reciptMessageEnglish1);
            this.Controls.Add(this.anotherTransactionsEnglish1);
            this.Name = "EnglishMenu";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelBtn;
        private Button withdrawBtn;
        private Button depositBtn;
        private Label MSG;
        private Button soldBtn;
        private Button backWardsBtn;
        private TextBox DepositOrWithdrawBox;
        private Button NOBtn;
        private Button yesBtn;
        private AnotherTransactionsEnglish anotherTransactionsEnglish1;
        private ReciptMessageEnglish reciptMessageEnglish1;
        private Button executeWithdrawBtn;
        private Button executeDepositBtn;
    }
}
