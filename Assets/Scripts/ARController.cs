using UnityEngine;
using System.Collections;

public class ARController : MonoBehaviour {
	public Sprite activate, deactivate;
	SpriteRenderer sprite;
	public GameObject[] steps;
    public GameObject guiSteps;
    public static bool activeAR;


	void Start(){
		sprite = GetComponent<SpriteRenderer> ();
		sprite.sprite = deactivate;
        activeAR = true;
	}

    void Update() {
        if (AREvent.onImageTarget)
            activateAR();
        activeAR = sprite.sprite == deactivate ? true : false;
    }

	void OnMouseDown(){
		sprite.sprite = (sprite.sprite == activate) ? deactivate : activate;
		foreach (GameObject temp in steps)
			temp.SetActive (sprite.sprite == activate ? false : true);
        guiSteps.SetActive(sprite.sprite == activate ? true : false);
        
	}

    void activateAR() {
        foreach (GameObject temp in steps)
            temp.SetActive(true);
        guiSteps.SetActive(false);
        sprite.sprite = deactivate;
    }


}
