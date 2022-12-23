using IntroASP.Models;
using IntroASP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IntroASP.Controllers
{
    public class ProductoController : Controller
    {
        private readonly MiBaseContext _context;

        public ProductoController(MiBaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() 
            => View(await _context.Productos.ToListAsync());

        public IActionResult Create()
        {
            ViewData["Productos"] = new SelectList(_context.Productos, "idProducto", "Descripcion");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoViewModel model)
        {

            if (ModelState.IsValid)
            {
                var producto = new Producto()
                {
                    Descripcion = model.Descripcion,
                    Color = model.Color,
                    Precio = model.Precio
                };
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            
            return View(model);
        }


    }
}
