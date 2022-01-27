using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Leather;
using Magic_Destroyers.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Melee
{
    public class Assasin : Melee
    {
        private const string DEFAULT_NAME = "Boby the Assasin";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 150;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        // We can not use constant on the objects, so we're gonna use readonly
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();


        private LightLeatherVest bodyArmor;
        private Sword weapon;

        // It has default initial values for everything
        public Assasin() // Default constructor 
            :this(DEFAULT_NAME, DEFAULT_LEVEL) // Chaining this ctor to the second ctor
        {
            
        }

        // It has default initial values except name and level
        public Assasin(string name, int level)
            :this(name,level, DEFAULT_HEALTHPOINTS) // Chaining this ctor to the 3rd ctor
        {

        }

        public Assasin(string name, int level, int healthPoints)
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
                if (value >= 0 && value <= 130)
                {
                    HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, this can't be smaller than 0");
                }
            }
        }

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            set
            {
                bodyArmor = value;
            }
        }

        public Sword Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public void Raze()
        {

        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }
    }
}
