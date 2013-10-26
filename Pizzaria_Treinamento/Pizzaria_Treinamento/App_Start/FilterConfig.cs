using System.Web;
using System.Web.Mvc;

namespace Pizzaria_Treinamento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}