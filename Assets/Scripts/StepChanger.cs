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
            salir.SetActive(anim.GetCurrentAnimatorStateInfo(0).IsName("Paso7"));
    }
}
