namespace ATM
{
    partial class AnotherTransactionsEnglish
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
            this.NOBTN = new System.Windows.Forms.Button();
            this.YEsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NOBTN
            // 
            this.NOBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NOBTN.Location = new System.Drawing.Point(579, 384);
            this.NOBTN.Name = "NOBTN";
            this.NOBTN.Size = new System.Drawing.Size(93, 37);
            this.NOBTN.TabIndex = 5;
            this.NOBTN.Text = "NO";
            this.NOBTN.UseVisualStyleBackColor = true;
            this.NOBTN.Click += new System.EventHandler(this.NOBTN_Click);
            // 
            // YEsBtn
            // 
            this.YEsBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YEsBtn.Location = new System.Drawing.Point(13, 384);
            this.YEsBtn.Name = "YEsBtn";
            this.YEsBtn.Size = new System.Drawing.Size(93, 37);
            this.YEsBtn.TabIndex = 4;
            this.YEsBtn.Text = "YES";
            this.YEsBtn.UseVisualStyleBackColor = true;
            this.YEsBtn.Click += new System.EventHandler(this.YEsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to make another transaction?";
            // 
            // AnotherTransactionsEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NOBTN);
            this.Controls.Add(this.YEsBtn);
            this.Controls.Add(this.label1);
            this.Name = "AnotherTransactionsEnglish";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NOBTN;
        private Button YEsBtn;
        private Label label1;
    }
}
