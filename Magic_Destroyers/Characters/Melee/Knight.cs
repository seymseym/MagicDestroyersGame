using Magic_Destroyers.Equipments.Armors.Heavy;
using Magic_Destroyers.Equipments.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private int healtPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        public Hammer weapon;

        public Knight()
            :this("Holly Knight", 1, 120)
        {

        }

        public Knight(string name, int level)
            :this(name, level, 120)
        {

        }

        public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = "Melee";
            this.AbilityPoints = 100;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Hammer();
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, it should be min 0 and max 10");
                }
            }
        }

        public int HealthPoints
        {
            get { return healtPoints; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    healtPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, this can't be smaller than 0");
                }
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, this can't be smaller than 0");
                }

            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "The faction should be either Melee or Spellcaster");
                }
            }
        }

        public Chainlink BodyArmor
        {
            get { return bodyArmor; }
            set
            {
                bodyArmor = value;
            }
        }
        public Hammer Weapon
        {
            get { return weapon; }
            set
            {
                weapon = value;
            }
        }

        public void HolyBlow()
        {

        }

        public void PurifySoul()
        {

        }

        public void RighteousWings()
        {

        }
    }
}
