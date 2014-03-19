using UnityEngine;
using System.Collections;

public class ScoreLabel : MonoBehaviour {
	protected Animator animator;
	public float Num=0;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("Number", Num);
	}
}
