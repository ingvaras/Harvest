using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {
	public Transform target;
	private Vector3 targetpos;
	// Use this for initialization
	void Start () {
		targetpos = GameObject.FindGameObjectWithTag("Player").transform.position;
		angle ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position != targetpos) {
			transform.position = Vector2.MoveTowards (transform.position, targetpos, 0.1f);
		} else {
			targetpos = new Vector3 (transform.position.x, transform.position.y - 10, 0);
			angle ();

		}

	}

	void angle(){
		
		Vector3 vectorToTarget = targetpos - transform.position;
		float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg)+90;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, 10f);

	}
}
