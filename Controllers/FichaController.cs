using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaOnline.Data;
using FichaOnline.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Transactions;
using FichaOnline.Migrations;
using Xunit.Abstractions;

namespace FichaOnline.Controllers
{
    public class FichaController : Controller
    {
        private readonly ContextoDb _context;

        public FichaController(ContextoDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contextoDb = _context.TBFICHA.Include(t => t.FichaCatOpcResp);
            return View(contextoDb);
        }

        public IActionResult Create()
        {
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeDesc");
            ViewData["AluId"] = new SelectList(_context.TBALUNO, "AluId", "AluNom");
            ViewData["CatId"] = new SelectList(_context.TBCATEGORIA, "CatId", "CatDesc");
            //List<TBCategoriaOpcoes> itens = _context.TBCATEGORIAOPCOES.ToList();

            var model = new ViewModel()
            {
                ListCategoriaOpcoes = _context.TBCATEGORIAOPCOES.ToList(),
                TBFicha = new TBFicha(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ViewModel model)
        {
            try
            {
                _context.TBFICHA.Add(model.TBFicha);
                await _context.SaveChangesAsync();

                var fichaid = model.TBFicha.FichaId;
                var incluidoPor = model.TBFicha.FichaIncPor;
                var incluidoEm = model.TBFicha.FichaIncEm;

                if (model != null && model.ListCategoriaOpcoes.Any(items => items.Selecionado))
                {
                    foreach (var item in model.ListCategoriaOpcoes)
                    {
                        if (item.Selecionado)
                        {
                            var tBFichaCategoriaOpcResp = new TBFichaCategoriaOpcResp
                            {
                                FichaId = fichaid,
                                CatOpcId = item.CatOpcId,
                                FichaCatOpcResIncPor = incluidoPor,
                                FichaCatOpcIncEm = incluidoEm
                            };

                            _context.TBCATEGORIAOPCRESP.Add(tBFichaCategoriaOpcResp);
                            await _context.SaveChangesAsync();
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }

            return View(model);
        }


        // GET: Ficha/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBFICHA == null)
            {
                return NotFound();
            }

            var tBFicha = await _context.TBFICHA.FindAsync(id);
            if (tBFicha == null)
            {
                return NotFound();
            }
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeId", tBFicha.FichaEscOrigemUnidadeId);
            return View(tBFicha);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaId,FichaCatId,FichaStsId,FichaAtualUnidadeId,FichaNova,AluId,FichaEscOrigemUnidadeId,FichaDtaIni,FichaDtaFim,FichaIncPor,FichaIncEm,FichaAltPor,FichaAltEm")] TBFicha tBFicha)
        {
            if (id != tBFicha.FichaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBFicha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBFichaExists(tBFicha.FichaId))
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
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeId", tBFicha.FichaEscOrigemUnidadeId);
            return View(tBFicha);
        }

        // GET: Ficha/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBFICHA == null)
            {
                return NotFound();
            }

            var tBFicha = await _context.TBFICHA
                .Include(t => t.FichaEscOrigemUnidade)
                .FirstOrDefaultAsync(m => m.FichaId == id);
            if (tBFicha == null)
            {
                return NotFound();
            }

            return View(tBFicha);
        }

        // POST: Ficha/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBFICHA == null)
            {
                return Problem("Entity set 'ContextoDb.TBFICHA'  is null.");
            }
            var tBFicha = await _context.TBFICHA.FindAsync(id);
            if (tBFicha != null)
            {
                _context.TBFICHA.Remove(tBFicha);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBFichaExists(int id)
        {
            return (_context.TBFICHA?.Any(e => e.FichaId == id)).GetValueOrDefault();
        }

    }
}
