namespace EmployeePortalWinforms.CustomersUI
{
    partial class SearchCustomer
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
            this.searchCutomerBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.customerInfoDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Customer Name";
            // 
            // searchCutomerBTN
            // 
            this.searchCutomerBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCutomerBTN.ForeColor = System.Drawing.Color.Black;
            this.searchCutomerBTN.Location = new System.Drawing.Point(300, 157);
            this.searchCutomerBTN.Name = "searchCutomerBTN";
            this.searchCutomerBTN.Size = new System.Drawing.Size(143, 31);
            this.searchCutomerBTN.TabIndex = 6;
            this.searchCutomerBTN.Text = "Search Customer";
            this.searchCutomerBTN.UseVisualStyleBackColor = true;
            this.searchCutomerBTN.Click += new System.EventHandler(this.searchCutomerBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(242, 65);
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
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Customer";
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(519, 73);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 15);
            this.nullNameLbl.TabIndex = 8;
            // 
            // customerInfoDisplay
            // 
            this.customerInfoDisplay.AutoSize = true;
            this.customerInfoDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerInfoDisplay.Location = new System.Drawing.Point(147, 122);
            this.customerInfoDisplay.Name = "customerInfoDisplay";
            this.customerInfoDisplay.Size = new System.Drawing.Size(13, 21);
            this.customerInfoDisplay.TabIndex = 9;
            this.customerInfoDisplay.Text = ".";
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerInfoDisplay);
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchCutomerBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchCustomer";
            this.Size = new System.Drawing.Size(733, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button searchCutomerBTN;
        private TextBox textBox1;
        private Label label1;
        private Label nullNameLbl;
        private Label customerInfoDisplay;
    }
}
