namespace EmployeePortalWinforms.FunctionsUI
{
    partial class FunctionsIndex
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
            this.regeneratePinCode = new System.Windows.Forms.Button();
            this.statementBtn = new System.Windows.Forms.Button();
            this.indexBTN = new System.Windows.Forms.Button();
            this.pinCodeRegeneration1 = new EmployeePortalWinforms.FunctionsUI.PinCodeRegeneration();
            this.generateStatement1 = new EmployeePortalWinforms.FunctionsUI.GenerateStatement();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Titillium Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Function";
            // 
            // regeneratePinCode
            // 
            this.regeneratePinCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regeneratePinCode.Location = new System.Drawing.Point(157, 153);
            this.regeneratePinCode.Name = "regeneratePinCode";
            this.regeneratePinCode.Size = new System.Drawing.Size(225, 48);
            this.regeneratePinCode.TabIndex = 1;
            this.regeneratePinCode.Text = "Pin Code Regeneration";
            this.regeneratePinCode.UseVisualStyleBackColor = true;
            this.regeneratePinCode.Click += new System.EventHandler(this.regeneratePinCode_Click);
            // 
            // statementBtn
            // 
            this.statementBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statementBtn.Location = new System.Drawing.Point(388, 153);
            this.statementBtn.Name = "statementBtn";
            this.statementBtn.Size = new System.Drawing.Size(225, 48);
            this.statementBtn.TabIndex = 2;
            this.statementBtn.Text = "Generate Statement";
            this.statementBtn.UseVisualStyleBackColor = true;
            this.statementBtn.Click += new System.EventHandler(this.statementBtn_Click);
            // 
            // indexBTN
            // 
            this.indexBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexBTN.Location = new System.Drawing.Point(3, 400);
            this.indexBTN.Name = "indexBTN";
            this.indexBTN.Size = new System.Drawing.Size(129, 41);
            this.indexBTN.TabIndex = 3;
            this.indexBTN.Text = "Functions Index";
            this.indexBTN.UseVisualStyleBackColor = true;
            this.indexBTN.Click += new System.EventHandler(this.indexBTN_Click);
            // 
            // pinCodeRegeneration1
            // 
            this.pinCodeRegeneration1.Location = new System.Drawing.Point(22, 3);
            this.pinCodeRegeneration1.Name = "pinCodeRegeneration1";
            this.pinCodeRegeneration1.Size = new System.Drawing.Size(752, 391);
            this.pinCodeRegeneration1.TabIndex = 4;
            // 
            // generateStatement1
            // 
            this.generateStatement1.Location = new System.Drawing.Point(22, 3);
            this.generateStatement1.Name = "generateStatement1";
            this.generateStatement1.Size = new System.Drawing.Size(752, 391);
            this.generateStatement1.TabIndex = 5;
            // 
            // FunctionsIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.indexBTN);
            this.Controls.Add(this.statementBtn);
            this.Controls.Add(this.regeneratePinCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinCodeRegeneration1);
            this.Controls.Add(this.generateStatement1);
            this.Name = "FunctionsIndex";
            this.Size = new System.Drawing.Size(802, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button regeneratePinCode;
        private Button statementBtn;
        private Button indexBTN;
        private PinCodeRegeneration pinCodeRegeneration1;
        private GenerateStatement generateStatement1;
    }
}
