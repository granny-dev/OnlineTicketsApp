using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.ActorServices
{
    public class ActorService : IActorService
    {
        public List<Actor> Actors { get; set; } = new List<Actor>();

        public void GetActorsList()
        {
            Actors = new()
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
        }
    }
}
