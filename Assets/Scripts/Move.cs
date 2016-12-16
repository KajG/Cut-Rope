using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Vector3 goUp = new Vector3(0, 0, 0);
    Vector3 speed = new Vector3(0, 0.01f, 0);

	void Start () {
        goUp = new Vector3(0, 0.01f,0);
	}
	
	
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }
	}
    void MoveUp()
    {
        print("up");
        goUp += speed;
        this.transform.position = goUp;
    }
}
