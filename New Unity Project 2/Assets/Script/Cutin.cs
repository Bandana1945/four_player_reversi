using UnityEngine;
using System.Collections;

public class Cutin : MonoBehaviour {
	public int count = 0;
	public float Anim=0;
	protected Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat("ANIM", Anim);
		count++;
		if (count > 0 && count <= 3) {
			Anim=0;
				}
		if (count > 3 && count <= 6) {
			Anim=1;
		}
		if (count > 6 && count <= 9) {
			Anim=2;
		}
		if (count > 9 && count <= 12) {
			Anim=3;
		}
		if (count > 12 && count <= 15) {
			Anim=4;
		}
		if (count > 15 && count <= 18) {
			Anim=5;
		}
		if (count > 18 && count <= 21) {
			Anim=6;
		}
		if (count > 21 && count <= 24) {
			Anim=7;
		}
		if (count > 24 && count <= 27) {
			Anim=8;
		}
		if (count > 27 && count <= 30) {
			Anim=9;
		}
		if (count > 30 && count <= 33) {
			Anim=10;
		}
		if (count > 33) {
			GameObject Target=GameObject.FindGameObjectWithTag("intercept");
			Destroy(Target);
				}
	}
}
