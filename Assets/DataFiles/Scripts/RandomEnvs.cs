using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnvs : MonoBehaviour {

	public GameObject [] diffTreeRocks;
	public GameObject [] diffGrassRocks;

	void Start () {
		for (int i = 0; i < Random.Range (600, 700); i++) {
			TreeRockCount ();
		}

		for (int j = 0; j < Random.Range (1000, 1200); j++) {
			GrassRockCount ();
		}
	}

	void TreeRockCount () {
		int treeRockIdx = Random.Range (0, diffTreeRocks.Length);
		GameObject randomTreeRock = Instantiate (diffTreeRocks [treeRockIdx]);
		randomTreeRock.transform.parent = transform;
		randomTreeRock.transform.localPosition = new Vector3(Random.Range (-95, 95), 0.0f, Random.Range (-95, 95));
	}

	void GrassRockCount () {
		int grassRockIdx = Random.Range (0, diffGrassRocks.Length);
		GameObject randomGrassRock = Instantiate (diffGrassRocks [grassRockIdx]);
		randomGrassRock.transform.parent = transform;
		randomGrassRock.transform.localPosition = new Vector3(Random.Range (-95, 95), 0.0f, Random.Range (-95, 95));
	}
}
