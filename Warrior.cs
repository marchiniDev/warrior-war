using System;
using WarriorWar.Enum;
using WarriorWar.Equipment;

namespace WarriorWar
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HELTH = 21;
        private const int BAD_GUY_STARTING_HELTH = 21;

        private readonly Faction FACTION;
        private int health;
        private string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior(string name, Faction faction)
        {

            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HELTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HELTH;
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoint;

            enemy.health -= damage;
            AttackResult(enemy);
        }

        private void AttackResult(Warrior enemy)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead! {name} won!", ConsoleColor.Red);
            }
            else
            {
                Tools.ColorfulWriteLine($"{name} attacked {enemy.name}.", ConsoleColor.Green);
                Tools.ColorfulWriteLine($"Hemaining health is {enemy.health}.", ConsoleColor.Blue);
            }
        }
    }
}