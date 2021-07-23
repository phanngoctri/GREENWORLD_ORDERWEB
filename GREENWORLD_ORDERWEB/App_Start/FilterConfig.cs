using System.Web;
using System.Web.Mvc;

namespace GREENWORLD_ORDERWEB
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
