using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	private GameObject player;
	public float speed;
	private bool left;
	private bool right;

	void Start() {
		speed = 5.0f;
		left = false;
		right = false;
	}

	void Update() {
		if(left)
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x - 1, transform.position.y), speed * Time.deltaTime);
		if(right)
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x + 1, transform.position.y), speed * Time.deltaTime);
	}
		
	public void MoveLeft() {
		left = true;
	}

	public void MoveRight() {
		right = true;
	}
	
	public void StopMoving() {
		left = false;
		right = false;
	}
}
