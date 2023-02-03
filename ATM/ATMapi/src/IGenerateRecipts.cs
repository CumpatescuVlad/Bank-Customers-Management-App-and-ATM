using ATMapi.DTOs;
using ATMapi.Modeles;

namespace ATMapi.src
{
    public interface IGenerateRecipts
    {
        string GenerateDepositRecipt(DepositModel depositModel);
        string GenerateSoldRecipt(SoldDTO soldDTO);
        string GenerateWithdrawRecipt(WithdrawModel withdrawModel);
    }
}