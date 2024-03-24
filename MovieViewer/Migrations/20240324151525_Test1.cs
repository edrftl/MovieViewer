using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieViewer.Migrations
{
    /// <inheritdoc />
    public partial class Test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raiting = table.Column<float>(type: "real", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Anime" },
                    { 2, "Cartoon" },
                    { 3, "Fashion" },
                    { 4, "Action" },
                    { 5, "Comedy" },
                    { 6, "Drama" },
                    { 7, "Horror" },
                    { 8, "Romance" },
                    { 9, "Science Fiction" },
                    { 10, "Fantasy" },
                    { 11, "Mystery" },
                    { 12, "Thriller" },
                    { 13, "Documentary" },
                    { 14, "Biography" },
                    { 15, "History" },
                    { 16, "Music" },
                    { 17, "Sport" },
                    { 18, "Adventure" },
                    { 19, "Family" },
                    { 20, "Animation" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "Description", "Dislikes", "ImageUrl", "Likes", "Name", "Raiting", "Year" },
                values: new object[,]
                {
                    { 1, 1, "У захоплюючій науково-фантастичній екшен-пригоді Джурасик Парк, вчений з клонування виведе до життя невідомі до цього часу тварини, щоб створити невеличкий острівний зоопарк для відвідувачів.", 100, "https://th.bing.com/th/id/OIP.8p51_xsbaTShT0_j4vp4BAHaEK?w=265&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1500, "Джурасик Парк", 4.7f, 1993 },
                    { 2, 2, "Сюжет розгортається далеко в галактиці, де група повстанців має завдання врятувати Галактику від злого Імператора та його владиша, Дарт Вейдера.", 80, "https://th.bing.com/th/id/OIP.A458KurFDlUolyL8HZwCZQHaEK?w=297&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1200, "Зоряні війни: Нова надія", 4.5f, 1977 },
                    { 3, 3, "Молодий винахідник знаходить спосіб подорожувати у часі, але його експерименти не йдуть за планом.", 50, "https://www.bing.com/th/id/OIP.05eZOL_QybtLiWXAL10dNAHaEK?w=313&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 800, "Назад у майбутнє", 4.6f, 1985 },
                    { 5, 5, "Два інтелектуальні гіганти зіштовхуються в епічній грі шахів, де на кону стоїть не тільки перемога, але й життя.", 40, "https://i.ytimg.com/vi/rQRG4M3pTHA/maxresdefault.jpg", 700, "Ігри розуму", 4.9f, 2001 },
                    { 6, 6, "Ув'язнений, здатний до чудес, протистоїть жорстокій системі в американському в'язниці під час Великої депресії.", 70, "https://th.bing.com/th/id/OIP.Ii_4K2n2Z88Nr4xsYZAeGgHaFj?w=214&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 950, "Зелена миля", 4.7f, 1999 },
                    { 7, 7, "У цьому драматичному фільмі комедії відображаються події в житті звичайної людини, яка не підозрює, що її життя - це телевізійне шоу.", 60, "https://th.bing.com/th/id/OIP.NmMR0WYahpJMGal0poW0ygHaEK?rs=1&pid=ImgDetMain", 850, "Шоу Трумена", 4.6f, 1998 },
                    { 8, 8, "Фільм розповідає історію вампіра, який розповідає свою історію з журналістом.", 70, "https://th.bing.com/th/id/OIP.-OfQY8KZjBr4pk3bsAwnRQHaE7?w=252&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1000, "Інтерв'ю з вампіром", 4.5f, 1994 },
                    { 9, 9, "У фільмі Сім детектив і його партнер долають внутрішні й зовнішні виклики, щоб вирішити серію вбивств, пов'язаних з сімоми смертями.", 55, "https://th.bing.com/th/id/OIP.Wr7cdoF5V4ZVx067Xfu2agHaE0?w=277&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 800, "Сім", 4.7f, 1995 },
                    { 10, 10, "Індіана Джонс повертається у пошуках зниклого святого келиха, у якому Христос відпивав під час Вечері, і відкриває загадку вікової могили.", 80, "https://th.bing.com/th/id/OIP.c040k81rRlU1RVm9A-OZeQHaEK?w=294&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1200, "Індіана Джонс і останній хрестовий похід", 4.8f, 1989 },
                    { 11, 11, "Джеймс випадково відкриває, що він володіє здатністю подорожувати в часі і зустрічається зі своєю дружиною в їхньому молодшому віці.", 65, "https://th.bing.com/th/id/OIP.KQuEdjqgTYmdgJmem3olawHaEK?w=273&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 900, "Побачення з Вами", 4.9f, 1989 },
                    { 12, 12, "Капітан Джек Спарроу шукає легендарний Чорний Жемчуг, що дозволить йому стати непереможним піратом.", 75, "https://th.bing.com/th/id/OIP.qJA7kX9YuTQVEPGRGAaqfQHaEK?w=312&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1100, "Пірати Карибського моря: Прокляття Чорної перлини", 4.7f, 2003 },
                    { 13, 13, "Форест Гамп, чоловік з низьким інтелектом, стає свідком та учасником багатьох історичних подій 20 століття в США.", 90, "https://th.bing.com/th/id/OIP.DuuK6n8vIbGQ7yhzVKnf_wHaFj?w=197&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1300, "Форест Гамп", 4.8f, 1994 },
                    { 14, 14, "Молода ірландська дівчина переїжджає в Бруклін, де швидко встраюється в новому місті та знаходить кохання.", 70, "https://th.bing.com/th/id/OIP.qDru8qZbVDnLMuok6beJVgHaEK?w=300&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 1000, "Бруклінська історія", 4.6f, 2015 },
                    { 15, 15, "У цьому містичному романсі банкір Сем вступає в незвичайний контакт з душею своєї померлої дружини Моллі, намагаючись допомогти їй розкрити заговор, який стоїть за її смертю.", 80, "https://th.bing.com/th/id/OIP.zEHVqOX5mHgN3d8Vvt-WrAHaEK?w=268&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", 950, "Привид", 4.5f, 1990 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryId",
                table: "Films",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
