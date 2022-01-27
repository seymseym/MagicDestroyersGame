using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Melee
{
    public class Melee : Character
    {
        private int abilityPoints;
        public virtual int AbilityPoints
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
    }
}
