using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour {

	public Text counterText;
	public Text restartText;
	private float countDown = 10;
	public AudioSource music;


	void Start(){
		restartText.enabled = false;
	}
	void Update () {
		countDown -= Time.deltaTime; 
		counterText.text = ("Time left: " + Mathf.RoundToInt(countDown) + "s");
		if (countDown <= 0) {
			Time.timeScale = 0;
			music.Stop();
			restartText.enabled = true;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			restartText.enabled = false;
			SceneManager.LoadScene (0);
			Time.timeScale = 1;
		}
	}
}
