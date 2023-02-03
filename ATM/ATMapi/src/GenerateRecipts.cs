using ATMapi.DTOs;
using ATMapi.Modeles;

namespace ATMapi.src
{
    public class GenerateRecipts : IGenerateRecipts
    {
        private readonly Random random = new();

        public string GenerateSoldRecipt(SoldDTO soldDTO)
        {
            string soldRecipt = "BANCA ROMANA\nWelcome!\n";
            soldRecipt += $"*******************************\nSold Cash\nTID:        000{random.Next(1000, 9000)}  MID:      {random.Next(100000, 900000)}\n";
            soldRecipt += $"-----------------------------------------\nRecipt NO: {random.Next(10000, 80000)}   Batch Number: {random.Next(100000, 700000)}\n";
            soldRecipt += $"PRN: {random.Next(10000, 60000)}    COD AUTH: {random.Next(100000, 900000)}\n";
            soldRecipt += $"STAN:   {random.Next(1000, 6000)}   RC: 0000{random.Next(1, 9)}\n";
            soldRecipt += $"Account Number:{soldDTO.AccountNumber}\n";
            soldRecipt += "---------------------------------------\n\n---------------------------------------";
            soldRecipt += $"\nAVAILABBLE CASH:  {soldDTO.Ballance}\n";
            soldRecipt += "\nTHANK YOU !\nKEEP THE RECIPT.\n";

            return soldRecipt;
        }

        public string GenerateWithdrawRecipt(WithdrawModel withdrawModel)
        {
            string withdrawRecipt = "BANCA ROMANA\nWelcome!\n";
            withdrawRecipt += $"*******************************\nWithdraw Cash\nTID:        000{random.Next(1000, 9000)}  MID:      {random.Next(100000, 900000)}\n";
            withdrawRecipt += $"Account Number:{withdrawModel.AccountNumber}\n-----------------------------------------\n{DateTime.Now}\n";
            withdrawRecipt += $"-----------------------------------------\nRecipt NO: {random.Next(10000, 80000)}    Batch Number: {random.Next(100000, 700000)}\n";
            withdrawRecipt += $"PRN: {random.Next(10000, 60000)}    COD AUTH: {random.Next(100000, 900000)}\n";
            withdrawRecipt += $"STAN:   {random.Next(1000, 6000)}   RC: 0000{random.Next(1, 9)}\n";
            withdrawRecipt += "---------------------------------------\n\n---------------------------------------";
            withdrawRecipt += $"\nAMOUNT:  {withdrawModel.Amount}\n";
            withdrawRecipt += "\nTHANK YOU !\nKEEP THE RECIPT.\n";

            return withdrawRecipt;
        }

        public string GenerateDepositRecipt(DepositModel depositModel)
        {
            string depositRecipt = "BANCA ROMANA\nWelcome!\n";
            depositRecipt += $"*******************************\nDeposit Cash\nTID:      {random.Next(1000, 9000)}  MID:      {random.Next(100000, 900000)}\n";
            depositRecipt += $"IBAN: {depositModel.AccountIBAN}\n-----------------------------------------\n{DateTime.Now}\n\n";
            depositRecipt += $"-----------------------------------------\nRecipt NO: {random.Next(10000, 80000)}    Batch Number: {random.Next(100000, 700000)}\n";
            depositRecipt += $"{random.Next(10000, 60000)}    COD AUTH: {random.Next(100000, 900000)}\n";
            depositRecipt += $"STAN:  {random.Next(1000, 6000)}   RC: 0000{random.Next(1, 9)}\n";
            depositRecipt += "---------------------------------------\n\n---------------------------------------";
            depositRecipt += $"\nAMOUNT:  {depositModel.Amount}\n";
            depositRecipt += "\nTHANK YOU !\nKEEP THE RECIPT.\n";

            return depositRecipt;
        }

    }
}
