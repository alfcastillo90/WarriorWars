using WarriorWars.Enum;
namespace WarriorWars.Equipment
{
    class Armor
    {
        private int armorPoints;
        private int goodGuyArmor;
        private int badGuyArmor;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = goodGuyArmor;
                    break;
                case Faction.BadGuy:
                    armorPoints = badGuyArmor;
                    break;
            }
        }
    }
}
