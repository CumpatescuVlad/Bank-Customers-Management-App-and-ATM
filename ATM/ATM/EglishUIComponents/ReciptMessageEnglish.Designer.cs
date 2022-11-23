namespace ATM
{
    partial class ReciptMessageEnglish
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
            this.NoBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.reciptMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoBtn
            // 
            this.NoBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoBtn.Location = new System.Drawing.Point(581, 368);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(90, 46);
            this.NoBtn.TabIndex = 5;
            this.NoBtn.Text = "NO";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.Location = new System.Drawing.Point(14, 368);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(90, 46);
            this.yesBtn.TabIndex = 4;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // reciptMsg
            // 
            this.reciptMsg.AutoSize = true;
            this.reciptMsg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reciptMsg.Location = new System.Drawing.Point(230, 41);
            this.reciptMsg.Name = "reciptMsg";
            this.reciptMsg.Size = new System.Drawing.Size(212, 25);
            this.reciptMsg.TabIndex = 3;
            this.reciptMsg.Text = "Do you want the recipt?";
            // 
            // ReciptMessageEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.reciptMsg);
            this.Name = "ReciptMessageEnglish";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NoBtn;
        private Button yesBtn;
        private Label reciptMsg;
    }
}
