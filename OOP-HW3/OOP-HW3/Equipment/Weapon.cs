using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Weapon
    {
        protected int Durability { get; set; }
        protected int Damage { get; set; }

        protected Weapon(int damage)
        {
            Durability = 100;
            Damage = damage;
        }
    }

    public class MainHand : Weapon
    {
        protected bool TwoHanded { get; set; }

        protected MainHand(bool isTwoHanded)
            : base(50)
        {
            if (isTwoHanded)
            {
                TwoHanded = true;
                Damage = 110;
            }
            else TwoHanded = false;
        }
    }

    public class OffHand : Weapon
    {
        protected uint ArmorRating { get; set; }

        protected OffHand(uint armorRating)
            : base(50)
        {
            ArmorRating = armorRating;
            if (ArmorRating > 0) Damage = 0;    //If it has armor, its a shield, no damage
        }
    }

    public class Zweihander : MainHand
    {
        public Zweihander()
            : base(true)
        {
        }
    }

    public class Gladius : MainHand
    {
        public Gladius()
            : base(false)
        {
        }
    }

    public class RoundShield : OffHand
    {
        public RoundShield()
            : base(70)
        {
        }
    }

    public class TowerShield : OffHand
    {
        public TowerShield()
            : base(120)
        {
        }
    }

    //Offhand example that isn't a shield
    public class Focus : OffHand
    {
        public Focus()
            : base(0)
        {
        }
    }



}