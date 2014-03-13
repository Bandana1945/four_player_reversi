using UnityEngine;
using System.Collections;

public class Face : MonoBehaviour {
	public int FaceID = 1;
	public float FaceMode=2;
	protected Animator animator;
	public Vector3 POS;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		POS = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetInteger ("FACEID", FaceID);
		animator.SetFloat ("FACEMODE", FaceMode);
		//this.transform.position = POS;
	}
}
