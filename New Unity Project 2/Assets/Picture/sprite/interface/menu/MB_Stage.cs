using UnityEngine;
using System.Collections;

public class MB_Stage : MonoBehaviour {
	public bool Toggle=false;
	protected Animator animator;
	public int ID=0;
	GlovalValue Sprite_GLOBALVALUE;
	GameObject GLOBALVALUE;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		GLOBALVALUE = GameObject.Find ("GlovalValue");
		Sprite_GLOBALVALUE = GLOBALVALUE.GetComponent<GlovalValue> ();
		if(CompareTag("button6"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen6;
			ID=0;
		}
		if(CompareTag("button8"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen8;
			ID=1;
		}
		if(CompareTag("button10"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen10;
			ID=2;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(CompareTag("button6"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen6;
		}
		if(CompareTag("button8"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen8;
		}
		if(CompareTag("button10"))
		{
			Toggle=Sprite_GLOBALVALUE.Flag_Banmen10;
		}
		if(Input.GetMouseButtonDown(0)) 
		{ 
			Vector2 touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collider2d = Physics2D.OverlapPoint(touchPoint);
			if(this.collider2D==collider2d)
			{
				if(CompareTag("button6"))
				{
					Sprite_GLOBALVALUE.Flag_Banmen6=true;
					Sprite_GLOBALVALUE.Flag_Banmen8=false;
					Sprite_GLOBALVALUE.Flag_Banmen10=false;
				}
				if(CompareTag("button8"))
				{
					Sprite_GLOBALVALUE.Flag_Banmen6=false;
					Sprite_GLOBALVALUE.Flag_Banmen8=true;
					Sprite_GLOBALVALUE.Flag_Banmen10=false;
				}
				if(CompareTag("button10"))
				{
					Sprite_GLOBALVALUE.Flag_Banmen6=false;
					Sprite_GLOBALVALUE.Flag_Banmen8=false;
					Sprite_GLOBALVALUE.Flag_Banmen10=true;
				}
			}
		}
		animator.SetFloat ("ID", (float)ID);
		if(CompareTag("button6"))
		{
			animator.SetBool ("Flag", Sprite_GLOBALVALUE.Flag_Banmen6);
		}
		if(CompareTag("button8"))
		{
			animator.SetBool ("Flag", Sprite_GLOBALVALUE.Flag_Banmen8);
		}
		if(CompareTag("button10"))
		{
			animator.SetBool ("Flag", Sprite_GLOBALVALUE.Flag_Banmen10);
		}

	}
}
