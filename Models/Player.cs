using Angeredsimulator.Models;
using System.Collections.Generic;

namespace AngeredSimulator.Models
{
    internal class Player(string Name, int HP, uint Damage, int Speed, double money) : Creature(Name, HP, Damage, Speed)
    {
        public List<StoreItem> Cloth { get; set; } = [];
        public List<DrugItem> Stash { get; set; } = [];
        public double Money { get; set; } = money;
        public Dictionary<Gang, uint> GangRep { get; set; } = new Dictionary<Gang, uint>();

        public void GangUpdateGangRep(Gang gangToUpdate, int newValue)
        {
            if (GangRep.ContainsKey(gangToUpdate))
            {
                GangRep[gangToUpdate] = (uint)newValue;
            }
        }

        public override uint TakeDamage(uint damage)
        {
            //TODO:Add item buff
            var damageTaken = damage;
            if (damage < 0)
            {
                return 0;
            }
            else
            {
                HP -= (int)damageTaken;
                return damageTaken;
            }
        }
    }
}