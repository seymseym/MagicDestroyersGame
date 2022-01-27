using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;
        public virtual int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, it should be min 0 and max 10");
                }
            }
        }

    }
}
