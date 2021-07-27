using System;
using UnityEngine;

namespace SoldierCubeGame
{

    public class ShapeColourChanger : MonoBehaviour
    {
        [SerializeField] SoldierColours colours;

        public static Action<SoldierColours> ChangeColour { get; set; }

        void OnMouseDown() => ChangeColour?.Invoke(colours);

        void OnMouseUp() => ChangeColour?.Invoke(SoldierColours.Default);
    }
}
