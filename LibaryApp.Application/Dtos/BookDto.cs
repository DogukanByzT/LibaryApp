using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Dtos
{
    public class BookDto
    {
        public string? ISBN { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int PageSize { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsPresent { get; set; }
    }
}
