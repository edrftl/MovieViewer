namespace MovieViewer.Models
{
    public class FilmCardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public float Raiting { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string? ImageUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
