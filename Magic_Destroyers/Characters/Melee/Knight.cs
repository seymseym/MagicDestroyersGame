using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Heavy;
using Magic_Destroyers.Equipments.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Holly Knight";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();


        private Chainlink bodyArmor;
        public Hammer weapon;

        public Knight()
            :this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS)
        {

        }

        public Knight(string name, int level)
            :this(name, level, DEFAULT_ABILITYPOINTS)
        {

        }

        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public override int HealthPoints
        {
            get { return base.HealthPoints; }
            set
            {
                if (value >= 0 && value <= 110)
                {
                    HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, this can't be smaller than 0");
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
