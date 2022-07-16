namespace desafio_rpg.src.Entities
{
    public class BlackWizard : WhiteWizard
    {
        public BlackWizard(string Name, int level, int HP, int MP, string HeroType) : base(Name, level, HP, MP, HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HP = HP;
            this.MP = MP;
            this.Herotype = "BlackWizard";
        }
      
    }
}