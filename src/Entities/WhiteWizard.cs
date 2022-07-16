namespace desafio_rpg.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int level, int HP, int MP, string HeroType) : base(Name, level, HP, MP, HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HP = HP;
            this.MP = MP;
            this.Herotype = "WhiteWizard";
        }

        public override string Attack()
        {
            return this.Name + " lançou magia ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou super magia com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " lançou magia normal com bônus de ataque de " + Bonus;
            }

        }
    }
}