using System;

namespace EmployeeInterface
{
    public class GenerateSecurityElements
    {
        private Random random = new Random();

        public string GenerateElement(string elementToGenerate)
        {
            string securityElement;

            switch (elementToGenerate)
            {
                case "IBAN":
                    securityElement = $"RO{random.Next(40, 70)}BNRC{random.Next(2000, 4000)}{random.Next(6000, 8000)}{random.Next(1000, 3000)}000{random.Next(1, 9)}";
                    break;
                case "CardNumber":
                    securityElement = $"{random.Next(1000, 2000)}{random.Next(3000, 4000)}{random.Next(5000, 6000)}{random.Next(6000, 8000)}";
                    break;
                case "AccountNumber":
                    securityElement = $"#{random.Next(50, 80)}{random.Next(30, 60)}{random.Next(10, 70)}";
                    break;
                case "Password":
                    securityElement = $"{random.Next(2000, 4000)}{random.Next(6000, 8000)}";
                    break;
                case "CVVCode":
                    securityElement = $"{random.Next(100, 2000)}";
                    break;
                case "CardPIN":
                    securityElement = $"{random.Next(5000, 9000)}";
                    break;
                case "AppPin":
                    securityElement = $"{random.Next(1000, 5000)}";
                    break;
                default:
                    securityElement = null;
                    break;
            }
 
            return securityElement;
        }

    }
}
