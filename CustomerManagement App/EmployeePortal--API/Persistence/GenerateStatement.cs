using EmployeePortal__API.BusinessLogic.Modeles;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Net;

namespace EmployeePortal__API.Persistence
{
    public class GenerateStatement : IGenerateStatement
    {
        private readonly ILogger<GenerateStatement> _logger;

        public GenerateStatement(ILogger<GenerateStatement> logger)
        {
            _logger = logger;
        }

        public HttpStatusCode GenerateWordStatement(StatementModel statementModel, string content)
        {
            FileStream wordOutputFile = new(Path.GetFullPath(@$"{Environment.CurrentDirectory}\Statements\WordStatements\Statement.doc"), FileMode.Create, FileAccess.ReadWrite);
            var statement = new WordDocument();
            IWSection contentParagraph = statement.AddSection();
            IWParagraph title = contentParagraph.AddParagraph();
            IWParagraph leftColum = contentParagraph.AddParagraph();
            leftColum.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
            IWParagraph footerParaghraph = contentParagraph.AddParagraph();
            title.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            WParagraphStyle? style = statement.Styles.FindByName("Normal") as WParagraphStyle;
            style.CharacterFormat.FontName = "Arial";
            style.CharacterFormat.FontSize = 10;
            style.CharacterFormat.Bold = true;
            title.ApplyStyle("Normal");

            title.AppendText(StatementHeader());
            leftColum.AppendText(StatementBody(statementModel));
            leftColum.AppendText(content);
            footerParaghraph.AppendText(StatementFooter());

            try
            {
                statement.Save(wordOutputFile, FormatType.Doc);
                statement.Close();
                wordOutputFile.Close();
                wordOutputFile.Dispose();
                statement.Dispose();

                return HttpStatusCode.Created;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                _logger.LogError(exception.GetType().ToString());
                _logger.LogError(exception.StackTrace);

                return HttpStatusCode.InternalServerError;
            }

        }

        private static string StatementHeader()
        {
            Random _random = new();
            string header = "\n\n\n";
            header += $"EXTRAS DE CONT NR.{_random.Next(1, 10)} din data de  {DateTime.Now}\n pe perioada: {DateTime.UtcNow} - {DateTime.Now.AddDays(3)}\n\n\n\n";
            return header;

        }

        private static string StatementBody(StatementModel statementModel)
        {
            string body = "\n";
            body += $"IBAN:{statementModel.AccountIBAN}\nProduse Valuta:RON\nTitular:{statementModel.CustomerName} \tCIC:{4563523}\tCNP/CUI:{3452353673}\nTip Produs:Cont curent {statementModel.AccountName}\n";
            body += $"Total tranzactii finalizate pana la {DateTime.Now}";
            body += "\n\n\n";
            return body;
        }

        private static string StatementFooter()
        {
            string footer = "\n\n\n";
            footer += "PREZENTUL DOCUMENT ESTE ELIBERAT DE O BANCA  SI ARE VALOARE DE ORIGINAL FIIND VALABIL   FARA SEMNATURA SI STAMPILA.\n";
            footer += "Soldul disponibil al zilei bancare inscris pe extrasul de cont reflecta situatia sumelor inregistrate  in contul curent in momentul editarii extrasului de cont, in functie de obligatiile de plataale  titularului de cont initiate sau evidentiate pana la momentul editarii extrasului de cont.";
            return footer;

        }



        #region CommentedStatement
        //FileStream wordOutputFile = new(Path.GetFullPath(@$"{Environment.CurrentDirectory}\Statements\WordStatements\Statement.doc"), FileMode.Create, FileAccess.ReadWrite);


        //var statement = new WordDocument();
        //IWSection content = statement.AddSection();
        //IWParagraph title = content.AddParagraph();
        //IWParagraph leftColum = content.AddParagraph();
        //IWParagraph footer = content.AddParagraph();


        //title.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
        //    WParagraphStyle? style = statement.Styles.FindByName("Normal") as WParagraphStyle;
        //style.CharacterFormat.FontName = "Arial";
        //    style.CharacterFormat.FontSize = 10;
        //    style.CharacterFormat.Bold = true;
        //    title.ApplyStyle("Normal");

        //    title.AppendText($"\n\n\n");

        //    title.AppendText($"EXTRAS DE CONT NR.{random.Next(1, 10)} din data de  {DateTime.Now}\n pe perioada: {DateTime.UtcNow} - {DateTime.Now.AddDays(3)}\n\n\n\n");

        //    leftColum.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;

        //    leftColum.AppendText($"IBAN:{statementModel.AccountIBAN}\nProduse Valuta:RON\nTitular:{statementModel.CustomerName} \tCIC:{4563523}\tCNP/CUI:{3452353673}\nTip Produs:Cont curent {statementModel.CurrentAccount}\n");

        //    leftColum.AppendText($"Total tranzactii finalizate pana la {DateTime.Now}\n\n\n{incomeTransactions}\n{outcomeTransactions}\n\n\n");

        //    footer.AppendText("PREZENTUL DOCUMENT ESTE ELIBERAT DE O BANCA  SI ARE VALOARE DE ORIGINAL FIIND VALABIL   FARA SEMNATURA SI STAMPILA.\n");

        //    footer.AppendText("Soldul disponibil al zilei bancare inscris pe extrasul de cont reflecta situatia sumelor inregistrate  in contul curent in momentul editarii extrasului de cont, in functie de obligatiile de plataale  titularului de cont initiate sau evidentiate pana la momentul editarii extrasului de cont.");

        //    try
        //    {
        //        statement.Save(wordOutputFile, FormatType.Doc);
        //        statement.Close();
        //        wordOutputFile.Close();
        //        wordOutputFile.Dispose();
        //        statement.Dispose();
        //        return HttpStatusCode.Created;
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception.Message);

        //        return HttpStatusCode.InternalServerError;
        //    }
        #endregion


    }
}
