using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {
    public float timeCounter = 0;
	Movement movement;
	private Vector2 movePos;
    float speed;
    float width;
    float height;
	void Start () {
		speed = 1;
		width = 1.4f;
		height = 1.4f;
		movement = GetComponent<Movement> ();
	}
	
	void Update () {
        timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter)*width;
        float y = Mathf.Sin(timeCounter)*height;
        float z = 0;
		movePos = new Vector2 (x, y) * speed;
		movement._rb.velocity = movePos;
	} 
}
