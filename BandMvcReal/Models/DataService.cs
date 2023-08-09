namespace BandMvcReal.Models
{

    
        public class DataService
        {
            List<Band> bands = new List<Band>()
        {
            new Band {Id = 1, Name = "The Beatles", 
                //Picture = "./Views/Pictures/Beatles.jpg",
                Picture = "Pictures/Beatles.jpg",
                Description = "The Beatles were an English rock band formed in Liverpool in 1960. With a line-up comprising John Lennon, Paul McCartney, George Harrison and Ringo Starr, they are regarded as the most influential band of all time." },
            new Band {Id = 2, Name = "The Rolling Stones",
                Picture = "Pictures/Therollingstones.jpg",
                Description = "The Rolling Stones are an English rock band formed in London in 1962. The first stable line-up consisted of bandleader Brian Jones, Mick Jagger, Keith Richards, Bill Wyman, Charlie Watts, and Ian Stewart." },
            new Band {Id = 3, Name = "The Who", 
                Picture = "Pictures/TheWho.png", 
                Description = "The Who are an English rock band formed in London in 1964. Their classic line-up consisted of lead singer Roger Daltrey, guitarist and singer Pete Townshend, bass guitarist John Entwistle, and drummer Keith Moon." },
            new Band {Id = 4, Name = "Led Zeppelin", Picture = "Pictures/LedZeppelin.jpg", Description = "Led Zeppelin were an English rock band formed in London in 1968. The group consisted of vocalist Robert Plant, guitarist Jimmy Page, bassist/keyboardist John Paul Jones, and drummer John Bonham." },
            new Band {Id = 5, Name = "Pink Floyd", Picture = "PinkFloyd.jpg", Description = "Pink Floyd were an English rock band formed in London in 1965. Gaining a following as a psychedelic pop group, they were distinguished for their extended compositions, sonic experimentation, philosophical lyrics and elaborate live shows, and became a leading band of the progressive rock genre." },


        };

            public Band GetBandById(int id)
            {

                return bands.FirstOrDefault(b => b.Id == id);
            }

            public Band[] GetAllBands()
            {
                return bands
                    .OrderBy(p => p.Name)
                    .ToArray();
            }
        }
    }


