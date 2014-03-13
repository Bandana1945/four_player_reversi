using UnityEngine;
using System.Collections;

public class HairB : MonoBehaviour {
	public float HairBID=0;
	protected Animator animator;
	public Vector3 POS;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("HAIRBID", HairBID);
		//this.transform.position = POS;
	}
}
