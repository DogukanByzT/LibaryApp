using LibraryApp.Domain.Abstract;

namespace LibraryApp.Domain.Entities
{
    public class Category : Entity
    {
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
