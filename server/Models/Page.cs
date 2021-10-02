using System.ComponentModel.DataAnnotations;

namespace Maze.Models
{
    public class Page
    {
        public int PageId { get; set; }
        public string Img { get; set; }
        public string Text { get; set; }
        public string Doors { get; set; }

    }
}

// combo system

// 1. upload image into server-folder on assets
// 2. database will store link to database Img
// 3. front end - img source = link
 