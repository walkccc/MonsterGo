using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour {

	public GameObject [] diffMonsters;

	void Start () {
		for (int i = 0; i < Random.Range (800, 900); i++) {
			MonsterCount ();
		}
	}

	void MonsterCount () {
		int index = Random.Range (0, diffMonsters.Length);
		GameObject randomMonster = Instantiate (diffMonsters [index]);
		randomMonster.transform.parent = transform;
		randomMonster.transform.localPosition = new Vector3(Random.Range (-95, 95), 0.0f, Random.Range (-95, 95));
	}
}
