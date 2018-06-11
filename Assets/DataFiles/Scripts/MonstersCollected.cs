using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersCollected : MonoBehaviour {

	Mcalculator mcalc;

	void Start () {
		mcalc = FindObjectOfType<Mcalculator> ();
	}
	
	public void OnTriggerEnter (Collider collide) {
		if (collide.gameObject.CompareTag ("GhostGreen") ||
			collide.gameObject.CompareTag ("GhostViolet") ||
			collide.gameObject.CompareTag ("RabbitRed") ||
			collide.gameObject.CompareTag ("RabbitYellow") ||
			collide.gameObject.CompareTag ("SlimeBlue") ||
			collide.gameObject.CompareTag ("SlimeRed")) {
			Destroy (collide.gameObject);
			Destroy (gameObject);
			mcalc.totolCount ();
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("ground")) {
			Destroy (gameObject);
		}
	}
}
