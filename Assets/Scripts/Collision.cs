using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	public ParticleSystem particles;
	private TimerController timeController;
	public GameObject particles2;
	private WinText winText;
	bool timer;
	float timerFloat = 0.3f;
	float timerFloat2 = 0.3f;
	private Vector3 offCenter;
	public StarsController starCount;
	AudioSource starPickup;

	void Start ()
    {
		winText = Camera.main.GetComponent<WinText> ();
		offCenter = new Vector3(-0.44f, 0.34f, this.transform.position.z);
		timeController = GameObject.Find ("Canvas").GetComponent<TimerController> ();
		starCount = starCount.GetComponent<StarsController> ();
		starPickup = GetComponent<AudioSource> ();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Star")
        {
			starPickup.Play ();
			starCount.count += 1;
            Destroy(other.gameObject);
			GameObject particleEffect2 = (GameObject)Instantiate (particles2, other.gameObject.transform.position - offCenter, Quaternion.identity);
			ParticleSystem particleEffect = (ParticleSystem)Instantiate (particles, other.gameObject.transform.position - offCenter, Quaternion.identity);
			Destroy (particleEffect, timerFloat);
			Destroy (particleEffect2, timerFloat2);
			timer = true;
        }
    }
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Omnom") {
			winText.Win ();
			timeController.Restart ();
		}
	}

}

