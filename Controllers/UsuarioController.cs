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
            var dataBaseContext = _db.TBUSUARIOS.Include(t => t.PerfilAcesso);
            return View(dataBaseContext.ToList());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null || _db.TBUSUARIOS == null)
            {
                return NotFound();
            }

            var tbusuario = _db.TBUSUARIOS
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
            ViewData["UnidadeId"] = new SelectList(_db.TBUNIDADES, "UnidadeId", "UnidadeDesc");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TBUsuarios usuario)
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
                _db.TBUSUARIOS.Add(usuario);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || _db.TBUSUARIOS == null)
            {
                return NotFound();
            }

            TBUsuarios usuario = _db.TBUSUARIOS.FirstOrDefault(x => x.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["PerfilAcessoId"] = new SelectList(_db.TBPERFILACESSO, "PerfilAcessoId", "PerfilAcessoDesc", usuario.PerfilAcessoId);
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(TBUsuarios usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario != null)
                {
                    usuario.UsuarioAltEm = DateTime.Now;
                    _db.TBUSUARIOS.Update(usuario);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View(usuario);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _db.TBUSUARIOS == null)
            {
                return NotFound();
            }

            var tbusuario = await _db.TBUSUARIOS
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
            if (_db.TBUSUARIOS == null)
            {
                return Problem("Entity set 'DataBaseContext.TBUSUARIO'  is null.");
            }
            var tbusuario = await _db.TBUSUARIOS.FindAsync(id);
            if (tbusuario != null)
            {
                _db.TBUSUARIOS.Remove(tbusuario);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbusuarioExists(int id)
        {
            return (_db.TBUSUARIOS?.Any(e => e.UsuarioId == id)).GetValueOrDefault();
        }
    }
}
