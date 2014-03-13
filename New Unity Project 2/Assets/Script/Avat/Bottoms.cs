using UnityEngine;
using System.Collections;

public class Bottoms : MonoBehaviour {
	public float BottomsID=0;
	protected Animator animator;
	public Vector3 POS;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("ID", BottomsID);
		//this.transform.position = POS;
	}
}
