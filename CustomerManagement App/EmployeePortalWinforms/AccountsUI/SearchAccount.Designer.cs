namespace EmployeePortalWinforms.AccountsUI
{
    partial class SearchAccount
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
            this.searchAccountBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Customer Name";
            // 
            // searchAccountBTN
            // 
            this.searchAccountBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchAccountBTN.ForeColor = System.Drawing.Color.Black;
            this.searchAccountBTN.Location = new System.Drawing.Point(345, 154);
            this.searchAccountBTN.Name = "searchAccountBTN";
            this.searchAccountBTN.Size = new System.Drawing.Size(132, 31);
            this.searchAccountBTN.TabIndex = 10;
            this.searchAccountBTN.Text = "Search Account";
            this.searchAccountBTN.UseVisualStyleBackColor = true;
            this.searchAccountBTN.Click += new System.EventHandler(this.searchAccountBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(280, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 29);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Account";
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(559, 77);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 15);
            this.nullNameLbl.TabIndex = 12;
            // 
            // SearchAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchAccountBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchAccount";
            this.Size = new System.Drawing.Size(733, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button searchAccountBTN;
        private TextBox textBox1;
        private Label label1;
        private Label nullNameLbl;
    }
}
