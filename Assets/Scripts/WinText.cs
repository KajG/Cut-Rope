using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinText : MonoBehaviour {
	private TextMesh winText;
	private TimerController timer;
	private StarsController count;
	void Start () {
		winText = GameObject.Find ("WinText").GetComponent<TextMesh>();
		count = GameObject.Find ("StarsUI").GetComponent<StarsController> ();
		timer = GameObject.Find ("Canvas").GetComponent<TimerController> ();
		winText.color = new Color (winText.color.r, winText.color.g, winText.color.b, 0);
	}
	
	void Update () {
		
	}
	public void Win(){
		winText.color = new Color (winText.color.r, winText.color.g, winText.color.b, 1);
		winText.text = "Congratulations you did it!\nYou got " + count.count + " stars!";
		timer.Restart ();
	}
}
