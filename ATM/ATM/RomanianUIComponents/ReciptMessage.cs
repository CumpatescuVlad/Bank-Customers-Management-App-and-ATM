using ATM.App_functionality;

namespace ATM
{
    public partial class ReciptMessage : UserControl
    {
        Temp temp = new Temp();

        public ReciptMessage()
        {
            InitializeComponent();
        }

        private void daBtn_Click(object sender, EventArgs e)
        {
            switch (temp.ReadFile("TypeOfRecipt.txt"))
            {
                case "SoldRecipt":
                    GenerateSoldRecipt();
                    break;

                case "DepositRecipt":
                    GenerateDepositRecipt();
                    break;

                case "WithdrawRecipt":
                    GenerateWithdrawRecipt();
                    break;
            }

            this.Hide();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        public partial class Recipt
        {
            public string ReciptContent { get; set; }
        }

        #region ReciptGeneration
        public void GenerateSoldRecipt()
        {

            List<Recipt> romanianReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" },
                new Recipt { ReciptContent = "*******************************\nInterogare Sold\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "Numar Card:456XX XXXX XXXX XXXX\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nAVETI DISPONIBIL:  {temp.ReadFile("Amount.txt")}\n" },
                new Recipt { ReciptContent = $"\nVA MULTUMIM!\n" }
            };
            temp.CreateFile("SoldRecipt.txt", "");

            foreach (Recipt romanianRecipt in romanianReciptContent)
            {
                temp.AppendFile("SoldRecipt.txt", romanianRecipt.ReciptContent);

            }



        }

        public void GenerateWithdrawRecipt()
        {
            List<Recipt> romanianReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" },
                new Recipt { ReciptContent = "*******************************\nRetragere Numerar\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = $"Numar Card:456X XXXX XXXX XXXX\n-----------------------------------------\n{DateTime.Now}\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nSUMA:  {temp.ReadFile("WithdrawedAmount.txt")}\n" },
                new Recipt { ReciptContent = $"\nVA MULTUMIM!\nPASTRATI CHITANTA.\n" }
            };
            temp.CreateFile("WithdrawRecipt.txt", "");

            foreach (Recipt romanianRecipt in romanianReciptContent)
            {
                temp.AppendFile("WithdrawRecipt.txt", romanianRecipt.ReciptContent);

            }


        }
        public void GenerateDepositRecipt()
        {
            List<Recipt> romanianReciptContent = new()
            {
                new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" },
                new Recipt { ReciptContent = "*******************************\nDepunere Numerar\nTID:        0008129  MID:      8325823\n" },
                new Recipt { ReciptContent = $"IBAN: RO3227520RNCB4235254\n-----------------------------------------\n{DateTime.Now}\n" },
                new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" },
                new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" },
                new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" },
                new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" },
                new Recipt { ReciptContent = $"\nSUMA:  {temp.ReadFile("DepositedAmount.txt")}\n" },
                new Recipt { ReciptContent = $"\nVA MULTUMIM!\nPASTRATI CHITANTA.\n" }
            };
            temp.CreateFile("DepositRecipt.txt", "");

            foreach (Recipt romanianRecipt in romanianReciptContent)
            {
                temp.AppendFile("DepositRecipt.txt", romanianRecipt.ReciptContent);

            }


        }
        #endregion



    }
}
