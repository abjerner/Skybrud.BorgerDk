using System;

namespace Skybrud.BorgerDk.ConsoleApp {
    
    class Program {
        
        private static void Main(string[] args) {

            BorgerDkService service = new BorgerDkService(BorgerDkEndpoint.Default, BorgerDkMunicipality.SlagelseKommune);

            BorgerDkArticle art = service.GetArticleFromId(861);

            Console.WriteLine(art.ToXElement(BorgerDkMunicipality.SlagelseKommune.Code, 1400));

        }

    }

}
