using IdentityDotNet.Data;
using IdentityDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityDotNet.Controllers
{
    public class OfferListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfferListController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexOffer()
        {
            return View(await _context.offerList.ToArrayAsync());
        }

        public IActionResult CreateOffer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOfferAsync(OfferList model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _context.offerList.AddAsync(model);
                    _context.SaveChanges();

                    return RedirectToAction("IndexOffer");
                }
                return View(model);

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await _context.offerList.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(OfferList model)
        {
            if (ModelState.IsValid)
            {
                _context.offerList.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexOffer");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var result = await _context.offerList.FindAsync(id);

                if (result == null)
                {
                    return NotFound();
                }

                _context.offerList.Remove(result);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexOffer");
            }catch (Exception ex)
            {
                return View(ex);
            }
            
        }
    }
}
