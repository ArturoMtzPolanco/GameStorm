using GameStorm.Models.Domain;
using GameStorm.Servicios.IServices;
using GameStorm.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca82.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServices _usuarioServices;

        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        public IActionResult Index()
        {
            var result = _usuarioServices.ObtenerUsuario();
            return View(result);
        }

        // GET: Crear Usuario
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Crear Usuario
        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioServices.AgregarUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Editar Usuario
        public IActionResult Editar(int PkUsuario)
        {
            var usuario = _usuarioServices.ObtenerPorId(PkUsuario);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        // POST: Editar Usuario
        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioServices.ActualizarUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // POST: Eliminar Usuario
        [HttpPost]
        public IActionResult Eliminar(int PkUsuario)
        {
            _usuarioServices.EliminarUsuario(PkUsuario);
            return RedirectToAction("Index");
        }
    }
}
