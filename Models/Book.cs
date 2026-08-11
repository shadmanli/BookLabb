namespace BookWork.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<BookImage> BookImages { get; set; }
    }
}
