using UnityEngine;
using System.Collections;

public class ARController : MonoBehaviour {
	public Sprite activate, deactivate;
	SpriteRenderer sprite;
	public GameObject[] steps;

	void Start(){
		sprite = GetComponent<SpriteRenderer> ();
		sprite.sprite = deactivate;
	}

	void OnMouseDown(){
		sprite.sprite = sprite.sprite == activate ? deactivate : activate;
		foreach (GameObject temp in steps)
			temp.SetActive (sprite.sprite == activate ? false : true);
	}
}
