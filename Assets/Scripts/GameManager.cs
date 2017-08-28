using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject piggy;

	private float Timer = 2.0f;

	void Update () {
		Timer -= Time.deltaTime;
		if (Timer <= 0.0f) {
			Instantiate (piggy, new Vector3 (Random.Range (Camera.main.ScreenToWorldPoint (new Vector3 (0, 0, 0)).x - 2f, Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0)).x) + 2f, 10f, 0f), transform.rotation);
			Timer = Random.Range(0.5f, 2.0f);
		}
	}
}
