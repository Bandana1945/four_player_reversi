using UnityEngine;
using System.Collections;

public class HairF : MonoBehaviour {
	public float HairFID=0;
	protected Animator animator;
	public Vector3 POS;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("HAIRFID", HairFID);
		//this.transform.position = new Vector3 (0, 0, 0);
		//this.transform.position = POS;
	}
}
