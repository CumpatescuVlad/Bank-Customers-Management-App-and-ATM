using System.Windows.Forms;
namespace EmployeeInterface
{
    public class Credentials
    {

        public bool isMatching(TextBox fullNameBox, TextBox passwordBox)
        {

            bool nameIsMatching = fullNameBox.Text == Temp.ReadFile("EmployeeID.txt");

            bool passwordIsmatching = passwordBox.Text == Temp.ReadFile("EmployeePassword.txt");

            bool credentialsAreCorrect = nameIsMatching is true && passwordIsmatching is true;

            return credentialsAreCorrect;
        }


    }
}
