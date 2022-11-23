namespace ATM
{
    partial class LanguageSelection
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.romanianMenu1 = new ATM.RomanianMenu();
            this.englishMenu1 = new ATM.EnglishMenu();
            this.authMsg = new System.Windows.Forms.Label();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.enterBtnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alegeti Limba";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Romana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(541, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "English";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Language";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // romanianMenu1
            // 
            this.romanianMenu1.Location = new System.Drawing.Point(-3, 3);
            this.romanianMenu1.Name = "romanianMenu1";
            this.romanianMenu1.Size = new System.Drawing.Size(684, 455);
            this.romanianMenu1.TabIndex = 5;
            // 
            // englishMenu1
            // 
            this.englishMenu1.Location = new System.Drawing.Point(0, 0);
            this.englishMenu1.Name = "englishMenu1";
            this.englishMenu1.Size = new System.Drawing.Size(684, 455);
            this.englishMenu1.TabIndex = 6;
            // 
            // authMsg
            // 
            this.authMsg.AutoSize = true;
            this.authMsg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authMsg.Location = new System.Drawing.Point(213, 54);
            this.authMsg.Name = "authMsg";
            this.authMsg.Size = new System.Drawing.Size(226, 25);
            this.authMsg.TabIndex = 7;
            this.authMsg.Text = "Authentification Message";
            // 
            // pinBox
            // 
            this.pinBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinBox.Location = new System.Drawing.Point(237, 154);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(178, 32);
            this.pinBox.TabIndex = 8;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterBtn.Location = new System.Drawing.Point(261, 239);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(118, 38);
            this.enterBtn.TabIndex = 9;
            this.enterBtn.Text = "ENTER";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // enterBtnEnglish
            // 
            this.enterBtnEnglish.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterBtnEnglish.Location = new System.Drawing.Point(261, 239);
            this.enterBtnEnglish.Name = "enterBtnEnglish";
            this.enterBtnEnglish.Size = new System.Drawing.Size(118, 38);
            this.enterBtnEnglish.TabIndex = 10;
            this.enterBtnEnglish.Text = "ENTER";
            this.enterBtnEnglish.UseVisualStyleBackColor = true;
            this.enterBtnEnglish.Click += new System.EventHandler(this.enterBtnEnglish_Click);
            // 
            // LanguageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enterBtnEnglish);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.authMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.romanianMenu1);
            this.Controls.Add(this.englishMenu1);
            this.Name = "LanguageSelection";
            this.Size = new System.Drawing.Size(684, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private RomanianMenu romanianMenu1;
        private EnglishMenu englishMenu1;
        private Label authMsg;
        private TextBox pinBox;
        private Button enterBtn;
        private Button enterBtnEnglish;
    }
}
