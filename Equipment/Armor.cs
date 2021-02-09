using WarriorWar.Enum;

namespace WarriorWar.Equipment
{
    public class Armor
    {
        private int armorPoint;

        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;

        public int ArmorPoint
        {
            get
            {
                return armorPoint;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoint = GOOD_GUY_ARMOR;
                    break;

                case Faction.BadGuy:
                    armorPoint = BAD_GUY_ARMOR;
                    break;
            }
        }
    }
}