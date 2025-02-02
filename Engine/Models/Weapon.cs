﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    // the Weapon class is a subclass of GameItem
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int minimumDamage, int maximumDamage) : base(itemTypeID, name, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeId, Name, Price, MinimumDamage, MaximumDamage);
        }
    }
}
