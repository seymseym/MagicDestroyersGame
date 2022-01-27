using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Light;
using Magic_Destroyers.Equipments.Weapons.Blunt;
using Magic_Destroyers.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Gargamel the Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Spellcasters;

        private readonly ClothRobe DEFAULT_BODYARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        private ClothRobe bodyArmor;
        private Staff weapon;

        public Mage() // Default constructor 
            : this(DEFAULT_NAME, DEFAULT_LEVEL) // Chaining this ctor to the second ctor
        {

        }

        // It has default initial values except name and level
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS) // Chaining this ctor to the 3rd ctor
        {

        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            this.ManaPoints = 150;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }
        public override int HealthPoints
        {
            get { return base.HealthPoints; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, this can't be smaller than 0");
                }
            }
        }
        public ClothRobe BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        private Staff Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public void ArcaneWrath()
        {

        }

        public void FireWall()
        {

        }

        public void Meditation()
        {

        }
    }
}
