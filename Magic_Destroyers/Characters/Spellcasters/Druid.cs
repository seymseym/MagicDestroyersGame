using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Leather;
using Magic_Destroyers.Equipments.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Android the Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Spellcasters;

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        public Druid() // Default constructor 
            : this(DEFAULT_NAME, DEFAULT_LEVEL) // Chaining this ctor to the second ctor
        {

        }

        // It has default initial values except name and level
        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS) // Chaining this ctor to the 3rd ctor
        {

        }

        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            base.ManaPoints = 100;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
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

        public override int ManaPoints 
        {
            get
            {
                return base.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    base.ManaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, it should be min 0 and max 10");
                }
            }
        }

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        private Staff Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public void MoonFire()
        {

        }

        public void StarBurst()
        {

        }

        public void OneWithNature()
        {

        }
    }
}
