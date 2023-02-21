namespace EmployeePortalWinforms.FunctionsUI
{
    partial class GenerateStatement
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
            this.generateStatementBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.nullAccountNameLbl = new System.Windows.Forms.Label();
            this.nullAccountIBANLbl = new System.Windows.Forms.Label();
            this.succesGenerated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Statement";
            // 
            // generateStatementBTN
            // 
            this.generateStatementBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateStatementBTN.Location = new System.Drawing.Point(353, 292);
            this.generateStatementBTN.Name = "generateStatementBTN";
            this.generateStatementBTN.Size = new System.Drawing.Size(164, 34);
            this.generateStatementBTN.TabIndex = 1;
            this.generateStatementBTN.Text = "GenerateStatement";
            this.generateStatementBTN.UseVisualStyleBackColor = true;
            this.generateStatementBTN.Click += new System.EventHandler(this.generateStatementBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(317, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account IBAN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(317, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 23);
            this.textBox3.TabIndex = 6;
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(554, 83);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 19);
            this.nullNameLbl.TabIndex = 8;
            // 
            // nullAccountNameLbl
            // 
            this.nullAccountNameLbl.AutoSize = true;
            this.nullAccountNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullAccountNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullAccountNameLbl.Location = new System.Drawing.Point(554, 151);
            this.nullAccountNameLbl.Name = "nullAccountNameLbl";
            this.nullAccountNameLbl.Size = new System.Drawing.Size(0, 19);
            this.nullAccountNameLbl.TabIndex = 9;
            // 
            // nullAccountIBANLbl
            // 
            this.nullAccountIBANLbl.AutoSize = true;
            this.nullAccountIBANLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullAccountIBANLbl.ForeColor = System.Drawing.Color.Red;
            this.nullAccountIBANLbl.Location = new System.Drawing.Point(554, 223);
            this.nullAccountIBANLbl.Name = "nullAccountIBANLbl";
            this.nullAccountIBANLbl.Size = new System.Drawing.Size(0, 19);
            this.nullAccountIBANLbl.TabIndex = 10;
            // 
            // succesGenerated
            // 
            this.succesGenerated.AutoSize = true;
            this.succesGenerated.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.succesGenerated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.succesGenerated.Location = new System.Drawing.Point(342, 261);
            this.succesGenerated.Name = "succesGenerated";
            this.succesGenerated.Size = new System.Drawing.Size(0, 19);
            this.succesGenerated.TabIndex = 11;
            // 
            // GenerateStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.succesGenerated);
            this.Controls.Add(this.nullAccountIBANLbl);
            this.Controls.Add(this.nullAccountNameLbl);
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generateStatementBTN);
            this.Controls.Add(this.label1);
            this.Name = "GenerateStatement";
            this.Size = new System.Drawing.Size(752, 411);
            this.Load += new System.EventHandler(this.GenerateStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button generateStatementBTN;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label nullNameLbl;
        private Label nullAccountNameLbl;
        private Label nullAccountIBANLbl;
        private Label succesGenerated;
    }
}
