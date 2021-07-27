using UnityEngine;
using UnityEngine.UI;

public class ApplicationExit : MonoBehaviour
{
    [SerializeField] Button exitButton = null;

    void Start()
    {
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(ExitGame);
    }

    void ExitGame() => Application.Quit();
}
