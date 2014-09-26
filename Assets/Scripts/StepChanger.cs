/*==============================================================================
*	Created by Rodrigo Medina 
*				Sept / 2014	
*	Github: Rckdrigo
==============================================================================*/

using UnityEngine;
using System.Collections;

public class StepChanger : MonoBehaviour {

    Animator anim;
    public GameObject salir;

    [HideInInspector()]
    public bool changeable;


    void Start() {
        anim = GetComponent<Animator>();
    }


    void OnMouseDown() {
        if(changeable)
                anim.SetTrigger("Advance");
    }

    void Update() {
		print (transform.parent.name + ": " + changeable);
		salir.SetActive((anim.GetCurrentAnimatorStateInfo(0).IsName("Paso7") | !AREvent.onImageTarget) & changeable);
    }
}
