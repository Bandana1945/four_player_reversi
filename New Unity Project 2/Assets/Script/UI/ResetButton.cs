using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {
	Avater Script_A;
	Game_Main MainScript;
	public GameObject ResetWindow_Back;
	public GameObject ResetWindow_Bun;
	public GameObject ResetWindow_Yes;
	public GameObject ResetWindow_No;
	public GameObject[] Target;
	// Use this for initialization
	void Start () {
		Script_A=GameObject.Find("Main Camera").GetComponent<Avater>();
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
				if(MainScript.Pause==false)
				{
					MainScript.Pause=true;
					obj = Instantiate(this.ResetWindow_Back,new Vector3(0,0,0),Quaternion.identity) as GameObject;
					obj = Instantiate(this.ResetWindow_Bun,new Vector3(0,3,0),Quaternion.identity) as GameObject;
					obj = Instantiate(this.ResetWindow_Yes,new Vector3(-6,-3,0),Quaternion.identity) as GameObject;
					obj = Instantiate(this.ResetWindow_No,new Vector3(6,-3,0),Quaternion.identity) as GameObject;
				}
				else
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
}
