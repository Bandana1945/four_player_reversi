using UnityEngine;
using System.Collections;
using System;

public class Game_Main : MonoBehaviour {
	public GameObject P_STONE;
	public GameObject P_CURSOR;
	public int[,] Banmen = new int[8, 8];
	public int[,] BanmenFlag = new int[8, 8];//盤面に置けるかどうかの判別用
	public int[,] BanmenFlag2 = new int[8, 8];//盤面に置けるかどうかの判別用
	public bool Sandwich=true;//盤面で挟み込めるような駒があるかどうかのフラグ
	public bool InterSepting=false;
	public GameObject[] Target;
	public GameObject[,] Stones = new GameObject[8, 8];
	public GameObject Cutin_Intercept;
	public int counter = 0;
	public bool SetEnd=false;
	public int[] CanIntersept=new int[4];
	public float Turn=1.0f;//ターン管理変数
	public bool Pause=false;
	public int RedScore=0;
	public int YellowScore=0;
	public int GreenScore=0;
	public int BlueScore=0;
	public GameObject Label_P1_0;
	public GameObject Label_P1_1;
	public GameObject Label_P2_0;
	public GameObject Label_P2_1;
	public GameObject Label_P3_0;
	public GameObject Label_P3_1;
	public GameObject Label_P4_0;
	public GameObject Label_P4_1;
	ScoreLabel LP1_0;
	ScoreLabel LP1_1;
	ScoreLabel LP2_0;
	ScoreLabel LP2_1;
	ScoreLabel LP3_0;
	ScoreLabel LP3_1;
	ScoreLabel LP4_0;
	ScoreLabel LP4_1;

