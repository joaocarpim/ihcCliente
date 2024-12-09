using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ihcCliente.Data;
using ihcCliente.Models;

namespace ihcCliente.Controllers
{
    public class ItemVendasController : Controller
    {
        private readonly ihcClienteContext _context;

        public ItemVendasController(ihcClienteContext context)
        {
            _context = context;
        }

        // GET: ItemVendas
        public async Task<IActionResult> Index()
        {
            var ihcClienteContext = _context.ItemVenda.Include(i => i.Produto).Include(i => i.Venda);
            return View(await ihcClienteContext.ToListAsync());
        }

        // GET: ItemVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .Include(i => i.Produto)
                .Include(i => i.Venda)
                .FirstOrDefaultAsync(m => m.ItemVendaId == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // GET: ItemVendas/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome");
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId");
            return View();
        }

        // POST: ItemVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemVendaId,ProdutoId,VendaId,Quantidade,PrecoUnitario")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome", itemVenda.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", itemVenda.VendaId);
            return View(itemVenda);
        }

        // GET: ItemVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome", itemVenda.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", itemVenda.VendaId);
            return View(itemVenda);
        }

        // POST: ItemVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemVendaId,ProdutoId,VendaId,Quantidade,PrecoUnitario")] ItemVenda itemVenda)
        {
            if (id != itemVenda.ItemVendaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemVendaExists(itemVenda.ItemVendaId))
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
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome", itemVenda.ProdutoId);
            ViewData["VendaId"] = new SelectList(_context.Venda, "VendaId", "VendaId", itemVenda.VendaId);
            return View(itemVenda);
        }

        // GET: ItemVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .Include(i => i.Produto)
                .Include(i => i.Venda)
                .FirstOrDefaultAsync(m => m.ItemVendaId == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // POST: ItemVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda != null)
            {
                _context.ItemVenda.Remove(itemVenda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemVendaExists(int id)
        {
            return _context.ItemVenda.Any(e => e.ItemVendaId == id);
        }
    }
}
