using UnityEngine;
using System.Collections;
using System;

public class Game_Main : MonoBehaviour {
	public GameObject P_STONE;
	public int[,] Banmen = new int[8, 8];
	public int[,] BanmenFlag = new int[8, 8];//盤面に置けるかどうかの判別用
	public int[,] BanmenFlag2 = new int[8, 8];//盤面に置けるかどうかの判別用
	public bool Sandwich=true;//盤面で挟み込めるような駒があるかどうかのフラグ
	public GameObject[,] Stones = new GameObject[8, 8];
	public float Turn=1.0f;//ターン管理変数
	// Use this for initialization
	//盤面の初期化を行います
	//初期駒も四つ置きます
	void Start () {
		for(int i=0;i<8;i++)
		{
			for(int j=0;j<8;j++)
			{
				Banmen[i,j]=0;
				BanmenFlag[i,j]=0;
				BanmenFlag2[i,j]=0;
			}
		}
		Vector3 Pos;
		Pos.x = -2.7f;
		Pos.y = 8.2f;
		Pos.z = 0.0f;
		Stones[3,3]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
		Stone stonescript = Stones[3,3].GetComponent<Stone>();
		Banmen [3, 3] = 4;
		stonescript.Init(4);
		Pos.x = 2.7f;
		Pos.y = 8.2f;
		Stones[4,3]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
		stonescript = Stones[4,3].GetComponent<Stone>();
		Banmen [4, 3] = 3;
		stonescript.Init(3);
		Pos.x = 2.7f;
		Pos.y = 3.1f;
		Stones[4,4]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
		stonescript = Stones[4,4].GetComponent<Stone>();
		Banmen [4, 4] = 2;
		stonescript.Init(2);
		Pos.x = -2.7f;
		Pos.y = 3.1f;
		Stones[3,4]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
		stonescript = Stones[3,4].GetComponent<Stone>();
		Banmen [3, 4] = 1;
		stonescript.Init(1);
		FieldCheck (1.0f);
	}

	
	// Update is called once per frame
	void Update () {
		Set_Stone ();
	}
	void Reverse(int X,int Y,int BECOLOR)
	{
		Stone stonescript = Stones[X,Y].GetComponent<Stone>();
		stonescript.Becolor = BECOLOR;
		stonescript.Nowcolor = BECOLOR;
		//stonescript.rollTrigger = true;
		//stonescript.colorChanged = false;
		Banmen [X, Y] = BECOLOR;
	}
	void Checking(int X,int Y, float Color)
	{
		int direction;
		for (direction=1; direction<10; direction++) {
			int x=X;
			int y=Y;
			switch (direction) {
			case 1:
				if(x-1>=0&&y+1<8)
				{
				if(Banmen[x-1,y+1]==0||Banmen[x-1,y+1]==(int)Color)
				{
					break;
				}
				else
				{
					while(x-1>=0&&y+1<8)
					{
						x=x-1;
						y=y+1;
						if(Banmen[x,y]==(int)Color)
						{
							if(Banmen[x+1,y-1]!=(int)Color||Banmen[x+1,y-1]!=0)
							{
								BanmenFlag[X,Y]=1;
								break;
							}
						}
						if(Banmen[x,y]==0)
							{
								break;
							}
					}
				}
				}
				break;
			case 2:
				if(y+1<8)
				{
					if(Banmen[x,y+1]==0||Banmen[x,y+1]==(int)Color)
					{
						break;
					}
					else
					{
						while(y+1<8)
						{
							y=y+1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x,y-1]!=(int)Color||Banmen[x,y-1]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 3:
				if(x+1<8&&y+1<8)
				{
					if(Banmen[x+1,y+1]==0||Banmen[x+1,y+1]==(int)Color)
					{
						break;
					}
					else
					{
						while(x+1<8&&y+1<8)
						{
							x=x+1;
							y=y+1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x-1,y-1]!=(int)Color||Banmen[x-1,y-1]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 4:
				if(x-1>=0)
				{
					if(Banmen[x-1,y]==0||Banmen[x-1,y]==(int)Color)
					{
						break;
					}
					else
					{
						while(x-1>=0)
						{
							x=x-1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x+1,y]!=(int)Color||Banmen[x+1,y]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 5:
				break;
			case 6:
				if(x+1<8)
				{
					if(Banmen[x+1,y]==0||Banmen[x+1,y]==(int)Color)
					{
						break;
					}
					else
					{
						while(x+1<8)
						{
							x=x+1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x-1,y]!=(int)Color||Banmen[x-1,y]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 7:
				if(x-1>=0&&y-1>=0)
				{
					if(Banmen[x-1,y-1]==0||Banmen[x-1,y-1]==(int)Color)
					{
						break;
					}
					else
					{
						while(x-1>=0&&y-1>=0)
						{
							x=x-1;
							y=y-1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x+1,y+1]!=(int)Color||Banmen[x+1,y+1]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 8:
				if(y-1>=0)
				{
					if(Banmen[x,y-1]==0||Banmen[x,y-1]==(int)Color)
					{
						break;
					}
					else
					{
						while(y-1>=0)
						{
							y=y-1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x,y+1]!=(int)Color||Banmen[x,y+1]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			case 9:
				if(x+1<8&&y-1>=0)
				{
					if(Banmen[x+1,y-1]==0||Banmen[x+1,y-1]==(int)Color)
					{
						break;
					}
					else
					{
						while(x+1<8&&y-1>=0)
						{
							x=x+1;
							y=y-1;
							if(Banmen[x,y]==(int)Color)
							{
								if(Banmen[x-1,y+1]!=(int)Color||Banmen[x-1,y+1]!=0)
								{
									BanmenFlag[X,Y]=1;
									break;
								}
							}
							if(Banmen[x,y]==0)
							{
								break;
							}
						}
					}
				}
				break;
			default:
				break;
			}
		}
	}
	void FieldCheck(float CheckColor)
	{

		switch ((int)CheckColor) 
		{
		case 1:
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					Checking(i,j,CheckColor);
				}
			}
			break;
		case 2:
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					Checking(i,j,CheckColor);
				}
			}
			break;
		case 3:
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					Checking(i,j,CheckColor);
				}
			}
			break;
		case 4:
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					Checking(i,j,CheckColor);
				}
			}
			break;
		default:
			break;
		}
	}
	void RollCheck(int X,int Y,float Color)
	{
		int Pos_X = X;
		int Pos_Y = Y;
		int COLOR = (int)Color;
		switch(COLOR)
		{
		case 1:
			RollChecking(Pos_X,Pos_Y,COLOR);
			break;
		case 2:
			RollChecking(Pos_X,Pos_Y,COLOR);
			break;
		case 3:
			RollChecking(Pos_X,Pos_Y,COLOR);
			break;
		case 4:
			RollChecking(Pos_X,Pos_Y,COLOR);
			break;
		default:
			break;
		}
	}
	void RollChecking(int X,int Y,int Color)
	{
		int Pos_X = X;
		int Pos_Y = Y;
		int COLOR = Color;
		int counter;
		for (int direction=1; direction<10; direction++) {
			Pos_X = X;
			Pos_Y = Y;
			switch(direction)
			{
			case 1:
				counter=0;
				while(Pos_X>0&&Pos_Y<7)
				{
					Pos_X--;
					Pos_Y++;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X-1<0||Pos_Y+1>=8)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X-i,Y+i,COLOR);
				}
				break;
			case 2:
				counter=0;
				while(Pos_Y<7)
				{
					Pos_Y++;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_Y+1>=8)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X,Y+i,COLOR);
				}
				break;
			case 3:
				counter=0;
				while(Pos_X<7&&Pos_Y<7)
				{
					Pos_X++;
					Pos_Y++;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X+1>=8||Pos_Y+1>=8)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X+i,Y+i,COLOR);
				}
				break;
			case 4:
				counter=0;
				while(Pos_X>0)
				{
					Pos_X--;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X-1<0)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X-i,Y,COLOR);
				}
				break;
			case 5:
				break;
			case 6:
				counter=0;
				while(Pos_X<7)
				{
					Pos_X++;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X+1>=8)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X+i,Y,COLOR);
				}
				break;
			case 7:
				counter=0;
				while(Pos_X>0&&Pos_Y>0)
				{
					Pos_X--;
					Pos_Y--;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X-1<0||Pos_Y-1<0)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X-i,Y-i,COLOR);
				}
				break;
			case 8:
				counter=0;
				while(Pos_Y>0)
				{
					Pos_Y--;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_Y-1<0)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X,Y-i,COLOR);
				}
				break;
			case 9:
				counter=0;
				while(Pos_X<7&&Pos_Y>0)
				{
					Pos_X++;
					Pos_Y--;
					if(Banmen[Pos_X,Pos_Y]==Color)
					{
						break;
					}
					else if(Banmen[Pos_X,Pos_Y]==0)
					{
						counter=0;
						break;
					}
					if(Pos_X+1>=8||Pos_Y-1<0)
					{
						counter=0;
						break;
					}
					counter++;
				}
				for(int i=1;i<=counter;i++)
				{
					Reverse(X+i,Y-i,COLOR);
				}
				break;
			default:
				break;
			}
		}
	}
	void Turn_Change()
	{
		int counter = 0;
		for(int i=0;i<8;i++)
		{
			for(int j=0;j<8;j++)
			{
				BanmenFlag[i,j]=0;
				BanmenFlag2[i,j]=0;
			}
		}
		FieldCheck (Turn);
		for (int i=0; i<8; i++) {
			for(int j=0;j<8;j++)
			{
				if(BanmenFlag[i,j]==1)
				{
					counter++;
					Sandwich=true;
					break;
				}
			}
				}
		if (counter == 0) {
			Sandwich=false;
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					if(Banmen[i,j]!=0)
					{
						for(int direction=1;direction<10;direction++)
						{
							switch(direction)
							{
							case 1:
								if(i>0&&j<7)
								{
									if(Banmen[i-1,j+1]==0)
									{
										BanmenFlag2[i-1,j+1]=1;
									}
								}
								break;
							case 2:
								if(j<7)
								{
									if(Banmen[i,j+1]==0)
									{
										BanmenFlag2[i,j+1]=1;
									}
								}
								break;
							case 3:
								if(i<7&&j<7)
								{
									if(Banmen[i+1,j+1]==0)
									{
										BanmenFlag2[i+1,j+1]=1;
									}
								}
								break;
							case 4:
								if(i>0)
								{
									if(Banmen[i-1,j]==0)
									{
										BanmenFlag2[i-1,j]=1;
									}
								}
								break;
							case 5:
								break;
							case 6:
								if(i<7)
								{
									if(Banmen[i+1,j]==0)
									{
										BanmenFlag2[i+1,j]=1;
									}
								}
								break;
							case 7:
								if(i>0&&j>0)
								{
									if(Banmen[i-1,j-1]==0)
									{
										BanmenFlag2[i-1,j-1]=1;
									}
								}
								break;
							case 8:
								if(j>0)
								{
									if(Banmen[i,j-1]==0)
									{
										BanmenFlag2[i,j-1]=1;
									}
								}
								break;
							case 9:
								if(i<7&&j>0)
								{
									if(Banmen[i+1,j-1]==0)
									{
										BanmenFlag2[i+1,j-1]=1;
									}
								}
								break;
							default:
								break;
							}
						}
					}
				}
			}
				}
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
		int Board_X = (int)(Math.Floor ((vec.x + 18+2.65)) / 5.1);
		int Board_Y = (int)(Math.Floor ((vec.y - 23.5-2.55)) / 5.1 * -1);
		if (Input.GetMouseButtonDown (0)) {
			if(Sandwich==true)
			{
				if(Board_X>=0&&Board_X<=7&&Board_Y>=0&&Board_Y<=7)
				{
					if(Banmen[Board_X,Board_Y]==0&&BanmenFlag[Board_X,Board_Y]==1)
					{
						Pos.x=Pos.x+(5.1f*Board_X);
						Pos.y=Pos.y-(5.1f*Board_Y);
						RollCheck(Board_X,Board_Y,Turn);
						Stones[Board_X,Board_Y]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
						Stone stonescript = Stones[Board_X,Board_Y].GetComponent<Stone>();
						stonescript.Init(Turn);
						Banmen[Board_X,Board_Y]=(int)Turn;
						Turn++;
						if(Turn>4)
							Turn=1.0f;
						Turn_Change();
					}
				}
			}
			else if(Sandwich==false)
			{
				if(Board_X>=0&&Board_X<=7&&Board_Y>=0&&Board_Y<=7)
				{
					if(Banmen[Board_X,Board_Y]==0&&BanmenFlag2[Board_X,Board_Y]==1)
					{
						Pos.x=Pos.x+(5.1f*Board_X);
						Pos.y=Pos.y-(5.1f*Board_Y);
						RollCheck(Board_X,Board_Y,Turn);
						Stones[Board_X,Board_Y]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
						Stone stonescript = Stones[Board_X,Board_Y].GetComponent<Stone>();
						stonescript.Init(Turn);
						Banmen[Board_X,Board_Y]=(int)Turn;
						Turn++;
						if(Turn>4)
							Turn=1.0f;
						Turn_Change();
					}
				}
			}
		}
	}
}
