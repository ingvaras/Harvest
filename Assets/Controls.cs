using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	private GameObject player;
	private bool left;
	private bool right;

	void Start() {
		left = false;
		right = false;
	}

	void Update() {
		if(left)
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x - 1, transform.position.y), Time.deltaTime);
		if(right)
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x + 1, transform.position.y), Time.deltaTime);
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
