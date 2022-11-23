using ATM.App_functionality;

namespace ATM
{
    public partial class ReciptMessageEnglish : UserControl
    {
        Temp temp = new Temp();


        public ReciptMessageEnglish()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {

            switch (temp.ReadFile("TypeOfRecipt.txt"))
            {
                case "SoldRecipt":
                    GenerateSoldReciptEnglish();
                    break;

                case "DepositRecipt":
                    GenerateDepositReciptEnglish();
                    break;

                case "WithdrawRecipt":
                    GenerateWithdrawReciptEnglish();
                    break;

            }

            this.Hide();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public partial class Recipt
        {
            public string ReciptContent { get; set; }
        }
        #region ReciptGeneration
        public void GenerateSoldReciptEnglish()
        {

            List<Recipt> englishReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" },
                new Recipt { ReciptContent = "*******************************\nSold Cash\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "Card Number:456XX XXXX XXXX XXXX\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nAVAILABBLE CASH:  {temp.ReadFile("Amount.txt")}\n" },
                new Recipt { ReciptContent = $"\nTHANK YOU !\n" }
            };
            temp.CreateFile("EnglishSoldRecipt.txt", "");

            foreach (Recipt englishRecipt in englishReciptContent)
            {
                temp.AppendFile("EnglishSoldRecipt.txt", englishRecipt.ReciptContent);

            }

        }
        public void GenerateWithdrawReciptEnglish()
        {
            List<Recipt> englishReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" },
                new Recipt { ReciptContent = "*******************************\nWithdraw Cash\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = $"Card Number:456X XXXX XXXX XXXX\n-----------------------------------------\n{DateTime.Now}\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nAMOUNT:  {temp.ReadFile("WithdrawedAmount.txt")}\n" },
                new Recipt { ReciptContent = $"\nTHANK YOU !\nKEEP THE RECIPT.\n" }
            };
            temp.CreateFile("EnglishWithdrawRecipt.txt", "");

            foreach (Recipt englishRecipt in englishReciptContent)
            {
                temp.AppendFile("EnglishWithdrawRecipt.txt", englishRecipt.ReciptContent);

            }



        }
        public void GenerateDepositReciptEnglish()
        {

            List<Recipt> englishReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" },
                new Recipt { ReciptContent = "*******************************\nDeposit Cash\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = $"IBAN: RO3227520RNCB4235254\n-----------------------------------------\n{DateTime.Now}\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nAMOUNT:  {temp.ReadFile("DepositedAmount.txt")}\n" },
                new Recipt { ReciptContent = $"\nTHANK YOU !\nKEEP THE RECIPT.\n" }
            };
            temp.CreateFile("EnglishDepositRecipt.txt", "");

            foreach (Recipt englishRecipt in englishReciptContent)
            {

                temp.AppendFile("EnglishDepositRecipt.txt", englishRecipt.ReciptContent);

            }

        }
        #endregion

    }
}
