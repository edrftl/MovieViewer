using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieViewer.Data.Entities;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace MovieViewer.Data
{
    public class FilmsDbContext : IdentityDbContext<User>
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Category { get; set; }

        public FilmsDbContext(DbContextOptions<FilmsDbContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Anime" },
                new Category() { Id = 2, Name = "Cartoon" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Action" },
                new Category() { Id = 5, Name = "Comedy" },
                new Category() { Id = 6, Name = "Drama" },
                new Category() { Id = 7, Name = "Horror" },
                new Category() { Id = 8, Name = "Romance" },
                new Category() { Id = 9, Name = "Science Fiction" },
                new Category() { Id = 10, Name = "Fantasy" },
                new Category() { Id = 11, Name = "Mystery" },
                new Category() { Id = 12, Name = "Thriller" },
                new Category() { Id = 13, Name = "Documentary" },
                new Category() { Id = 14, Name = "Biography" },
                new Category() { Id = 15, Name = "History" },
                new Category() { Id = 16, Name = "Music" },
                new Category() { Id = 17, Name = "Sport" },
                new Category() { Id = 18, Name = "Adventure" },
                new Category() { Id = 19, Name = "Family" },
                new Category() { Id = 20, Name = "Animation" }
            });

            modelBuilder.Entity<Film>().HasData(new[]
            {
                new Film
                {
                    Id = 1,
                    Name = "Джурасик Парк",
                    Year = 1993,
                    Description = "У захоплюючій науково-фантастичній екшен-пригоді Джурасик Парк, вчений з клонування виведе до життя невідомі до цього часу тварини, щоб створити невеличкий острівний зоопарк для відвідувачів.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.8p51_xsbaTShT0_j4vp4BAHaEK?w=265&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1500,
                    Dislikes = 100,
                    Raiting = 4.7f,
                    CategoryId = 1,
                },
                new Film
                {
                    Id = 2,
                    Name = "Зоряні війни: Нова надія",
                    Year = 1977,
                    Description = "Сюжет розгортається далеко в галактиці, де група повстанців має завдання врятувати Галактику від злого Імператора та його владиша, Дарт Вейдера.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.A458KurFDlUolyL8HZwCZQHaEK?w=297&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1200,
                    Dislikes = 80,
                    Raiting = 4.5f,
                    CategoryId = 2,
                },

                new Film
                {
                    Id = 3,
                    Name = "Назад у майбутнє",
                    Year = 1985,
                    Description = "Молодий винахідник знаходить спосіб подорожувати у часі, але його експерименти не йдуть за планом.",
                    ImageUrl = "https://www.bing.com/th/id/OIP.05eZOL_QybtLiWXAL10dNAHaEK?w=313&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 800,
                    Dislikes = 50,
                    Raiting = 4.6f,
                    CategoryId = 3,
                },
               
                new Film
                {
                    Id = 5,
                    Name = "Ігри розуму",
                    Year = 2001,
                    Description = "Два інтелектуальні гіганти зіштовхуються в епічній грі шахів, де на кону стоїть не тільки перемога, але й життя.",
                    ImageUrl = "https://i.ytimg.com/vi/rQRG4M3pTHA/maxresdefault.jpg",
                    Likes = 700,
                    Dislikes = 40,
                    Raiting = 4.9f,
                    CategoryId = 5,
                },
                new Film
                {
                    Id = 6,
                    Name = "Зелена миля",
                    Year = 1999,
                    Description = "Ув'язнений, здатний до чудес, протистоїть жорстокій системі в американському в'язниці під час Великої депресії.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.Ii_4K2n2Z88Nr4xsYZAeGgHaFj?w=214&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 950,
                    Dislikes = 70,
                    Raiting = 4.7f,
                    CategoryId = 6,
                },
                new Film
                {
                    Id = 7,
                    Name = "Шоу Трумена",
                    Year = 1998,
                    Description = "У цьому драматичному фільмі комедії відображаються події в житті звичайної людини, яка не підозрює, що її життя - це телевізійне шоу.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.NmMR0WYahpJMGal0poW0ygHaEK?rs=1&pid=ImgDetMain",
                    Likes = 850,
                    Dislikes = 60,
                    Raiting = 4.6f,
                    CategoryId = 7,
                },
                new Film
                {
                    Id = 8,
                    Name = "Інтерв'ю з вампіром",
                    Year = 1994,
                    Description = "Фільм розповідає історію вампіра, який розповідає свою історію з журналістом.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.-OfQY8KZjBr4pk3bsAwnRQHaE7?w=252&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1000,
                    Dislikes = 70,
                    Raiting = 4.5f,
                    CategoryId = 8,
                },
                new Film
                {
                    Id = 9,
                    Name = "Сім",
                    Year = 1995,
                    Description = "У фільмі Сім детектив і його партнер долають внутрішні й зовнішні виклики, щоб вирішити серію вбивств, пов'язаних з сімоми смертями.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.Wr7cdoF5V4ZVx067Xfu2agHaE0?w=277&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 800,
                    Dislikes = 55,
                    Raiting = 4.7f,
                    CategoryId = 9,
                },
                new Film
                {
                    Id = 10,
                    Name = "Індіана Джонс і останній хрестовий похід",
                    Year = 1989,
                    Description = "Індіана Джонс повертається у пошуках зниклого святого келиха, у якому Христос відпивав під час Вечері, і відкриває загадку вікової могили.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.c040k81rRlU1RVm9A-OZeQHaEK?w=294&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1200,
                    Dislikes = 80,
                    Raiting = 4.8f,
                    CategoryId = 10,
                },
                new Film
                {
                    Id = 11,
                    Name = "Побачення з Вами",
                    Year = 1989,
                    Description = "Джеймс випадково відкриває, що він володіє здатністю подорожувати в часі і зустрічається зі своєю дружиною в їхньому молодшому віці.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.KQuEdjqgTYmdgJmem3olawHaEK?w=273&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 900,
                    Dislikes = 65,
                    Raiting = 4.9f,
                    CategoryId = 11,
                },
                new Film
                {
                    Id = 12,
                    Name = "Пірати Карибського моря: Прокляття Чорної перлини",
                    Year = 2003,
                    Description = "Капітан Джек Спарроу шукає легендарний Чорний Жемчуг, що дозволить йому стати непереможним піратом.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.qJA7kX9YuTQVEPGRGAaqfQHaEK?w=312&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1100,
                    Dislikes = 75,
                    Raiting = 4.7f,
                    CategoryId = 12
                },
                new Film
                {
                    Id = 13,
                    Name = "Форест Гамп",
                    Year = 1994,
                    Description = "Форест Гамп, чоловік з низьким інтелектом, стає свідком та учасником багатьох історичних подій 20 століття в США.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.DuuK6n8vIbGQ7yhzVKnf_wHaFj?w=197&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1300,
                    Dislikes = 90,
                    Raiting = 4.8f,
                    CategoryId = 13
                },
                new Film
                {
                    Id = 14,
                    Name = "Бруклінська історія",
                    Year = 2015,
                    Description = "Молода ірландська дівчина переїжджає в Бруклін, де швидко встраюється в новому місті та знаходить кохання.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.qDru8qZbVDnLMuok6beJVgHaEK?w=300&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 1000,
                    Dislikes = 70,
                    Raiting = 4.6f,
                    CategoryId = 14
                },
                new Film
                {
                    Id = 15,
                    Name = "Привид",
                    Year = 1990,
                    Description = "У цьому містичному романсі банкір Сем вступає в незвичайний контакт з душею своєї померлої дружини Моллі, намагаючись допомогти їй розкрити заговор, який стоїть за її смертю.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.zEHVqOX5mHgN3d8Vvt-WrAHaEK?w=268&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    Likes = 950,
                    Dislikes = 80,
                    Raiting = 4.5f,
                    CategoryId = 15
                },

            });

            modelBuilder.Entity<Film>()
        .HasOne(f => f.Category)
        .WithMany(c => c.Films)
        .HasForeignKey(f => f.CategoryId)
        .OnDelete(DeleteBehavior.Restrict);  // Change DeleteBehavior to Restrict

            // Additional configuration
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Films)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);








            //modelBuilder.Entity<Film>()
            //    .HasOne(a => a.Category)
            //    .WithMany(b => b.Films)
            //    .HasForeignKey(a => a.CategoryId);

            /////////////////////////////////



        }
    }
}
