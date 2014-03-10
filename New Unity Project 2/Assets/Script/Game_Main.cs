using UnityEngine;
using System.Collections;
using System;

public class Game_Main : MonoBehaviour {
	public GameObject P_STONE;
	public int[,] Banmen=new int[8,8];
	// Use this for initialization
	//盤面の初期化を行います
	void Start () {
		for(int i=0;i<8;i++)
		{
			for(int j=0;j<8;j++)
			{
				Banmen[i,j]=0;
			}
		}
	}

	
	// Update is called once per frame
	void Update () {
		Set_Stone ();
	}
	void Set_Stone()
	{
		Vector3 vec = Input.mousePosition;
		Vector3 Pos;
		vec = camera.ScreenToWorldPoint (vec);
		vec.z = 0.0f;
		Pos.x = -18.0f;
		Pos.y = 23.5f;
		Pos.z = 0.0f;
		int Board_X = (int)(Math.Floor ((vec.x + 18+2.25)) / 5.1);
		int Board_Y = (int)(Math.Floor ((vec.y - 23.5-2.25)) / 5.1 * -1);
		if (Input.GetMouseButtonDown (0)) {
			if(Board_X>=0&&Board_X<=7&&Board_Y>=0&&Board_Y<=7)
			{
				if(Banmen[Board_X,Board_Y]==0)
				{
					Pos.x=Pos.x+(5.1f*Board_X);
					Pos.y=Pos.y-(5.1f*Board_Y);
					Instantiate (this.P_STONE, Pos, Quaternion.identity);
					Banmen[Board_X,Board_Y]=1;
				}
			}
		}
	}
}
