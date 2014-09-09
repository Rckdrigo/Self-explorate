using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

    public GameObject aRCam, imgTarget;

    public void startAR()
    {
        aRCam.SetActive(true);
        imgTarget.SetActive(true);
    }

	public void Update(){
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit ();
	}

	public void OnApplicationPause(bool pause){
		if(pause)
			Application.Quit ();
	}
}
