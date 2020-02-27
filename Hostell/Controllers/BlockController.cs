using Hostell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hostell.Controllers
{
    public class BlockController : Controller
    {
        HostelAppContext db;
        public BlockController(HostelAppContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Main()
        {
            return View(db.Blocks.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(    );
        }
        [HttpPost]
        public IActionResult Add(Block block)
        {
            db.Blocks.Add(block);
            db.SaveChanges();
            return RedirectToAction("Main");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Block block = await db.Blocks.FirstOrDefaultAsync(p => p.Id == id);
            return View(block);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Block block)
        {
            db.Remove(block);
            await  db.SaveChangesAsync();
            return RedirectToAction("Main");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Block block = await db.Blocks.FirstOrDefaultAsync(p => p.Id == id);
            return View(block);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Block block)
        {
            db.Blocks.Update(block);
            await db.SaveChangesAsync();
            return RedirectToAction("Main");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Block block = await db.Blocks.FirstOrDefaultAsync(p => p.Id == id);
            block.People=db.Residents.Where(x => x.BlockId == id).ToList();
            return View(block);
        }
    }
}
