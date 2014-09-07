using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
    public GameObject aRCam, imgTarget;

    void OnMouseDown()
    {
        transform.parent.gameObject.SetActive(false);
    }

}
