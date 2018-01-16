using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
	private GameObject mouse;
	void Start () {
		mouse = GameObject.Find ("Mouse");
	}
	
	void Update () {
		transform.position = mouse.transform.position;
	}
}
