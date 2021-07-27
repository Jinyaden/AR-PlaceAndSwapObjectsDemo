using UnityEngine;

namespace SoldierCubeGame
{
    public class GreenSoldier : SoldierBase
    {
        public override void ChangeColour(SoldierColours col)
        {
            base.ChangeColour(col);
            if (col == myColour)
                material.SetColor("_Color", Color.green);
        }
    }
}
