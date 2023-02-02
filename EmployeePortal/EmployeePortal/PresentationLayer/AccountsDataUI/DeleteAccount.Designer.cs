namespace EmployeePortal
{
    partial class DeleteAccount
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
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.succesMessage = new System.Windows.Forms.Label();
            this.accountIBANBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeOfAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberBox.Location = new System.Drawing.Point(281, 61);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(211, 26);
            this.numberBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(77, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Number";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameBox.Location = new System.Drawing.Point(281, 14);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(211, 26);
            this.nameBox.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteBtn.Location = new System.Drawing.Point(290, 242);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 37);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account Owner Name";
            // 
            // succesMessage
            // 
            this.succesMessage.AutoSize = true;
            this.succesMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.succesMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.succesMessage.Location = new System.Drawing.Point(589, 189);
            this.succesMessage.Name = "succesMessage";
            this.succesMessage.Size = new System.Drawing.Size(0, 17);
            this.succesMessage.TabIndex = 10;
            // 
            // accountIBANBox
            // 
            this.accountIBANBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountIBANBox.Location = new System.Drawing.Point(281, 152);
            this.accountIBANBox.Name = "accountIBANBox";
            this.accountIBANBox.Size = new System.Drawing.Size(211, 26);
            this.accountIBANBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(77, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Account IBAN";
            // 
            // accountNameBox
            // 
            this.accountNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountNameBox.Location = new System.Drawing.Point(281, 106);
            this.accountNameBox.Name = "accountNameBox";
            this.accountNameBox.Size = new System.Drawing.Size(211, 26);
            this.accountNameBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(77, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account Name";
            // 
            // typeOfAccount
            // 
            this.typeOfAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeOfAccount.Location = new System.Drawing.Point(281, 198);
            this.typeOfAccount.Name = "typeOfAccount";
            this.typeOfAccount.Size = new System.Drawing.Size(211, 26);
            this.typeOfAccount.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(77, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Type Of Account";
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeOfAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountIBANBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.succesMessage);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAccount";
            this.Size = new System.Drawing.Size(666, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label succesMessage;
        private System.Windows.Forms.TextBox accountIBANBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeOfAccount;
        private System.Windows.Forms.Label label5;
    }
}
