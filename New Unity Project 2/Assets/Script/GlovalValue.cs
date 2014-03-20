using UnityEngine;
using System.Collections;

public class GlovalValue : MonoBehaviour {
	public bool Flag_Intercept;
	public bool Flag_2on2;
	public bool Flag_Chicken;
	public bool Flag_Banmen6;
	public bool Flag_Banmen8;
	public bool Flag_Banmen10;
	public int BanmenID=0;
	public int RedStones;
	public int YellowStones;
	public int GreenStones;
	public int BlueStones;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
