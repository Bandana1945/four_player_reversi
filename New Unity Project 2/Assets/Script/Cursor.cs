using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
	public bool RemoveTrigger=false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Remove()
	{
		Object.Destroy(gameObject,0.0f);
	}
}
