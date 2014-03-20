using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) 
		{ 
			Vector2 touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collider2d = Physics2D.OverlapPoint(touchPoint);
			if(this.collider2D==collider2d)
			{
				Application.LoadLevel("Menu");
			}
		}
	}
}
