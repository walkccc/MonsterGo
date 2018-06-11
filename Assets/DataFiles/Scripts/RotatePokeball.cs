using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePokeball : MonoBehaviour {

	void Update () {
		transform.Rotate (new Vector3 (300, 300, 300) * Time.deltaTime);	
	}
}
