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
            label2 = new Label();
            deleteAccountBTN = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            accountSucesfullyDeleted = new Label();
            nullNameLbl = new Label();
            nullAccountLbl = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(261, 26);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 7;
            label2.Text = "Enter Customer Name";
            // 
            // deleteAccountBTN
            // 
            deleteAccountBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAccountBTN.ForeColor = Color.Red;
            deleteAccountBTN.Location = new Point(321, 243);
            deleteAccountBTN.Name = "deleteAccountBTN";
            deleteAccountBTN.Size = new Size(134, 31);
            deleteAccountBTN.TabIndex = 6;
            deleteAccountBTN.Text = "Delete Account";
            deleteAccountBTN.UseVisualStyleBackColor = true;
            deleteAccountBTN.Click += deleteAccountBTN_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(261, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 29);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 4;
            label1.Text = "Delete Account";
            // 
            // accountSucesfullyDeleted
            // 
            accountSucesfullyDeleted.AutoSize = true;
            accountSucesfullyDeleted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountSucesfullyDeleted.ForeColor = Color.FromArgb(0, 192, 0);
            accountSucesfullyDeleted.Location = new Point(321, 225);
            accountSucesfullyDeleted.Name = "accountSucesfullyDeleted";
            accountSucesfullyDeleted.Size = new Size(0, 21);
            accountSucesfullyDeleted.TabIndex = 8;
            // 
            // nullNameLbl
            // 
            nullNameLbl.AutoSize = true;
            nullNameLbl.ForeColor = Color.Red;
            nullNameLbl.Location = new Point(529, 58);
            nullNameLbl.Name = "nullNameLbl";
            nullNameLbl.Size = new Size(0, 15);
            nullNameLbl.TabIndex = 9;
            // 
            // nullAccountLbl
            // 
            nullAccountLbl.AutoSize = true;
            nullAccountLbl.ForeColor = Color.Red;
            nullAccountLbl.Location = new Point(529, 123);
            nullAccountLbl.Name = "nullAccountLbl";
            nullAccountLbl.Size = new Size(0, 15);
            nullAccountLbl.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 91);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 11;
            label4.Text = "Enter Account Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(261, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 29);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(261, 156);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 14;
            label6.Text = "Type Of Account";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 29);
            comboBox1.TabIndex = 15;
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(nullAccountLbl);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(nullNameLbl);
            Controls.Add(accountSucesfullyDeleted);
            Controls.Add(label2);
            Controls.Add(deleteAccountBTN);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "DeleteAccount";
            Size = new Size(733, 286);
            Load += DeleteAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        protected internal Button deleteAccountBTN;
        private TextBox textBox1;
        private Label label1;
        private Label accountSucesfullyDeleted;
        private Label nullNameLbl;
        private Label nullAccountLbl;
        private Label label4;
        private TextBox textBox2;
        private Label label6;
        private ComboBox comboBox1;
    }
}
