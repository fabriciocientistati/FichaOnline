using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaOnline.Data;
using FichaOnline.Models;

namespace FichaOnline.Controllers
{
    public class PerfilController : Controller
    {
        private readonly DataBaseContext _context;

        public PerfilController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Perfil
        public async Task<IActionResult> Index()
        {
              return _context.TBPERFILACESSO != null ? 
                          View(await _context.TBPERFILACESSO.ToListAsync()) :
                          Problem("Entity set 'DataBaseContext.TBPERFILACESSO'  is null.");
        }

        // GET: Perfil/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBPERFILACESSO == null)
            {
                return NotFound();
            }

            var tbperfilacesso = await _context.TBPERFILACESSO
                .FirstOrDefaultAsync(m => m.PerfilAcessoId == id);
            if (tbperfilacesso == null)
            {
                return NotFound();
            }

            return View(tbperfilacesso);
        }

        // GET: Perfil/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Perfil/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerfilAcessoId,PerfilAcessoDesc,PerfilAcessoNivel,PerfilAcessoIncPor,PerfilAcessoIncEm,PerfilAcessoAltPor,PerfilAcessoAltEm")] TBPerfilaAcesso tbperfilacesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbperfilacesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbperfilacesso);
        }

        // GET: Perfil/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBPERFILACESSO == null)
            {
                return NotFound();
            }

            var tbperfilacesso = await _context.TBPERFILACESSO.FindAsync(id);
            if (tbperfilacesso == null)
            {
                return NotFound();
            }
            return View(tbperfilacesso);
        }

        // POST: Perfil/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PerfilAcessoId,PerfilAcessoDesc,PerfilAcessoNivel,PerfilAcessoIncPor,PerfilAcessoIncEm,PerfilAcessoAltPor,PerfilAcessoAltEm")] TBPerfilaAcesso tbperfilacesso)
        {
            if (id != tbperfilacesso.PerfilAcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbperfilacesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbperfilacessoExists(tbperfilacesso.PerfilAcessoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tbperfilacesso);
        }

        // GET: Perfil/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBPERFILACESSO == null)
            {
                return NotFound();
            }

            var tbperfilacesso = await _context.TBPERFILACESSO
                .FirstOrDefaultAsync(m => m.PerfilAcessoId == id);
            if (tbperfilacesso == null)
            {
                return NotFound();
            }

            return View(tbperfilacesso);
        }

        // POST: Perfil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBPERFILACESSO == null)
            {
                return Problem("Entity set 'DataBaseContext.TBPERFILACESSO'  is null.");
            }
            var tbperfilacesso = await _context.TBPERFILACESSO.FindAsync(id);
            if (tbperfilacesso != null)
            {
                _context.TBPERFILACESSO.Remove(tbperfilacesso);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbperfilacessoExists(int id)
        {
          return (_context.TBPERFILACESSO?.Any(e => e.PerfilAcessoId == id)).GetValueOrDefault();
        }
    }
}
