using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;


	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target.position, 0.1f);
		Vector3 vectorToTarget = target.position - transform.position;
		float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg)+90;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		Debug.Log (q);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, 0.1f);
	}
		
}
