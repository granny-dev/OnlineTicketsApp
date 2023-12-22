using Microsoft.EntityFrameworkCore;
using OnlineTickets.Shared;

namespace OnlineTickets.Server.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                List<Actor> Actors = new()
                {
                        new Actor
                        {
                            ActorId = 1,
                            ActorName = "Benedict Cumberbatch",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/BCumberbatch_Comic-Con_2019.jpg/330px-BCumberbatch_Comic-Con_2019.jpg",
                            ActorBiography = "Benedict Timothy Carlton Cumberbatch CBE (born 19 July 1976) is an English actor. Known for his work on screen and stage, he has received various accolades, including a BAFTA Award, a Primetime Emmy Award and a Laurence Olivier Award, in addition to nominations for two Academy Awards and four Golden Globes.",
                            MovieId = 1
                        },
                        new Actor
                        {
                            ActorId = 2,
                            ActorName = "Chris Pratt",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Chris_Pratt_2018.jpg/330px-Chris_Pratt_2018.jpg",
                            ActorBiography = "Christopher Michael Pratt (born June 21, 1979) is an American actor. He rose to prominence for playing Andy Dwyer in the NBC sitcom Parks and Recreation (2009–2015). He also appeared in The WB drama series Everwood (2002–2006) and had supporting roles in the films Wanted (2008), Jennifer's Body (2009), Moneyball (2011), Zero Dark Thirty (2012), and Her (2013).",
                            MovieId = 6
                        },
                        new Actor
                        {
                            ActorId = 3,
                            ActorName = "Ryan Gosling",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Ryan_Gosling_in_2018.jpg/330px-Ryan_Gosling_in_2018.jpg",
                            ActorBiography = "Ryan Thomas Gosling (born November 12, 1980) is a Canadian actor. Prominent in both independent film and major studio features of varying genres, his films have accrued a worldwide box office gross of over 1.9 billion USD. He has received various accolades, including a Golden Globe Award, and nominations for two Academy Awards, a BAFTA and a Grammy Award.",
                            MovieId = 5
                        },
                        new Actor
                        {
                            ActorId = 4,
                            ActorName = "Margot Robbie",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/33/SYDNEY%2C_AUSTRALIA_-_JANUARY_23_Margot_Robbie_arrives_at_the_Australian_Premiere_of_%27I%2C_Tonya%27_on_January_23%2C_2018_in_Sydney%2C_Australia_%2828074883999%29_%28cropped%29.jpg/330px-thumbnail.jpg",
                            ActorBiography = "Margot Elise Robbie (born 2 July 1990) is an Australian actress and producer. Known for her work in both blockbuster and independent films, she has received various accolades, including nominations for two Academy Awards, five BAFTA Awards and six Golden Globe Awards.",
                            MovieId = 5
                        },
                        new Actor
                        {
                            ActorId = 5,
                            ActorName = "Emily Blunt",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emily_Blunt_SAG_Awards_2019.png/330px-Emily_Blunt_SAG_Awards_2019.png",
                            ActorBiography = "Emily Olivia Laura Blunt (born 23 February 1983) is a British actress. She is the recipient of several accolades, including a Golden Globe Award and a Screen Actors Guild Award, in addition to nominations for three British Academy Film Awards. Forbes ranked her as one of the highest-paid actresses in the world in 2020.",
                            MovieId= 4
                        },
                        new Actor
                        {
                            ActorId = 6,
                            ActorName = "Cillian Murphy",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Cillian_Murphy-2014.jpg/330px-Cillian_Murphy-2014.jpg",
                            ActorBiography = "Cillian Murphy (born 25 May 1976) is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, a role he later reprised in the 2001 screen adaptation. His early film credits include the horror film 28 Days Later (2002), the dark comedy Intermission (2003), the thriller Red Eye (2005), the Irish war drama The Wind That Shakes the Barley (2006), and the science fiction thriller Sunshine (2007). He played a transgender Irish woman in the comedy-drama Breakfast on Pluto (2005), which earned him a Golden Globe Award nomination.",
                            MovieId = 4
                        },
                        new Actor
                        {
                            ActorId = 7,
                            ActorName = "Henry Golding",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Henry_Golding_%28edit%29.jpg/330px-Henry_Golding_%28edit%29.jpg",
                            ActorBiography = "Henry Ewan Golding (born 5 February 1987) is a Malaysian-born British actor. Golding has been a presenter on BBC's The Travel Show since 2014. He is known for his film work, playing the role of Nick Young in Crazy Rich Asians (2018), the title character in the action-adventure Snake Eyes (2021), Sean Townsend in the thriller A Simple Favor (2018), and Tom in the romantic comedy Last Christmas (2019), the latter two directed by Paul Feig.",
                            MovieId = 3
                        },
                        new Actor
                        {
                            ActorId = 8,
                            ActorName = "Emilia Clarke",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg/330px-Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg",
                            ActorBiography = "Emilia Isobel Euphemia Rose Clarke (born 23 October 1986) is a British actress. She is best known for her portrayal of Daenerys Targaryen in the HBO fantasy series Game of Thrones (2011–2019), for which she received nominations for four Primetime Emmy Awards.",
                            MovieId = 3
                        },
                        new Actor
                        {
                            ActorId = 9,
                            ActorName = "Luke Treadaway",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg/330px-Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg",
                            ActorBiography = "Luke Antony Newman Treadaway (born 10 September 1984) is a British actor and singer. He won an Olivier Award for Best Leading Actor for his performance as Christopher in the National Theatre's production of The Curious Incident of the Dog in the Night-Time in 2013.",
                            MovieId = 2
                        }
                };
            modelBuilder.Entity<Actor>().HasData(Actors);

             List<Cinema> Cinemas = new()
             {
                new Cinema
                {
                    CinemaId= 1,
                    CinemaName = "Blokbaster",
                    CinemaLogo = "https://www.blockbuster.ua/upload/iblock/e9f/c8f1de7e046f5d6926dde59758622a77.jpg",
                    CinemaDescription = "Blokbuster is located near the subway station Petrovka and is housed within an entertainment complex that includes a cinema as well as a variety of other entertainments for all ages. In addition to a 3D IMAX theatre, 5D cinema, and a megaplex, the theatre also features bowling lanes, billiards tables, restaurants, slot machines, and skating rinks.",
                    Capacity = 18,
                },
                new Cinema
                {
                    CinemaId= 2,
                    CinemaName = "Cinema Citi",
                    CinemaLogo = "https://cinemaciti.ua/app/images/logo.svg",
                    CinemaDescription = "Cinema Citi hosts three rooms for watching films in 3D. Films are brought in from all genres and all parts of the world, including European films and Hollywood productions. A VIP hall features a popcorn bar, fresh juice bar, and other conveniences for those wanting to watch in comfort.",
                    Capacity = 20,
                },
                new Cinema
                {
                    CinemaId= 3,
                    CinemaName = "Butterfly Cinema",
                    CinemaLogo = "https://www.kino-butterfly.com.ua/img/background.jpg",
                    CinemaDescription = "Located near the Vokzalnaya metro station, the Butterfly Cinema is relatively new, having opened in 2004 in the Ultramarine Entertainment Centre. With six auditoriums, this cinema seats several hundred people in each room and in very comfortable, upholstered seats. Various films are featured here, including ones for adults as well as children, new hits, and old films.",
                    Capacity = 16,
                }
             };
            modelBuilder.Entity<Cinema>().HasData(Cinemas);

            List<Movie> Movies = new()
            {
                new Movie
                {
                    MovieId = 1,
                    MovieName = "The Grinch",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4f/The_Grinch%2C_final_poster.jpg",
                    MovieCategory = "Cartoon",
                    MovieDescription = "The plot follows the Grinch and his pet dog Max who plan to stop Whoville's Christmas celebration by stealing all the town's decorations and gifts.",

                    ProducerId = 6,
                    ProducerName = "Chris Meledandri",
                    CinemaId = 1,
                    CinemaName = "Blokbaster",
                    StartDate = new DateTime(2024 ,2,2),
                    EndDate = new DateTime(2024 ,2,11),
                    Reserved = 10,
                    Price = 20

                },
                new Movie
                {
                    MovieId = 2,
                    MovieName = "A Gift from Bob",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4b/Christmas_gift_from_bob_ver2.jpg/330px-Christmas_gift_from_bob_ver2.jpg",
                    MovieCategory = "Family",
                    MovieDescription = "James looks back at the last Christmas he and Bob spent scraping a living on the streets and how Bob helped him through one of his toughest times – providing strength, friendship and inspiration – and ultimately teaching each other about the true meaning of Christmas spirit along the way.",

                    ProducerId = 5,
                    ProducerName = "Charles Martin Smith",
                    CinemaId = 2,
                    CinemaName = "Cinema Citi",
                    StartDate = new DateTime(2024 ,2,9),
                    EndDate = new DateTime(2024 ,2,18),
                    Reserved = 10,
                    Price = 25

                },
                new Movie
                {
                    MovieId = 3,
                    MovieName = "Last Christmas",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Last_Christmas_poster.jpeg",
                    MovieCategory = "Romance",
                    MovieDescription = "Katarina \"Kate\" Andrich, a young aspiring singer, bounces around between her friends’ places, and has a dead-end job as an elf at a year-round Christmas shop in Central London, whose strict but good-hearted Chinese owner calls herself \"Santa\". Whilst at work, she notices a man outside staring upward and strikes up a conversation, learning that his name is Tom Webster and his oft-repeated life wisdom is to \"look up\" for things that others seldom observe.",

                    ProducerId = 4,
                    ProducerName = "Paul Feig",
                    CinemaId = 3,
                    CinemaName = "Butterfly Cinema",
                    StartDate = new DateTime(2024 ,2,2),
                    EndDate = new DateTime(2024 ,2,11),
                    Reserved = 10,
                    Price = 22

                },
                new Movie
                {
                    MovieId = 4,
                    MovieName = "Oppenheimer",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Oppenheimer_%28film%29.jpg",
                    MovieCategory = "Drama",
                    MovieDescription = "Based on the 2005 biography American Prometheus by Kai Bird and Martin J. Sherwin, the film chronicles the career of Oppenheimer, with the story predominantly focusing on his studies, his direction of the Manhattan Project during World War II, and his eventual fall from grace due to his 1954 security hearing.",

                    ProducerId = 3,
                    ProducerName = "Christopher Nolan",
                    CinemaId = 1,
                    CinemaName = "Blokbaster",
                    StartDate = new DateTime(2024 ,2,9),
                    EndDate = new DateTime(2024 ,2,18),
                    Reserved = 10,
                    Price = 28

                },
                new Movie
                {
                    MovieId = 5,
                    MovieName = "Barbie",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0b/Barbie_2023_poster.jpg",
                    MovieCategory = "Comedy",
                    MovieDescription = "Based on the eponymous fashion dolls by Mattel, it is the first live-action Barbie film after numerous computer-animated films and specials.",

                    ProducerId = 2,
                    ProducerName = "Greta Gerwig",
                    CinemaId = 2,
                    CinemaName = "Cinema Citi",
                    StartDate = new DateTime(2024 ,2,2),
                    EndDate = new DateTime(2024 ,2,11),
                    Reserved = 10,
                    Price = 24

                },
                new Movie
                {
                    MovieId = 6,
                    MovieName = "The Super Mario Bros. Movie",
                    MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/The_Super_Mario_Bros._Movie_poster.jpg",
                    MovieCategory = "Comedy",
                    MovieDescription = "Italian-American brothers Mario and Luigi have recently opened a plumbing business in Brooklyn, to the derision of their ex-employer Spike and the disapproval of their father. After seeing a significant water main leak on the news, Mario and Luigi go underground to fix it but are sucked into a Warp Pipe and separated.",

                    ProducerId = 1,
                    ProducerName = "Aaron Horvath",
                    CinemaId = 3,
                    CinemaName = "Butterfly Cinema",
                    StartDate = new DateTime(2024 ,2,9),
                    EndDate = new DateTime(2024 ,2,18),
                    Reserved = 10,
                    Price = 27

                }
            };
            modelBuilder.Entity<Movie>().HasData(Movies);

            List<Producer> Producers = new()
            {
                new Producer
                {
                    ProducerId = 1,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Aaron_Horvath_by_Gage_Skidmore.jpg/330px-Aaron_Horvath_by_Gage_Skidmore.jpg",
                    ProducerName = "Aaron Horvath",
                    ProducerBiography = "Aaron James Horvath (born August 19, 1980) is an American animator, screenwriter, producer, and director.",
                },
                new Producer
                {
                    ProducerId = 2,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg/330px-Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg",
                    ProducerName = "Greta Gerwig",
                    ProducerBiography = "Greta Celeste Gerwig (born August 4, 1983) is an American actress, writer, and director.",
                },
                new Producer
                {
                    ProducerId = 3,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/330px-Christopher_Nolan_Cannes_2018.jpg",
                    ProducerName = "Christopher Nolan",
                    ProducerBiography = "Christopher Edward Nolan CBE (born 30 July 1970) is a British and American film director, screenwriter, and producer.",
                },
                new Producer
                {
                    ProducerId = 4,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/44/Paul_Feig.jpg",
                    ProducerName = "Paul Feig",
                    ProducerBiography = "Paul Feig( born September 17, 1962) is an American filmmaker, actor, and comedian",
                },
                new Producer
                {
                    ProducerId = 5,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/CharlesMartinSmith08TIFF.jpg/330px-CharlesMartinSmith08TIFF.jpg",
                    ProducerName = "Charles Martin Smith",
                    ProducerBiography = "Charles Martin Smith (born October 30, 1953) is an American actor, writer, and director of film and television based in British Columbia, Canada.",
                },
                new Producer
                {
                    ProducerId = 6,
                    ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg/330px-Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg",
                    ProducerName = "Chris Meledandri",
                    ProducerBiography = "Christopher Meledandri (/mɛləˈdɑːndri/;[1] born May 15, 1959) is an American film producer and founder and CEO of Illumination."
                }
            };
            modelBuilder.Entity<Producer>().HasData(Producers);
        }
        
               
    }

        
}
