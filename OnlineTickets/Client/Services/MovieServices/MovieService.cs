using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.MovieServices;

public class MovieService : IMovieService
{
    
    public List<Movie>Movies { get; set; } = new List<Movie>();

    public void GetMoviesList()
    {
        Movies = new List<Movie>()
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
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7),
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
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(10),
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
                StartDate = DateTime.Now.AddDays(7),
                EndDate = DateTime.Now.AddDays(14),
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
                StartDate = DateTime.Now.AddDays(2),
                EndDate = DateTime.Now.AddDays(9),
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
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7),
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
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(8),
                Price = 27

            }
        };
    }
}
