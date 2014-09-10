/*==============================================================================
*	Created by Rodrigo Medina 
*				Sept / 2014	
*	Github: Rckdrigo
==============================================================================*/

using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
    public GameObject[] steps;
    public GameObject splash, inicial;

    void OnMouseDown()
    {
        Destroy(splash);
        Destroy(inicial);

        foreach (GameObject step in steps)
            step.GetComponent<StepChanger>().changeable = true;

        Destroy(gameObject);
    }


}
