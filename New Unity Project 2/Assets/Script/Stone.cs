using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	public float Nowcolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	public float Becolor=0;//1:Red 2:Yellow 3:Green 4:Blue
	public bool rollTrigger=false;//まわりはじめふらぐ
	public bool colorChanged=false;//アニメーションで一つだけ全色共通のコマがあり そのコマになった時に色判定を変更します
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
		Anim ();
	}
	void Anim()
	{
		/*switch ((int)Nowcolor) {
		case 1:
			if(rollTrigger=true&&colorChanged==false)
			{
				if (!animation.IsPlaying("Roll_Rto"))
				{
					colorChanged=true;
					Nowcolor=Becolor;
					Becolor=0;
				}
			}
			break;
		case 2:
			if(rollTrigger=true&&colorChanged==false)
			{
				if (!animation.IsPlaying("Roll_Yto"))
				{
					colorChanged=true;
					Nowcolor=Becolor;
					Becolor=0;
				}
			}
			break;
		case 3: 
			if(rollTrigger=true&&colorChanged==false)
			{
				if (!animation.IsPlaying("Roll_Gto"))
				{
					colorChanged=true;
					Nowcolor=Becolor;
					Becolor=0;
				}
			}
			break;
		case 4:
			if(rollTrigger=true&&colorChanged==false)
			{
				if (!animation.IsPlaying("Roll_Bto"))
				{
					colorChanged=true;
					Nowcolor=Becolor;
					Becolor=0;
				}
			}
			break;
		default:
			break;
				}
		if(rollTrigger=true&&colorChanged==true)
		{
			if(Nowcolor==1)
			{
				if (!animation.IsPlaying("Roll_toR"))
				{
					colorChanged=false;
					rollTrigger=false;
				}
			}
			if(Nowcolor==2)
			{
				if (!animation.IsPlaying("Roll_toY"))
				{
					colorChanged=false;
					rollTrigger=false;
				}
			}
			if(Nowcolor==3)
			{
				if (!animation.IsPlaying("Roll_toG"))
				{
					colorChanged=false;
					rollTrigger=false;
				}
			}
			if(Nowcolor==4)
			{
				if (!animation.IsPlaying("Roll_toB"))
				{
					colorChanged=false;
					rollTrigger=false;
				}
			}
		}*/
	}
	public void ColorChange(float COLOR)
	{
		Becolor = COLOR;
		rollTrigger = true;
	}
}
