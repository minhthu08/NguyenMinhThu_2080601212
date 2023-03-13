using System.Web;
using System.Web.Mvc;

namespace NguyenMinhThu_2080601212
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
