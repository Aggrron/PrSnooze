using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public GameObject snooze;
	public GameObject zad;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, snooze.transform.position.y, -10);
		zad.transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
	}
}
