namespace EmployeePortal.UIComponents.CreditCardUI
{
    partial class CreateCreditCardTab
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
            this.createCreditCard = new System.Windows.Forms.Button();
            this.IBANBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.succesMsg = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createCreditCard
            // 
            this.createCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createCreditCard.Location = new System.Drawing.Point(422, 254);
            this.createCreditCard.Name = "createCreditCard";
            this.createCreditCard.Size = new System.Drawing.Size(153, 38);
            this.createCreditCard.TabIndex = 2;
            this.createCreditCard.Text = "CREATE";
            this.createCreditCard.UseVisualStyleBackColor = true;
            this.createCreditCard.Click += new System.EventHandler(this.createCreditCard_Click);
            // 
            // IBANBox
            // 
            this.IBANBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IBANBox.Location = new System.Drawing.Point(388, 187);
            this.IBANBox.Name = "IBANBox";
            this.IBANBox.Size = new System.Drawing.Size(249, 29);
            this.IBANBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(170, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account IBAN";
            // 
            // succesMsg
            // 
            this.succesMsg.AutoSize = true;
            this.succesMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.succesMsg.Location = new System.Drawing.Point(436, 167);
            this.succesMsg.Name = "succesMsg";
            this.succesMsg.Size = new System.Drawing.Size(0, 17);
            this.succesMsg.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameBox.Location = new System.Drawing.Point(388, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 29);
            this.nameBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(170, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name";
            // 
            // CreateCreditCardTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.succesMsg);
            this.Controls.Add(this.IBANBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createCreditCard);
            this.Name = "CreateCreditCardTab";
            this.Size = new System.Drawing.Size(1054, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createCreditCard;
        private System.Windows.Forms.TextBox IBANBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label succesMsg;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}
