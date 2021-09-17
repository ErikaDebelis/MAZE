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
  }
}