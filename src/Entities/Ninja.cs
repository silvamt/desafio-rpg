namespace desafio_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int level, int HP, int MP, string HeroType) : base(Name, level, HP, MP, HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HP = HP;
            this.MP = MP;
            this.Herotype = "Ninja";
        }

        public override string Attack()
        {
            return this.Name + " fez golpe ninja ";
        }

    }
}