namespace ATMapi.BusinessLogic.DTOs
{
    public class PinDTO
    {
        public PinDTO(int aTMPin)
        {
            ATMPin = aTMPin;
        }

        public int ATMPin { get; set; }
    }
}
