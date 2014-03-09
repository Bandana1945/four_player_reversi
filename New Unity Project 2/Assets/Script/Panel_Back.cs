using UnityEngine;
using System.Collections;
//背景のパネルという事で持たせるべき情報は
//・背景ID
//といったところでしょうか
//
public class Panel_Back : MonoBehaviour {

	public float ID_Back=0;//背景のIDです
	//この変数で背景だとか盤面の変更を行います
	//どうやらfloat型でしかやり取りを行えないメソッドがあるらしいのでそれに備えてfloat型にしています
	
	//初期化処理ってやつですね
	//このLoadメソッドで背景のIDを取得しそれに応じた画像に設定してやります
	void Load (float ID) {
		switch ((int)ID) {
		case 0:
			break;
		default:
			break;
		}
	}
	
	// Update is called once per frame
	//背景で毎フレすべき様な処理が見当たらないので空になってます
	void Update () {
	
	}
}
