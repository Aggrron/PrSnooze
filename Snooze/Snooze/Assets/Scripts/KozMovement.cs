using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KozMovement : MonoBehaviour {

	public float speed;


	private Vector3 pos;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y - speed, transform.position.z);

	}

}
