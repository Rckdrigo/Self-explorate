using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

    public GameObject aRCam, imgTarget,splash, inicial, boton;

    public void startAR()
    {
        aRCam.SetActive(true);
        imgTarget.SetActive(true);
    }
}
