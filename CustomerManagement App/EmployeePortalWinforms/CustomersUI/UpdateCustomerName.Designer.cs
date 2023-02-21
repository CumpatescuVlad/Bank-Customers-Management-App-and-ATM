namespace EmployeePortalWinforms.CustomersUI
{
    partial class UpdateCustomerName
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateCustomerNameBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.succesNameUpdatedLbl = new System.Windows.Forms.Label();
            this.nullNameLbl = new System.Windows.Forms.Label();
            this.nullNewNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(305, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 29);
            this.textBox1.TabIndex = 1;
            // 
            // updateCustomerNameBtn
            // 
            this.updateCustomerNameBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCustomerNameBtn.Location = new System.Drawing.Point(352, 208);
            this.updateCustomerNameBtn.Name = "updateCustomerNameBtn";
            this.updateCustomerNameBtn.Size = new System.Drawing.Size(194, 30);
            this.updateCustomerNameBtn.TabIndex = 2;
            this.updateCustomerNameBtn.Text = "Update Customer Name";
            this.updateCustomerNameBtn.UseVisualStyleBackColor = true;
            this.updateCustomerNameBtn.Click += new System.EventHandler(this.updateCustomerNameBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Current Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter New Customer Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(305, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 29);
            this.textBox2.TabIndex = 4;
            // 
            // succesNameUpdatedLbl
            // 
            this.succesNameUpdatedLbl.AutoSize = true;
            this.succesNameUpdatedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.succesNameUpdatedLbl.Location = new System.Drawing.Point(333, 174);
            this.succesNameUpdatedLbl.Name = "succesNameUpdatedLbl";
            this.succesNameUpdatedLbl.Size = new System.Drawing.Size(0, 15);
            this.succesNameUpdatedLbl.TabIndex = 6;
            // 
            // nullNameLbl
            // 
            this.nullNameLbl.AutoSize = true;
            this.nullNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNameLbl.Location = new System.Drawing.Point(599, 78);
            this.nullNameLbl.Name = "nullNameLbl";
            this.nullNameLbl.Size = new System.Drawing.Size(0, 19);
            this.nullNameLbl.TabIndex = 7;
            // 
            // nullNewNameLbl
            // 
            this.nullNewNameLbl.AutoSize = true;
            this.nullNewNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nullNewNameLbl.ForeColor = System.Drawing.Color.Red;
            this.nullNewNameLbl.Location = new System.Drawing.Point(599, 134);
            this.nullNewNameLbl.Name = "nullNewNameLbl";
            this.nullNewNameLbl.Size = new System.Drawing.Size(0, 19);
            this.nullNewNameLbl.TabIndex = 8;
            // 
            // UpdateCustomerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nullNewNameLbl);
            this.Controls.Add(this.nullNameLbl);
            this.Controls.Add(this.succesNameUpdatedLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateCustomerNameBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomerName";
            this.Size = new System.Drawing.Size(761, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button updateCustomerNameBtn;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label succesNameUpdatedLbl;
        private Label nullNameLbl;
        private Label nullNewNameLbl;
    }
}
