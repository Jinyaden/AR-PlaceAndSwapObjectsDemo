using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Button LoadButton = null;
    [SerializeField] int sceneIndex = 0;

    void Start()
    {
        Button btn = LoadButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadScene);
    }

    void LoadScene() => SceneManager.LoadScene(sceneIndex);
}
