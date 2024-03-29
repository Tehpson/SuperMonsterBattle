﻿namespace AngeredSimulator.Models
{
    public class Creature
    {
        public string Name { get; private set; }

        private int hp;
        public int HP
        {
            get => hp;
            set
            {
                if (value < 0)
                {
                    Dead = true;
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }

        public uint Exp { get; private set; }
        public uint Damage { get; set; }
        public bool Dead { get; private set; }

        public int Speed { get; set; }

        public Creature(string Name, int HP, uint Damage, int Speed)
        {
            this.Name = Name;
            this.HP = HP;
            this.Damage = Damage;
            this.Speed = Speed;
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
                HP -= (int)damage;
                return damage;
            }
        }
    }
}