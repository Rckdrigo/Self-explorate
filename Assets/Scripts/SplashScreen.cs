using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

    public GameObject aRCam, imgTarget;

    public void startAR()
    {
        aRCam.SetActive(true);
        imgTarget.SetActive(true);
    }
}
