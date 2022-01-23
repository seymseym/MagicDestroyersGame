using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Equipments.Weapons.Blunt
{
    public class Hammer
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "damage can not be smaller than 1");

                }
            }
        }
        public Hammer()
        {

        }

        public void Stun()
        {

        }
    }
}
