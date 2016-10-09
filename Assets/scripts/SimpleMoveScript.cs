﻿using UnityEngine;
using System.Collections;

public class SimpleMoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(0, -1);
	private Vector2 movement;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
	}

	void FixedUpdate() {
		if(rb2d == null) {
			rb2d = GetComponent<Rigidbody2D>();
		}
		rb2d.velocity = movement;
	}
}
