using IntroASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroASP.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApiProductoController : ControllerBase
	{
		private readonly MiBaseContext _context;

		public ApiProductoController(MiBaseContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<List<Producto>> Get()
			=> await _context.Productos.ToListAsync();
    }
}
