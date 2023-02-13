using System.Windows.Forms;

namespace EmployeePortal.src
{
    public class Imput
    {
        public static bool IsNumber(TextBox imputBox)
        {
            bool isNumber = imputBox.Text.Contains("1") || imputBox.Text.Contains("2") || imputBox.Text.Contains("3") || imputBox.Text.Contains("4")
                || imputBox.Text.Contains("5") || imputBox.Text.Contains("6") || imputBox.Text.Contains("7") || imputBox.Text.Contains("8")
                || imputBox.Text.Contains("9") || imputBox.Text.Contains("0");

            return isNumber;
        }
    }
}
