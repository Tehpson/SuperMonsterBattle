namespace SuperMonsterBattle.Models
{
    internal class Creature
    {
        public string Name { get; private set; }

        public uint HP
        {
            get
            {
                return HP;
            }
            set
            {
                if (value > HP)
                {
                    Dead = true;
                    HP = 0;
                }
            }
        }

        public uint Exp { get; private set; }
        public uint Damage { get; set; }
        public bool Dead { get; private set; }

        public Creature(string Name, uint HP, uint Damage)
        {
            this.Name = Name;
            this.HP = HP;
            this.Damage = Damage;
        }

        public uint GiveDamage()
        {
            return Damage;
        }

        public virtual uint TakeDamage(uint damage)
        {
            if (damage < 0)
            {
                return 0;
            }
            else
            {
                HP -= damage;
                return damage;
            }
        }
    }
}