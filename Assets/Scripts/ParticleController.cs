using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

	public ParticleSystem Particles;

	void Start () 
	{
		Particles = Particles.GetComponent<ParticleSystem> ();
	}
	

	void Update () 
	{
		
	}
}
