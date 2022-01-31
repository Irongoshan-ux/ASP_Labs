using System.Web;

namespace ASP_Lab5
{
    public static class MasterPageManager
    {
        private const string HeaderName = "MasterPage";
        private const string MasterPage1Name = "~/Site1.Master";
        private const string MasterPage2Name = "~/Site2.Master";

        public static void ChangeMasterPage(HttpRequest request, int page)
        {
            request.Headers.Add(HeaderName, page.ToString());
        }

        public static string GetMasterPage(HttpRequest request)
        {
            switch (request.Headers[HeaderName])
            {
                case MasterPage1Name:
                    return MasterPage1Name;
                case MasterPage2Name: 
                    return MasterPage2Name;
                default:
                    return MasterPage1Name;
            }

        }
    }
}