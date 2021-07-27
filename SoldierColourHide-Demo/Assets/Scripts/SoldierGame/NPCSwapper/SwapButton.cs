using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SoldierCubeGame
{
    public class SwapButton : MonoBehaviour
    {
        [SerializeField] Button button = null;

        ISwap swapper;
        
        void Awake()  => swapper = GetComponent<ISwap>();

        void Start()
        {
            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(Swap);
        }

        public void Swap() => swapper.SwapCharacters();
    }
}
