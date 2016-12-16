using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Vector2 position = new Vector2(-3, 5);
    Vector2 movement;
	public Rigidbody2D _rb;
    //public GameObject player;



	void Start ()
    {
        this.transform.position = position;
		_rb = GetComponent<Rigidbody2D>();
		//movement = new Vector2 (0, 1);
    }

	void Update ()
    {   
        if (Input.GetKeyDown(KeyCode.A))
        {
            //pressLeft();
			_rb.velocity += movement;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //pressRight();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //pressUp();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           // pressDown();
        }
        //position += movement * Time.deltaTime;
        //this.transform.position = position;.


    }

    void pressLeft()
    {
        movement = new Vector2(-1, 0);
    }
    void pressRight()
    {
        movement = new Vector2(1, 0);
    }
    void pressUp()
    {
        movement = new Vector2(0, 1);
    }
    void pressDown()
    {
        movement = new Vector2(0, -1);
    }
}
