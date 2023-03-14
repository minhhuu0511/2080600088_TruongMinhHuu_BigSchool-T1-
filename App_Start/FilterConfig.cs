using System.Web;
using System.Web.Mvc;

namespace _2080600088_TruongMinhHuu_BigSchool_T1_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
