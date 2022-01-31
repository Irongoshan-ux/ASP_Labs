using System.Web;
using System.Web.UI;

namespace ASP_Lab5
{
    public static class MasterPageManager
    {
        public static void ChangeMasterPage(HttpRequest request,
                                            Page page)
        {
            if (request["masterPage1"] != null)
            {
                page.MasterPageFile = "~/Site1.Master";
            }
            else if (request["masterPage2"] != null)
            {
                page.MasterPageFile = "~/Site2.Master";
            }
        }
    }
}