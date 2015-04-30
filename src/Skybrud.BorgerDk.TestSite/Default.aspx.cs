using System;

namespace Skybrud.BorgerDk.TestSite {

    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            BorgerDkService service = new BorgerDkService(BorgerDkEndpoint.Default, BorgerDkMunicipality.SlagelseKommune);

            var id = service.GetArticleIdFromUrl("https://www.borger.dk/Sider/Drikkevand-og-vandforbrug.aspx");

            var art = service.GetArticleFromId(id);

            Response.ContentType = "text/xml";
            Response.Write(art.ToXElement(BorgerDkMunicipality.SlagelseKommune.Code, 1400));
            Response.End();

        }

    }

}