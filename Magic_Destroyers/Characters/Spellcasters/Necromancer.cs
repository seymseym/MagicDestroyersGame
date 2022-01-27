using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Equipments.Armors.Leather;
using Magic_Destroyers.Equipments.Weapons.Blunt;
using Magic_Destroyers.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "The Necro Guy";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Spellcasters;

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();


        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public Necromancer() // Default constructor 
            : this(DEFAULT_NAME, DEFAULT_LEVEL) // Chaining this ctor to the second ctor
        {

        }

        // It has default initial values except name and level
        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS) // Chaining this ctor to the 3rd ctor
        {

        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = 80;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        public override int HealthPoints
        {
            get { return base.HealthPoints; }
            set
            {
                if (value >= 0 && value <= 140)
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
            set { bodyArmor = value; }
        }

        private Sword Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public void ShadowRage()
        {

        }

        public void VampireTouch()
        {

        }

        public void BoneShield()
        {

        }
    }
}