	// Use this for initialization
	//盤面の初期化を行います
	//初期駒も四つ置きます
	void Start () {
		Label_P1_0 = GameObject.Find ("Label_P1_0");
		Label_P1_1 = GameObject.Find ("Label_P1_1");
		Label_P2_0 = GameObject.Find ("Label_P2_0");
		Label_P2_1 = GameObject.Find ("Label_P2_1");
		Label_P3_0 = GameObject.Find ("Label_P3_0");
		Label_P3_1 = GameObject.Find ("Label_P3_1");
		Label_P4_0 = GameObject.Find ("Label_P4_0");
		Label_P4_1 = GameObject.Find ("Label_P4_1");
		LP1_0 = Label_P1_0.GetComponent<ScoreLabel> ();
		LP1_1 = Label_P1_1.GetComponent<ScoreLabel> ();
		LP2_0 = Label_P2_0.GetComponent<ScoreLabel> ();
		LP2_1 = Label_P2_1.GetComponent<ScoreLabel> ();
		LP3_0 = Label_P3_0.GetComponent<ScoreLabel> ();
		LP3_1 = Label_P3_1.GetComponent<ScoreLabel> ();
		LP4_0 = Label_P4_0.GetComponent<ScoreLabel> ();
		LP4_1 = Label_P4_1.GetComponent<ScoreLabel> ();
		for(int i=0;i<8;i++)
		{
			for(int j=0;j<8;j++)
			{
				Banmen[i,j]=0;
				BanmenFlag[i,j]=0;
				BanmenFlag2[i,j]=0;
			}
		}
		CanIntersept[0] = 1;
		CanIntersept[1] = 1;
		CanIntersept[2] = 1;
		CanIntersept[3] = 1;
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
		AvaterSet ();
		FieldCheck (1.0f);
	}
	void scoreCheck()
	{
		RedScore = 0;
		YellowScore = 0;
		GreenScore = 0;
		BlueScore = 0;
		for(int i=0;i<8;i++)
		{
			for(int j=0;j<8;j++)
			{
				switch(Banmen[i,j])
				{
				case 0:
					break;
				case 1:
					RedScore++;
					break;
				case 2:
					YellowScore++;
					break;
				case 3:
					GreenScore++;
					break;
				case 4:
					BlueScore++;
					break;
				default:
					break;
				}
			}
		}
		for(int i=0;i<4;i++)
		{
			float Label1_Num=0;
			float Label2_Num=0;
			for(int j=0;j<4;j++)
			{
				switch(j)
				{
				case 0:
					while(RedScore>10)
					{
						RedScore-=10;
						Label2_Num++;
					}
					Label1_Num=(float)RedScore;
					LP1_0.Num=Label1_Num;
					LP1_1.Num=Label2_Num;
					break;
				case 1:
					while(YellowScore>10)
					{
						YellowScore-=10;
						Label2_Num++;
					}
					Label1_Num=(float)YellowScore;
					LP2_0.Num=Label1_Num;
					LP2_1.Num=Label2_Num;
					break;
				case 2:
					while(GreenScore>10)
					{
						GreenScore-=10;
						Label2_Num++;
					}
					Label1_Num=(float)GreenScore;
					LP3_0.Num=Label1_Num;
					LP3_1.Num=Label2_Num;
					break;
				case 3:
					while(BlueScore>10)
					{
						BlueScore-=10;
						Label2_Num++;
					}
					Label1_Num=(float)BlueScore;
					LP4_0.Num=Label1_Num;
					LP4_1.Num=Label2_Num;
					break;
				default:
					break;
				}
			}
		}
	}
	void Intersept()
	{
		Vector3 Pos;
		GameObject obj;
		InterSepting = true;
		Target=GameObject.FindGameObjectsWithTag("Cursor");
		foreach(GameObject target in Target)
		{
			GameObject.Destroy(target);
		}
		for (int i=0; i<8; i++) 
		{
			for (int j=0; j<8; j++) 
			{
				Pos.x = -18.0f;
				Pos.y = 23.5f;
				Pos.z = 0.0f;
				BanmenFlag [i, j] = 0;
				BanmenFlag2 [i, j] = 0;
				if (Banmen [i, j] != 0 && Banmen [i, j] != (int)Turn) 
					{
						Pos.x = Pos.x + (5.1f * i);
						Pos.y = Pos.y - (5.1f * j);
						obj = Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
					}
			}		
		}
	}
	void AvaterSet()
	{
		for (int i=0; i<4; i++) {
			switch(i)
			{
			case 0:
				GetComponent<Avater>().Init(i,0,0,0,0);
				break;
			case 1:
				GetComponent<Avater>().Init(i,1,1,1,1);
				break;
			case 2:
				GetComponent<Avater>().Init(i,1,0,0,1);
				break;
			case 3:
				GetComponent<Avater>().Init(i,0,1,1,0);
				GetComponent<Avater>().InitTrigger=true;
				break;
			default:
				break;
			}
				}
	}

	
	// Update is called once per frame
	void Update () {
		if (Pause != true) {
						Set_Stone ();
						TurnRote ();
			scoreCheck();
			GetComponent<Avater>().Turn=Turn;
				}
	}
	void Reverse(int X,int Y,int BECOLOR)
	{
		Stone stonescript = Stones[X,Y].GetComponent<Stone>();
		stonescript.Becolor = BECOLOR;
		stonescript.rollTrigger = true;
		stonescript.counter = 0;
		Banmen [X, Y] = BECOLOR;
	}
	void Checking(int X,int Y, float Color)
	{
		int direction;
		Vector3 Pos;
		GameObject obj;
		for (direction=1; direction<10; direction++) {
			int x=X;
			int y=Y;
			Pos.x = -18.0f;
			Pos.y = 23.5f;;
			Pos.z = 0.0f;
			switch (direction) {
			case 1:
				x--;
				y++;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x>0&&y<7)
					{
						x--;
						y++;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 2:
				y++;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(y<7)
					{
						y++;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 3:
				x++;
				y++;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x<7&&y<7)
					{
						x++;
						y++;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 4:
				x--;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x>0)
					{
						x--;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 5:
				break;
			case 6:
				x++;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x<7)
					{
						x++;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 7:
				x--;
				y--;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x>0&&y>0)
					{
						x--;
						y--;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 8:
				y--;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(y>0)
					{
						y--;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
				}
				break;
			case 9:
				x++;
				y--;
				if(x<0||x>7||y<0||y>7)
				{
					break;
				}
				if(Banmen[X,Y]==0&&Banmen[x,y]!=(int)Color&&Banmen[x,y]!=0)
				{
					while(x<7&&y>0)
					{
						x++;
						y--;
						if(Banmen[x,y]==0)
						{
							break;
						}
						else if(Banmen[x,y]==(int)Color)
						{
							Pos.x=Pos.x+(5.1f*X);
							Pos.y=Pos.y-(5.1f*Y);
							obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
							BanmenFlag[X,Y]=1;
							break;
						}
					}
				}
				else
				{
					break;
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
			GameObject obj;
			Vector3 Pos;
			Pos.x = -18.0f;
			Pos.y = 23.5f;;
			Pos.z = 0.0f;
			for(int i=0;i<8;i++)
			{
				for(int j=0;j<8;j++)
				{
					if(Banmen[i,j]!=0)
					{
						for(int direction=1;direction<10;direction++)
						{
							Pos.x = -18.0f;
							Pos.y = 23.5f;;
							switch(direction)
							{
							case 1:
								if(i-1>=0&&j+1<=7)
								{
									if(Banmen[i-1,j+1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i-1));
										Pos.y=Pos.y-(5.1f*(j+1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i-1,j+1]=1;
									}
								}
								break;
							case 2:
								if(j+1<=7)
								{
									if(Banmen[i,j+1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i));
										Pos.y=Pos.y-(5.1f*(j+1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i,j+1]=1;
									}
								}
								break;
							case 3:
								if(i+1<=7&&j+1<=7)
								{
									if(Banmen[i+1,j+1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i+1));
										Pos.y=Pos.y-(5.1f*(j+1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i+1,j+1]=1;
									}
								}
								break;
							case 4:
								if(i-1>=0)
								{
									if(Banmen[i-1,j]==0)
									{
										Pos.x=Pos.x+(5.1f*(i-1));
										Pos.y=Pos.y-(5.1f*(j));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i-1,j]=1;
									}
								}
								break;
							case 5:
								break;
							case 6:
								if(i+1<=7)
								{
									if(Banmen[i+1,j]==0)
									{
										Pos.x=Pos.x+(5.1f*(i+1));
										Pos.y=Pos.y-(5.1f*(j));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i+1,j]=1;
									}
								}
								break;
							case 7:
								if(i-1>=0&&j-1>=0)
								{
									if(Banmen[i-1,j-1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i-1));
										Pos.y=Pos.y-(5.1f*(j-1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i-1,j-1]=1;
									}
								}
								break;
							case 8:
								if(j-1>=0)
								{
									if(Banmen[i,j-1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i));
										Pos.y=Pos.y-(5.1f*(j-1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
										BanmenFlag2[i,j-1]=1;
									}
								}
								break;
							case 9:
								if(i+1<=7&&j-1>=0)
								{
									if(Banmen[i+1,j-1]==0)
									{
										Pos.x=Pos.x+(5.1f*(i+1));
										Pos.y=Pos.y-(5.1f*(j-1));
										obj=Instantiate (this.P_CURSOR, Pos, Quaternion.identity) as GameObject;
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
	void TurnRote()
	{
		if (SetEnd == true)
		{
			counter++;
			if(counter>=60)
			{
				counter=0;
				Turn++;
				if(Turn>4)
					Turn=1.0f;
				Turn_Change();
				GetComponent<Avater>().Turn=Turn;
				SetEnd=false;
			}
		}
	}
	void Set_Stone()
	{
		GameObject CUTIN_INTERCEPT;
		Vector3 vec = Input.mousePosition;
		Vector3 Pos;
		vec = camera.ScreenToWorldPoint (vec);
		vec.z = 0.0f;
		Pos.x = -18.0f;
		Pos.y = 23.5f;
		Pos.z = 0.0f;
		int Board_X = (int)(Math.Floor ((vec.x + 18+2.65) / 5.1));
		int Board_Y = (int)(Math.Floor ((vec.y - 23.5-2.55) / 5.1 * -1));
		if (Input.GetMouseButtonDown (0)) {
			if(SetEnd==false)
			{
				if(Sandwich==true)
				{
					if(Board_X>=0&&Board_X<=7&&Board_Y>=0&&Board_Y<=7)
					{
						if(Banmen[Board_X,Board_Y]==0&&BanmenFlag[Board_X,Board_Y]==1)
						{
							if(InterSepting==false)
							{
							Pos.x=Pos.x+(5.1f*Board_X);
							Pos.y=Pos.y-(5.1f*Board_Y);
							RollCheck(Board_X,Board_Y,Turn);
							Stones[Board_X,Board_Y]=Instantiate (this.P_STONE, Pos, Quaternion.identity) as GameObject;
							Stone stonescript = Stones[Board_X,Board_Y].GetComponent<Stone>();
							stonescript.Init(Turn);
							Banmen[Board_X,Board_Y]=(int)Turn;
							Target=GameObject.FindGameObjectsWithTag("Cursor");
							foreach(GameObject obj in Target)
							{
								GameObject.Destroy(obj);
							}
							SetEnd=true;
							}
						}
						else if(Banmen[Board_X,Board_Y]!=0&&Banmen[Board_X,Board_Y]!=(int)Turn)
						{
							if(InterSepting==true)
							{
							Pos.x=Pos.x+(5.1f*Board_X);
							Pos.y=Pos.y-(5.1f*Board_Y);
							Reverse(Board_X,Board_Y,(int)Turn);
							Banmen[Board_X,Board_Y]=(int)Turn;
							Target=GameObject.FindGameObjectsWithTag("Cursor");
							foreach(GameObject obj in Target)
							{
								GameObject.Destroy(obj);
							}
							SetEnd=true;
							InterSepting=false;
							CUTIN_INTERCEPT=Instantiate(this.Cutin_Intercept,new Vector3(0,0,0),Quaternion.identity) as GameObject;
							CanIntersept[(int)Turn-1]--;
							}
						}

					}
					else
					{
						if(InterSepting==false&&CanIntersept[(int)Turn-1]>0&&vec.y>-30)
						{
							Intersept();
						}
						else if(InterSepting==true)
						{
							Target=GameObject.FindGameObjectsWithTag("Cursor");
							foreach(GameObject target in Target)
							{
								GameObject.Destroy(target);
							}
							InterSepting=false;
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
							SetEnd=true;
							Target=GameObject.FindGameObjectsWithTag("Cursor");
							foreach(GameObject obj in Target)
							{
								GameObject.Destroy(obj);
							}
							SetEnd=true;
						}
						else if(Banmen[Board_X,Board_Y]!=0&&Banmen[Board_X,Board_Y]!=(int)Turn)
						{
							if(InterSepting==true)
							{
								Pos.x=Pos.x+(5.1f*Board_X);
								Pos.y=Pos.y-(5.1f*Board_Y);
								Reverse(Board_X,Board_Y,(int)Turn);
								Banmen[Board_X,Board_Y]=(int)Turn;
								Target=GameObject.FindGameObjectsWithTag("Cursor");
								foreach(GameObject obj in Target)
								{
									GameObject.Destroy(obj);
								}
								SetEnd=true;
								CanIntersept[(int)Turn-1]--;
								CUTIN_INTERCEPT=Instantiate(this.Cutin_Intercept,new Vector3(0,0,0),Quaternion.identity) as GameObject;
								InterSepting=false;
							}
						}
					}
					else
					{
						if(InterSepting==false&&CanIntersept[(int)Turn-1]>0&&vec.y>-30)
						{
							Intersept();
						}
						else if(InterSepting==true)
						{
							Target=GameObject.FindGameObjectsWithTag("Cursor");
							foreach(GameObject target in Target)
							{
								GameObject.Destroy(target);
							}
							InterSepting=false;
							Turn_Change();
						}
					}
				}
			}
		}
	}
}