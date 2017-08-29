using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hay_Bay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.FindGameObjectWithTag("Player") == null)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0, 0.1f,0);
		if (transform.position.y < Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 0)).y)
			Destroy (this.gameObject);
	}
}
