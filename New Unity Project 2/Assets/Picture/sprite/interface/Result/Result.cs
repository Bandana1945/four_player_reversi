using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {
	GlovalValue Sprite_GLOBALVALUE;
	GameObject GLOBALVALUE;
	ScoreLabel LP_0;
	ScoreLabel LP_1;
	public GameObject Label_0;
	public GameObject Label_1;
	// Use this for initialization
	void Start () {
		GLOBALVALUE = GameObject.Find ("GlovalValue");
		Sprite_GLOBALVALUE = GLOBALVALUE.GetComponent<GlovalValue> ();
		for(int i=0;i<4;i++)
		{
			float Label1_Num=0;
			float Label2_Num=0;
			float Score;
			switch(i)
			{
			case 0:
				Score=Sprite_GLOBALVALUE.RedStones;
				Label_0 = GameObject.Find ("Label_P1_0");
				Label_1 = GameObject.Find ("Label_P1_1");
				LP_0 = Label_0.GetComponent<ScoreLabel> ();
				LP_1 = Label_1.GetComponent<ScoreLabel> ();
				while(Score>9)
				{
					Score-=10;
					Label2_Num++;
				}
				Label1_Num=Score;
				LP_0.Num=Label1_Num;
				LP_1.Num=Label2_Num;
				break;
			case 1:
				Score=Sprite_GLOBALVALUE.YellowStones;
				Label_0 = GameObject.Find ("Label_P2_0");
				Label_1 = GameObject.Find ("Label_P2_1");
				LP_0 = Label_0.GetComponent<ScoreLabel> ();
				LP_1 = Label_1.GetComponent<ScoreLabel> ();
				while(Score>9)
				{
					Score-=10;
					Label2_Num++;
				}
				Label1_Num=Score;
				LP_0.Num=Label1_Num;
				LP_1.Num=Label2_Num;
				break;
			case 2:
				Score=Sprite_GLOBALVALUE.GreenStones;
				Label_0 = GameObject.Find ("Label_P3_0");
				Label_1 = GameObject.Find ("Label_P3_1");
				LP_0 = Label_0.GetComponent<ScoreLabel> ();
				LP_1 = Label_1.GetComponent<ScoreLabel> ();
				while(Score>9)
				{
					Score-=10;
					Label2_Num++;
				}
				Label1_Num=Score;
				LP_0.Num=Label1_Num;
				LP_1.Num=Label2_Num;
				break;
			case 3:
				Score=Sprite_GLOBALVALUE.BlueStones;
				Label_0 = GameObject.Find ("Label_P4_0");
				Label_1 = GameObject.Find ("Label_P4_1");
				LP_0 = Label_0.GetComponent<ScoreLabel> ();
				LP_1 = Label_1.GetComponent<ScoreLabel> ();
				while(Score>9)
				{
					Score-=10;
					Label2_Num++;
				}
				Label1_Num=Score;
				LP_0.Num=Label1_Num;
				LP_1.Num=Label2_Num;
				break;
			default:
				break;
			}
		}
		if(Sprite_GLOBALVALUE.Flag_2on2==true)
		{
			GameObject obj;
			obj=GameObject.Find ("rank1st");
			obj.transform.position=new Vector3(-1.5f,1f,0f);
			obj=GameObject.Find ("rank2nd");
			obj.transform.position=new Vector3(-1.5f,-1.5f,0f);
			obj=GameObject.Find ("rank3rd");
			obj.transform.position=new Vector3(-1000f,1f,0f);
			obj=GameObject.Find ("rank4th");
			obj.transform.position=new Vector3(-1000f,-1.5f,0f);
			if(Sprite_GLOBALVALUE.Flag_Chicken==true)
			{
				float Label1_Num=0;
				float Label2_Num=0;
				int TeamAStones=Sprite_GLOBALVALUE.RedStones+Sprite_GLOBALVALUE.GreenStones;
				int TeamBStones=Sprite_GLOBALVALUE.YellowStones+Sprite_GLOBALVALUE.BlueStones;
				if(TeamAStones<=TeamBStones||TeamBStones==0)
				{
					obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,0.7f,0f);
					obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,1.3f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					int Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P1_0");
					Label_1 = GameObject.Find ("Label_P1_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
					
					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-1.2f,0f);
					obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-1.8f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P4_0");
					Label_1 = GameObject.Find ("Label_P4_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
				}
				else if(TeamAStones>=TeamBStones||TeamAStones==0)
				{
					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-1.2f,0f);
					obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-1.8f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					int Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P1_0");
					Label_1 = GameObject.Find ("Label_P1_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
					
					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,0.7f,0f);
					obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,1.3f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P4_0");
					Label_1 = GameObject.Find ("Label_P4_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
				}
			}
			else
			{
				float Label1_Num=0;
				float Label2_Num=0;
				int TeamAStones=Sprite_GLOBALVALUE.RedStones+Sprite_GLOBALVALUE.GreenStones;
				int TeamBStones=Sprite_GLOBALVALUE.YellowStones+Sprite_GLOBALVALUE.BlueStones;
				if(TeamAStones>=TeamBStones)
				{
					obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,0.7f,0f);
					obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,1.3f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					int Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P1_0");
					Label_1 = GameObject.Find ("Label_P1_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;

					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-1.2f,0f);
					obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-1.8f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P4_0");
					Label_1 = GameObject.Find ("Label_P4_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
				}
				else
				{
					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-1.2f,0f);
					obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-1.8f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					int Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P1_0");
					Label_1 = GameObject.Find ("Label_P1_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;

					Label1_Num=0;
					Label2_Num=0;
					obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,0.7f,0f);
					obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,1.3f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(200f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(100f,1f,0f);
					Score=TeamAStones;
					Label_0 = GameObject.Find ("Label_P4_0");
					Label_1 = GameObject.Find ("Label_P4_1");
					LP_0 = Label_0.GetComponent<ScoreLabel> ();
					LP_1 = Label_1.GetComponent<ScoreLabel> ();
					while(Score>9)
					{
						Score-=10;
						Label2_Num++;
					}
					Label1_Num=Score;
					LP_0.Num=Label1_Num;
					LP_1.Num=Label2_Num;
				}
			}
		}
		else
		{
			if(Sprite_GLOBALVALUE.Flag_Chicken==true)
			{
				int[] Rank=new int[4];
				int[] Put=new int[4];
				Rank[0]=Sprite_GLOBALVALUE.RedStones;
				Rank[1]=Sprite_GLOBALVALUE.YellowStones;
				Rank[2]=Sprite_GLOBALVALUE.GreenStones;
				Rank[3]=Sprite_GLOBALVALUE.BlueStones;
				for(int i=0;i<Rank.Length;i++)
				{
					for(int j=Rank.Length-1;j>i;j--)
					{
						if(Rank[j]<Rank[j-1]&&Rank[j]!=0){
							int t=Rank[j];
							Rank[j]=Rank[j-1];
							Rank[j-1]=t;
						}
						else if(Rank[j]==0)
						{
							switch(j)
							{
							case 0:
								Rank[0]=Rank[1];
								Rank[1]=Rank[2];
								Rank[2]=Rank[3];
								Rank[3]=0;
								break;
							case 1:
								Rank[1]=Rank[2];
								Rank[2]=Rank[3];
								Rank[3]=0;
								break;
							case 2:
								Rank[2]=Rank[3];
								Rank[3]=0;
								break;
							case 3:
								Rank[3]=0;
								break;
							default:
								break;
							}
						}
					}
				}
				if(Rank[0]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[0]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[1]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[2]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[3]=1;
				}
				
				if(Rank[1]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[0]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[1]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[2]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[3]=1;
				}
				
				if(Rank[2]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[0]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[1]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[2]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[3]=1;
				}
				
				if(Rank[3]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[0]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[1]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[2]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[3]=1;
				}
			}
			else
			{
				int[] Rank=new int[4];
				int[] Put=new int[4];
				Rank[0]=Sprite_GLOBALVALUE.RedStones;
				Rank[1]=Sprite_GLOBALVALUE.YellowStones;
				Rank[2]=Sprite_GLOBALVALUE.GreenStones;
				Rank[3]=Sprite_GLOBALVALUE.BlueStones;
				for(int i=0;i<Rank.Length;i++)
				{
					for(int j=Rank.Length-1;j>i;j--)
					{
						if(Rank[j]<Rank[j-1]){
							int t=Rank[j];
							Rank[j]=Rank[j-1];
							Rank[j-1]=t;
						}
					}
				}
				if(Rank[3]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[0]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[1]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[2]=1;
				}
				else if(Rank[3]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,3.5f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,3.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,3.5f,0f);
					Put[3]=1;
				}

				if(Rank[2]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[0]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[1]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[2]=1;
				}
				else if(Rank[2]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,1f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,1f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,1f,0f);
					Put[3]=1;
				}

				if(Rank[1]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[0]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[1]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[2]=1;
				}
				else if(Rank[1]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-1.5f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-1.5f,0f);
					Put[3]=1;
				}

				if(Rank[0]==Sprite_GLOBALVALUE.RedStones&&Put[0]==0)
				{
					GameObject obj=GameObject.Find("label1p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P1_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P1_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[0]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.YellowStones&&Put[1]==0)
				{
					GameObject obj=GameObject.Find("label2p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P2_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P2_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[1]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.GreenStones&&Put[2]==0)
				{
					GameObject obj=GameObject.Find("label3p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P3_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P3_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[2]=1;
				}
				else if(Rank[0]==Sprite_GLOBALVALUE.BlueStones&&Put[3]==0)
				{
					GameObject obj=GameObject.Find("label4p");
					obj.transform.position=new Vector3(0.5f,-4f,0f);
					obj=GameObject.Find ("Label_P4_0");
					obj.transform.position=new Vector3(2.2f,-4f,0f);
					obj=GameObject.Find ("Label_P4_1");
					obj.transform.position=new Vector3(1.7f,-4f,0f);
					Put[3]=1;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
