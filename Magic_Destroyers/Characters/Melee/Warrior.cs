using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Heavy;
using Magic_Destroyers.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Melee
{
    public class Warrior : Melee
    {

        private const string DEFAULT_NAME = "Chucky the Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();


        private Chainlink bodyArmor;
        private Axe weapon;

        public Warrior() // Default constructor 
            : this(DEFAULT_NAME, DEFAULT_LEVEL) // Chaining this ctor to the second ctor
        {

        }

        // It has default initial values except name and level
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS) // Chaining this ctor to the 3rd ctor
        {

        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        public override int HealthPoints
        {
            get { return base.HealthPoints; }
            set
            {
                if (value >= 0 && value <= 150)
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
            set { bodyArmor = value; }
        }
        public Axe Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
