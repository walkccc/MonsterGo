using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float timeRemaining;
	public TextMesh timerText;

	void Start () {
		
	}

	void Update () {
		timeRemaining = timeRemaining - Time.deltaTime;
		timerText.text = Mathf.Floor(timeRemaining).ToString ();

		if (timeRemaining < 1) {
			SceneManager.LoadScene ("EndScene");
		}
	}
}
