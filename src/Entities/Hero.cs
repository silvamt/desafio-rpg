namespace desafio_rpg.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int level, int HP, int MP, string HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HP = HP;
            this.MP = MP;
            this.Herotype = HeroType;
        }

        public string Name;
        public int Level;

        public int HP;

        public int MP;
        public string Herotype;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Herotype;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada ";
        }
    }
}