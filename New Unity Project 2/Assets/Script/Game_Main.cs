using UnityEngine;
using System.Collections;

public class Game_Main : MonoBehaviour {
	public GameObject P_STONE;
	public int[,] Banmen=new int[8,8];
	// Use this for initialization
	void SetUp (int Size) {

	}

	
	// Update is called once per frame
	void Update () {
		Vector3 Pos = new Vector3 (0.0f, 0.0f, 0.0f);
		Vector3 vec = Input.mousePosition;
		vec = camera.ScreenToWorldPoint (vec);
		vec.z = 0.0f;
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (this.P_STONE, vec, Quaternion.identity);
		}
	}
}
