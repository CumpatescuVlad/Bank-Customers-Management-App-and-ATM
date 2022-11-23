namespace ATM
{
    partial class ReciptMessage
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
            this.reciptMsg = new System.Windows.Forms.Label();
            this.daBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reciptMsg
            // 
            this.reciptMsg.AutoSize = true;
            this.reciptMsg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reciptMsg.Location = new System.Drawing.Point(229, 41);
            this.reciptMsg.Name = "reciptMsg";
            this.reciptMsg.Size = new System.Drawing.Size(144, 25);
            this.reciptMsg.TabIndex = 0;
            this.reciptMsg.Text = "Doriti Chitanta?";
            // 
            // daBtn
            // 
            this.daBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daBtn.Location = new System.Drawing.Point(13, 368);
            this.daBtn.Name = "daBtn";
            this.daBtn.Size = new System.Drawing.Size(90, 46);
            this.daBtn.TabIndex = 1;
            this.daBtn.Text = "DA";
            this.daBtn.UseVisualStyleBackColor = true;
            this.daBtn.Click += new System.EventHandler(this.daBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBtn.Location = new System.Drawing.Point(580, 368);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(90, 46);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "NU";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // ReciptMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.daBtn);
            this.Controls.Add(this.reciptMsg);
            this.Name = "ReciptMessage";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label reciptMsg;
        private Button daBtn;
        private Button noBtn;
    }
}
