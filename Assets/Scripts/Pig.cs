using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {
	
	public Transform target;
	private Vector3 targetpos;

	void Start () {
		
		if (GameObject.FindGameObjectWithTag("Player") == null)
			Destroy (gameObject);
		else targetpos = GameObject.FindGameObjectWithTag("Player").transform.position;
		angle ();
	}

	void Update () {
		if (transform.position != targetpos) {
			transform.position = Vector2.MoveTowards (transform.position, targetpos, 0.1f);
		} else {
			targetpos = new Vector3 (transform.position.x * transform.right.x, transform.position.y-10, 0);
			angle ();
		}

		if (transform.position.y < Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 0)).y)
			Destroy (this.gameObject);
	}

	void angle(){
		Vector3 vectorToTarget = targetpos - transform.position;
		float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg)+90;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, 10f);
	}
}
