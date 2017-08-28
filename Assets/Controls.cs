using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	private GameObject player;
		
	public void MoveLeft() {
		transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x -1, transform.position.y), 1);
	}

	public void MoveRight() {
		transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x + 1, transform.position.y), 1);
	}
}
