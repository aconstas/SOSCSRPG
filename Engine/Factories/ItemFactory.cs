using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    // static because we are not going to instantiate it, we're going to use the functions in it
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            // initialize the empty list
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
