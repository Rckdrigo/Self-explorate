using UnityEngine;
using System.Collections;

public class StepChanger : MonoBehaviour {

    Animator anim;
    int state7 = Animator.StringToHash("Base. Atak1");

    [HideInInspector()]
    public bool changeable;


    void Start() {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown() {
        if(changeable)
            if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Paso7"))
                anim.SetTrigger("Advance");
    }
}
