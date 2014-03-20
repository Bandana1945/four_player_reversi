using UnityEngine;
using System.Collections;

public class BackTitleButton : MonoBehaviour {
	Avater Script_A;
	Game_Main MainScript;
	public GameObject Window_Back;
	public GameObject Window_Bun;
	public GameObject Window_Yes;
	public GameObject Window_No;
	public GameObject[] Target;
	// Use this for initialization
	void Start () {
		Script_A=GameObject.Find("Main Camera").GetComponent<Avater>();
		MainScript=GameObject.Find("Main Camera").GetComponent<Game_Main>();
	}
	
	// Update is called once per frame
	void Update () {
				Vector2 touchPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Collider2D collider2d = Physics2D.OverlapPoint (touchPoint);
				GameObject obj;
				if (Input.GetMouseButtonDown (0)) {
						if (this.collider2D == collider2d) {
								if (MainScript.Pause == false) {
										MainScript.Pause = true;
										obj = Instantiate (this.Window_Back, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
										obj = Instantiate (this.Window_Bun, new Vector3 (0, 3, 0), Quaternion.identity) as GameObject;
										obj = Instantiate (this.Window_Yes, new Vector3 (-6, -3, 0), Quaternion.identity) as GameObject;
										obj = Instantiate (this.Window_No, new Vector3 (6, -3, 0), Quaternion.identity) as GameObject;
								} else {
										MainScript.Pause = false;
										Target = GameObject.FindGameObjectsWithTag ("ResetWindow");
										foreach (GameObject target in Target) {
												GameObject.Destroy (target);
										}
								}
						}
				}
		}
}
