using UnityEngine;
using System.Collections;

public class KickScript : MonoBehaviour {
 
	void OnTriggerEnter(Collider col) {
		if(col.tag == "Enemy") {
			Debug.Log("敵に当たった");
			col.GetComponent<BallScript>().SetState(BallScript.BallState.isKicked);
		}
	}
}
