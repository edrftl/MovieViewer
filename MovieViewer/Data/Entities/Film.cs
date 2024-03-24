namespace MovieViewer.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public float Raiting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
