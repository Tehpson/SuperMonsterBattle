using AngeredSimulator.Models;
using System.Collections.Generic;

namespace Angeredsimulator.Models
{
    public class Gang
    {
        public Gang(string name)
        {
            Name = name;
        }

        public Gang(int id, string name, string descripton, List<Creature> creatures, int riches)
        {
            Id = id;
            Name = name;
            Description = descripton;
            GangBangers = creatures;
            Riches = riches;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Creature> GangBangers { get; set; } = [];
        public int Riches { get; set; }
    }
    public class Gangs
    {
        public Gangs()
        {
            List<Gang> gangs =
            [
                new Gang(0,
                         "ÖstenGang",
                         "Ett gäng fattiga IT-stundenter som inte har något att leva för. Det gäller att passa sig då de inte tänker helt rakt",
                         [new Creature("Lil-Garell", 100, 6, 10), new Creature("Bans", 70, 2, 39), new Creature("TennyBoii", 150, 3, 6), new Creature("Per", 5, 100, 2)], 
                         10000),
                new Gang(1,
                        "SugGråGang",
                        "De gömmer sig i skuggarna och är snabbare än vinden",
                        [new Creature("ALiibabba",70,26,34), new Creature("Mohammed", 79, 24, 53),], //TODO: lägg til flera
                        60000)
            ];
            GangsList.AddRange(gangs);
        }
    public List<Gang> GangsList { get; set; } = [];

    }
}