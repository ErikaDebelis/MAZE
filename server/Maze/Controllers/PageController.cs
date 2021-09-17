using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

using Maze.Models;

namespace Maze.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PagesController : ControllerBase
  {
    private readonly MazeContext _db;
    public PagesController(MazeContext db)
    {
      _db = db;
    }

    // GET api/pages
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Page>>> Get()
    {
      return await _db.Pages.ToListAsync();
    }

    // POST api/pages
    [HttpPost]
    public async Task<ActionResult<Page>> Post(Page page)
    {
      _db.Pages.Add(page);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = page.PageId }, page);
    }

    // GET: api/Ages/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Page>> GetPage(int id)
    {
      Page page = await _db.Pages.FindAsync(id);

      if (page == null)
      {
        return NotFound();
      }

      return page;
    }
  }
}