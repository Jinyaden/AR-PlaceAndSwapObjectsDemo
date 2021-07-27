using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class RayCastTargetSpawner : MonoBehaviour
{
    [SerializeField] ARRaycastManager rayCastManager;
    [SerializeField] GameObject miniGame;

    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    int gameCount = 0;

    public static Action ScreenTouched { get; set; }

    void Update() => GetTouchFromRayHit();

    void GetTouchFromRayHit()
    {

        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {
                if (Input.touchCount == 1)
                {
                    if (rayCastManager.Raycast(touch.position, hits) & gameCount == 0)
                    {
                        Instantiate(miniGame, hits[0].pose.position, Quaternion.identity);
                        ScreenTouched?.Invoke();
                        gameCount = 1;
                    }
                }
            }
        }
    }
}
