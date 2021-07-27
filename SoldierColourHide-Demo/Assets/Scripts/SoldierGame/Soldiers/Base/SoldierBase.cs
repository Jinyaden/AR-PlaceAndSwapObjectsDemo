using UnityEngine;

namespace SoldierCubeGame
{
    public abstract class SoldierBase : MonoBehaviour
    {
        [SerializeField] protected SoldierColours myColour;

        protected Material material;

        void Awake()
        {
            material = GetComponent<Renderer>().material;
        }
        void OnEnable() => ShapeColourChanger.ChangeColour += ChangeColour;

        void OnDisable() => ShapeColourChanger.ChangeColour -= ChangeColour;

        public virtual void ChangeColour(SoldierColours col)
        {
            if (col == SoldierColours.Default)
                material.color = Color.white;
        }
    }
}
