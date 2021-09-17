using System.ComponentModel.DataAnnotations;

namespace Maze.Models
{
    public class Page
    {
        public int PageId { get; set; }
        [Required]
        public string Picture { get; set; }
        public string Text { get; set; }
        public int Doors { get; set; }

    }
}