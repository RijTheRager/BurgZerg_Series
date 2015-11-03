using UnityEngine;
using System.Collections;

namespace Rij.ItemSystem
{
    public interface IISObject
    {
        string ISName { get; set; }
        int ISValue { get; set; }
        Sprite ISIcon { get; set; }
        int ISBurden { get; set; }
        ISQuality ISQuality { get; set; }

        //These go to other interfaces
        //equip
        //durability
        //takeDamage
        //questItem flag
        //prefab - equipping model to character
    }
}