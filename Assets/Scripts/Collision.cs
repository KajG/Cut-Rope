using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	public ParticleSystem particles;
	public GameObject particles2;
	bool timer;
	float timerFloat = 0.3f;
	float timerFloat2 = 0.3f;
	private Vector3 offCenter;
	public StarsController starCount;
	AudioSource starPickup;

	void Start ()
    {
		//particles = particles.GetComponent<ParticleSystem> ();
		offCenter = new Vector3(-0.44f, 0.34f, this.transform.position.z);
		starCount = starCount.GetComponent<StarsController> ();
		starPickup = GetComponent<AudioSource> ();
	}
	

	void Update ()
    {
		/*if(timer)
		{
			timerFloat -= Time.deltaTime;
		}
		if(timerFloat <= 0)
		{
			Destroy (particles);
		}*/
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

}

