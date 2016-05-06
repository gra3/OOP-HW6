using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Armor
    {
        protected Armor(int durability, int protection)
        {
            Durability = durability;
            Protection = protection;
        }
        public int Durability;
        public int Protection;
    }


    public class PlateArmor : Armor
    {
        public PlateArmor()
            : base(100, 100)
        {
        }

    }
    
    public class ChainArmor : Armor
    {
        public ChainArmor()
            : base(100, 100)
        {
        }
    }
    public class ScaleArmor : Armor
    {
        ScaleArmor()
            : base(100, 100)
        {
        }
    }

    public class RingArmor : Armor
    {
        RingArmor()
            : base(100, 100)
        {
        }
    }

    public class LeatherArmor : Armor
    {
        public LeatherArmor()
            : base(100, 100)
        {
            Durability = 100;
            Protection = 10;
        }
    }

    public class Pants : Armor
    {
        public Pants()
            : base(100, 100)
        {
            Durability = 100;
            Protection = 1;
        }
    }


}