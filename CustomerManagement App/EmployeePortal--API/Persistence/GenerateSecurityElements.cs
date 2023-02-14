namespace EmployeePortal__API.Persistence
{
    public class GenerateSecurityElements
    {
        public static string GenerateElement(string elementToGenerate)
        {
            var random = new Random();
            string? securityElement = elementToGenerate switch
            {
                "IBAN" => $"RO{random.Next(40, 70)}BNRC{random.Next(2000, 4000)}{random.Next(6000, 8000)}{random.Next(1000, 3000)}000{random.Next(1, 9)}",
                "CardNumber" => $"{random.Next(1000, 2000)}{random.Next(3000, 4000)}{random.Next(5000, 6000)}{random.Next(6000, 8000)}",
                "AccountNumber" => $"#{random.Next(50, 80)}{random.Next(30, 60)}{random.Next(10, 70)}",
                "Password" => $"{random.Next(2000, 4000)}{random.Next(6000, 8000)}",
                "SecurityCode" => $"{random.Next(100, 2000)}",
                "CardPIN" => $"{random.Next(5000, 9000)}",
                "AppPin" => $"{random.Next(1000, 5000)}",
                _ => null,
            };
            return securityElement;
        }

    }
}
