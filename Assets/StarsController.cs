using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsController : MonoBehaviour {
	public float count;
	public GameObject[] starArray;
    Vector3 rotation;
	public float rotationSpeed; 

	void Start () {
		rotation = new Vector3 (0, rotationSpeed, 0);
	}

	void Update () {
		if (starArray [0].transform.eulerAngles.y <= 160) {
			if (count >= 1) {
				starArray [0].transform.Rotate (rotation);
			}
		}
		if (starArray [1].transform.eulerAngles.y <= 160) {
			if (count >= 2) {
				starArray [1].transform.Rotate (rotation);
			}
		}
		if (starArray [2].transform.eulerAngles.y <= 160) {
			if (count >= 3) {
				starArray [2].transform.Rotate (rotation);
			}
		}
	}
}
