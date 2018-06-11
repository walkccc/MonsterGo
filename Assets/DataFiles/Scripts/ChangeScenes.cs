using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

	public void LoadDayScene () {
		SceneManager.LoadScene ("DayScene");
	}

	public void LoadNightScene () {
		SceneManager.LoadScene ("NightScene");
	}

	public void QuitGame () {
		Application.Quit ();
		Debug.Log ("Quit Game!");
	}
}
