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
    public class AlunoController : Controller
    {
        private readonly ContextoDb _context;

        public AlunoController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Aluno
        public async Task<IActionResult> Index()
        {
              return _context.TBALUNO != null ? 
                          View(await _context.TBALUNO.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBALUNO'  is null.");
        }

        // GET: Aluno/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBALUNO == null)
            {
                return NotFound();
            }

            var tBAluno = await _context.TBALUNO
                .FirstOrDefaultAsync(m => m.AluId == id);
            if (tBAluno == null)
            {
                return NotFound();
            }

            return View(tBAluno);
        }

        // GET: Aluno/Create
        public IActionResult Create()
        {
            ViewData["BairroId"] = new SelectList(_context.TBBAIRRO, "BairroId", "BairroNome");
                return View();
        }

        // POST: Aluno/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AluId,AluNom,AluNomSoc,AluDtaNasc,AluCpf,AluSexo,AluFiliacao1,AluFiliacao2,AluFiliacao3,AluIdinep,AluRaca,AluEndLog,AluEndNmrLog,AluEndCmpLog,AluEndBairro,AluEndCep,AluTelResDdd,AluTelRes,AluTelCelDdd,AluTelCel,AluTelConDdd,AluTelCon,AluObs,AluStatus,AluIncPor,AluIncEm,AluAltPor,AluAltEm,BairroId,GedAluCod")] TBAluno tBAluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBAluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBAluno);
        }

        // GET: Aluno/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBALUNO == null)
            {
                return NotFound();
            }

            var tBAluno = await _context.TBALUNO.FindAsync(id);
            if (tBAluno == null)
            {
                return NotFound();
            }
            return View(tBAluno);
        }

        // POST: Aluno/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AluId,AluNom,AluNomSoc,AluDtaNasc,AluCpf,AluSexo,AluFiliacao1,AluFiliacao2,AluFiliacao3,AluIdinep,AluRaca,AluEndLog,AluEndNmrLog,AluEndCmpLog,AluEndBairro,AluEndCep,AluTelResDdd,AluTelRes,AluTelCelDdd,AluTelCel,AluTelConDdd,AluTelCon,AluObs,AluStatus,AluIncPor,AluIncEm,AluAltPor,AluAltEm,BairroId,GedAluCod")] TBAluno tBAluno)
        {
            if (id != tBAluno.AluId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBAluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBAlunoExists(tBAluno.AluId))
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
            return View(tBAluno);
        }

        // GET: Aluno/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBALUNO == null)
            {
                return NotFound();
            }

            var tBAluno = await _context.TBALUNO
                .FirstOrDefaultAsync(m => m.AluId == id);
            if (tBAluno == null)
            {
                return NotFound();
            }

            return View(tBAluno);
        }

        // POST: Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBALUNO == null)
            {
                return Problem("Entity set 'ContextoDb.TBALUNO'  is null.");
            }
            var tBAluno = await _context.TBALUNO.FindAsync(id);
            if (tBAluno != null)
            {
                _context.TBALUNO.Remove(tBAluno);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBAlunoExists(int id)
        {
          return (_context.TBALUNO?.Any(e => e.AluId == id)).GetValueOrDefault();
        }
    }
}
