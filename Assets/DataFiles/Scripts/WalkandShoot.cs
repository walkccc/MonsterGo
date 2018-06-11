using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandShoot : MonoBehaviour {

	public GameObject pokeball;
	public float shootingSpeed = 10;
	public float speed;

	void Start () {
		
	}

	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {
			GameObject pokego = Instantiate (pokeball);
			pokego.transform.position = transform.position;
			Rigidbody rb = pokego.GetComponent<Rigidbody> ();
			Camera cam = GetComponentInChildren<Camera> ();
			rb.velocity = cam.transform.rotation * Vector3.forward * shootingSpeed;
		}
	}
}
