/*==============================================================================
*	Created by Rodrigo Medina 
*				Sept / 2014	
*	Github: Rckdrigo
==============================================================================*/

using UnityEngine;
using System.Collections;

public class UIScreens : MonoBehaviour {
	public GameObject[] steps;
    public GameObject aRCam;
	public GameObject aRButton;

	Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}
	
    void startAR(){
        aRCam.SetActive(true);
    }

	void Update(){
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit ();

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("NoScreen")){
			collider.enabled = false;
		}
	}

	void OnApplicationPause(bool pause){
		if(pause)
			Application.Quit ();
	}

	void OnMouseDown(){
		anim.SetTrigger ("NextScreen");
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Screen3"))
			activateSteps ();
	}

	void activateSteps(){
		foreach (GameObject step in steps)
			step.GetComponent<StepChanger>().changeable = true;
	}
}
