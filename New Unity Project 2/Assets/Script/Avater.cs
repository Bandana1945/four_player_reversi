using UnityEngine;
using System.Collections;

public class Avater : MonoBehaviour {
	public GameObject BOTTOMS;
	public GameObject TOPS;
	public GameObject FACE;
	public GameObject HAIR_F;
	public GameObject HAIR_B;
	public bool InitTrigger;
	Game_Main MainScript;
	public float Turn=1;
	public struct Player
	{
		public int PlayerNumber;
		public GameObject Bottoms;
		public GameObject Tops;
		public GameObject Face;
		public GameObject HairF;
		public GameObject HairB;
		public int Shaketrigger;
		public int MoveTrigger;
		public Vector3 POS;
		public float ID_Bottoms;
		public float ID_Tops;
		public float ID_Face;
		public float ID_Hair;
		public Tops TopsScript;
		public Bottoms BottomsScript;
		public Face FaceScript;
		public HairB HairBScript;
		public HairF HairFScript;
	};
	// Use this for initialization
	public Player[] Players = new Player[4];
	void Start () {
		MainScript=GameObject.Find("Main Camera").GetComponent<Game_Main>();
		for (int i=0; i<4; i++) {
			Players[i]=new Player();
			Players[i].Bottoms=new GameObject();
			Players[i].Tops=new GameObject();
			Players[i].Face=new GameObject();
			Players[i].HairF=new GameObject();
			Players[i].HairB=new GameObject();
				}
	}
	void Update()
	{
				if (MainScript.Pause == false) {
				if (InitTrigger == true) {
						switch ((int)Turn) {
						case 1:
								Players [(int)Turn - 1].Bottoms.transform.position = (new Vector3 (-17, -24, 0));
								Players [(int)Turn - 1].Tops.transform.position = (new Vector3 (-17, -24, 0));
								Players [(int)Turn - 1].Face.transform.position = (new Vector3 (-17, -24, 0));
								Players [(int)Turn - 1].HairB.transform.position = (new Vector3 (-17, -24, 0));
								Players [(int)Turn - 1].HairF.transform.position = (new Vector3 (-17, -24, 0));
								Players [(int)Turn - 1].TopsScript.IDEON = true;
								for (int i=0; i<4; i++) {
										if (i != (Turn - 1)) {
												switch (i) {
												case 0:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 1:
														Players [i].Bottoms.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 2:
														Players [i].Bottoms.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 3:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												default:
														break;
												}
										}
								}
								break;
						case 2:
								Players [(int)Turn - 1].Bottoms.transform.position = (new Vector3 (17, -24, 0));
								Players [(int)Turn - 1].Tops.transform.position = (new Vector3 (17, -24, 0));
								Players [(int)Turn - 1].Face.transform.position = (new Vector3 (17, -24, 0));
								Players [(int)Turn - 1].HairB.transform.position = (new Vector3 (17, -24, 0));
								Players [(int)Turn - 1].HairF.transform.position = (new Vector3 (17, -24, 0));
								Players [(int)Turn - 1].TopsScript.IDEON = true;
								for (int i=0; i<4; i++) {
										if (i != (Turn - 1)) {
												switch (i) {
												case 0:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 1:
														Players [i].Bottoms.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 2:
														Players [i].Bottoms.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 3:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												default:
														break;
												}
										}
								}
								break;
						case 3:
								Players [(int)Turn - 1].Bottoms.transform.position = (new Vector3 (17, 35, 0));
								Players [(int)Turn - 1].Tops.transform.position = (new Vector3 (17, 35, 0));
								Players [(int)Turn - 1].Face.transform.position = (new Vector3 (17, 35, 0));
								Players [(int)Turn - 1].HairB.transform.position = (new Vector3 (17, 35, 0));
								Players [(int)Turn - 1].HairF.transform.position = (new Vector3 (17, 35, 0));
								Players [(int)Turn - 1].TopsScript.IDEON = true;
								for (int i=0; i<4; i++) {
										if (i != (Turn - 1)) {
												switch (i) {
												case 0:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 1:
														Players [i].Bottoms.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 2:
														Players [i].Bottoms.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 3:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												default:
														break;
												}
										}
								}
								break;
						case 4:
								Players [(int)Turn - 1].Bottoms.transform.position = (new Vector3 (-17, 35, 0));
								Players [(int)Turn - 1].Tops.transform.position = (new Vector3 (-17, 35, 0));
								Players [(int)Turn - 1].Face.transform.position = (new Vector3 (-17, 35, 0));
								Players [(int)Turn - 1].HairB.transform.position = (new Vector3 (-17, 35, 0));
								Players [(int)Turn - 1].HairF.transform.position = (new Vector3 (-17, 35, 0));
								Players [(int)Turn - 1].TopsScript.IDEON = true;
								for (int i=0; i<4; i++) {
										if (i != (Turn - 1)) {
												switch (i) {
												case 0:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 1:
														Players [i].Bottoms.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, -26, 0));
														Players [i].Face.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, -26, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, -26, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 2:
														Players [i].Bottoms.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												case 3:
														Players [i].Bottoms.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Tops.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].Face.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairB.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].HairF.transform.position = (new Vector3 (-17, 37, 0));
														Players [i].TopsScript.IDEON = false;
														break;
												default:
														break;
												}
										}
								}
								break;
						default: 
								break;
						}
				}
		}
	}
	public void Init(int Number,float bottoms,float tops,float face,float hair)
	{
				Players [Number].PlayerNumber = Number;
				Players [Number].ID_Bottoms = bottoms;
				Players [Number].ID_Tops = tops;
				Players [Number].ID_Face = face;
				Players [Number].ID_Hair = hair;
				switch (Number) {
				case 0:
						Players [Number].Bottoms = Instantiate (this.BOTTOMS, new Vector3 (-17, -26, 0), Quaternion.Euler (0, 180, 0)) as GameObject;
						Players [Number].Tops = Instantiate (this.TOPS, new Vector3 (-17, -26, 0), Quaternion.Euler (0, 180, 0)) as GameObject;
						Players [Number].Face = Instantiate (this.FACE, new Vector3 (-17, -26, 0), Quaternion.Euler (0, 180, 0)) as GameObject;
						Players [Number].HairB = Instantiate (this.HAIR_B, new Vector3 (-17, -26, 0), Quaternion.Euler (0, 180, 0)) as GameObject;
						Players [Number].HairF = Instantiate (this.HAIR_F, new Vector3 (-17, -26, 0), Quaternion.Euler (0, 180, 0)) as GameObject;
						Players [Number].BottomsScript = Players [Number].Bottoms.GetComponent<Bottoms> ();
						Players [Number].TopsScript = Players [Number].Tops.GetComponent<Tops> ();
						Players [Number].FaceScript = Players [Number].Face.GetComponent<Face> ();
						Players [Number].HairBScript = Players [Number].HairB.GetComponent<HairB> ();
						Players [Number].HairFScript = Players [Number].HairF.GetComponent<HairF> ();
						Players [Number].BottomsScript.BottomsID = bottoms;
						Players [Number].TopsScript.TopsID = tops;
						Players [Number].FaceScript.FaceID = (int)face;
						Players [Number].HairBScript.HairBID = hair;
						Players [Number].HairFScript.HairFID = hair;
						break;
				case 1:
						Players [Number].Bottoms = Instantiate (this.BOTTOMS, new Vector3 (17, -26, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
						Players [Number].Tops = Instantiate (this.TOPS, new Vector3 (17, -26, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
						Players [Number].Face = Instantiate (this.FACE, new Vector3 (17, -26, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
						Players [Number].HairB = Instantiate (this.HAIR_B, new Vector3 (17, -26, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
						Players [Number].HairF = Instantiate (this.HAIR_F, new Vector3 (17, -26, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
						Players [Number].BottomsScript = Players [Number].Bottoms.GetComponent<Bottoms> ();
						Players [Number].TopsScript = Players [Number].Tops.GetComponent<Tops> ();
						Players [Number].FaceScript = Players [Number].Face.GetComponent<Face> ();
						Players [Number].HairBScript = Players [Number].HairB.GetComponent<HairB> ();
						Players [Number].HairFScript = Players [Number].HairF.GetComponent<HairF> ();
						Players [Number].BottomsScript.BottomsID = bottoms;
						Players [Number].TopsScript.TopsID = tops;
						Players [Number].FaceScript.FaceID = (int)face;
						Players [Number].HairBScript.HairBID = hair;
						Players [Number].HairFScript.HairFID = hair;
						break;
				case 2:
						Players [Number].Bottoms = Instantiate (this.BOTTOMS, new Vector3 (17, 37, 0), Quaternion.Euler (0, 180, 180)) as GameObject;
						Players [Number].Tops = Instantiate (this.TOPS, new Vector3 (17, 37, 0), Quaternion.Euler (0, 180, 180)) as GameObject;
						Players [Number].Face = Instantiate (this.FACE, new Vector3 (17, 37, 0), Quaternion.Euler (0, 180, 180)) as GameObject;
						Players [Number].HairB = Instantiate (this.HAIR_B, new Vector3 (17, 37, 0), Quaternion.Euler (0, 180, 180)) as GameObject;
						Players [Number].HairF = Instantiate (this.HAIR_F, new Vector3 (17, 37, 0), Quaternion.Euler (0, 180, 180)) as GameObject;
						Players [Number].BottomsScript = Players [Number].Bottoms.GetComponent<Bottoms> ();
						Players [Number].TopsScript = Players [Number].Tops.GetComponent<Tops> ();
						Players [Number].FaceScript = Players [Number].Face.GetComponent<Face> ();
						Players [Number].HairBScript = Players [Number].HairB.GetComponent<HairB> ();
						Players [Number].HairFScript = Players [Number].HairF.GetComponent<HairF> ();
						Players [Number].BottomsScript.BottomsID = bottoms;
						Players [Number].TopsScript.TopsID = tops;
						Players [Number].FaceScript.FaceID = (int)face;
						Players [Number].HairBScript.HairBID = hair;
						Players [Number].HairFScript.HairFID = hair;
						break;
				case 3:
						Players [Number].Bottoms = Instantiate (this.BOTTOMS, new Vector3 (-17, 37, 0), Quaternion.Euler (0, 0, 180)) as GameObject;
						Players [Number].Tops = Instantiate (this.TOPS, new Vector3 (-17, 37, 0), Quaternion.Euler (0, 0, 180)) as GameObject;
						Players [Number].Face = Instantiate (this.FACE, new Vector3 (-17, 37, 0), Quaternion.Euler (0, 0, 180)) as GameObject;
						Players [Number].HairB = Instantiate (this.HAIR_B, new Vector3 (-17, 37, 0), Quaternion.Euler (0, 0, 180)) as GameObject;
						Players [Number].HairF = Instantiate (this.HAIR_F, new Vector3 (-17, 37, 0), Quaternion.Euler (0, 0, 180)) as GameObject;
						Players [Number].BottomsScript = Players [Number].Bottoms.GetComponent<Bottoms> ();
						Players [Number].TopsScript = Players [Number].Tops.GetComponent<Tops> ();
						Players [Number].FaceScript = Players [Number].Face.GetComponent<Face> ();
						Players [Number].HairBScript = Players [Number].HairB.GetComponent<HairB> ();
						Players [Number].HairFScript = Players [Number].HairF.GetComponent<HairF> ();
						Players [Number].BottomsScript.BottomsID = bottoms;
						Players [Number].TopsScript.TopsID = tops;
						Players [Number].FaceScript.FaceID = (int)face;
						Players [Number].HairBScript.HairBID = hair;
						Players [Number].HairFScript.HairFID = hair;
						break;
				default:
						break;
				}
		}
	}

