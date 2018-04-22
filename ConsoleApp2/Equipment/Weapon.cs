using WarriorWars.Enum;
namespace WarriorWars.Equipment
{
    class Weapon
    {
        private int damage;
        private int goodGuyDamage;
        private int badGuyDamage;
        public int Damage
        {
            get
            {
                return damage;
            }

        }
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
            }
        }
    }
}
