using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	public float Nowcolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	public float Becolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	bool rollTrigger=false;
	bool colorChanged=false;
	protected Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

	}
	public void Init(float Color)
	{
		Nowcolor = Color;
	}
	// Update is called once per frame
	void Update () {
		animator.SetFloat("Color", Nowcolor);
		animator.SetBool("RollTrigger", rollTrigger);
		animator.SetBool("ColorChanged", colorChanged);
	}
	void Anim()
	{

	}
	public void ColorChange(float COLOR)
	{
		Becolor = COLOR;
		rollTrigger = true;
	}
}
