using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mcalculator : MonoBehaviour {

	public int counter;
	public TextMesh totalMonster;

	void Start () {
		counter = 0;
		DontDestroyOnLoad (gameObject);
	}

	void Update () {
		
	}

	public void totolCount () {
		counter = counter + 1;
		totalMonster.text = counter.ToString ();
		Debug.Log ("Monsters Collected: " + counter);
	}
}
