using UnityEngine;

namespace SoldierCubeGame
{
    public class BlueSoldier : SoldierBase
    {
        public override void ChangeColour(SoldierColours col)
        {
            base.ChangeColour(col);
            if (col == myColour)
                material.SetColor("_Color", Color.blue);
        }
    }
}
