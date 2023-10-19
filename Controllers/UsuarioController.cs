using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaOnline.Data;
using FichaOnline.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FichaOnline.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DataBaseContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public UsuarioController(DataBaseContext context, UserManager<IdentityUser> userManager)
        {
            _db = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var dataBaseContext = _db.TBUSUARIO.Include(t => t.PerfilAcesso);
            return View(dataBaseContext.ToList());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null || _db.TBUSUARIO == null)
            {
                return NotFound();
            }

            var tbusuario = _db.TBUSUARIO
                .Include(x => x.PerfilAcesso)
                .FirstOrDefault(x => x.UsuarioId == id);

            if (tbusuario == null)
            {
                return NotFound();
            }

            return View(tbusuario);
        }

        public IActionResult Create()
        {
            ViewData["PerfilAcessoId"] = new SelectList(_db.TBPERFILACESSO, "PerfilAcessoId", "PerfilAcessoDesc");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tbusuario usuario)
        {
            //if (!User.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction("Index", "Login");
            //}

            //string user = _userManager.GetUserId(User);
            //int.TryParse(user, out int userId);
            if (ModelState.IsValid)
            {
                usuario.SetSenhaHash();
                usuario.UsuarioIncEm = DateTime.Now;
                //usuario.UsuarioIncPor = userId;
                _db.TBUSUARIO.Add(usuario);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || _db.TBUSUARIO == null)
            {
                return NotFound();
            }

            Tbusuario usuario = _db.TBUSUARIO.FirstOrDefault(x => x.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["PerfilAcessoId"] = new SelectList(_db.TBPERFILACESSO, "PerfilAcessoId", "PerfilAcessoDesc", usuario.PerfilAcessoId);
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Tbusuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario != null)
                {
                    usuario.UsuarioAltEm = DateTime.Now;
                    _db.TBUSUARIO.Update(usuario);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View(usuario);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _db.TBUSUARIO == null)
            {
                return NotFound();
            }

            var tbusuario = await _db.TBUSUARIO
                .Include(t => t.PerfilAcesso)
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (tbusuario == null)
            {
                return NotFound();
            }

            return View(tbusuario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_db.TBUSUARIO == null)
            {
                return Problem("Entity set 'DataBaseContext.TBUSUARIO'  is null.");
            }
            var tbusuario = await _db.TBUSUARIO.FindAsync(id);
            if (tbusuario != null)
            {
                _db.TBUSUARIO.Remove(tbusuario);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbusuarioExists(int id)
        {
            return (_db.TBUSUARIO?.Any(e => e.UsuarioId == id)).GetValueOrDefault();
        }
    }
}
