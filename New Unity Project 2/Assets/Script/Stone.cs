using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	public float Nowcolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	public float Becolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	public bool rollTrigger=false;//まわりはじめふらぐ
	public bool colorChanged=false;//アニメーションで一つだけ全色共通のコマがあり そのコマになった時に色判定を変更します
	public int counter=0;
	//これはその色判定の変更を司るフラグです
	protected Animator animator;
	//Animatorに数値を渡したいのでおまじないをば
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
		ColorChange ();
	}
	public void ColorChange()
	{
		if (rollTrigger == true) {
			counter++;
			if(counter>=13)
			{
				counter=0;
				Nowcolor=Becolor;
				rollTrigger=false;
			}
				}
	}
}
