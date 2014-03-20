using UnityEngine;
using System.Collections;

public class ButtoninMenu : MonoBehaviour {
	public bool Toggle=false;
	protected Animator animator;
	GlovalValue Sprite_GLOBALVALUE;
	GameObject GLOBALVALUE;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		GLOBALVALUE = GameObject.Find ("GlovalValue");
		Sprite_GLOBALVALUE = GLOBALVALUE.GetComponent<GlovalValue> ();
		if (CompareTag ("MB2on2")) {
			Toggle=Sprite_GLOBALVALUE.Flag_2on2;
		}
		if (CompareTag ("MBChicken")) {
			Toggle=Sprite_GLOBALVALUE.Flag_Chicken;
		}
		if (CompareTag ("MBIntercept")) {
			Toggle=Sprite_GLOBALVALUE.Flag_Intercept;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) 
		{ 
			Vector2 touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collider2d = Physics2D.OverlapPoint(touchPoint);
			if(this.collider2D==collider2d)
			{
				if(Toggle==true)
					Toggle=false;
				else
					Toggle=true;
			}
		}
		if (CompareTag ("MB2on2")) {
			Sprite_GLOBALVALUE.Flag_2on2=Toggle;
				}
		if (CompareTag ("MBChicken")) {
			Sprite_GLOBALVALUE.Flag_Chicken=Toggle;
		}
		if (CompareTag ("MBIntercept")) {
			Sprite_GLOBALVALUE.Flag_Intercept=Toggle;
		}
		animator.SetBool ("Flag", Toggle);
	}
}
