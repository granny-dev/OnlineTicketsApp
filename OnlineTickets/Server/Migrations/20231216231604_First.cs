using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CinemaLogo = table.Column<string>(type: "TEXT", nullable: false),
                    CinemaName = table.Column<string>(type: "TEXT", nullable: false),
                    CinemaDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProducerProfilePictureURL = table.Column<string>(type: "TEXT", nullable: false),
                    ProducerName = table.Column<string>(type: "TEXT", nullable: false),
                    ProducerBiography = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(type: "TEXT", nullable: false),
                    MovieDescription = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    MovieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    MovieImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CinemaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CinemaName = table.Column<string>(type: "TEXT", nullable: false),
                    ProducerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProducerName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "ProducerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActorProfilePictureURL = table.Column<string>(type: "TEXT", nullable: false),
                    ActorName = table.Column<string>(type: "TEXT", nullable: false),
                    ActorBiography = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "CinemaId", "Capacity", "CinemaDescription", "CinemaLogo", "CinemaName" },
                values: new object[,]
                {
                    { 1, 50, "Blokbuster is located near the subway station Petrovka and is housed within an entertainment complex that includes a cinema as well as a variety of other entertainments for all ages. In addition to a 3D IMAX theatre, 5D cinema, and a megaplex, the theatre also features bowling lanes, billiards tables, restaurants, slot machines, and skating rinks.", "https://www.blockbuster.ua/upload/iblock/e9f/c8f1de7e046f5d6926dde59758622a77.jpg", "Blokbaster" },
                    { 2, 20, "Cinema Citi hosts three rooms for watching films in 3D. Films are brought in from all genres and all parts of the world, including European films and Hollywood productions. A VIP hall features a popcorn bar, fresh juice bar, and other conveniences for those wanting to watch in comfort.", "https://cinemaciti.ua/app/images/logo.svg", "Cinema Citi" },
                    { 3, 30, "Located near the Vokzalnaya metro station, the Butterfly Cinema is relatively new, having opened in 2004 in the Ultramarine Entertainment Centre. With six auditoriums, this cinema seats several hundred people in each room and in very comfortable, upholstered seats. Various films are featured here, including ones for adults as well as children, new hits, and old films.", "https://www.kino-butterfly.com.ua/img/background.jpg", "Butterfly Cinema" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ProducerId", "ProducerBiography", "ProducerName", "ProducerProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Aaron James Horvath (born August 19, 1980) is an American animator, screenwriter, producer, and director.", "Aaron Horvath", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Aaron_Horvath_by_Gage_Skidmore.jpg/330px-Aaron_Horvath_by_Gage_Skidmore.jpg" },
                    { 2, "Greta Celeste Gerwig (born August 4, 1983) is an American actress, writer, and director.", "Greta Gerwig", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg/330px-Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg" },
                    { 3, "Christopher Edward Nolan CBE (born 30 July 1970) is a British and American film director, screenwriter, and producer.", "Christopher Nolan", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/330px-Christopher_Nolan_Cannes_2018.jpg" },
                    { 4, "Paul Feig( born September 17, 1962) is an American filmmaker, actor, and comedian", "Paul Feig", "https://upload.wikimedia.org/wikipedia/commons/4/44/Paul_Feig.jpg" },
                    { 5, "Charles Martin Smith (born October 30, 1953) is an American actor, writer, and director of film and television based in British Columbia, Canada.", "Charles Martin Smith", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/CharlesMartinSmith08TIFF.jpg/330px-CharlesMartinSmith08TIFF.jpg" },
                    { 6, "Christopher Meledandri (/mɛləˈdɑːndri/;[1] born May 15, 1959) is an American film producer and founder and CEO of Illumination.", "Chris Meledandri", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg/330px-Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CinemaId", "CinemaName", "EndDate", "MovieCategory", "MovieDescription", "MovieImageUrl", "MovieName", "Price", "ProducerId", "ProducerName", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, "Blokbaster", new DateTime(2023, 12, 24, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2689), "Cartoon", "The plot follows the Grinch and his pet dog Max who plan to stop Whoville's Christmas celebration by stealing all the town's decorations and gifts.", "https://upload.wikimedia.org/wikipedia/en/4/4f/The_Grinch%2C_final_poster.jpg", "The Grinch", 20m, 6, "Chris Meledandri", new DateTime(2023, 12, 17, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2629) },
                    { 2, 2, "Cinema Citi", new DateTime(2023, 12, 27, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2698), "Family", "James looks back at the last Christmas he and Bob spent scraping a living on the streets and how Bob helped him through one of his toughest times – providing strength, friendship and inspiration – and ultimately teaching each other about the true meaning of Christmas spirit along the way.", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4b/Christmas_gift_from_bob_ver2.jpg/330px-Christmas_gift_from_bob_ver2.jpg", "A Gift from Bob", 25m, 5, "Charles Martin Smith", new DateTime(2023, 12, 20, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2697) },
                    { 3, 3, "Butterfly Cinema", new DateTime(2023, 12, 31, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2702), "Romance", "Katarina \"Kate\" Andrich, a young aspiring singer, bounces around between her friends’ places, and has a dead-end job as an elf at a year-round Christmas shop in Central London, whose strict but good-hearted Chinese owner calls herself \"Santa\". Whilst at work, she notices a man outside staring upward and strikes up a conversation, learning that his name is Tom Webster and his oft-repeated life wisdom is to \"look up\" for things that others seldom observe.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Last_Christmas_poster.jpeg", "Last Christmas", 22m, 4, "Paul Feig", new DateTime(2023, 12, 24, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2701) },
                    { 4, 1, "Blokbaster", new DateTime(2023, 12, 26, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2707), "Drama", "Based on the 2005 biography American Prometheus by Kai Bird and Martin J. Sherwin, the film chronicles the career of Oppenheimer, with the story predominantly focusing on his studies, his direction of the Manhattan Project during World War II, and his eventual fall from grace due to his 1954 security hearing.", "https://upload.wikimedia.org/wikipedia/en/4/4a/Oppenheimer_%28film%29.jpg", "Oppenheimer", 28m, 3, "Christopher Nolan", new DateTime(2023, 12, 19, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2706) },
                    { 5, 2, "Cinema Citi", new DateTime(2023, 12, 24, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2711), "Comedy", "Based on the eponymous fashion dolls by Mattel, it is the first live-action Barbie film after numerous computer-animated films and specials.", "https://upload.wikimedia.org/wikipedia/en/0/0b/Barbie_2023_poster.jpg", "Barbie", 24m, 2, "Greta Gerwig", new DateTime(2023, 12, 17, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2710) },
                    { 6, 3, "Butterfly Cinema", new DateTime(2023, 12, 25, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2715), "Comedy", "Italian-American brothers Mario and Luigi have recently opened a plumbing business in Brooklyn, to the derision of their ex-employer Spike and the disapproval of their father. After seeing a significant water main leak on the news, Mario and Luigi go underground to fix it but are sucked into a Warp Pipe and separated.", "https://upload.wikimedia.org/wikipedia/en/4/44/The_Super_Mario_Bros._Movie_poster.jpg", "The Super Mario Bros. Movie", 27m, 1, "Aaron Horvath", new DateTime(2023, 12, 18, 1, 16, 4, 817, DateTimeKind.Local).AddTicks(2714) }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorBiography", "ActorName", "ActorProfilePictureURL", "MovieId" },
                values: new object[,]
                {
                    { 1, "Benedict Timothy Carlton Cumberbatch CBE (born 19 July 1976) is an English actor. Known for his work on screen and stage, he has received various accolades, including a BAFTA Award, a Primetime Emmy Award and a Laurence Olivier Award, in addition to nominations for two Academy Awards and four Golden Globes.", "Benedict Cumberbatch", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/BCumberbatch_Comic-Con_2019.jpg/330px-BCumberbatch_Comic-Con_2019.jpg", 1 },
                    { 2, "Christopher Michael Pratt (born June 21, 1979) is an American actor. He rose to prominence for playing Andy Dwyer in the NBC sitcom Parks and Recreation (2009–2015). He also appeared in The WB drama series Everwood (2002–2006) and had supporting roles in the films Wanted (2008), Jennifer's Body (2009), Moneyball (2011), Zero Dark Thirty (2012), and Her (2013).", "Chris Pratt", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Chris_Pratt_2018.jpg/330px-Chris_Pratt_2018.jpg", 6 },
                    { 3, "Ryan Thomas Gosling (born November 12, 1980) is a Canadian actor. Prominent in both independent film and major studio features of varying genres, his films have accrued a worldwide box office gross of over 1.9 billion USD. He has received various accolades, including a Golden Globe Award, and nominations for two Academy Awards, a BAFTA and a Grammy Award.", "Ryan Gosling", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Ryan_Gosling_in_2018.jpg/330px-Ryan_Gosling_in_2018.jpg", 5 },
                    { 4, "Margot Elise Robbie (born 2 July 1990) is an Australian actress and producer. Known for her work in both blockbuster and independent films, she has received various accolades, including nominations for two Academy Awards, five BAFTA Awards and six Golden Globe Awards.", "Margot Robbie", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/33/SYDNEY%2C_AUSTRALIA_-_JANUARY_23_Margot_Robbie_arrives_at_the_Australian_Premiere_of_%27I%2C_Tonya%27_on_January_23%2C_2018_in_Sydney%2C_Australia_%2828074883999%29_%28cropped%29.jpg/330px-thumbnail.jpg", 5 },
                    { 5, "Emily Olivia Laura Blunt (born 23 February 1983) is a British actress. She is the recipient of several accolades, including a Golden Globe Award and a Screen Actors Guild Award, in addition to nominations for three British Academy Film Awards. Forbes ranked her as one of the highest-paid actresses in the world in 2020.", "Emily Blunt", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emily_Blunt_SAG_Awards_2019.png/330px-Emily_Blunt_SAG_Awards_2019.png", 4 },
                    { 6, "Cillian Murphy (born 25 May 1976) is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, a role he later reprised in the 2001 screen adaptation. His early film credits include the horror film 28 Days Later (2002), the dark comedy Intermission (2003), the thriller Red Eye (2005), the Irish war drama The Wind That Shakes the Barley (2006), and the science fiction thriller Sunshine (2007). He played a transgender Irish woman in the comedy-drama Breakfast on Pluto (2005), which earned him a Golden Globe Award nomination.", "Cillian Murphy", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Cillian_Murphy-2014.jpg/330px-Cillian_Murphy-2014.jpg", 4 },
                    { 7, "Henry Ewan Golding (born 5 February 1987) is a Malaysian-born British actor. Golding has been a presenter on BBC's The Travel Show since 2014. He is known for his film work, playing the role of Nick Young in Crazy Rich Asians (2018), the title character in the action-adventure Snake Eyes (2021), Sean Townsend in the thriller A Simple Favor (2018), and Tom in the romantic comedy Last Christmas (2019), the latter two directed by Paul Feig.", "Henry Golding", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Henry_Golding_%28edit%29.jpg/330px-Henry_Golding_%28edit%29.jpg", 3 },
                    { 8, "Emilia Isobel Euphemia Rose Clarke (born 23 October 1986) is a British actress. She is best known for her portrayal of Daenerys Targaryen in the HBO fantasy series Game of Thrones (2011–2019), for which she received nominations for four Primetime Emmy Awards.", "Emilia Clarke", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg/330px-Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg", 3 },
                    { 9, "Luke Antony Newman Treadaway (born 10 September 1984) is a British actor and singer. He won an Olivier Award for Best Leading Actor for his performance as Christopher in the National Theatre's production of The Curious Incident of the Dog in the Night-Time in 2013.", "Luke Treadaway", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg/330px-Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieId",
                table: "Actors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
