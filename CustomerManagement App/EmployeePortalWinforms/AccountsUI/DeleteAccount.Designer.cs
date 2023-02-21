namespace EmployeePortalWinforms.AccountsUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteAccountBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountSucesfullyDeleted = new System.Windows.Forms.Label();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Customer Name";
            // 
            // deleteAccountBTN
            // 
            this.deleteAccountBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAccountBTN.ForeColor = System.Drawing.Color.Red;
            this.deleteAccountBTN.Location = new System.Drawing.Point(327, 153);
            this.deleteAccountBTN.Name = "deleteAccountBTN";
            this.deleteAccountBTN.Size = new System.Drawing.Size(134, 31);
            this.deleteAccountBTN.TabIndex = 6;
            this.deleteAccountBTN.Text = "Delete Account";
            this.deleteAccountBTN.UseVisualStyleBackColor = true;
            this.deleteAccountBTN.Click += new System.EventHandler(this.deleteAccountBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(257, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete Account";
            // 
            // accountSucesfullyDeleted
            // 
            this.accountSucesfullyDeleted.AutoSize = true;
            this.accountSucesfullyDeleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accountSucesfullyDeleted.Location = new System.Drawing.Point(310, 121);
            this.accountSucesfullyDeleted.Name = "accountSucesfullyDeleted";
            this.accountSucesfullyDeleted.Size = new System.Drawing.Size(0, 15);
            this.accountSucesfullyDeleted.TabIndex = 8;
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(531, 80);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 15);
            this.nullNameLbl.TabIndex = 9;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.accountSucesfullyDeleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteAccountBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAccount";
            this.Size = new System.Drawing.Size(733, 286);
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        protected internal Button deleteAccountBTN;
        private TextBox textBox1;
        private Label label1;
        private Label accountSucesfullyDeleted;
        private Label nullNameLbl;
    }
}
