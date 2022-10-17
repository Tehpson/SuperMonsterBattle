namespace SuperMonsterBattle.Models
{
    interface ICreature
    {
        public string Name { get; set; }
        public uint HP { get; set; }
        public uint Exp { get; set; }
        public void TakeDamage(int damage);
        public void GiveDamage();

    }
}
