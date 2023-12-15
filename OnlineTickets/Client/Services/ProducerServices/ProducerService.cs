using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ProducerServices
{
    public class ProducerService : IProducerService
    {
        public List<Producer> Producers { get; set; } = new List<Producer>();

        public void GetProducersList()
        {
            Producers = new()
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
                ProducerBiography = "Greta Celeste Gerwig (/ˈɡɜːrwɪɡ/;[1] born August 4, 1983) is an American actress, writer, and director.",
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
        
        }
    }
}
