using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Equipments.Armors.Leather
{
    public class LightLeatherVest
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (armorPoints >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Point can not be smaller than 1");
                }
            }
        }
        public LightLeatherVest()
        {

        }
    }
}
