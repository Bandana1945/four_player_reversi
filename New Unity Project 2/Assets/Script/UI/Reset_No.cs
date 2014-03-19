using UnityEngine;
using System.Collections;

public class Reset_No : MonoBehaviour {
	public GameObject[] Target;
	Game_Main MainScript;
	// Use this for initialization
	void Start () {
		MainScript=GameObject.Find("Main Camera").GetComponent<Game_Main>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) 
		{
			Vector2 touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collider2d = Physics2D.OverlapPoint(touchPoint);
			GameObject obj;
			if(this.collider2D==collider2d)
			{
				MainScript.Pause=false;
				Target=GameObject.FindGameObjectsWithTag("ResetWindow");
				foreach(GameObject target in Target)
				{
					GameObject.Destroy(target);
				}
			}
		}
	}
}
