namespace EmployeePortal
{
    partial class DeleteCustomerTab
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.customerDeleted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(417, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of The Customer";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerName.Location = new System.Drawing.Point(328, 128);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(337, 26);
            this.customerName.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(424, 228);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 32);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete Customer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // customerDeleted
            // 
            this.customerDeleted.AutoSize = true;
            this.customerDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerDeleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customerDeleted.Location = new System.Drawing.Point(421, 94);
            this.customerDeleted.Name = "customerDeleted";
            this.customerDeleted.Size = new System.Drawing.Size(0, 17);
            this.customerDeleted.TabIndex = 3;
            // 
            // DeleteCustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerDeleted);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCustomerTab";
            this.Size = new System.Drawing.Size(1065, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label customerDeleted;
    }
}
