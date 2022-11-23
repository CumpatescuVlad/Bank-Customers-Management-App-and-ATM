namespace ATM
{
    partial class AnotherTransaction
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
            this.daBtn = new System.Windows.Forms.Button();
            this.nuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doriti sa efectuati alta tranzactie?";
            // 
            // daBtn
            // 
            this.daBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daBtn.Location = new System.Drawing.Point(12, 393);
            this.daBtn.Name = "daBtn";
            this.daBtn.Size = new System.Drawing.Size(93, 37);
            this.daBtn.TabIndex = 1;
            this.daBtn.Text = "DA";
            this.daBtn.UseVisualStyleBackColor = true;
            this.daBtn.Click += new System.EventHandler(this.daBtn_Click);
            // 
            // nuBtn
            // 
            this.nuBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nuBtn.Location = new System.Drawing.Point(578, 393);
            this.nuBtn.Name = "nuBtn";
            this.nuBtn.Size = new System.Drawing.Size(93, 37);
            this.nuBtn.TabIndex = 2;
            this.nuBtn.Text = "NU";
            this.nuBtn.UseVisualStyleBackColor = true;
            this.nuBtn.Click += new System.EventHandler(this.nuBtn_Click);
            // 
            // AnotherTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nuBtn);
            this.Controls.Add(this.daBtn);
            this.Controls.Add(this.label1);
            this.Name = "AnotherTransaction";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button daBtn;
        private Button nuBtn;
    }
}
