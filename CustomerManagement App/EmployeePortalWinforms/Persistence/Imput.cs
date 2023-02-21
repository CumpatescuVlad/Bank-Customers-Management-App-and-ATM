namespace EmployeePortalWinforms.Persistence
{
    internal class Imput
    {
        public static void NullImput(TextBox textBox, Label errorLbl, string message)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorLbl.Text = message;

            }
        }
    }
}
