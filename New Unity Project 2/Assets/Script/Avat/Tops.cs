using UnityEngine;
using System.Collections;

public class Tops : MonoBehaviour {
	protected Animator animator;
	public float TopsID = 0;
	public bool ShakeTrigger=false;
	public Vector3 POS;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("TOPSID", TopsID);
		animator.SetBool ("SHAKETRIGGER", ShakeTrigger);
		//this.transform.position = POS;
	}
}
