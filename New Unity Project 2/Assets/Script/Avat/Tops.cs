using UnityEngine;
using System.Collections;

public class Tops : MonoBehaviour {
	protected Animator animator;
	public float TopsID = 0;
	public bool IDEON=false;//防衛本能に呼応して発動します
	public bool ShakeTrigger=false;
	public int counter = 0;
	public Vector3 POS;
	Game_Main MainScript;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
		MainScript=GameObject.Find("Main Camera").GetComponent<Game_Main>();
	}
	
	// Update is called once per frame
	void Update () {
		if (MainScript.Pause == false) {
						if (IDEON == true)
								counter++;
						if (counter == 30) {
								ShakeTrigger = !ShakeTrigger;
								counter = 0;
						}
						animator.SetFloat ("TOPSID", TopsID);
						animator.SetBool ("SHAKETRIGGER", ShakeTrigger);
						//this.transform.position = POS;
				}
	}
}
