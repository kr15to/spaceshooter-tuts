using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(10, 10);
	private Vector2 movement;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// movement per direction
		movement = new Vector2(speed.x * inputX, speed.y * inputY);
	}

	void FixedUpdate() {
		if(rb2d == null) {
			rb2d = GetComponent<Rigidbody2D>();
		}
		// move the ship
		rb2d.velocity = movement;
	}
}
