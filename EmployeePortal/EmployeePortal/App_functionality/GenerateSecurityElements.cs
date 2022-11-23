using System;

namespace EmployeeInterface
{
    public class GenerateSecurityElements
    {
        private Random random = new Random();

        public string GenerateAccountIBAN() => $@"RO{random.Next(40, 70)}BNRC{random.Next(2000, 4000)}{random.Next(6000, 8000)}{random.Next(1000, 3000)}000{random.Next(1, 9)}";

        public string GenerateCardNumber() => $"{random.Next(1000, 2000)}{random.Next(3000, 4000)}{random.Next(5000, 6000)}{random.Next(6000, 8000)}";

        public string GenerateAccountNumber() => $"#{random.Next(50, 80)}{random.Next(30, 60)}{random.Next(10, 70)}";

        public string GeneratePassword() => $"{random.Next(2000, 4000)}{random.Next(6000, 8000)}";

        public string GenerateCVVCode() => $"{random.Next(100, 2000)}";

        public string GenerateCardPIN() => $"{random.Next(5000, 9000)}";

        public string GenerateAppPIN() => $"{random.Next(1000, 5000)}";

    }
}
