﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieViewer.Data;

#nullable disable

namespace MovieViewer.Migrations
{
    [DbContext(typeof(FilmsDbContext))]
    [Migration("20240324151525_Test1")]
    partial class Test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieViewer.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Anime"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cartoon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 15,
                            Name = "History"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Animation"
                        });
                });

            modelBuilder.Entity("MovieViewer.Data.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Raiting")
                        .HasColumnType("real");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "У захоплюючій науково-фантастичній екшен-пригоді Джурасик Парк, вчений з клонування виведе до життя невідомі до цього часу тварини, щоб створити невеличкий острівний зоопарк для відвідувачів.",
                            Dislikes = 100,
                            ImageUrl = "https://th.bing.com/th/id/OIP.8p51_xsbaTShT0_j4vp4BAHaEK?w=265&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1500,
                            Name = "Джурасик Парк",
                            Raiting = 4.7f,
                            Year = 1993
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Сюжет розгортається далеко в галактиці, де група повстанців має завдання врятувати Галактику від злого Імператора та його владиша, Дарт Вейдера.",
                            Dislikes = 80,
                            ImageUrl = "https://th.bing.com/th/id/OIP.A458KurFDlUolyL8HZwCZQHaEK?w=297&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1200,
                            Name = "Зоряні війни: Нова надія",
                            Raiting = 4.5f,
                            Year = 1977
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Молодий винахідник знаходить спосіб подорожувати у часі, але його експерименти не йдуть за планом.",
                            Dislikes = 50,
                            ImageUrl = "https://www.bing.com/th/id/OIP.05eZOL_QybtLiWXAL10dNAHaEK?w=313&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 800,
                            Name = "Назад у майбутнє",
                            Raiting = 4.6f,
                            Year = 1985
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Description = "Два інтелектуальні гіганти зіштовхуються в епічній грі шахів, де на кону стоїть не тільки перемога, але й життя.",
                            Dislikes = 40,
                            ImageUrl = "https://i.ytimg.com/vi/rQRG4M3pTHA/maxresdefault.jpg",
                            Likes = 700,
                            Name = "Ігри розуму",
                            Raiting = 4.9f,
                            Year = 2001
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            Description = "Ув'язнений, здатний до чудес, протистоїть жорстокій системі в американському в'язниці під час Великої депресії.",
                            Dislikes = 70,
                            ImageUrl = "https://th.bing.com/th/id/OIP.Ii_4K2n2Z88Nr4xsYZAeGgHaFj?w=214&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 950,
                            Name = "Зелена миля",
                            Raiting = 4.7f,
                            Year = 1999
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            Description = "У цьому драматичному фільмі комедії відображаються події в житті звичайної людини, яка не підозрює, що її життя - це телевізійне шоу.",
                            Dislikes = 60,
                            ImageUrl = "https://th.bing.com/th/id/OIP.NmMR0WYahpJMGal0poW0ygHaEK?rs=1&pid=ImgDetMain",
                            Likes = 850,
                            Name = "Шоу Трумена",
                            Raiting = 4.6f,
                            Year = 1998
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 8,
                            Description = "Фільм розповідає історію вампіра, який розповідає свою історію з журналістом.",
                            Dislikes = 70,
                            ImageUrl = "https://th.bing.com/th/id/OIP.-OfQY8KZjBr4pk3bsAwnRQHaE7?w=252&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1000,
                            Name = "Інтерв'ю з вампіром",
                            Raiting = 4.5f,
                            Year = 1994
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 9,
                            Description = "У фільмі Сім детектив і його партнер долають внутрішні й зовнішні виклики, щоб вирішити серію вбивств, пов'язаних з сімоми смертями.",
                            Dislikes = 55,
                            ImageUrl = "https://th.bing.com/th/id/OIP.Wr7cdoF5V4ZVx067Xfu2agHaE0?w=277&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 800,
                            Name = "Сім",
                            Raiting = 4.7f,
                            Year = 1995
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 10,
                            Description = "Індіана Джонс повертається у пошуках зниклого святого келиха, у якому Христос відпивав під час Вечері, і відкриває загадку вікової могили.",
                            Dislikes = 80,
                            ImageUrl = "https://th.bing.com/th/id/OIP.c040k81rRlU1RVm9A-OZeQHaEK?w=294&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1200,
                            Name = "Індіана Джонс і останній хрестовий похід",
                            Raiting = 4.8f,
                            Year = 1989
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 11,
                            Description = "Джеймс випадково відкриває, що він володіє здатністю подорожувати в часі і зустрічається зі своєю дружиною в їхньому молодшому віці.",
                            Dislikes = 65,
                            ImageUrl = "https://th.bing.com/th/id/OIP.KQuEdjqgTYmdgJmem3olawHaEK?w=273&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 900,
                            Name = "Побачення з Вами",
                            Raiting = 4.9f,
                            Year = 1989
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 12,
                            Description = "Капітан Джек Спарроу шукає легендарний Чорний Жемчуг, що дозволить йому стати непереможним піратом.",
                            Dislikes = 75,
                            ImageUrl = "https://th.bing.com/th/id/OIP.qJA7kX9YuTQVEPGRGAaqfQHaEK?w=312&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1100,
                            Name = "Пірати Карибського моря: Прокляття Чорної перлини",
                            Raiting = 4.7f,
                            Year = 2003
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 13,
                            Description = "Форест Гамп, чоловік з низьким інтелектом, стає свідком та учасником багатьох історичних подій 20 століття в США.",
                            Dislikes = 90,
                            ImageUrl = "https://th.bing.com/th/id/OIP.DuuK6n8vIbGQ7yhzVKnf_wHaFj?w=197&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1300,
                            Name = "Форест Гамп",
                            Raiting = 4.8f,
                            Year = 1994
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 14,
                            Description = "Молода ірландська дівчина переїжджає в Бруклін, де швидко встраюється в новому місті та знаходить кохання.",
                            Dislikes = 70,
                            ImageUrl = "https://th.bing.com/th/id/OIP.qDru8qZbVDnLMuok6beJVgHaEK?w=300&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 1000,
                            Name = "Бруклінська історія",
                            Raiting = 4.6f,
                            Year = 2015
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 15,
                            Description = "У цьому містичному романсі банкір Сем вступає в незвичайний контакт з душею своєї померлої дружини Моллі, намагаючись допомогти їй розкрити заговор, який стоїть за її смертю.",
                            Dislikes = 80,
                            ImageUrl = "https://th.bing.com/th/id/OIP.zEHVqOX5mHgN3d8Vvt-WrAHaEK?w=268&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                            Likes = 950,
                            Name = "Привид",
                            Raiting = 4.5f,
                            Year = 1990
                        });
                });

            modelBuilder.Entity("MovieViewer.Data.Entities.Film", b =>
                {
                    b.HasOne("MovieViewer.Data.Entities.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MovieViewer.Data.Entities.Category", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
