using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Windows.Forms;
using HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment;


namespace EmployeePortal
{
    public partial class GenerateStatementTab : UserControl
    {

        private readonly Random random = new Random();
        dynamic date = DateTime.Now.Date;
        public GenerateStatementTab()
        {
            InitializeComponent();


        }
        #region TextBoxes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GenerateStatementTab_Load(object sender, EventArgs e)
        {

        }
        #endregion



        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(Temp.ReadFile("AccountName.txt"));

        }

        private void CreateStatement(string order)
        {
            #region ParagraphSettings
            WordDocument statement = new WordDocument();
            IWSection content = statement.AddSection();
            IWParagraph title = content.AddParagraph();
            IWParagraph leftColum = content.AddParagraph();
            IWParagraph footer = content.AddParagraph();


            title.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            WParagraphStyle style = statement.Styles.FindByName("Normal") as WParagraphStyle;
            style.CharacterFormat.FontName = "Arial";
            style.CharacterFormat.FontSize = 12;
            style.CharacterFormat.Bold = true;
            title.ApplyStyle("Normal");

            #endregion


            title.AppendText($"\n\n\n\n\n\n");

            title.AppendText($"EXTRAS DE CONT NR.{stateNoBox.Text} din data de  {date}\npe perioada: {textBox1.Text} - {textBox2.Text}\n");

            leftColum.AppendText("\n\n\n\n");

            leftColum.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;

            leftColum.AppendText($"NR. Cont:{Temp.ReadFile("AccountNumber.txt")}\nIBAN:{Temp.ReadFile("AccountIBAN.txt")}\nProduse Valuta:{currencyBox.Text}\nTitular:{Temp.ReadFile("CustomerFullName.txt")}");

            leftColum.AppendText($"\tCIC:{4563523}\tCNP/CUI:{3452353673}\nTip Produs:Cont curent {Temp.ReadFile("AccountName.txt")}\n");

            leftColum.AppendText($"Total tranzactii finalizate pe perioada:\n");

            leftColum.AppendText(order);

            leftColum.AppendText($"\nTotal:{Temp.ReadFile("Total.txt")}\n");

            leftColum.AppendText($"Sold Disponibil  la :\t\t\t{date}\t\t\t{random.Next(2000, 8000)}\n");

            footer.AppendText("\n\n\n\n");

            footer.AppendText("PREZENTUL DOCUMENT ESTE ELIBERAT DE O BANCA  SI ARE VALOARE DE ORIGINAL FIIND VALABIL   FARA SEMNATURA SI STAMPILA.\n");

            footer.AppendText("Soldul disponibil al zilei bancare inscris pe extrasul de cont reflecta situatia sumelor inregistrate  in contul curent in momentul editarii extrasului de cont, in functie de obligatiile de plataale  titularului de cont initiate sau evidentiate pana la momentul editarii extrasului de cont.");

            statement.Save("StatementFinal.docx", FormatType.Docx);

            statement.Close();
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Value")
            {
                CreateStatement(Temp.ReadFile("TransactionsOrderedByAmount Desc.txt"));
            }
            else if (comboBox1.Text == "Date")
            {

                CreateStatement(Temp.ReadFile("TransactionsOrderedByDate Asc.txt"));
            }


            statementGenerated.Text = "Statement Succesfully Generated";
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Value")
            {
                Temp.CreateFile("Statement.csv", $"{Temp.ReadFile("TransactionsOrderedByAmount Desc.txt")}\n");
            }
            else if (comboBox1.Text == "Date")
            {
                Temp.CreateFile("Statement.csv", $"{Temp.ReadFile("TransactionsOrderedByDate Asc.txt")}\n");
            }

            statementGenerated.Text = "Statement Succesfully Generated";
            this.Hide();
        }


    }
}
