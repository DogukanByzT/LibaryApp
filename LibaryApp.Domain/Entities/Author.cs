using LibraryApp.Domain.Abstract;

namespace LibraryApp.Domain.Entities
{
    public class Author : Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Book>? Books { get; set; }

    }
}
