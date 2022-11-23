namespace ATM
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.standByMenu1 = new ATM.StandByMenu();
            this.languageSelection1 = new ATM.LanguageSelection();
            this.SuspendLayout();
            // 
            // standByMenu1
            // 
            this.standByMenu1.Location = new System.Drawing.Point(1, 2);
            this.standByMenu1.Name = "standByMenu1";
            this.standByMenu1.Size = new System.Drawing.Size(684, 455);
            this.standByMenu1.TabIndex = 0;
            // 
            // languageSelection1
            // 
            this.languageSelection1.Location = new System.Drawing.Point(1, 2);
            this.languageSelection1.Name = "languageSelection1";
            this.languageSelection1.Size = new System.Drawing.Size(684, 455);
            this.languageSelection1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 454);
            this.ControlBox = false;
            this.Controls.Add(this.languageSelection1);
            this.Controls.Add(this.standByMenu1);
            this.Name = "Form1";
            this.Text = "ATM";
            this.ResumeLayout(false);

        }

        #endregion

        private StandByMenu standByMenu1;
        private LanguageSelection languageSelection1;
    }
}