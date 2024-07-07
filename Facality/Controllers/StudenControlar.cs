using Microsoft.AspNetCore.Mvc;

namespace Facality.Controllers
{
	public class StudenControlar : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
