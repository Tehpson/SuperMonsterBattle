namespace SuperMonsterBattle.Models
{
    internal interface ICreature
    {
        /// <summary>
        /// Name of Creature
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Health of Creature
        /// </summary>
        public uint HP { get; }

        /// <summary>
        /// Experince of Creature
        /// </summary>
        public uint Exp { get; }

        /// <summary>
        /// Attack damage creature have
        /// </summary>
        public uint Damage { get; }

        /// <summary>
        /// if dead
        /// </summary>
        public bool Dead { get; }

        /// <summary>
        /// reduce HP of creatuer
        /// </summary>
        /// <param name="damage">how much get attack with</param>
        /// <returns>true damage taken</returns>
        public uint TakeDamage(int damage);

        /// <summary>
        /// Give Damage
        /// </summary>
        /// <returns> true damage given</returns>
        public uint GiveDamage();
    }
}