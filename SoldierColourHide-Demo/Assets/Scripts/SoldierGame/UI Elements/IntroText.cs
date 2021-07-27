using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroText : MonoBehaviour
{
    TextMeshProUGUI introText;

    [SerializeField] string textToDisplay;

    void Awake() => introText = GetComponentInChildren<TextMeshProUGUI>();

    void Start() => StartCoroutine(DisplayStartingText());

    IEnumerator DisplayStartingText()
    {
        introText.text = textToDisplay;

        yield return new WaitForSeconds(4f);

        gameObject.SetActive(false);
    }
}
