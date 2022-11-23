namespace ATM
{
    partial class StandByMenu
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.creditCardNumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(248, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Card\r\nIntroducetiCardul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterBtn.Location = new System.Drawing.Point(291, 231);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(103, 38);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "ENTER";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // creditCardNumberBox
            // 
            this.creditCardNumberBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditCardNumberBox.Location = new System.Drawing.Point(200, 159);
            this.creditCardNumberBox.Name = "creditCardNumberBox";
            this.creditCardNumberBox.Size = new System.Drawing.Size(282, 29);
            this.creditCardNumberBox.TabIndex = 3;
            // 
            // StandByMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creditCardNumberBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.label1);
            this.Name = "StandByMenu";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button enterBtn;
        private TextBox creditCardNumberBox;
    }
}
