using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
    public GameObject[] steps;

    void OnMouseDown()
    {
        transform.parent.gameObject.SetActive(false);
        foreach (GameObject step in steps)
            step.GetComponent<StepChanger>().changeable = true;
    }


}
