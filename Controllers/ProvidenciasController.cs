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
    public class ProvidenciasController : Controller
    {
        private readonly ContextoDb _context;

        public ProvidenciasController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Providencias
        public async Task<IActionResult> Index()
        {
            return _context.TBFICHAPROVIDENCIASRESP != null ?
                          View(await _context.TBFICHAPROVIDENCIASRESP.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBFICHAPROVIDENCIASRESP'  is null.");
        }

        // GET: Providencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP
                .FirstOrDefaultAsync(m => m.FichaProvRespId == id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }

            return View(tBFichaProvidenciasResp);
        }

        public IActionResult Create(int? id)
        {
            if (id == null || id == 0)
            {
                ViewData["FichaId"] = new SelectList(_context.TBFICHA, "FichaId", "FichaId");
                return View();
            }

            ViewBag.FichaId = new SelectList(_context.TBFICHA, "FichaId", "FichaId", id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, [Bind("FichaProvRespId,FichaId,FichaProvRespIncPor,FichaProvRespIncEm,FichaProvRespAltPor,FichaprovRespAltEm,FichaDtaComunicRespons,FichaMeioComunic,FichaPorQuemUsuariorId,FichaPraQuemUsuariorId,FichaProcedimentoUnidade,FichaRecebidoEm,FichaDataTramitacao,FichaDefineRetorno")] TBFichaProvidenciasResp tBFichaProvidenciasResp)
        {
            tBFichaProvidenciasResp.FichaId = id;

            if (ModelState.IsValid)
            {

                //var model = new TBFichaCategoriaOpcResp()
                //{
                //    CatOpcId = 12,
                //    FichaId = 1,
                //    FichaCatOpcResIncPor = 1,
                //    FichaCatOpcIncEm = DateTime.Now
                //};

                //_context.Add(model);
                _context.Add(tBFichaProvidenciasResp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBFichaProvidenciasResp);
        }

        // GET: Providencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP.FindAsync(id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }
            return View(tBFichaProvidenciasResp);
        }

        // POST: Providencias/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaProvRespId,FichaId,FichaProvRespIncPor,FichaProvRespIncEm,FichaProvRespAltPor,FichaprovRespAltEm,FichaDtaComunicRespons,FichaMeioComunic,FichaPorQuemUsuariorId,FichaPraQuemUsuariorId,FichaProcedimentoUnidade,FichaRecebidoEm,FichaDataTramitacao,FichaDefineRetorno")] TBFichaProvidenciasResp tBFichaProvidenciasResp)
        {
            if (id != tBFichaProvidenciasResp.FichaProvRespId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBFichaProvidenciasResp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBFichaProvidenciasRespExists(tBFichaProvidenciasResp.FichaProvRespId))
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
            return View(tBFichaProvidenciasResp);
        }

        // GET: Providencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP
                .FirstOrDefaultAsync(m => m.FichaProvRespId == id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }

            return View(tBFichaProvidenciasResp);
        }

        // POST: Providencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBFICHAPROVIDENCIASRESP == null)
            {
                return Problem("Entity set 'ContextoDb.TBFICHAPROVIDENCIASRESP'  is null.");
            }
            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP.FindAsync(id);
            if (tBFichaProvidenciasResp != null)
            {
                _context.TBFICHAPROVIDENCIASRESP.Remove(tBFichaProvidenciasResp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBFichaProvidenciasRespExists(int id)
        {
          return (_context.TBFICHAPROVIDENCIASRESP?.Any(e => e.FichaProvRespId == id)).GetValueOrDefault();
        }
    }
}
