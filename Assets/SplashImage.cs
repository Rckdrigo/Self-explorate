using UnityEngine;
using System.Collections;

[ExecuteInEditMode()]
public class SplashImage : MonoBehaviour {
	public Texture wallpaper;
	public GUIStyle style;

	void OnGUI(){
		GUI.color = new Color(0.7265625f,0.42578125f,0.5625f,0.7f);
		GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),wallpaper);
		GUILayout.BeginArea (new Rect(Screen.width/2-40,0,80,300));
			GUILayout.Label ("Cuando se active tu camara, enfoca la imagen del COLLARIN Y DEJALA ENFOCADA UNOS ",style);
		GUILayout.EndArea ();
	}
}
