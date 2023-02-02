namespace EmployeePortal
{
    partial class ManageCustomerData
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
            this.fullNamebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.updateSuccededAcName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nullValueError = new System.Windows.Forms.Label();
            this.updateDataPanel1 = new EmployeePortal.UpdateDataPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // fullNamebox
            // 
            this.fullNamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fullNamebox.Location = new System.Drawing.Point(423, 181);
            this.fullNamebox.Name = "fullNamebox";
            this.fullNamebox.Size = new System.Drawing.Size(217, 29);
            this.fullNamebox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(456, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1048, 101);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // updateSuccededAcName
            // 
            this.updateSuccededAcName.AutoSize = true;
            this.updateSuccededAcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateSuccededAcName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateSuccededAcName.Location = new System.Drawing.Point(742, 415);
            this.updateSuccededAcName.Name = "updateSuccededAcName";
            this.updateSuccededAcName.Size = new System.Drawing.Size(0, 20);
            this.updateSuccededAcName.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(110, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(258, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "PhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(258, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Customer Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(855, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 36);
            this.button2.TabIndex = 55;
            this.button2.Text = "Update Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nullValueError
            // 
            this.nullValueError.AutoSize = true;
            this.nullValueError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nullValueError.ForeColor = System.Drawing.Color.Red;
            this.nullValueError.Location = new System.Drawing.Point(433, 307);
            this.nullValueError.Name = "nullValueError";
            this.nullValueError.Size = new System.Drawing.Size(0, 20);
            this.nullValueError.TabIndex = 57;
            // 
            // updateDataPanel1
            // 
            this.updateDataPanel1.Location = new System.Drawing.Point(224, 0);
            this.updateDataPanel1.Name = "updateDataPanel1";
            this.updateDataPanel1.Size = new System.Drawing.Size(560, 304);
            this.updateDataPanel1.TabIndex = 56;
            // 
            // ManageCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nullValueError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateSuccededAcName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullNamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateDataPanel1);
            this.Name = "ManageCustomerData";
            this.Size = new System.Drawing.Size(1054, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNamebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label updateSuccededAcName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private UpdateDataPanel updateDataPanel1;
        private System.Windows.Forms.Label nullValueError;
    }
}
