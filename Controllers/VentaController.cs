using IntroASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroASP.Controllers
{
	public class VentaController : Controller
	{
		private readonly MiBaseContext _context;

		public VentaController(MiBaseContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var ventas = _context.Venta.ToListAsync();
             
            return View(await ventas);
		}
	}
}
