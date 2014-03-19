using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
	public float Scale=0.1f;
	public float Angle=0.1f;
	public Color COLOR = new Color (1.0f, 1.0f, 1.0f, 0.0f);
	public float Opacity=0.0f;
	Game_Main MainScript;
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(Scale, Scale, 1);
		MainScript=GameObject.Find("Main Camera").GetComponent<Game_Main>();
	}
	
	// Update is called once per frame
	void Update () {
		if (MainScript.Pause == false) {
						if (Opacity < 1.0f) {
								Opacity += 0.1f;
						}
						if (Scale < 1.0f) {
								Scale += 0.1f;
						}
						COLOR.a = Opacity;
						Angle++;
						transform.localScale = new Vector3 (Scale, Scale, 1);
						transform.rotation = Quaternion.Euler (0, 0, Angle);
						renderer.material.color = COLOR;
				}
	}
}
