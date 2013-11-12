using System;

namespace Skybrud.BorgerDk.TestSite {

    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            BorgerDkService service = new BorgerDkService(BorgerDkEndpoint.Default, BorgerDkMunicipality.SlagelseKommune);

            var art = service.GetArticleFromId(556);

            Response.ContentType = "text/xml";
            Response.Write(art.ToXElement(BorgerDkMunicipality.SlagelseKommune.Code, 1400));
            Response.End();

        }

    }

}