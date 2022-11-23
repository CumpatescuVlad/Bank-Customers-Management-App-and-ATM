namespace ATM
{
    partial class RomanianMenu
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
            this.soldBtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.depositOrWithdrawBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.backWardsBtn = new System.Windows.Forms.Button();
            this.reciptMessage1 = new ATM.ReciptMessage();
            this.anotherTransaction1 = new ATM.AnotherTransaction();
            this.executeDepositBtn = new System.Windows.Forms.Button();
            this.executeWithdrawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soldBtn
            // 
            this.soldBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldBtn.Location = new System.Drawing.Point(3, 93);
            this.soldBtn.Name = "soldBtn";
            this.soldBtn.Size = new System.Drawing.Size(183, 39);
            this.soldBtn.TabIndex = 0;
            this.soldBtn.Text = "SOLD CONT";
            this.soldBtn.UseVisualStyleBackColor = true;
            this.soldBtn.Click += new System.EventHandler(this.soldBtn_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msg.Location = new System.Drawing.Point(220, 14);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(184, 30);
            this.msg.TabIndex = 1;
            this.msg.Text = "Selectati Operatia";
            this.msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // depositBtn
            // 
            this.depositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.Location = new System.Drawing.Point(505, 93);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(176, 39);
            this.depositBtn.TabIndex = 2;
            this.depositBtn.Text = "DEPUNERE NUMERAR";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.Location = new System.Drawing.Point(3, 342);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(183, 39);
            this.withdrawBtn.TabIndex = 3;
            this.withdrawBtn.Text = "RETRAGERE NUMERAR";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(505, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(176, 39);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // depositOrWithdrawBox
            // 
            this.depositOrWithdrawBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositOrWithdrawBox.Location = new System.Drawing.Point(236, 184);
            this.depositOrWithdrawBox.Name = "depositOrWithdrawBox";
            this.depositOrWithdrawBox.Size = new System.Drawing.Size(193, 29);
            this.depositOrWithdrawBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "DA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBtn.Location = new System.Drawing.Point(498, 387);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(183, 39);
            this.noBtn.TabIndex = 7;
            this.noBtn.Text = "NU";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // backWardsBtn
            // 
            this.backWardsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backWardsBtn.Location = new System.Drawing.Point(3, 184);
            this.backWardsBtn.Name = "backWardsBtn";
            this.backWardsBtn.Size = new System.Drawing.Size(183, 39);
            this.backWardsBtn.TabIndex = 8;
            this.backWardsBtn.Text = "<<<<";
            this.backWardsBtn.UseVisualStyleBackColor = true;
            this.backWardsBtn.Click += new System.EventHandler(this.backWardsBtn_Click);
            // 
            // reciptMessage1
            // 
            this.reciptMessage1.Location = new System.Drawing.Point(-3, -3);
            this.reciptMessage1.Name = "reciptMessage1";
            this.reciptMessage1.Size = new System.Drawing.Size(684, 455);
            this.reciptMessage1.TabIndex = 10;
            // 
            // anotherTransaction1
            // 
            this.anotherTransaction1.Location = new System.Drawing.Point(0, 0);
            this.anotherTransaction1.Name = "anotherTransaction1";
            this.anotherTransaction1.Size = new System.Drawing.Size(684, 452);
            this.anotherTransaction1.TabIndex = 11;
            // 
            // executeDepositBtn
            // 
            this.executeDepositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeDepositBtn.Location = new System.Drawing.Point(267, 256);
            this.executeDepositBtn.Name = "executeDepositBtn";
            this.executeDepositBtn.Size = new System.Drawing.Size(121, 39);
            this.executeDepositBtn.TabIndex = 13;
            this.executeDepositBtn.Text = "DEPUNERE";
            this.executeDepositBtn.UseVisualStyleBackColor = true;
            this.executeDepositBtn.Click += new System.EventHandler(this.executeDepositBtn_Click);
            // 
            // executeWithdrawBtn
            // 
            this.executeWithdrawBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeWithdrawBtn.Location = new System.Drawing.Point(267, 256);
            this.executeWithdrawBtn.Name = "executeWithdrawBtn";
            this.executeWithdrawBtn.Size = new System.Drawing.Size(121, 39);
            this.executeWithdrawBtn.TabIndex = 14;
            this.executeWithdrawBtn.Text = "RETRAGERE";
            this.executeWithdrawBtn.UseVisualStyleBackColor = true;
            this.executeWithdrawBtn.Click += new System.EventHandler(this.executeWithdrawBtn_Click);
            // 
            // RomanianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.executeWithdrawBtn);
            this.Controls.Add(this.executeDepositBtn);
            this.Controls.Add(this.backWardsBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depositOrWithdrawBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.soldBtn);
            this.Controls.Add(this.reciptMessage1);
            this.Controls.Add(this.anotherTransaction1);
            this.Name = "RomanianMenu";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button soldBtn;
        private Label msg;
        private Button depositBtn;
        private Button withdrawBtn;
        private Button cancelBtn;
        private TextBox depositOrWithdrawBox;
        private Button button1;
        private Button noBtn;
        private Button backWardsBtn;
        private ReciptMessage reciptMessage1;
        private AnotherTransaction anotherTransaction1;
        private Button executeDepositBtn;
        private Button executeWithdrawBtn;
    }
}
