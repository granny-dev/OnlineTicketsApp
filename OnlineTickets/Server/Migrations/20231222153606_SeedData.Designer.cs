﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTickets.Server.Data;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231222153606_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("OnlineTickets.Shared.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActorBiography")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActorProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            ActorBiography = "Benedict Timothy Carlton Cumberbatch CBE (born 19 July 1976) is an English actor. Known for his work on screen and stage, he has received various accolades, including a BAFTA Award, a Primetime Emmy Award and a Laurence Olivier Award, in addition to nominations for two Academy Awards and four Golden Globes.",
                            ActorName = "Benedict Cumberbatch",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/BCumberbatch_Comic-Con_2019.jpg/330px-BCumberbatch_Comic-Con_2019.jpg",
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            ActorBiography = "Christopher Michael Pratt (born June 21, 1979) is an American actor. He rose to prominence for playing Andy Dwyer in the NBC sitcom Parks and Recreation (2009–2015). He also appeared in The WB drama series Everwood (2002–2006) and had supporting roles in the films Wanted (2008), Jennifer's Body (2009), Moneyball (2011), Zero Dark Thirty (2012), and Her (2013).",
                            ActorName = "Chris Pratt",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Chris_Pratt_2018.jpg/330px-Chris_Pratt_2018.jpg",
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 3,
                            ActorBiography = "Ryan Thomas Gosling (born November 12, 1980) is a Canadian actor. Prominent in both independent film and major studio features of varying genres, his films have accrued a worldwide box office gross of over 1.9 billion USD. He has received various accolades, including a Golden Globe Award, and nominations for two Academy Awards, a BAFTA and a Grammy Award.",
                            ActorName = "Ryan Gosling",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Ryan_Gosling_in_2018.jpg/330px-Ryan_Gosling_in_2018.jpg",
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 4,
                            ActorBiography = "Margot Elise Robbie (born 2 July 1990) is an Australian actress and producer. Known for her work in both blockbuster and independent films, she has received various accolades, including nominations for two Academy Awards, five BAFTA Awards and six Golden Globe Awards.",
                            ActorName = "Margot Robbie",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/33/SYDNEY%2C_AUSTRALIA_-_JANUARY_23_Margot_Robbie_arrives_at_the_Australian_Premiere_of_%27I%2C_Tonya%27_on_January_23%2C_2018_in_Sydney%2C_Australia_%2828074883999%29_%28cropped%29.jpg/330px-thumbnail.jpg",
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 5,
                            ActorBiography = "Emily Olivia Laura Blunt (born 23 February 1983) is a British actress. She is the recipient of several accolades, including a Golden Globe Award and a Screen Actors Guild Award, in addition to nominations for three British Academy Film Awards. Forbes ranked her as one of the highest-paid actresses in the world in 2020.",
                            ActorName = "Emily Blunt",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emily_Blunt_SAG_Awards_2019.png/330px-Emily_Blunt_SAG_Awards_2019.png",
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 6,
                            ActorBiography = "Cillian Murphy (born 25 May 1976) is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, a role he later reprised in the 2001 screen adaptation. His early film credits include the horror film 28 Days Later (2002), the dark comedy Intermission (2003), the thriller Red Eye (2005), the Irish war drama The Wind That Shakes the Barley (2006), and the science fiction thriller Sunshine (2007). He played a transgender Irish woman in the comedy-drama Breakfast on Pluto (2005), which earned him a Golden Globe Award nomination.",
                            ActorName = "Cillian Murphy",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Cillian_Murphy-2014.jpg/330px-Cillian_Murphy-2014.jpg",
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 7,
                            ActorBiography = "Henry Ewan Golding (born 5 February 1987) is a Malaysian-born British actor. Golding has been a presenter on BBC's The Travel Show since 2014. He is known for his film work, playing the role of Nick Young in Crazy Rich Asians (2018), the title character in the action-adventure Snake Eyes (2021), Sean Townsend in the thriller A Simple Favor (2018), and Tom in the romantic comedy Last Christmas (2019), the latter two directed by Paul Feig.",
                            ActorName = "Henry Golding",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Henry_Golding_%28edit%29.jpg/330px-Henry_Golding_%28edit%29.jpg",
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 8,
                            ActorBiography = "Emilia Isobel Euphemia Rose Clarke (born 23 October 1986) is a British actress. She is best known for her portrayal of Daenerys Targaryen in the HBO fantasy series Game of Thrones (2011–2019), for which she received nominations for four Primetime Emmy Awards.",
                            ActorName = "Emilia Clarke",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg/330px-Emilia_Clarke_at_the_2023_Harper%27s_Bazaar_Women_of_the_Year_Awards.jpg",
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 9,
                            ActorBiography = "Luke Antony Newman Treadaway (born 10 September 1984) is a British actor and singer. He won an Olivier Award for Best Leading Actor for his performance as Christopher in the National Theatre's production of The Curious Incident of the Dog in the Night-Time in 2013.",
                            ActorName = "Luke Treadaway",
                            ActorProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg/330px-Luke_Treadaway_in_Ordeal_by_Innocence_2018.jpg",
                            MovieId = 2
                        });
                });

            modelBuilder.Entity("OnlineTickets.Shared.Cinema", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CinemaDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CinemaLogo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CinemaName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            CinemaId = 1,
                            Capacity = 18,
                            CinemaDescription = "Blokbuster is located near the subway station Petrovka and is housed within an entertainment complex that includes a cinema as well as a variety of other entertainments for all ages. In addition to a 3D IMAX theatre, 5D cinema, and a megaplex, the theatre also features bowling lanes, billiards tables, restaurants, slot machines, and skating rinks.",
                            CinemaLogo = "https://www.blockbuster.ua/upload/iblock/e9f/c8f1de7e046f5d6926dde59758622a77.jpg",
                            CinemaName = "Blokbaster"
                        },
                        new
                        {
                            CinemaId = 2,
                            Capacity = 20,
                            CinemaDescription = "Cinema Citi hosts three rooms for watching films in 3D. Films are brought in from all genres and all parts of the world, including European films and Hollywood productions. A VIP hall features a popcorn bar, fresh juice bar, and other conveniences for those wanting to watch in comfort.",
                            CinemaLogo = "https://cinemaciti.ua/app/images/logo.svg",
                            CinemaName = "Cinema Citi"
                        },
                        new
                        {
                            CinemaId = 3,
                            Capacity = 16,
                            CinemaDescription = "Located near the Vokzalnaya metro station, the Butterfly Cinema is relatively new, having opened in 2004 in the Ultramarine Entertainment Centre. With six auditoriums, this cinema seats several hundred people in each room and in very comfortable, upholstered seats. Various films are featured here, including ones for adults as well as children, new hits, and old films.",
                            CinemaLogo = "https://www.kino-butterfly.com.ua/img/background.jpg",
                            CinemaName = "Butterfly Cinema"
                        });
                });

            modelBuilder.Entity("OnlineTickets.Shared.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CinemaName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProducerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reserved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SelectedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CinemaId = 1,
                            CinemaName = "Blokbaster",
                            EndDate = new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Cartoon",
                            MovieDescription = "The plot follows the Grinch and his pet dog Max who plan to stop Whoville's Christmas celebration by stealing all the town's decorations and gifts.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4f/The_Grinch%2C_final_poster.jpg",
                            MovieName = "The Grinch",
                            PlaceName = "",
                            Price = 20m,
                            ProducerId = 6,
                            ProducerName = "Chris Meledandri",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5749),
                            StartDate = new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        },
                        new
                        {
                            MovieId = 2,
                            CinemaId = 2,
                            CinemaName = "Cinema Citi",
                            EndDate = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Family",
                            MovieDescription = "James looks back at the last Christmas he and Bob spent scraping a living on the streets and how Bob helped him through one of his toughest times – providing strength, friendship and inspiration – and ultimately teaching each other about the true meaning of Christmas spirit along the way.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4b/Christmas_gift_from_bob_ver2.jpg/330px-Christmas_gift_from_bob_ver2.jpg",
                            MovieName = "A Gift from Bob",
                            PlaceName = "",
                            Price = 25m,
                            ProducerId = 5,
                            ProducerName = "Charles Martin Smith",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5828),
                            StartDate = new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        },
                        new
                        {
                            MovieId = 3,
                            CinemaId = 3,
                            CinemaName = "Butterfly Cinema",
                            EndDate = new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Romance",
                            MovieDescription = "Katarina \"Kate\" Andrich, a young aspiring singer, bounces around between her friends’ places, and has a dead-end job as an elf at a year-round Christmas shop in Central London, whose strict but good-hearted Chinese owner calls herself \"Santa\". Whilst at work, she notices a man outside staring upward and strikes up a conversation, learning that his name is Tom Webster and his oft-repeated life wisdom is to \"look up\" for things that others seldom observe.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Last_Christmas_poster.jpeg",
                            MovieName = "Last Christmas",
                            PlaceName = "",
                            Price = 22m,
                            ProducerId = 4,
                            ProducerName = "Paul Feig",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5832),
                            StartDate = new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        },
                        new
                        {
                            MovieId = 4,
                            CinemaId = 1,
                            CinemaName = "Blokbaster",
                            EndDate = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Drama",
                            MovieDescription = "Based on the 2005 biography American Prometheus by Kai Bird and Martin J. Sherwin, the film chronicles the career of Oppenheimer, with the story predominantly focusing on his studies, his direction of the Manhattan Project during World War II, and his eventual fall from grace due to his 1954 security hearing.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Oppenheimer_%28film%29.jpg",
                            MovieName = "Oppenheimer",
                            PlaceName = "",
                            Price = 28m,
                            ProducerId = 3,
                            ProducerName = "Christopher Nolan",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5835),
                            StartDate = new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        },
                        new
                        {
                            MovieId = 5,
                            CinemaId = 2,
                            CinemaName = "Cinema Citi",
                            EndDate = new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Comedy",
                            MovieDescription = "Based on the eponymous fashion dolls by Mattel, it is the first live-action Barbie film after numerous computer-animated films and specials.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0b/Barbie_2023_poster.jpg",
                            MovieName = "Barbie",
                            PlaceName = "",
                            Price = 24m,
                            ProducerId = 2,
                            ProducerName = "Greta Gerwig",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5839),
                            StartDate = new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        },
                        new
                        {
                            MovieId = 6,
                            CinemaId = 3,
                            CinemaName = "Butterfly Cinema",
                            EndDate = new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MovieCategory = "Comedy",
                            MovieDescription = "Italian-American brothers Mario and Luigi have recently opened a plumbing business in Brooklyn, to the derision of their ex-employer Spike and the disapproval of their father. After seeing a significant water main leak on the news, Mario and Luigi go underground to fix it but are sucked into a Warp Pipe and separated.",
                            MovieImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/The_Super_Mario_Bros._Movie_poster.jpg",
                            MovieName = "The Super Mario Bros. Movie",
                            PlaceName = "",
                            Price = 27m,
                            ProducerId = 1,
                            ProducerName = "Aaron Horvath",
                            Qty = 0,
                            Reserved = 10,
                            SelectedDate = new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5842),
                            StartDate = new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Available"
                        });
                });

            modelBuilder.Entity("OnlineTickets.Shared.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProducerBiography")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProducerProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            ProducerId = 1,
                            ProducerBiography = "Aaron James Horvath (born August 19, 1980) is an American animator, screenwriter, producer, and director.",
                            ProducerName = "Aaron Horvath",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Aaron_Horvath_by_Gage_Skidmore.jpg/330px-Aaron_Horvath_by_Gage_Skidmore.jpg"
                        },
                        new
                        {
                            ProducerId = 2,
                            ProducerBiography = "Greta Celeste Gerwig (born August 4, 1983) is an American actress, writer, and director.",
                            ProducerName = "Greta Gerwig",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg/330px-Greta_Gerwig_at_Barbie_Movie_Reception_%28headshot%29.jpg"
                        },
                        new
                        {
                            ProducerId = 3,
                            ProducerBiography = "Christopher Edward Nolan CBE (born 30 July 1970) is a British and American film director, screenwriter, and producer.",
                            ProducerName = "Christopher Nolan",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/330px-Christopher_Nolan_Cannes_2018.jpg"
                        },
                        new
                        {
                            ProducerId = 4,
                            ProducerBiography = "Paul Feig( born September 17, 1962) is an American filmmaker, actor, and comedian",
                            ProducerName = "Paul Feig",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/44/Paul_Feig.jpg"
                        },
                        new
                        {
                            ProducerId = 5,
                            ProducerBiography = "Charles Martin Smith (born October 30, 1953) is an American actor, writer, and director of film and television based in British Columbia, Canada.",
                            ProducerName = "Charles Martin Smith",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/CharlesMartinSmith08TIFF.jpg/330px-CharlesMartinSmith08TIFF.jpg"
                        },
                        new
                        {
                            ProducerId = 6,
                            ProducerBiography = "Christopher Meledandri (/mɛləˈdɑːndri/;[1] born May 15, 1959) is an American film producer and founder and CEO of Illumination.",
                            ProducerName = "Chris Meledandri",
                            ProducerProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg/330px-Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg"
                        });
                });

            modelBuilder.Entity("OnlineTickets.Shared.Movie", b =>
                {
                    b.HasOne("OnlineTickets.Shared.Cinema", null)
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTickets.Shared.Producer", null)
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTickets.Shared.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("OnlineTickets.Shared.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
