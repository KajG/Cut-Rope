using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCutting : MonoBehaviour {
	public bool holdMouse;
	private GameObject trail;
	void Start () {
		trail = GameObject.Find("Trail");
		var em = trail.GetComponent<ParticleSystem>().emission;
		em.enabled = false;
	}
	
	void Update () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
		transform.position = mousePos;
		if (Input.GetMouseButton (0)) {
			holdMouse = true;
			var em = trail.GetComponent<ParticleSystem>().emission;
			em.enabled = true;
		} else {
			var em = trail.GetComponent<ParticleSystem>().emission;
			holdMouse = false;
			em.enabled = false;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Rope") {
			Destroy (other.gameObject);
		}
	}
}
