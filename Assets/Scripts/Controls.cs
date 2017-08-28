using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	public float speed;
	private GameObject player;
	private bool left;
	private bool right;

	void Start() {
		speed = 5.0f;
		left = false;
		right = false;
	}

	void Update() {
		if(left && transform.position.x - 0.6f > Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x)
			transform.position = Vector2.MoveTowards (transform.position, new Vector2(transform.position.x - 1, transform.position.y), speed * Time.deltaTime);
		if(right && transform.position.x + 0.6f < Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).x)
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

	void OnCollisionEnter2D(Collision2D col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
		}
	}
}
