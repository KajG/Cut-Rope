using UnityEngine;
using System.Collections;

public class GravitySwitch : MonoBehaviour {
    public Rigidbody2D Ball;
    void Start () {
		Ball = Ball.GetComponent<Rigidbody2D>();
    }
    public void AntiGravity()
    {
      Ball.gravityScale *= -1;
    }
}
