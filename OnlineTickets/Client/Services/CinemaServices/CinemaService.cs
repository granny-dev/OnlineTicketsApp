using OnlineTickets.Shared;

namespace OnlineTickets.Client.Services.CinemaServices
{
    public class CinemaService : ICinemaService
    {
        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();

        public void GetCinemasList()
        {
            Cinemas = new()
            {

                new Cinema
                {
                    CinemaId= 1,
                    CinemaName = "Blokbaster",
                    CinemaLogo = "https://www.blockbuster.ua/upload/iblock/e9f/c8f1de7e046f5d6926dde59758622a77.jpg",
                    CinemaDescription = "Blokbuster is located near the subway station Petrovka and is housed within an entertainment complex that includes a cinema as well as a variety of other entertainments for all ages. In addition to a 3D IMAX theatre, 5D cinema, and a megaplex, the theatre also features bowling lanes, billiards tables, restaurants, slot machines, and skating rinks.",
                    Capacity = 50,
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
                    Capacity = 30,
                }



            };
        }
    }
}
